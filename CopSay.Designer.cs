namespace ThisIsThePolice_Test {
    partial class CopSay {
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
            this.pnDescription = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbStatusText = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.copBox1 = new ThisIsThePolice_Test.CopBox();
            this.pnDescription.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDescription
            // 
            this.pnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.pnDescription.Controls.Add(this.lbDescription);
            this.pnDescription.Location = new System.Drawing.Point(130, 29);
            this.pnDescription.Name = "pnDescription";
            this.pnDescription.Size = new System.Drawing.Size(324, 126);
            this.pnDescription.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Font = new System.Drawing.Font("AlphaSmart 3000", 12F);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(15, 16);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(297, 100);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "description";
            // 
            // pnStatus
            // 
            this.pnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnStatus.BackColor = System.Drawing.Color.Brown;
            this.pnStatus.Controls.Add(this.lbStatusText);
            this.pnStatus.Location = new System.Drawing.Point(130, 3);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(324, 25);
            this.pnStatus.TabIndex = 1;
            // 
            // lbStatusText
            // 
            this.lbStatusText.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusText.Font = new System.Drawing.Font("AlphaSmart 3000", 14F);
            this.lbStatusText.ForeColor = System.Drawing.Color.White;
            this.lbStatusText.Location = new System.Drawing.Point(3, 0);
            this.lbStatusText.Name = "lbStatusText";
            this.lbStatusText.Size = new System.Drawing.Size(318, 25);
            this.lbStatusText.TabIndex = 0;
            this.lbStatusText.Text = "ГНЕВ";
            this.lbStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Black;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("AlphaSmart 3000", 14F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(130, 156);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(324, 36);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "ЗАКРЫТЬ";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // copBox1
            // 
            this.copBox1.BackColor = System.Drawing.Color.Transparent;
            this.copBox1.BlockCop = true;
            this.copBox1.CopColorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.copBox1.CopDriveColor = System.Drawing.Color.Purple;
            this.copBox1.CopDriveProcent = 0;
            this.copBox1.CopDriveVisible = true;
            this.copBox1.CopEnergyProcent = 0;
            this.copBox1.CopName = "имя";
            this.copBox1.CopNameColor = System.Drawing.Color.White;
            this.copBox1.CopPhoto = null;
            this.copBox1.CopPhotoBackColor = null;
            this.copBox1.CopProfesionalism = "654";
            this.copBox1.IsAlcoholic = false;
            this.copBox1.IsDead = false;
            this.copBox1.IsOld = false;
            this.copBox1.IsWeed = false;
            this.copBox1.Location = new System.Drawing.Point(3, 3);
            this.copBox1.MinimumSize = new System.Drawing.Size(125, 189);
            this.copBox1.Name = "copBox1";
            this.copBox1.Size = new System.Drawing.Size(125, 189);
            this.copBox1.TabIndex = 0;
            // 
            // CopSay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 194);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnDescription);
            this.Controls.Add(this.copBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CopSay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopSay";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.CopSay_Load);
            this.Shown += new System.EventHandler(this.CopSay_Shown);
            this.pnDescription.ResumeLayout(false);
            this.pnStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CopBox copBox1;
        private System.Windows.Forms.Panel pnDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbStatusText;
        private System.Windows.Forms.Button btClose;
    }
}