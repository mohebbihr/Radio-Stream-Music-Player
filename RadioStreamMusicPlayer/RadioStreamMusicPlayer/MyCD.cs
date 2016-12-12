using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Cd;
using Un4seen.Bass.AddOn.Mix;
using Un4seen.Bass.AddOn.Wma;
using Un4seen.Bass.AddOn.Tags;
using Un4seen.Bass.Misc;


namespace RadioStreamMusicPlayer
{
    public partial class MyCD : Form
    {
        public  System.Windows.Forms.Button buttonStop;
        public  System.Windows.Forms.Button buttonPlay;
        public  System.Windows.Forms.PictureBox pictureBox1;
        public  System.Windows.Forms.Label label1;
        public  System.Windows.Forms.Button buttonBrowse;
        public  System.Windows.Forms.ListBox listBox1;
        public  System.Windows.Forms.ComboBox comboBox1;
        public  System.Windows.Forms.Button buttonDriveInfo;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TrackBar volume;
        public System.Windows.Forms.Label volumelabel;



        public MyCD()
        {
            InitializeComponent();
        }

        public void closeCD()
        {

        }

        #region Declarations
        int Y;
        System.Drawing.Graphics GO;
        int VisNumber;
        //CD Stream 
        private static int cdStream=0;
        short CDMode;
        string sFileName = "";

        #endregion

        #region Public Properties
        private static int m_sElapsedSeconds;

        public int sElapsedSeconds
        {
            set
            {
                m_sElapsedSeconds = value;
            }
            get
            {
                return m_sElapsedSeconds;

            }
        }

        private static int m_sRemainSeconds;
        public int sRemainSeconds
        {
            set
            {
                m_sRemainSeconds = value;
            }
            get
            {
                return m_sRemainSeconds;
            }
        }

        private static long m_RippedBytes;
        public long RippedBytes
        {
            set
            {
                m_RippedBytes = value;
            }
            get
            {
                return m_RippedBytes;
            }
        }

        private static long m_TotalSeconds;
        public long TotalSeconds
        {
            set
            {
                m_TotalSeconds = value;
            }
            get
            {
                return m_TotalSeconds;
            }
        }
        #endregion

        #region Drives

        private void LoadCDDrives()
        {
            char DL;
            string DESCR;

            comboBox1.Items.Clear();

            BASS_CD_INFO[] drives = BassCd.BASS_CD_GetInfos();
            //BASS_CD_INFO info;
            foreach (BASS_CD_INFO info in drives)
            {
                DL = info.DriveLetter;
                DESCR = info.ToString();
                comboBox1.Items.Add(DL + " "+ DESCR);
            }
            if (comboBox1.Items.Count > 0) comboBox1.SelectedIndex = 0;
        }

