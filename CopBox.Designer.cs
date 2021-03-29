namespace ThisIsThePolice_Test {
    partial class CopBox {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.pnCopEnergyBack = new System.Windows.Forms.Panel();
            this.pnCopEnergy = new System.Windows.Forms.Panel();
            this.lbCopProfessionalism = new System.Windows.Forms.Label();
            this.lbCopName = new System.Windows.Forms.Label();
            this.pnDrive = new System.Windows.Forms.Panel();
            this.pnDead = new System.Windows.Forms.Panel();
            this.lbDead = new System.Windows.Forms.Label();
            this.pnBadgeAlcohol = new System.Windows.Forms.Panel();
            this.pnBadgeOld = new System.Windows.Forms.Panel();
            this.pnBadgeWeed = new System.Windows.Forms.Panel();
            this.pnCopPicture = new System.Windows.Forms.PictureBox();
            this.pnCopEnergyBack.SuspendLayout();
            this.pnDead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnCopPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCopEnergyBack
            // 
            this.pnCopEnergyBack.BackColor = System.Drawing.Color.White;
            this.pnCopEnergyBack.Controls.Add(this.pnCopEnergy);
            this.pnCopEnergyBack.Location = new System.Drawing.Point(0, 182);
            this.pnCopEnergyBack.Name = "pnCopEnergyBack";
            this.pnCopEnergyBack.Size = new System.Drawing.Size(125, 7);
            this.pnCopEnergyBack.TabIndex = 3;
            // 
            // pnCopEnergy
            // 
            this.pnCopEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.pnCopEnergy.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCopEnergy.Location = new System.Drawing.Point(0, 0);
            this.pnCopEnergy.Name = "pnCopEnergy";
            this.pnCopEnergy.Size = new System.Drawing.Size(93, 7);
            this.pnCopEnergy.TabIndex = 0;
            // 
            // lbCopProfessionalism
            // 
            this.lbCopProfessionalism.BackColor = System.Drawing.Color.White;
            this.lbCopProfessionalism.Font = new System.Drawing.Font("AlphaSmart 3000", 12F);
            this.lbCopProfessionalism.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.lbCopProfessionalism.Location = new System.Drawing.Point(0, 25);
            this.lbCopProfessionalism.Name = "lbCopProfessionalism";
            this.lbCopProfessionalism.Size = new System.Drawing.Size(125, 17);
            this.lbCopProfessionalism.TabIndex = 0;
            this.lbCopProfessionalism.Text = "654";
            this.lbCopProfessionalism.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCopName
            // 
            this.lbCopName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.lbCopName.Font = new System.Drawing.Font("AlphaSmart 3000", 12F, System.Drawing.FontStyle.Bold);
            this.lbCopName.ForeColor = System.Drawing.Color.White;
            this.lbCopName.Location = new System.Drawing.Point(0, 0);
            this.lbCopName.Name = "lbCopName";
            this.lbCopName.Size = new System.Drawing.Size(125, 25);
            this.lbCopName.TabIndex = 0;
            this.lbCopName.Text = "имя";
            this.lbCopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDrive
            // 
            this.pnDrive.BackColor = System.Drawing.Color.Purple;
            this.pnDrive.Location = new System.Drawing.Point(130, 189);
            this.pnDrive.Name = "pnDrive";
            this.pnDrive.Size = new System.Drawing.Size(5, 0);
            this.pnDrive.TabIndex = 4;
            // 
            // pnDead
            // 
            this.pnDead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnDead.Controls.Add(this.lbDead);
            this.pnDead.Location = new System.Drawing.Point(111, 42);
            this.pnDead.Name = "pnDead";
            this.pnDead.Size = new System.Drawing.Size(125, 140);
            this.pnDead.TabIndex = 1;
            this.pnDead.Visible = false;
            // 
            // lbDead
            // 
            this.lbDead.BackColor = System.Drawing.Color.Black;
            this.lbDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbDead.ForeColor = System.Drawing.Color.White;
            this.lbDead.Location = new System.Drawing.Point(0, 116);
            this.lbDead.Name = "lbDead";
            this.lbDead.Size = new System.Drawing.Size(125, 24);
            this.lbDead.TabIndex = 1;
            this.lbDead.Text = "R.I.P";
            this.lbDead.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbDead.Visible = false;
            // 
            // pnBadgeAlcohol
            // 
            this.pnBadgeAlcohol.BackColor = System.Drawing.Color.Transparent;
            this.pnBadgeAlcohol.BackgroundImage = global::ThisIsThePolice_Test.Properties.Resources.Badge_Alcohol;
            this.pnBadgeAlcohol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBadgeAlcohol.Location = new System.Drawing.Point(3, 46);
            this.pnBadgeAlcohol.Name = "pnBadgeAlcohol";
            this.pnBadgeAlcohol.Size = new System.Drawing.Size(22, 22);
            this.pnBadgeAlcohol.TabIndex = 0;
            this.pnBadgeAlcohol.Visible = false;
            // 
            // pnBadgeOld
            // 
            this.pnBadgeOld.BackColor = System.Drawing.Color.Transparent;
            this.pnBadgeOld.BackgroundImage = global::ThisIsThePolice_Test.Properties.Resources.Badge_Old;
            this.pnBadgeOld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBadgeOld.Location = new System.Drawing.Point(3, 70);
            this.pnBadgeOld.Name = "pnBadgeOld";
            this.pnBadgeOld.Size = new System.Drawing.Size(22, 22);
            this.pnBadgeOld.TabIndex = 0;
            this.pnBadgeOld.Visible = false;
            // 
            // pnBadgeWeed
            // 
            this.pnBadgeWeed.BackColor = System.Drawing.Color.Transparent;
            this.pnBadgeWeed.BackgroundImage = global::ThisIsThePolice_Test.Properties.Resources.Badge_Weed;
            this.pnBadgeWeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBadgeWeed.Location = new System.Drawing.Point(3, 94);
            this.pnBadgeWeed.Name = "pnBadgeWeed";
            this.pnBadgeWeed.Size = new System.Drawing.Size(22, 22);
            this.pnBadgeWeed.TabIndex = 0;
            this.pnBadgeWeed.Visible = false;
            // 
            // pnCopPicture
            // 
            this.pnCopPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(9)))), ((int)(((byte)(20)))));
            this.pnCopPicture.Image = global::ThisIsThePolice_Test.Properties.Resources.Elena;
            this.pnCopPicture.Location = new System.Drawing.Point(0, 42);
            this.pnCopPicture.Name = "pnCopPicture";
            this.pnCopPicture.Size = new System.Drawing.Size(125, 140);
            this.pnCopPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnCopPicture.TabIndex = 6;
            this.pnCopPicture.TabStop = false;
            // 
            // CopBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnBadgeAlcohol);
            this.Controls.Add(this.pnBadgeWeed);
            this.Controls.Add(this.pnBadgeOld);
            this.Controls.Add(this.pnDead);
            this.Controls.Add(this.pnCopPicture);
            this.Controls.Add(this.lbCopProfessionalism);
            this.Controls.Add(this.lbCopName);
            this.Controls.Add(this.pnDrive);
            this.Controls.Add(this.pnCopEnergyBack);
            this.MinimumSize = new System.Drawing.Size(125, 189);
            this.Name = "CopBox";
            this.Size = new System.Drawing.Size(125, 189);
            this.pnCopEnergyBack.ResumeLayout(false);
            this.pnDead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnCopPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbCopName;
        private System.Windows.Forms.Label lbCopProfessionalism;
        private System.Windows.Forms.Panel pnCopEnergyBack;
        private System.Windows.Forms.Panel pnCopEnergy;
        private System.Windows.Forms.Panel pnDrive;
        private System.Windows.Forms.Panel pnBadgeAlcohol;
        private System.Windows.Forms.Panel pnBadgeOld;
        private System.Windows.Forms.Panel pnBadgeWeed;
        private System.Windows.Forms.Panel pnDead;
        private System.Windows.Forms.Label lbDead;
        private System.Windows.Forms.PictureBox pnCopPicture;
    }
}
