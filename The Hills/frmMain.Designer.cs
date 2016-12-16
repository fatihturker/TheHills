namespace The_Hills
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtYoutubeID = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWatchCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTorLink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtYoutubeID
            // 
            this.txtYoutubeID.Location = new System.Drawing.Point(86, 51);
            this.txtYoutubeID.Name = "txtYoutubeID";
            this.txtYoutubeID.Size = new System.Drawing.Size(175, 23);
            this.txtYoutubeID.TabIndex = 0;
            this.txtYoutubeID.Text = "a2iVF1xSwuE";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRun.Location = new System.Drawing.Point(267, 20);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(68, 25);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Youtube ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Watch:";
            // 
            // lblWatchCount
            // 
            this.lblWatchCount.AutoSize = true;
            this.lblWatchCount.Location = new System.Drawing.Point(83, 84);
            this.lblWatchCount.Name = "lblWatchCount";
            this.lblWatchCount.Size = new System.Drawing.Size(14, 15);
            this.lblWatchCount.TabIndex = 4;
            this.lblWatchCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tor Link:";
            // 
            // txtTorLink
            // 
            this.txtTorLink.Location = new System.Drawing.Point(86, 21);
            this.txtTorLink.Name = "txtTorLink";
            this.txtTorLink.Size = new System.Drawing.Size(175, 23);
            this.txtTorLink.TabIndex = 6;
            this.txtTorLink.Text = "C:\\Users\\Fatih Türker\\Desktop\\Tor Browser\\Browser\\firefox.exe";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 114);
            this.Controls.Add(this.txtTorLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWatchCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtYoutubeID);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "The Hills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYoutubeID;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWatchCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTorLink;
    }
}

