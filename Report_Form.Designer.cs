namespace ThisIsThePolice_Test {
    partial class Report_Form {
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
            this.pnName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnDescription = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.pnName.SuspendLayout();
            this.pnDescription.SuspendLayout();
            this.pnPicture.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Location = new System.Drawing.Point(0, 0);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(928, 40);
            this.pnName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("AlphaSmart 3000", 18F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(928, 40);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "NAME";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDescription
            // 
            this.pnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.pnDescription.Controls.Add(this.lbDescription);
            this.pnDescription.Location = new System.Drawing.Point(0, 41);
            this.pnDescription.Name = "pnDescription";
            this.pnDescription.Size = new System.Drawing.Size(928, 126);
            this.pnDescription.TabIndex = 0;
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(34, 2);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(860, 122);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "DESCRIPTION";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(0, 430);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(928, 50);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "ЗАКРЫТЬ";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pnPicture
            // 
            this.pnPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnPicture.BackgroundImage = global::ThisIsThePolice_Test.Properties.Resources.Pic_FalseCall;
            this.pnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPicture.Controls.Add(this.pnStatus);
            this.pnPicture.Location = new System.Drawing.Point(0, 168);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(928, 260);
            this.pnPicture.TabIndex = 0;
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(22)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.pnStatus.Controls.Add(this.lbResult);
            this.pnStatus.Location = new System.Drawing.Point(0, 220);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(928, 40);
            this.pnStatus.TabIndex = 0;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbResult.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Location = new System.Drawing.Point(38, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(890, 40);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "STATUS";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(932, 535);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pnPicture);
            this.Controls.Add(this.pnDescription);
            this.Controls.Add(this.pnName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotAcceptedMission_Form";
            this.TransparencyKey = System.Drawing.Color.CornflowerBlue;
            this.Load += new System.EventHandler(this.NotAcceptedMission_Form_Load);
            this.Shown += new System.EventHandler(this.NotAcceptedMission_Form_Shown);
            this.pnName.ResumeLayout(false);
            this.pnDescription.ResumeLayout(false);
            this.pnPicture.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Panel pnDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbName;
    }
}