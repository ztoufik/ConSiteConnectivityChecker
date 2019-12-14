namespace WinFSiteconnectivityChecker
{
    partial class Form1
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
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.btnRmUrl = new System.Windows.Forms.Button();
            this.TxtbxUrl = new System.Windows.Forms.TextBox();
            this.RTxtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.TxtBxInterval = new System.Windows.Forms.TextBox();
            this.BtnValidInterv = new System.Windows.Forms.Button();
            this.LstVwUrls = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Location = new System.Drawing.Point(66, 56);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(91, 23);
            this.btnAddUrl.TabIndex = 0;
            this.btnAddUrl.Text = "add an Url";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // btnRmUrl
            // 
            this.btnRmUrl.Location = new System.Drawing.Point(66, 95);
            this.btnRmUrl.Name = "btnRmUrl";
            this.btnRmUrl.Size = new System.Drawing.Size(91, 23);
            this.btnRmUrl.TabIndex = 1;
            this.btnRmUrl.Text = "remove an Url";
            this.btnRmUrl.UseVisualStyleBackColor = true;
            this.btnRmUrl.Click += new System.EventHandler(this.btnRmUrl_Click);
            // 
            // TxtbxUrl
            // 
            this.TxtbxUrl.Location = new System.Drawing.Point(44, 22);
            this.TxtbxUrl.Name = "TxtbxUrl";
            this.TxtbxUrl.Size = new System.Drawing.Size(134, 20);
            this.TxtbxUrl.TabIndex = 2;
            // 
            // RTxtDisplay
            // 
            this.RTxtDisplay.Location = new System.Drawing.Point(216, 23);
            this.RTxtDisplay.Name = "RTxtDisplay";
            this.RTxtDisplay.Size = new System.Drawing.Size(251, 114);
            this.RTxtDisplay.TabIndex = 4;
            this.RTxtDisplay.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 160);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(103, 160);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // TxtBxInterval
            // 
            this.TxtBxInterval.Location = new System.Drawing.Point(524, 162);
            this.TxtBxInterval.Name = "TxtBxInterval";
            this.TxtBxInterval.Size = new System.Drawing.Size(100, 20);
            this.TxtBxInterval.TabIndex = 7;
            // 
            // BtnValidInterv
            // 
            this.BtnValidInterv.Location = new System.Drawing.Point(426, 162);
            this.BtnValidInterv.Name = "BtnValidInterv";
            this.BtnValidInterv.Size = new System.Drawing.Size(75, 23);
            this.BtnValidInterv.TabIndex = 9;
            this.BtnValidInterv.Text = "Ok";
            this.BtnValidInterv.UseVisualStyleBackColor = true;
            this.BtnValidInterv.Click += new System.EventHandler(this.BtnValidInterv_Click);
            // 
            // LstVwUrls
            // 
            this.LstVwUrls.HideSelection = false;
            this.LstVwUrls.Location = new System.Drawing.Point(487, 23);
            this.LstVwUrls.Name = "LstVwUrls";
            this.LstVwUrls.Size = new System.Drawing.Size(126, 114);
            this.LstVwUrls.TabIndex = 10;
            this.LstVwUrls.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 211);
            this.Controls.Add(this.LstVwUrls);
            this.Controls.Add(this.BtnValidInterv);
            this.Controls.Add(this.TxtBxInterval);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.RTxtDisplay);
            this.Controls.Add(this.TxtbxUrl);
            this.Controls.Add(this.btnRmUrl);
            this.Controls.Add(this.btnAddUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.Button btnRmUrl;
        private System.Windows.Forms.TextBox TxtbxUrl;
        private System.Windows.Forms.RichTextBox RTxtDisplay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox TxtBxInterval;
        private System.Windows.Forms.Button BtnValidInterv;
        private System.Windows.Forms.ListView LstVwUrls;
    }
}

