using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using Un4seen.Bass.AddOn.Mix;
using Un4seen.Bass.AddOn.Tags;
using Un4seen.Bass.Misc;
using Un4seen.BassAsio;

namespace RadioStreamMusicPlayer
{
    public partial class MyMicrophone : Form
    {
        //added by mohebbihr for the microphone part
        public System.Windows.Forms.Button buttonStartRec;
        public System.Windows.Forms.GroupBox recordingGroupBox;
        public System.Windows.Forms.Button buttonStopRec;
        public System.Windows.Forms.Label labelRec;
        public System.Windows.Forms.TrackBar volume;
        //

        public MyMicrophone()
        {
            InitializeComponent();
        }

        public void closeMicrophone()
        {
            
        }

        #region Live Recording
        //the part of recording, added by mohebbihr

        private WaveForm WF = null;
        private int _recorderHandle = 0;
        private BASSBuffer monBuffer = new BASSBuffer(2f, 44100, 2, 16); // 44.1kHz, 16-bit, stereo (like we record!)
        private int monStream = 0;
        private STREAMPROC monProc = null;
        EncoderLAME lame = null;
        // LOCAL VARS
        private int _wmaPlugIn = 0;
        //private int _stream = 0;
        private int _encHandle = 0;
        //private string _fileName = String.Empty;
        private string _fileNameOutput = String.Empty;
        private byte[] _encBuffer = new byte[65536]; // our encoder buffer (32KB x 16-bit)
        private TAG_INFO _tagInfo;

        private void buttonStartRec_Click(object sender, System.EventArgs e)
        {
            this.labelRec.Text = "Recording Started";
            
            //start recording from mic
            _recorderHandle = Bass.BASS_RecordStart(44100, 2, BASSFlag.BASS_RECORD_PAUSE, null, IntPtr.Zero); // start recording paused

            //add recording to the mixer
            bool mixstatus = BassMix.BASS_Mixer_StreamAddChannel(RadioStreamMusicPlayer.outputMixerStream, _recorderHandle, BASSFlag.BASS_MIXER_DOWNMIX | BASSFlag.BASS_MIXER_FILTER | BASSFlag.BASS_MIXER_NORAMPIN); 


            lame = new EncoderLAME(RadioStreamMusicPlayer.outputMixerStream);
            lame.InputFile = null;	//STDIN
            lame.OutputFile = "rectest.mp3";
            lame.LAME_Bitrate = (int)EncoderLAME.BITRATE.kbps_192;
            lame.LAME_Mode = EncoderLAME.LAMEMode.Default;
            lame.LAME_TargetSampleRate = (int)EncoderLAME.SAMPLERATE.Hz_44100;
            lame.LAME_Quality = EncoderLAME.LAMEQuality.Quality;

            // really start recording
            lame.Start(null, IntPtr.Zero, false);
            Bass.BASS_ChannelPlay(_recorderHandle, false); // resume recording
            Bass.BASS_ChannelPlay(RadioStreamMusicPlayer.outputMixerStream, false);

     
        }

        private void buttonStopRec_Click(object sender, System.EventArgs e)
        {
            Bass.BASS_ChannelStop(_recorderHandle);
            lame.Stop();
            this.buttonStartRec.Enabled = true;
            this.labelRec.Text = "Recording stopped!";
            // stop the live recording waveform
            if (WF != null)
            {
                WF.RenderStopRecording();
            }

        }

        private void volume_Scroll(object sender, System.EventArgs e)
        {
            if(_recorderHandle !=0){

                Bass.BASS_ChannelSetAttribute(_recorderHandle, Un4seen.Bass.BASSAttribute.BASS_ATTRIB_VOL, volume.Value );
            }
        }

        private RECORDPROC _myRecProc; // make it global, so that the Garbage Collector can not remove it

 
        #endregion
    }
}