        private void combobox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!BassCd.BASS_CD_IsReady(comboBox1.SelectedIndex))
            {
                listBox1.Items.Clear();
            }
            int nTracks = BassCd.BASS_CD_GetTracks(comboBox1.SelectedIndex);
            GetDriveInfo();
            if (nTracks == -1)
            {
                listBox1.Items.Clear();
            }
            listBox1.Items.Clear();
            for (int A = 0; A < nTracks; A++ )
            {
                if (A <= 8)
                {
                    listBox1.Items.Add("Track 0" + (A + 1).ToString());
                }
                else
                {
                    listBox1.Items.Add("Track " + (A + 1).ToString());
                }
            }
        }

        private string GetDriveInfo()
        {
            Un4seen.Bass.AddOn.Cd.BASS_CD_INFO T = new BASS_CD_INFO();
            string OutText;

            BassCd.BASS_CD_GetInfo(comboBox1.SelectedIndex, T);

            OutText = comboBox1.Text + "\n\n";
            OutText += " Cache: " + T.cache.ToString() + " KB" + "\n";
            OutText += " Max Speed: " + T.maxspeed.ToString() + " KB/s or " + (T.maxspeed / 150).ToString() + "x" + "\n";
            OutText += " Can Lock: " + T.canlock.ToString() + "\n";
            OutText += " Can Open: " + T.canopen.ToString() + "\n\n";

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READSUBCHAN)
            {
                OutText += " Read Subcodes: True\n";
            }
            else
            {
                OutText += " Read Subcodes: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READCDRW)
            {
                OutText += " Read CD/RW: True\n";
            }
            else
            {
                OutText += " Read CD/RW: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READSUBCHANDI)
            {
                OutText += " Read Subcodes Interlaced: True\n";
            }
            else
            {
                OutText += " Read Subcodes Interlaced: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READCDRW)
            {
                OutText += " Read CD/RW: True\n";
            }
            else
            {
                OutText += " Read CD/RW: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READDVD)
            {
                OutText += " Read DVD: True\n";
            }
            else
            {
                OutText += " Read DVD: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READDVDR)
            {
                OutText += " Read DVD-+R: True\n";
            }
            else
            {
                OutText += " Read DVD-+R: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READDVDRAM)
            {
                OutText += " Read DVD-RAM: True\n";
            }
            else
            {
                OutText += " Read DVD-RAM: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READUPC)
            {
                OutText += " Read UPC: True\n";
            }
            else
            {
                OutText += " Read UPC: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READANALOG)
            {
                OutText += " Read Analog: True\n";
            }
            else
            {
                OutText += " Read Analog: False\n";
            }

            if (T.rwflags == Un4seen.Bass.AddOn.Cd.BASSCDRWFlags.BASS_CD_RWFLAG_READMULTI)
            {
                OutText += " Read Multi: True\n";
            }
            else
            {
                OutText += " Read Multi: False\n";
            }
            return OutText;   
        }
        #endregion

        #region Misc Code

        private int Percentage(long IntDone, long IntMax)
        {
            int D;
            long t = 100 * IntDone / IntMax;
            D = (int)t / 10;
            return D;

        }

        public string BrowseForFile()
        {
            System.Windows.Forms.OpenFileDialog ofd1= new OpenFileDialog();
            DialogResult Dr;

            ofd1.Filter = "CD Audio (*.cda)|*.cda";
            ofd1.DefaultExt = "*.cda";
            Dr = ofd1.ShowDialog(this);
            if (Dr == System.Windows.Forms.DialogResult.OK)
            {
                return ofd1.FileName;
            }
            return "";
        }

        public string BrowseForFolder()
        {
            System.Windows.Forms.FolderBrowserDialog bfd1 = new FolderBrowserDialog();
            DialogResult Dr;

            bfd1.ShowNewFolderButton = true;
            bfd1.Description = "Select a folder...";
            Dr = bfd1.ShowDialog();
            if (Dr == System.Windows.Forms.DialogResult.OK)
            {
                return bfd1.SelectedPath.ToString();
            }
            return "";
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CDMode = 0;
        }

        private  void timer1_Tick(Object myObject, EventArgs myEventArgs)
        {
            string OutText = "";

            if (Bass.BASS_ChannelIsActive(cdStream) != Un4seen.Bass.BASSActive.BASS_ACTIVE_PLAYING)
            {
                listBox1.Enabled = true;
                comboBox1.Enabled = true;
                buttonPlay.Enabled = true;
                buttonStop.Enabled = false;
                buttonBrowse.Enabled = true;
                buttonDriveInfo.Enabled = true;
                if (label1.Text != "CD Recognition") label1.Text = "CD Recognition";
                return;
            }

            if (buttonPlay.Enabled == true) buttonPlay.Enabled = false;
            if (buttonBrowse.Enabled == true) buttonBrowse.Enabled = false;
            if (buttonDriveInfo.Enabled == true) buttonDriveInfo.Enabled = false;
            if (buttonStop.Enabled == false) buttonStop.Enabled = true;
            if (listBox1.Enabled == true) listBox1.Enabled = false;
            if (comboBox1.Enabled == true) comboBox1.Enabled = false;

            m_sElapsedSeconds = (int)Bass.BASS_ChannelBytes2Seconds(cdStream, Bass.BASS_ChannelGetPosition(cdStream));
            m_TotalSeconds = (int)Bass.BASS_ChannelBytes2Seconds(cdStream, Bass.BASS_ChannelGetLength(cdStream));
            m_sRemainSeconds = (int) m_TotalSeconds - m_sElapsedSeconds;

            OutText = Un4seen.Bass.Utils.FixTimespan(m_sElapsedSeconds, "MMSS") + " -" + Un4seen.Bass.Utils.FixTimespan(m_TotalSeconds - m_sElapsedSeconds, "MMSS") + " " + Un4seen.Bass.Utils.FixTimespan(m_TotalSeconds, "MMSS");
            if (label1.Text != OutText) label1.Text = OutText;

            if (Bass.BASS_ChannelIsActive(cdStream) == BASSActive.BASS_ACTIVE_STOPPED)
            {
                return;
            }


        }

        private void picVis_Click(object sender, EventArgs e)
        {
            BumpVisual();
        }


        #endregion


        #region Form Events

        private void MyCD_Load(object sender, EventArgs e)
        {

        }

        public void CD_Loading()
        {
            Boolean BB;
            BB = Bass.BASS_Init(1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
            BB = Bass.BASS_Start();
            if (!BB) MessageBox.Show("Bass could not be started!");
            LoadCDDrives();
        }


        private void MyCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_Stop();
            Bass.BASS_Free();
        }


        private void buttonDriveInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show( GetDriveInfo());
            
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            string Filename = BrowseForFile();
            if (Filename == "") return;
            CDMode = 1;
            sFileName = Filename;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //testing part
            bool test = false;
            if (test)  testCDMix(0,3);
            else
            {
                //
                int DriveNum = 0;
                int TrackNum = 0;

                switch (CDMode)
                {
                    case 0: //bass_cd_streamcreate
                        DriveNum = comboBox1.SelectedIndex;
                        if (listBox1.SelectedItem == null) listBox1.SelectedIndex = 0;
                        TrackNum = listBox1.SelectedIndex;
                        if (!BassCd.BASS_CD_IsReady(DriveNum))
                        {
                            BASS_CD_INFO info = BassCd.BASS_CD_GetInfo(DriveNum);
                            MessageBox.Show(" Drive: " + info.DriveLetter + " Is Not Ready");
                            break;
                        }
                        testCDMix(DriveNum, TrackNum);

                        break;

                    case 1:

                        if (sFileName == "")
                        {
                            MessageBox.Show("filename is not valid");
                            break;
                        }
                        if (!System.IO.File.Exists(sFileName))
                        {
                            MessageBox.Show("Filename: " + sFileName + "\n" + " Does not exist!");
                            break;
                        }
                        testCDMix(sFileName);
                        break;


                }             

            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (!Bass.BASS_ChannelStop(cdStream)) MessageBox.Show("Stream could not be stopped!");
        }

        #endregion

        #region Visuals

        public double Sqrt(double num)
        {
            return Math.Pow(num, 0.5);
        }


        public void BumpVisual()
        {
            VisNumber += 1;
            if (VisNumber == 3) VisNumber = 0;
        }

        //public void Visual1()
        //{
        //    Bitmap bit = new Bitmap(picVis.Width, picVis.Height);
        //    Graphics graph = Graphics.FromImage(bit);
        //    Pen whitePen = new Pen(Color.Azure, 2);
        //    Pen PurplePen = new Pen(Color.BlueViolet, 2);
        //    float [] d= new float[1023];
        //    BASSActive playing;
        //    int X;

        //    graph.SmoothingMode = SmoothingMode.AntiAlias;
        //    //playing = Bass.BASS_ChannelIsActive(strmPlay);
        //    playing = Bass.BASS_ChannelIsActive(cdStream);
        //    if (playing != BASSActive.BASS_ACTIVE_PLAYING) return;

        //    //Bass.BASS_ChannelGetData(strmPlay, d, (int)Un4seen.Bass.BASSData.BASS_DATA_FFT1024);
        //    //Bass.BASS_ChannelGetData(cdStream, d, (int)Un4seen.Bass.BASSData.BASS_DATA_FFT1024);

        //    for (X = 0; X < picVis.Width; X+=4 )
        //    {
        //        Y =(int) (Sqrt((double)d[X + 1]) * 3 * picVis.Height);
        //        if (Y > picVis.Height) Y = picVis.Height;
        //        if (Y < 0) Y = 0;
        //        graph.DrawLine(whitePen, X + 2, picVis.Height / 2, X + 2, picVis.Height / 2 - Y);
        //        graph.DrawLine(PurplePen, X + 2, picVis.Height / 2 + Y, X + 2, picVis.Height / 2);

        //    }
        //    //draw the visual onto the picturebox
        //    picVis.Image = bit;

        //    try
        //    {
        //        graph.Dispose();
        //        whitePen.Dispose();
        //        PurplePen.Dispose();

        //        bit= null;
        //        graph = null;
        //        whitePen = null;
        //        PurplePen = null;
        //    }catch(Exception ex){}

        //}

        //public void Visual2()
        //{
        //    Bitmap bit = new Bitmap(picVis.Width, picVis.Height);
        //    Graphics graph = Graphics.FromImage(bit);
        //    Pen redPen = new Pen(Color.Red, 5);
        //    Pen yellowPen = new Pen(Color.Yellow, 5);
        //    float[] d = new float[1023];
        //    BASSActive playing;
        //    int X;

        //    graph.SmoothingMode = SmoothingMode.AntiAlias;
        //    playing = Bass.BASS_ChannelIsActive(strmPlay);
        //    if (playing != BASSActive.BASS_ACTIVE_PLAYING) return;

        //    Bass.BASS_ChannelGetData(strmPlay, d, (int)Un4seen.Bass.BASSData.BASS_DATA_FFT1024);

        //    for (X = 0; X < picVis.Width; X += 8)
        //    {
        //        Y = (int) (Sqrt(d[X + 1]) * 3 * picVis.Height);
        //        if (Y > picVis.Height) Y = picVis.Height;
        //        if (Y < 0) Y = 0;
        //        graph.DrawLine(redPen, X + 2, picVis.Height, X + 2, picVis.Height - Y);
        //        graph.DrawLine(yellowPen, X + 2, picVis.Height - Y, X + 2, picVis.Height - Y -2);

        //    }
        //    //draw the visual onto the picturebox
        //    picVis.Image = bit;

        //    try
        //    {
        //        graph.Dispose();
        //        redPen.Dispose();
        //        yellowPen.Dispose();

        //        bit = null;
        //        graph = null;
        //        redPen = null;
        //        yellowPen = null;
        //    }
        //    catch (Exception ex) { }
        //}

        //public void Visual3()
        //{
        //    Bitmap bit = new Bitmap(picVis.Width, picVis.Height);
        //    Graphics graph = Graphics.FromImage(bit);
        //    Pen greenPen = new Pen(Color.Green, 2);
        //    float[] d = new float[1023];
        //    BASSActive playing;
        //    int X;

        //    graph.SmoothingMode = SmoothingMode.AntiAlias;
        //    playing = Bass.BASS_ChannelIsActive(strmPlay);
        //    if (playing != BASSActive.BASS_ACTIVE_PLAYING) return;

        //    Bass.BASS_ChannelGetData(strmPlay, d, (int)Un4seen.Bass.BASSData.BASS_DATA_FFT1024);

        //    for (X = 0; X < picVis.Width; X += 4)
        //    {
        //        Y = (int)(Sqrt(d[X + 1]) * 3 * picVis.Height);
        //        if (Y > picVis.Height) Y = picVis.Height;
        //        if (Y < 0) Y = 0;
        //        graph.DrawEllipse(greenPen, X , picVis.Height - Y, 5, 10);
                
        //    }
        //    //draw the visual onto the picturebox
        //    picVis.Image = bit;

        //    try
        //    {
        //        graph.Dispose();
        //        greenPen.Dispose();

        //        bit = null;
        //        graph = null;
        //        greenPen = null;

        //    }
        //    catch (Exception ex) { }
        //}

        #endregion

        private void testCDMix(int drive, int track)
        {
            //creating stream from cd
            cdStream = BassCd.BASS_CD_StreamCreate(drive, track, BASSFlag.BASS_STREAM_DECODE);

            //add background music to mixer
            bool cdMix = BassMix.BASS_Mixer_StreamAddChannel(RadioStreamMusicPlayer.outputMixerStream, cdStream, 0);

            if (cdMix == false)
            {
                MessageBox.Show("Could not mix the cd stream");
                return;
            }

            EncoderLAME _lame = null;
            _lame = new EncoderLAME(RadioStreamMusicPlayer.outputMixerStream);
            _lame.InputFile = null;	//STDIN
            _lame.OutputFile = "recCD.mp3";
            _lame.LAME_Bitrate = (int)EncoderLAME.BITRATE.kbps_192;
            _lame.LAME_Mode = EncoderLAME.LAMEMode.Default;
            _lame.LAME_TargetSampleRate = (int)EncoderLAME.SAMPLERATE.Hz_44100;
            _lame.LAME_Quality = EncoderLAME.LAMEQuality.Quality;

            // really start recording
            _lame.Start(null, IntPtr.Zero, false);
            Bass.BASS_ChannelPlay(cdStream, false);
            Bass.BASS_ChannelPlay(RadioStreamMusicPlayer.outputMixerStream, false);

        }

        private void testCDMix(string filename)
        {

            //creating stream from cd
            cdStream = BassCd.BASS_CD_StreamCreateFile(filename, BASSFlag.BASS_STREAM_DECODE);

            //add background music to mixer
            bool cdMix = BassMix.BASS_Mixer_StreamAddChannel(RadioStreamMusicPlayer.outputMixerStream, cdStream, 0);

            if (cdMix == false)
            {
                MessageBox.Show("Could not mix the cd stream");
                return;
            }

            EncoderLAME _lame = null;
            _lame = new EncoderLAME(RadioStreamMusicPlayer.outputMixerStream);
            _lame.InputFile = null;	//STDIN
            _lame.OutputFile = "recCD.mp3";
            _lame.LAME_Bitrate = (int)EncoderLAME.BITRATE.kbps_192;
            _lame.LAME_Mode = EncoderLAME.LAMEMode.Default;
            _lame.LAME_TargetSampleRate = (int)EncoderLAME.SAMPLERATE.Hz_44100;
            _lame.LAME_Quality = EncoderLAME.LAMEQuality.Quality;

            // really start recording
            _lame.Start(null, IntPtr.Zero, false);

            Bass.BASS_ChannelPlay(cdStream, false);
            Bass.BASS_ChannelPlay(RadioStreamMusicPlayer.outputMixerStream, false);

        }

        private void volume_Scroll(object sender, System.EventArgs e)
        {
            if (cdStream != 0)
            {

                Bass.BASS_ChannelSetAttribute(cdStream, Un4seen.Bass.BASSAttribute.BASS_ATTRIB_VOL, volume.Value);
            }
        }
    }
}
