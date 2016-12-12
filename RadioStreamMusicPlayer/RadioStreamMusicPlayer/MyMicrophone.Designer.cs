namespace RadioStreamMusicPlayer
{
    partial class MyMicrophone
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
            this.buttonStartRec = new System.Windows.Forms.Button();
            this.buttonStopRec = new System.Windows.Forms.Button();
            this.recordingGroupBox = new System.Windows.Forms.GroupBox();
            this.labelRec = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TrackBar();
            this.recordingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartRec
            // 
            this.buttonStartRec.Location = new System.Drawing.Point(10, 30);
            this.buttonStartRec.Name = "buttonStartRec";
            this.buttonStartRec.Size = new System.Drawing.Size(78, 23);
            this.buttonStartRec.TabIndex = 2;
            this.buttonStartRec.Text = "Start Rec";
            this.buttonStartRec.Click += new System.EventHandler(this.buttonStartRec_Click);
            // 
            // buttonStopRec
            // 
            this.buttonStopRec.Location = new System.Drawing.Point(100, 30);
            this.buttonStopRec.Name = "buttonStopRec";
            this.buttonStopRec.Size = new System.Drawing.Size(78, 23);
            this.buttonStopRec.TabIndex = 1;
            this.buttonStopRec.Text = "Stop Rec";
            this.buttonStopRec.Click += new System.EventHandler(this.buttonStopRec_Click);
            //
            // volume
            //
            this.volume.Location = new System.Drawing.Point(10, 90);
            this.volume.Name = "Volume";
            this.volume.Size = new System.Drawing.Size(220, 45);
            this.volume.Maximum = 100;
            this.volume.TickFrequency = 5;
            this.volume.Value = 100;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // recordingGroupBox
            // 
            this.recordingGroupBox.Controls.Add(this.labelRec);
            this.recordingGroupBox.Controls.Add(this.buttonStopRec);
            this.recordingGroupBox.Controls.Add(this.buttonStartRec);
            this.recordingGroupBox.Controls.Add(this.volume);
            this.recordingGroupBox.Location = new System.Drawing.Point(10, 10);
            this.recordingGroupBox.Name = "recordingGroupBox";
            this.recordingGroupBox.Size = new System.Drawing.Size(400, 400);
            this.recordingGroupBox.TabIndex = 0;
            this.recordingGroupBox.TabStop = false;
            this.recordingGroupBox.Text = "Live Recording";
            //this.recordingGroupBox.BackColor = System.Drawing.Color.Yellow;
            // 
            // labelRec
            // 
            this.labelRec.Location = new System.Drawing.Point(10, 60);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(200, 30);
            this.labelRec.TabIndex = 0;
            //this.labelRec.BackColor = System.Drawing.Color.Red;                       
            // 
            // MyMicrophone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Name = "MyMicrophone";
            this.Text = "MyMicrophone";
            this.recordingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

      

        #endregion
    }
}