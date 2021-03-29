namespace ThisIsThePolice_Test {
    partial class Complication_form {
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
            this.pnComplicationName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.Answer3 = new ThisIsThePolice_Test.AnswerBox();
            this.Answer1 = new ThisIsThePolice_Test.AnswerBox();
            this.Answer2 = new ThisIsThePolice_Test.AnswerBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnComplicationName.SuspendLayout();
            this.BackPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnComplicationName
            // 
            this.pnComplicationName.BackColor = System.Drawing.Color.Brown;
            this.pnComplicationName.Controls.Add(this.lbName);
            this.pnComplicationName.Location = new System.Drawing.Point(0, 0);
            this.pnComplicationName.Name = "pnComplicationName";
            this.pnComplicationName.Size = new System.Drawing.Size(928, 40);
            this.pnComplicationName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("AlphaSmart 3000", 18F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(928, 40);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "COMPLICATION NAME";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.Controls.Add(this.panel1);
            this.BackPanel.Controls.Add(this.Answer3);
            this.BackPanel.Controls.Add(this.Answer1);
            this.BackPanel.Controls.Add(this.Answer2);
            this.BackPanel.Controls.Add(this.pbImage);
            this.BackPanel.Location = new System.Drawing.Point(0, 43);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(928, 580);
            this.BackPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.lbDescription);
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 100);
            this.panel1.TabIndex = 7;
            // 
            // lbDescription
            // 
            this.lbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.lbDescription.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(27, 2);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(876, 94);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "DESCRIPTION";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Answer3
            // 
            this.Answer3.AccessibleName = "sda";
            this.Answer3.AnswerText = "ANSWER 3";
            this.Answer3.Location = new System.Drawing.Point(0, 506);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(928, 70);
            this.Answer3.TabIndex = 5;
            // 
            // Answer1
            // 
            this.Answer1.AccessibleName = "sda";
            this.Answer1.AnswerText = "ANSWER 1";
            this.Answer1.Location = new System.Drawing.Point(0, 362);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(928, 70);
            this.Answer1.TabIndex = 4;
            // 
            // Answer2
            // 
            this.Answer2.AccessibleName = "sda";
            this.Answer2.AnswerText = "ANSWER 2";
            this.Answer2.Location = new System.Drawing.Point(0, 434);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(928, 70);
            this.Answer2.TabIndex = 4;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(0, -1);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(928, 260);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // Complication_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(930, 621);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.pnComplicationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Complication_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complications_form";
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            this.Load += new System.EventHandler(this.Complication_form_Load);
            this.Shown += new System.EventHandler(this.Complication_form_Shown);
            this.pnComplicationName.ResumeLayout(false);
            this.BackPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnComplicationName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.PictureBox pbImage;
        private AnswerBox Answer3;
        private AnswerBox Answer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDescription;
        private AnswerBox Answer1;
    }
}