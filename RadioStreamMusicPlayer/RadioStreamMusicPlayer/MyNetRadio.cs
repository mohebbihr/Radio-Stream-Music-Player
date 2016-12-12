/*
 * Creato da Alberto Scozzari.
 * Utente: User
 * Data: 02/10/2012
 * Ora: 17.31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Wma;
using Un4seen.Bass.AddOn.Tags;

namespace RadioStreamMusicPlayer
{
	/// <summary>
	/// Description of MyNetRadio.
	/// </summary>
	public partial class MyNetRadio : System.Windows.Forms.Form
	{
		public System.Windows.Forms.Button btnConnect;
		public System.Windows.Forms.Button btnDisconnect;
		public System.Windows.Forms.Button btnSearch;
		public System.Windows.Forms.TextBox textBoxConn;
		public System.Windows.Forms.TextBox textBoxSearch;
		public System.Windows.Forms.Label statusBarConn;
		public System.Windows.Forms.ComboBox comboBoxURL;
		public System.Windows.Forms.TextBox textBoxArtist;
		public System.Windows.Forms.TextBox textBoxTitle;
		public System.Windows.Forms.TextBox textBoxAlbum;
		public System.Windows.Forms.TextBox textBoxComment;
		public System.Windows.Forms.TextBox textBoxGenre;
		public System.Windows.Forms.TextBox textBoxYear;
		
		private void InitializeComponent()
		{
			
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.textBoxConn = new System.Windows.Forms.TextBox();
			//this.statusBarConn = new System.Windows.Forms.StatusBar();
			this.statusBarConn = new System.Windows.Forms.Label();
			this.comboBoxURL = new System.Windows.Forms.ComboBox();
			this.textBoxArtist = new System.Windows.Forms.TextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxAlbum = new System.Windows.Forms.TextBox();
			this.textBoxComment = new System.Windows.Forms.TextBox();
			this.textBoxGenre = new System.Windows.Forms.TextBox();
			this.textBoxYear = new System.Windows.Forms.TextBox();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(16, 40);
			this.btnConnect.Name = "buttonConnect";
			this.btnConnect.Size = new System.Drawing.Size(120, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(140, 40);
			this.btnDisconnect.Name = "buttonDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(120, 23);
			this.btnDisconnect.TabIndex = 2;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(300, 12);
			this.btnSearch.Name = "buttonSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 23);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Cerca  Stazioni";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxSearch.Location = new System.Drawing.Point(420, 13);
			this.textBoxSearch.Size = new System.Drawing.Size(250, 23);
			this.textBoxSearch.MaxLength = 2032767;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.TabIndex = 6;
			this.textBoxSearch.Text = "";
			this.textBoxSearch.WordWrap = false;
			// 
			// textBoxConn
			// 
			this.textBoxConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxConn.Location = new System.Drawing.Point(16, 72);
			this.textBoxConn.MaxLength = 2032767;
			this.textBoxConn.Multiline = true;
			this.textBoxConn.Name = "textBoxConn";
			this.textBoxConn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxConn.Size = new System.Drawing.Size(260, 326);
			this.textBoxConn.TabIndex = 7;
			this.textBoxConn.Text = "";
			this.textBoxConn.WordWrap = false;
			// 
			// statusBarConn
			// 
			this.statusBarConn.Location = new System.Drawing.Point(0, 400);
			this.statusBarConn.Name = "statusBarConn";
			this.statusBarConn.Size = new System.Drawing.Size(612, 22);
			this.statusBarConn.TabIndex = 9;
			// 
			// comboBoxURL
			// 
			this.comboBoxURL.DataSource = strSourceStations;
			this.comboBoxURL.Location = new System.Drawing.Point(16, 12);
			this.comboBoxURL.Name = "comboBoxURL";
			this.comboBoxURL.Size = new System.Drawing.Size(262, 21);
			this.comboBoxURL.TabIndex = 10;
			// 
			// textBoxArtist
			// 
			this.textBoxArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxArtist.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxArtist.Location = new System.Drawing.Point(286, 74);
			this.textBoxArtist.Name = "textBoxArtist";
			this.textBoxArtist.Size = new System.Drawing.Size(376, 13);
			this.textBoxArtist.TabIndex = 11;
			this.textBoxArtist.Text = "Artist";
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTitle.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTitle.Location = new System.Drawing.Point(286, 98);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(376, 13);
			this.textBoxTitle.TabIndex = 12;
			this.textBoxTitle.Text = "Title";
			// 
			// textBoxAlbum
			// 
			this.textBoxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxAlbum.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAlbum.Location = new System.Drawing.Point(286, 122);
			this.textBoxAlbum.Name = "textBoxAlbum";
			this.textBoxAlbum.Size = new System.Drawing.Size(376, 13);
			this.textBoxAlbum.TabIndex = 13;
			this.textBoxAlbum.Text = "Album";
			// 
			// textBoxComment
			// 
			this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxComment.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxComment.Location = new System.Drawing.Point(286, 146);
			this.textBoxComment.Name = "textBoxComment";
			this.textBoxComment.Size = new System.Drawing.Size(376, 13);
			this.textBoxComment.TabIndex = 14;
			this.textBoxComment.Text = "Comment";
			// 
			// textBoxGenre
			// 
			this.textBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxGenre.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxGenre.Location = new System.Drawing.Point(286, 170);
			this.textBoxGenre.Name = "textBoxGenre";
			this.textBoxGenre.Size = new System.Drawing.Size(376, 13);
			this.textBoxGenre.TabIndex = 15;
			this.textBoxGenre.Text = "Genre";
			// 
			// textBoxYear
			// 
			this.textBoxYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxYear.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxYear.Location = new System.Drawing.Point(286, 194);
			this.textBoxYear.Name = "textBoxYear";
			this.textBoxYear.Size = new System.Drawing.Size(376, 13);
			this.textBoxYear.TabIndex = 16;
			this.textBoxYear.Text = "Year";
			
		}
		
		public MyNetRadio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.initNetRadio();
			InitializeComponent();
			_myUserAgentPtr = Marshal.StringToHGlobalAnsi(_myUserAgent);
		}
		
		// PINNED
        private string _myUserAgent = "RADIOTIM";
        [FixedAddressValueType()]
        public IntPtr _myUserAgentPtr;

		// LOCAL VARS
		private int _Stream = 0;
		private string _url = String.Empty;
		private System.Collections.ArrayList strSourceStations;
		private DOWNLOADPROC myStreamCreateURL;
		private TAG_INFO _tagInfo;
		private SYNCPROC mySync;
		private RECORDPROC myRecProc;
		
        private void initNetRadio()
		{
			//string userAgent = Bass.BASS_GetConfigString(BASSConfig.BASS_CONFIG_NET_AGENT);

            Bass.BASS_SetConfigPtr(BASSConfig.BASS_CONFIG_NET_AGENT, _myUserAgentPtr);
			
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_PREBUF, 0); // so that we can display the buffering%
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_PLAYLIST, 1);
			Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_NET_TIMEOUT, 10000);
            
			myStreamCreateURL = new DOWNLOADPROC(MyDownloadProc);
		
        	//Ricerca delle stazioni radio interrogando un Web Service
        	strSourceStations = new System.Collections.ArrayList();
        	
        	strSourceStations.Add("http://lounge-office.rautemusik.fm");
        	strSourceStations.Add("http://www.radioparadise.com/musiclinks/rp_128-9.m3u");
        	strSourceStations.Add("http://www.sky.fm/mp3/classical.pls");
        	strSourceStations.Add("http://www.sky.fm/mp3/the80s.pls");
        	strSourceStations.Add("http://somafm.com/secretagent.pls");
        	strSourceStations.Add("http://rautemusik.fm:14100");
        	strSourceStations.Add("http://64.236.34.97/stream/1006");
        	strSourceStations.Add("http://ogg.smgradio.com/vr160.ogg");
        	strSourceStations.Add("http://localhost:8000/bass.ogg");
        	strSourceStations.Add("mms://a1149.l1305038288.c13050.g.lm.akamaistream.net/D/1149/13050/v0001/reflector:38288");
        	strSourceStations.Add("http://repc-1.adinjector.net/amtmsvc/gateway.asp?stationid=109&adformat=2");
      	}
        
        public void closeNetRadio()
		{
        	Bass.BASS_StreamFree(_Stream);
        }
        
		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			Bass.BASS_StreamFree(_Stream);
			this.textBoxConn.Text = "";
			_url = this.comboBoxURL.Text;
			// test BASS_StreamCreateURL

			bool isWMA = false;
			if (_url != String.Empty)
			{
				this.textBoxConn.Text += "URL: "+_url+Environment.NewLine;
				// create the stream
                _Stream = Bass.BASS_StreamCreateURL(_url, 0, BASSFlag.BASS_STREAM_STATUS, myStreamCreateURL, IntPtr.Zero);
				if (_Stream == 0)
				{
					// try WMA streams...
					_Stream = BassWma.BASS_WMA_StreamCreateFile( _url, 0, 0, BASSFlag.BASS_DEFAULT );
					if (_Stream != 0)
						isWMA = true;
					else
					{
						// error
						this.statusBarConn.Text = "ERROR..." + Enum.GetName(typeof(BASSError), Bass.BASS_ErrorGetCode());
						return;
					}
				}
				_tagInfo = new TAG_INFO(_url);
				BASS_CHANNELINFO info = Bass.BASS_ChannelGetInfo(_Stream);
				if (info.ctype == BASSChannelType.BASS_CTYPE_STREAM_WMA)
					isWMA = true;
				// ok, do some pre-buffering...
				this.statusBarConn.Text = "Buffering...";
				if (!isWMA)
				{
					// display buffering for MP3, OGG...
					while (true) 
					{ 
						long len = Bass.BASS_StreamGetFilePosition(_Stream, BASSStreamFilePosition.BASS_FILEPOS_END);
						if (len == -1)
							break; // typical for WMA streams
						// percentage of buffer filled
						float progress = ( 
							Bass.BASS_StreamGetFilePosition(_Stream, BASSStreamFilePosition.BASS_FILEPOS_DOWNLOAD) - 
							Bass.BASS_StreamGetFilePosition(_Stream, BASSStreamFilePosition.BASS_FILEPOS_CURRENT) 
							) * 100f / len;
                        
						if (progress > 75f) 
						{
							break; // over 75% full, enough
						}

						this.statusBarConn.Text = String.Format( "Buffering... {0}%", progress );
					}
				}
				else
				{
					// display buffering for WMA...
					while (true) 
					{ 
						long len = Bass.BASS_StreamGetFilePosition(_Stream, BASSStreamFilePosition.BASS_FILEPOS_WMA_BUFFER);
						if (len == -1L)
							break;
						// percentage of buffer filled
						if (len > 75L) 
						{
							break; // over 75% full, enough
						}

						this.statusBarConn.Text = String.Format( "Buffering... {0}%", len );
					}
				}

				// get the meta tags (manually - will not work for WMA streams here)
				string[] icy = Bass.BASS_ChannelGetTagsICY(_Stream);
				if (icy == null)
				{
					// try http...
					icy = Bass.BASS_ChannelGetTagsHTTP(_Stream);
				}
				if (icy != null)
				{
					foreach (string tag in icy)
					{
						this.textBoxConn.Text += "ICY: "+tag+Environment.NewLine;
					}
				}
				// get the initial meta data (streamed title...)
				icy = Bass.BASS_ChannelGetTagsMETA(_Stream);
				if (icy != null)
				{
					foreach (string tag in icy)
					{
						this.textBoxConn.Text += "Meta: "+tag+Environment.NewLine;
					}
				}
				else
				{
					// an ogg stream meta can be obtained here
					icy = Bass.BASS_ChannelGetTagsOGG(_Stream);
					if (icy != null)
					{
						foreach (string tag in icy)
						{
							this.textBoxConn.Text += "Meta: "+tag+Environment.NewLine;
						}
					}
				}

				// alternatively to the above, you might use the TAG_INFO (see BassTags add-on)
				// This will also work for WMA streams here ;-)
				if ( BassTags.BASS_TAG_GetFromURL( _Stream, _tagInfo) )
				{
					// and display what we get
					this.textBoxAlbum.Text = _tagInfo.album;
					this.textBoxArtist.Text = _tagInfo.artist;
					this.textBoxTitle.Text = _tagInfo.title;
					this.textBoxComment.Text = _tagInfo.comment;
					this.textBoxGenre.Text = _tagInfo.genre;
					this.textBoxYear.Text = _tagInfo.year;
				}

				// set a sync to get the title updates out of the meta data...
				mySync = new SYNCPROC(MetaSync);
                Bass.BASS_ChannelSetSync(_Stream, BASSSync.BASS_SYNC_META, 0, mySync, IntPtr.Zero);
                Bass.BASS_ChannelSetSync(_Stream, BASSSync.BASS_SYNC_WMA_CHANGE, 0, mySync, IntPtr.Zero);
				
				// start recording...
				int rechandle = 0;
				//if ( Bass.BASS_RecordInit(-1) )
				//{
					_byteswritten = 0;
					myRecProc = new RECORDPROC(MyRecoring);
                    rechandle = Bass.BASS_RecordStart(44100, 2, BASSFlag.BASS_RECORD_PAUSE, myRecProc, IntPtr.Zero);
				//}
				this.statusBarConn.Text = "Playing...";
				// play the stream
				Bass.BASS_ChannelPlay(_Stream, false);
				// record the stream
				Bass.BASS_ChannelPlay(rechandle, false);
			}
			else{
				this.statusBarConn.Text = "Disconnected";
				this.textBoxAlbum.Text = "";
				this.textBoxArtist.Text = "";
				this.textBoxTitle.Text = "";
				this.textBoxComment.Text = "";
				this.textBoxGenre.Text = "";
				this.textBoxYear.Text = "";
			}
		}
		
		private void btnDisconnect_Click(object sender, System.EventArgs e)
		{
				Bass.BASS_StreamFree(_Stream);
				this.textBoxConn.Text = "";
				this.statusBarConn.Text = "Disconnected";
				this.textBoxAlbum.Text = "";
				this.textBoxArtist.Text = "";
				this.textBoxTitle.Text = "";
				this.textBoxComment.Text = "";
				this.textBoxGenre.Text = "";
				this.textBoxYear.Text = "";
		}
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			System.Collections.ArrayList filteredSourceStations = new System.Collections.ArrayList();
			if(this.textBoxSearch.Text!=""){
				
				foreach (string stationName in strSourceStations)
            	{
					if (stationName.Contains(this.textBoxSearch.Text))
				    	filteredSourceStations.Add(stationName);
				    
				}

				this.comboBoxURL.DataSource = filteredSourceStations;
			
			}else
				this.comboBoxURL.DataSource = strSourceStations;
		}
		private int _byteswritten = 0;
		private byte[] _recbuffer = new byte[1048510]; // 1MB buffer
        private bool MyRecoring(int handle, IntPtr buffer, int length, IntPtr user)
		{
			// just a dummy here...nothing is really written to disk...
			if (length > 0 && buffer != IntPtr.Zero)
			{
				// copy from managed to unmanaged memory
				// it is clever to NOT alloc the byte[] everytime here, since ALL callbacks should be really fast!
				// and if you would do a 'new byte[]' every time here...the GarbageCollector would never really clean up that memory here
				// even other sideeffects might occure, due to the fact, that BASS micht call this callback too fast and too often...
				Marshal.Copy(buffer, _recbuffer, 0, length);
				// write to file
				// NOT implemented her...;-)
				_byteswritten += length;
				Console.WriteLine( "Bytes written = {0}", _byteswritten);
				if (_byteswritten < 800000)
					return true; // continue recording
				else
					return false;
			}
			return true;
		}

        private void MyDownloadProc(IntPtr buffer, int length, IntPtr user)
		{
			if (buffer != IntPtr.Zero && length == 0)
			{
				// the buffer contains HTTP or ICY tags.
				string txt = Marshal.PtrToStringAnsi(buffer);
				try {
					//if (this.InvokeRequired)
						this.textBoxConn.Invoke(new UpdateMessageDelegate(UpdateMessageDisplay), new object[] { txt });
				} catch (Exception ex) {
					System.Windows.Forms.MessageBox.Show(ex.Message);
				}
				// you might instead also use "this.BeginInvoke(...)", which would call the delegate asynchron!
			}
		}

        private void MetaSync(int handle, int channel, int data, IntPtr user)
        {
            // BASS_SYNC_META is triggered on meta changes of SHOUTcast streams
            if (_tagInfo.UpdateFromMETA(Bass.BASS_ChannelGetTags(channel, BASSTag.BASS_TAG_META), false, true))
            {
                try {
					//if (this.InvokeRequired)
				   	    this.textBoxConn.Invoke(new UpdateTagDelegate(UpdateTagDisplay));
            	} catch (Exception ex) {
					System.Windows.Forms.MessageBox.Show(ex.Message);
				}
            }
        }

        public delegate void UpdateTagDelegate();
        private void UpdateTagDisplay()
        {
            this.textBoxAlbum.Text = _tagInfo.album;
            this.textBoxArtist.Text = _tagInfo.artist;
            this.textBoxTitle.Text = _tagInfo.title;
            this.textBoxComment.Text = _tagInfo.comment;
            this.textBoxGenre.Text = _tagInfo.genre;
            this.textBoxYear.Text = _tagInfo.year;
        }

        //public delegate void UpdateStatusDelegate(string txt);
        //private void UpdateStatusDisplay(string txt)
        //{
        //    this.statusBarConn.Text = txt;
        //}

		public delegate void UpdateMessageDelegate(string txt);
		private void UpdateMessageDisplay(string txt)
		{
			this.textBoxConn.Text += "Tags: " + txt + Environment.NewLine;
		}
	}
}
