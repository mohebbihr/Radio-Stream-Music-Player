/*
 * Creato da Alberto Scozzari.
 * Utente: User
 * Data: 02/10/2012
 * Ora: 16.42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Un4seen.Bass;
using Un4seen.Bass.AddOn.Mix;
using Un4seen.Bass.Misc;

namespace RadioStreamMusicPlayer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class RadioStreamMusicPlayer : Form
	{
		
		//private MyMusicPlayer player;
        //changed by mohebbihr
        public static MyMusicPlayer player;
		private MyNetRadio radio;
		private MyStreaming streaming;
        //added by mohebbihr for microphone and cd parts
        private MyMicrophone microphone;
        private MyCD cd;
		
		private int _wmaPlugIn = 0;
		
		public static int outputMixerStream = 0;
		
		//TABS PRINCIPALI
		
		private TabControl tabMain = new TabControl();
		private TabPage tabPlayer = new TabPage("Player");
		private TabPage tabRadio = new TabPage("Radio");
		private TabPage tabStreaming = new TabPage("Streaming");

        //added by mohebbihr for microphone and cd parts
        private TabPage tabMicrophone = new TabPage("Microphone");
        private TabPage tabCD = new TabPage("CD");
		
		public RadioStreamMusicPlayer()
		{
			DSP_Load();
			player = new MyMusicPlayer();
			radio = new MyNetRadio();
			streaming = new MyStreaming();

            //added by mohebbihr for microphone and cd parts
            microphone = new MyMicrophone();
            cd = new MyCD();

			InitializeComponent();
		}
		
		private void DSP_Load()
		{
			//BassNet.Registration("your email", "your regkey");
			_wmaPlugIn = Bass.BASS_PluginLoad("basswma.dll");
			// check the version..
			if (Utils.HighWord(Bass.BASS_GetVersion()) != Bass.BASSVERSION)
			{
				System.Windows.Forms.MessageBox.Show( this, "Wrong Bass Version!" );
			}
			if (!( Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_LATENCY, this.Handle)))
				MessageBox.Show(this, "Bass_Init error!" );
			if ( Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_WMA_PREBUF, 0) == false)
			{
				Console.WriteLine( "ERROR: " + Enum.GetName(typeof(BASSError), Bass.BASS_ErrorGetCode()) );
			}
			if ( !Bass.BASS_RecordInit(-1) )
				System.Windows.Forms.MessageBox.Show(this, "Bass_RecordInit error!" );
			try {
				
				outputMixerStream = BassMix.BASS_Mixer_StreamCreate(44100, 2, BASSFlag.BASS_SAMPLE_FLOAT);
                //outputMixerStream = BassMix.BASS_Mixer_StreamCreate(44100, 2, BASSFlag.BASS_DEFAULT);
				Bass.BASS_ChannelPlay(RadioStreamMusicPlayer.outputMixerStream, false);
				
			} catch (Exception ex) {
				MessageBox.Show(this, "Bass_Mixer error! " + ex.Message );
			}
			
		
		}
		
		private void DSP_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
			player.closePlayer();
			radio.closeNetRadio();
			streaming.closeStreaming();
            //added by mohebbihr for microphone and cd parts
            microphone.closeMicrophone();
            cd.closeCD();
			
			// close bass
			Bass.BASS_Stop();
			Bass.BASS_Free();
			Bass.BASS_PluginFree(_wmaPlugIn);
			
		}
		
		public static void  RMS_2(out int peakL, out int peakR)
		{
			float maxL = 0f;
			float maxR = 0f;
			float[] _rmsData = null;
		
			int length = (int)Bass.BASS_ChannelSeconds2Bytes(RadioStreamMusicPlayer.outputMixerStream, 0.03); // 30ms window // 30ms window already set at buttonPlay_Click
			int l4 = length/4; // the number of 32-bit floats required (since length is in bytes!)
	
			// increase our data buffer as needed
			if (_rmsData == null || _rmsData.Length < l4)
				_rmsData = new float[l4];
	
			// create a handle to a managed object and pin it,
			// so that the Garbage Collector will not remove it
			GCHandle hGC = GCHandle.Alloc(_rmsData, GCHandleType.Pinned);
			try
			{
				// this will hand over an IntPtr to our managed data object
				//length = BassMix.BASS_Mixer_ChannelGetData(RadioStreamMusicPlayer.outputMixerStream, hGC.AddrOfPinnedObject(), length);
				length = Bass.BASS_ChannelGetData(RadioStreamMusicPlayer.outputMixerStream, hGC.AddrOfPinnedObject(), length);
			}
			finally
			{
				// free the pinned handle, so that the Garbage Collector can use it
				hGC.Free();
			}
	
			l4 = length/4; // the number of 32-bit floats received
	
			for (int a=0; a < l4; a++)
			{
				// decide on L/R channel
				if (a % 2 == 0)
				{
					// L channel
					if (_rmsData[a] > maxL)
						maxL = _rmsData[a];
				}
				else
				{
					// R channel
					if (_rmsData[a] > maxR)
						maxR = _rmsData[a];
				}
			}
	
			// limit the maximum peak levels to +6bB = 0xFFFF = 65535
			// the peak levels will be int values, where 32767 = 0dB!
			// and a float value of 1.0 also represents 0db.
			peakL = (int)Math.Round(32767f * maxL) & 0xFFFF;
			peakR = (int)Math.Round(32767f * maxR) & 0xFFFF;
		}
     }
}
