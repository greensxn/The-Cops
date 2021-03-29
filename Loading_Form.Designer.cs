namespace ThisIsThePolice_Test {
    partial class Loading_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLoading = new System.Windows.Forms.Label();
            this.lbLoadingStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1228, 710);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbLoading
            // 
            this.lbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLoading.Font = new System.Drawing.Font("AlphaSmart 3000", 24F, System.Drawing.FontStyle.Bold);
            this.lbLoading.ForeColor = System.Drawing.Color.Gold;
            this.lbLoading.Location = new System.Drawing.Point(930, 627);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(291, 35);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLoading.Visible = false;
            // 
            // lbLoadingStatus
            // 
            this.lbLoadingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoadingStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLoadingStatus.Font = new System.Drawing.Font("AlphaSmart 3000", 13F, System.Drawing.FontStyle.Bold);
            this.lbLoadingStatus.ForeColor = System.Drawing.Color.Gold;
            this.lbLoadingStatus.Location = new System.Drawing.Point(645, 666);
            this.lbLoadingStatus.Name = "lbLoadingStatus";
            this.lbLoadingStatus.Size = new System.Drawing.Size(576, 35);
            this.lbLoadingStatus.TabIndex = 1;
            this.lbLoadingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLoadingStatus.Visible = false;
            // 
            // Loading_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 710);
            this.Controls.Add(this.lbLoadingStatus);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Loading_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.Label lbLoadingStatus;
    }
}