namespace 多媒體播放器
{
    partial class frmMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.palButton = new System.Windows.Forms.Panel();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.palButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, -1);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(442, 271);
            this.wmpVideo.TabIndex = 0;
            // 
            // palButton
            // 
            this.palButton.Controls.Add(this.btnStop);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Controls.Add(this.BtnPlay);
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Location = new System.Drawing.Point(0, 276);
            this.palButton.Name = "palButton";
            this.palButton.Size = new System.Drawing.Size(442, 56);
            this.palButton.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(12, 10);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(89, 36);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "瀏覽";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(129, 10);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(88, 36);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "播放";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(239, 10);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(82, 36);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(336, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 36);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 339);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.wmpVideo);
            this.Name = "frmMediaPlayer";
            this.Text = "多媒體播放器";
            this.Load += new System.EventHandler(this.frmMediaPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.palButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel palButton;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button btnBrowser;
    }
}

