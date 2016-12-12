namespace RadioStreamMusicPlayer
{
    partial class MyCD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;




        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDriveInfo = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.TrackBar();
            this.volumelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStop.Location = new System.Drawing.Point(184, 72);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPlay.Location = new System.Drawing.Point(120, 72);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(56, 23);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 32);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CD Recognition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBrowse.Location = new System.Drawing.Point(248, 72);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(64, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "&Browse...";
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(8, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(108, 147);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(120, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.combobox1_SelectedIndexChanged);
            // 
            // buttonDriveInfo
            // 
            this.buttonDriveInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDriveInfo.Location = new System.Drawing.Point(320, 72);
            this.buttonDriveInfo.Name = "buttonDriveInfo";
            this.buttonDriveInfo.Size = new System.Drawing.Size(120, 23);
            this.buttonDriveInfo.TabIndex = 7;
            this.buttonDriveInfo.Text = "Drive Information";
            this.buttonDriveInfo.Click += new System.EventHandler(this.buttonDriveInfo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // volume
            //
            
            this.volume.Location = new System.Drawing.Point(120, 120);
            this.volume.Name = "Volume";
            this.volume.Size = new System.Drawing.Size(220, 45);
            this.volume.Maximum = 100;
            this.volume.TickFrequency = 5;
            this.volume.Value = 100;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            //
            // volumelabel
            //
            this.volumelabel.Location = new System.Drawing.Point(120, 100);
            this.volumelabel.Name = "VolumeLabel";
            this.volumelabel.Size = new System.Drawing.Size(50, 20);
            this.volumelabel.Text = "Volume:";
            // 
            // MyCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.buttonDriveInfo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.volumelabel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCD";
            this.Load += new System.EventHandler(this.MyCD_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyCD_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion









    }
}