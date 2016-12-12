/*
 * Creato da Alberto Scozzari.
 * Utente: User
 * Data: 02/10/2012
 * Ora: 16.42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
namespace RadioStreamMusicPlayer
{
	partial class RadioStreamMusicPlayer
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "RadioStreamMusicPlayer";
			this.Name = "MainForm";
			
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(735, 494);

			
			tabMain.Width = this.Width;
			tabMain.Height = this.Height;
			tabMain.Controls.Add(tabPlayer);
			tabMain.Controls.Add(tabRadio);
			tabMain.Controls.Add(tabStreaming);
            //added by mohebbihr for microphone and cd parts
            tabMain.Controls.Add(tabMicrophone);
            tabMicrophone.AutoSize = true;
            tabMain.Controls.Add(tabCD);
            tabCD.AutoSize = true;
			
			tabPlayer.AutoSize = true;
			tabRadio.AutoSize = true;
			tabStreaming.AutoSize = true;
			
			this.SizeChanged += new System.EventHandler(MainForm_SizeChanged);
			
			this.Controls.Add(tabMain);
						
			tabPlayer.Controls.Add(player.label30);
			tabPlayer.Controls.Add(player.trackBarSoftSatDepth);
			tabPlayer.Controls.Add(player.checkBoxStreamCopy);
			tabPlayer.Controls.Add(player.label29);
			tabPlayer.Controls.Add(player.comboBoxStreamCopy);
			tabPlayer.Controls.Add(player.buttonPause);
			tabPlayer.Controls.Add(player.trackBarSoftSat);
			tabPlayer.Controls.Add(player.checkBoxSoftSat);
			tabPlayer.Controls.Add(player.label27);
			tabPlayer.Controls.Add(player.labelIIRDelay);
			tabPlayer.Controls.Add(player.trackBarIIRDelayFeedback);
			tabPlayer.Controls.Add(player.label24);
			tabPlayer.Controls.Add(player.label25);
			tabPlayer.Controls.Add(player.label26);
			tabPlayer.Controls.Add(player.trackBarIIRDelayWet);
			tabPlayer.Controls.Add(player.buttonZoom);
			tabPlayer.Controls.Add(player.checkBoxMonoInvert);
			tabPlayer.Controls.Add(player.checkBoxMono);
			tabPlayer.Controls.Add(player.pictureBoxSpectrum);
			tabPlayer.Controls.Add(player.label17);
			tabPlayer.Controls.Add(player.checkBoxDAmp);
			tabPlayer.Controls.Add(player.buttonSetGain);
			tabPlayer.Controls.Add(player.textBoxGainDBValue);
			tabPlayer.Controls.Add(player.label23);
			tabPlayer.Controls.Add(player.label22);
			tabPlayer.Controls.Add(player.label13);
			tabPlayer.Controls.Add(player.label21);
			tabPlayer.Controls.Add(player.label18);
			tabPlayer.Controls.Add(player.label14);
			tabPlayer.Controls.Add(player.trackBarGain);
			tabPlayer.Controls.Add(player.trackBarIIRDelay);
			tabPlayer.Controls.Add(player.checkBoxIIRDelay);
			tabPlayer.Controls.Add(player.checkBoxLevel2Bypass);
			tabPlayer.Controls.Add(player.checkBoxLevel1Bypass);
			tabPlayer.Controls.Add(player.label19);
			tabPlayer.Controls.Add(player.label20);
			tabPlayer.Controls.Add(player.label15);
			tabPlayer.Controls.Add(player.label16);
			tabPlayer.Controls.Add(player.labelStereoEnhancer);
			tabPlayer.Controls.Add(player.checkBoxStereoEnhancer);
			tabPlayer.Controls.Add(player.checkBoxGainDither);
			tabPlayer.Controls.Add(player.label12);
			tabPlayer.Controls.Add(player.labelCompThreshold);
			tabPlayer.Controls.Add(player.label11);
			tabPlayer.Controls.Add(player.progressBarPeak2Right);
			tabPlayer.Controls.Add(player.label6);
			tabPlayer.Controls.Add(player.progressBarPeak2Left);
			tabPlayer.Controls.Add(player.label7);
			tabPlayer.Controls.Add(player.buttonStop);
			tabPlayer.Controls.Add(player.pictureBox1);
			tabPlayer.Controls.Add(player.labelTime);
			tabPlayer.Controls.Add(player.buttonPlay);
			tabPlayer.Controls.Add(player.progressBarPeak1Right);
			tabPlayer.Controls.Add(player.label2);
			tabPlayer.Controls.Add(player.progressBarPeak1Left);
			tabPlayer.Controls.Add(player.label1);
			tabPlayer.Controls.Add(player.btnSceltaFile);
			tabPlayer.Controls.Add(player.label3);
			tabPlayer.Controls.Add(player.label4);
			tabPlayer.Controls.Add(player.trackBarEffect);
			tabPlayer.Controls.Add(player.labelLevel2);
			tabPlayer.Controls.Add(player.label5);
			tabPlayer.Controls.Add(player.label8);
			tabPlayer.Controls.Add(player.label9);
			tabPlayer.Controls.Add(player.label10);
			tabPlayer.Controls.Add(player.labelLevel1);
			tabPlayer.Controls.Add(player.checkBoxCompressor);
			tabPlayer.Controls.Add(player.trackBarCompressor);
			tabPlayer.Controls.Add(player.trackBarStereoEnhancerWetDry);
			tabPlayer.Controls.Add(player.trackBarStereoEnhancerWide);

            //added by mohebbihr for microphone part
            tabMicrophone.Controls.Add(this.microphone.buttonStartRec);
            tabMicrophone.Controls.Add(this.microphone.buttonStopRec);
            tabMicrophone.Controls.Add(this.microphone.labelRec);
            tabMicrophone.Controls.Add(this.microphone.recordingGroupBox);
			
            //added by mohebbihr for cd part         
            tabCD.Controls.Add(this.cd.buttonBrowse);
            tabCD.Controls.Add(this.cd.buttonDriveInfo);
            tabCD.Controls.Add(this.cd.buttonPlay);
            tabCD.Controls.Add(this.cd.buttonStop);
            tabCD.Controls.Add(this.cd.label1);
            tabCD.Controls.Add(this.cd.pictureBox1);
            tabCD.Controls.Add(this.cd.comboBox1);
            tabCD.Controls.Add(this.cd.listBox1);
            tabCD.Controls.Add(this.cd.volume);
            tabCD.Controls.Add(this.cd.volumelabel);

            //
            this.Load += new System.EventHandler(RadioStreamMusicPlayer_Load);

			tabRadio.Controls.Add(this.radio.btnConnect);
			tabRadio.Controls.Add(this.radio.btnDisconnect);
			tabRadio.Controls.Add(this.radio.btnSearch);
			tabRadio.Controls.Add(this.radio.textBoxSearch);
			tabRadio.Controls.Add(this.radio.textBoxConn);
			tabRadio.Controls.Add(this.radio.statusBarConn);
			tabRadio.Controls.Add(this.radio.comboBoxURL);
			tabRadio.Controls.Add(this.radio.textBoxArtist);
			tabRadio.Controls.Add(this.radio.textBoxTitle);
			tabRadio.Controls.Add(this.radio.textBoxAlbum);
			tabRadio.Controls.Add(this.radio.textBoxComment);
			tabRadio.Controls.Add(this.radio.textBoxGenre);
			tabRadio.Controls.Add(this.radio.textBoxYear);
			
			tabStreaming.Controls.Add(streaming.label1);
			tabStreaming.Controls.Add(streaming.comboBoxKbps);
			tabStreaming.Controls.Add(streaming.checkBoxAutoReconnect);
			tabStreaming.Controls.Add(streaming.checkBoxUseBASS);
			tabStreaming.Controls.Add(streaming.textBoxUrl);
			tabStreaming.Controls.Add(streaming.textBoxGenre);
			tabStreaming.Controls.Add(streaming.textBoxName);
			tabStreaming.Controls.Add(streaming.textBoxPort);
			tabStreaming.Controls.Add(streaming.textBoxPassword);
			tabStreaming.Controls.Add(streaming.textBoxServerAddress);
			tabStreaming.Controls.Add(streaming.radioButtonLAME);
			tabStreaming.Controls.Add(streaming.radioButtonWMA);
			tabStreaming.Controls.Add(streaming.labelEnc);
			tabStreaming.Controls.Add(streaming.checkBoxPublic);
			tabStreaming.Controls.Add(streaming.radioButtonOGG);
			tabStreaming.Controls.Add(streaming.radioButtonAAC);
			tabStreaming.Controls.Add(streaming.labelServer);
			tabStreaming.Controls.Add(streaming.labelPort);
			tabStreaming.Controls.Add(streaming.labelPwd);
			tabStreaming.Controls.Add(streaming.labelGenre);
			tabStreaming.Controls.Add(streaming.labelURL);
			tabStreaming.Controls.Add(streaming.labelName);
			tabStreaming.Controls.Add(streaming.listBoxMessage);
			tabStreaming.Controls.Add(streaming.tabControlBroadCast);
			tabStreaming.Controls.Add(streaming.labelHint);
			tabStreaming.Controls.Add(streaming.groupBox1);
						
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			
			this.Closing += new System.ComponentModel.CancelEventHandler(this.DSP_Closing);
			((System.ComponentModel.ISupportInitialize)(player.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarEffect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarCompressor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarStereoEnhancerWide)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarStereoEnhancerWetDry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarIIRDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarGain)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.pictureBoxSpectrum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarIIRDelayWet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarIIRDelayFeedback)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarSoftSat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(player.trackBarSoftSatDepth)).EndInit();
						
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		
		private void setTabSize () {
			tabMain.Width = this.Width;
			tabMain.Height = this.Height;
		}
		
		public void MainForm_SizeChanged(object sender, System.EventArgs e) {
			this.setTabSize();
		}

        private void RadioStreamMusicPlayer_Load(object sender, EventArgs e)
        {
            cd.CD_Loading();
        }
	}
}
