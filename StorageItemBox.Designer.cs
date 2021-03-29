namespace ThisIsThePolice_Test {
    partial class StorageItemBox {
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
            this.pnDock = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pnCountItem = new System.Windows.Forms.Panel();
            this.lbCountItem = new System.Windows.Forms.Label();
            this.pnBackImage = new System.Windows.Forms.Panel();
            this.pnWrongType = new System.Windows.Forms.Panel();
            this.pnColor1 = new System.Windows.Forms.Panel();
            this.pnColor2 = new System.Windows.Forms.Panel();
            this.pnColor3 = new System.Windows.Forms.Panel();
            this.pnColor4 = new System.Windows.Forms.Panel();
            this.pnSure = new System.Windows.Forms.Panel();
            this.lbSure = new System.Windows.Forms.Label();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.lbAnswerYes = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.lbAnswerNo = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pnDock.SuspendLayout();
            this.pnCountItem.SuspendLayout();
            this.pnBackImage.SuspendLayout();
            this.pnSure.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDock
            // 
            this.pnDock.BackColor = System.Drawing.Color.SeaGreen;
            this.pnDock.Controls.Add(this.lbPrice);
            this.pnDock.Controls.Add(this.lbName);
            this.pnDock.Location = new System.Drawing.Point(0, 106);
            this.pnDock.Name = "pnDock";
            this.pnDock.Size = new System.Drawing.Size(350, 48);
            this.pnDock.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("AlphaSmart 3000", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(226, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(106, 49);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "$450";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(17, -2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(209, 50);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Лекарства";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnCountItem
            // 
            this.pnCountItem.BackColor = System.Drawing.Color.SeaGreen;
            this.pnCountItem.Controls.Add(this.lbCountItem);
            this.pnCountItem.Location = new System.Drawing.Point(318, 0);
            this.pnCountItem.Name = "pnCountItem";
            this.pnCountItem.Size = new System.Drawing.Size(32, 32);
            this.pnCountItem.TabIndex = 1;
            // 
            // lbCountItem
            // 
            this.lbCountItem.BackColor = System.Drawing.Color.Transparent;
            this.lbCountItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCountItem.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.lbCountItem.ForeColor = System.Drawing.Color.White;
            this.lbCountItem.Location = new System.Drawing.Point(0, 0);
            this.lbCountItem.Name = "lbCountItem";
            this.lbCountItem.Size = new System.Drawing.Size(32, 32);
            this.lbCountItem.TabIndex = 0;
            this.lbCountItem.Text = "5";
            this.lbCountItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBackImage
            // 
            this.pnBackImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnBackImage.Controls.Add(this.pnWrongType);
            this.pnBackImage.Controls.Add(this.pnColor1);
            this.pnBackImage.Controls.Add(this.pnColor2);
            this.pnBackImage.Controls.Add(this.pnColor3);
            this.pnBackImage.Controls.Add(this.pnColor4);
            this.pnBackImage.Controls.Add(this.pnSure);
            this.pnBackImage.Controls.Add(this.pnLeft);
            this.pnBackImage.Controls.Add(this.pnRight);
            this.pnBackImage.Controls.Add(this.pbImage);
            this.pnBackImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackImage.Location = new System.Drawing.Point(0, 0);
            this.pnBackImage.Name = "pnBackImage";
            this.pnBackImage.Size = new System.Drawing.Size(350, 154);
            this.pnBackImage.TabIndex = 2;
            // 
            // pnWrongType
            // 
            this.pnWrongType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnWrongType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnWrongType.Location = new System.Drawing.Point(0, -107);
            this.pnWrongType.Name = "pnWrongType";
            this.pnWrongType.Size = new System.Drawing.Size(350, 107);
            this.pnWrongType.TabIndex = 5;
            this.pnWrongType.Visible = false;
            // 
            // pnColor1
            // 
            this.pnColor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnColor1.BackColor = System.Drawing.Color.Gold;
            this.pnColor1.Location = new System.Drawing.Point(5, 5);
            this.pnColor1.Name = "pnColor1";
            this.pnColor1.Size = new System.Drawing.Size(25, 25);
            this.pnColor1.TabIndex = 3;
            this.pnColor1.Visible = false;
            this.pnColor1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor2_MouseClick);
            // 
            // pnColor2
            // 
            this.pnColor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnColor2.BackColor = System.Drawing.Color.Brown;
            this.pnColor2.Location = new System.Drawing.Point(36, 5);
            this.pnColor2.Name = "pnColor2";
            this.pnColor2.Size = new System.Drawing.Size(25, 25);
            this.pnColor2.TabIndex = 3;
            this.pnColor2.Visible = false;
            this.pnColor2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor2_MouseClick);
            // 
            // pnColor3
            // 
            this.pnColor3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnColor3.BackColor = System.Drawing.Color.Violet;
            this.pnColor3.Location = new System.Drawing.Point(5, 36);
            this.pnColor3.Name = "pnColor3";
            this.pnColor3.Size = new System.Drawing.Size(25, 25);
            this.pnColor3.TabIndex = 3;
            this.pnColor3.Visible = false;
            this.pnColor3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor2_MouseClick);
            // 
            // pnColor4
            // 
            this.pnColor4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnColor4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnColor4.Location = new System.Drawing.Point(36, 36);
            this.pnColor4.Name = "pnColor4";
            this.pnColor4.Size = new System.Drawing.Size(25, 25);
            this.pnColor4.TabIndex = 3;
            this.pnColor4.Visible = false;
            this.pnColor4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnColor2_MouseClick);
            // 
            // pnSure
            // 
            this.pnSure.Controls.Add(this.lbSure);
            this.pnSure.Location = new System.Drawing.Point(0, -32);
            this.pnSure.Name = "pnSure";
            this.pnSure.Size = new System.Drawing.Size(350, 32);
            this.pnSure.TabIndex = 1;
            this.pnSure.Visible = false;
            // 
            // lbSure
            // 
            this.lbSure.BackColor = System.Drawing.Color.White;
            this.lbSure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSure.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.lbSure.ForeColor = System.Drawing.Color.Black;
            this.lbSure.Location = new System.Drawing.Point(0, 0);
            this.lbSure.Name = "lbSure";
            this.lbSure.Size = new System.Drawing.Size(350, 32);
            this.lbSure.TabIndex = 0;
            this.lbSure.Text = "ВЫ УВЕРЕНЫ?";
            this.lbSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Goldenrod;
            this.pnLeft.Controls.Add(this.lbAnswerYes);
            this.pnLeft.Location = new System.Drawing.Point(-175, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(175, 154);
            this.pnLeft.TabIndex = 1;
            this.pnLeft.Visible = false;
            // 
            // lbAnswerYes
            // 
            this.lbAnswerYes.BackColor = System.Drawing.Color.Gold;
            this.lbAnswerYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAnswerYes.Font = new System.Drawing.Font("AlphaSmart 3000", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbAnswerYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbAnswerYes.Location = new System.Drawing.Point(0, 0);
            this.lbAnswerYes.Name = "lbAnswerYes";
            this.lbAnswerYes.Size = new System.Drawing.Size(175, 154);
            this.lbAnswerYes.TabIndex = 0;
            this.lbAnswerYes.Text = "ДА";
            this.lbAnswerYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAnswerYes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerYes_MouseClick);
            this.lbAnswerYes.MouseEnter += new System.EventHandler(this.OnAnswerMouseEnter);
            this.lbAnswerYes.MouseLeave += new System.EventHandler(this.OnAnswerMouseLeave);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnRight.Controls.Add(this.lbAnswerNo);
            this.pnRight.Location = new System.Drawing.Point(350, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(175, 154);
            this.pnRight.TabIndex = 1;
            this.pnRight.Visible = false;
            // 
            // lbAnswerNo
            // 
            this.lbAnswerNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAnswerNo.Font = new System.Drawing.Font("AlphaSmart 3000", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbAnswerNo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbAnswerNo.Location = new System.Drawing.Point(0, 0);
            this.lbAnswerNo.Name = "lbAnswerNo";
            this.lbAnswerNo.Size = new System.Drawing.Size(175, 154);
            this.lbAnswerNo.TabIndex = 0;
            this.lbAnswerNo.Text = "НЕТ";
            this.lbAnswerNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAnswerNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerNo_MouseClick);
            this.lbAnswerNo.MouseEnter += new System.EventHandler(this.OnAnswerMouseEnter);
            this.lbAnswerNo.MouseLeave += new System.EventHandler(this.OnAnswerMouseLeave);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::ThisIsThePolice_Test.Properties.Resources.Storage_Pills;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(350, 154);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // StorageItemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnCountItem);
            this.Controls.Add(this.pnDock);
            this.Controls.Add(this.pnBackImage);
            this.Name = "StorageItemBox";
            this.Size = new System.Drawing.Size(350, 154);
            this.pnDock.ResumeLayout(false);
            this.pnCountItem.ResumeLayout(false);
            this.pnBackImage.ResumeLayout(false);
            this.pnSure.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbCountItem;
        private System.Windows.Forms.Panel pnBackImage;
        public System.Windows.Forms.PictureBox pbImage;
        public System.Windows.Forms.Panel pnDock;
        public System.Windows.Forms.Panel pnCountItem;
        public System.Windows.Forms.Panel pnRight;
        public System.Windows.Forms.Panel pnLeft;
        public System.Windows.Forms.Label lbAnswerYes;
        public System.Windows.Forms.Label lbAnswerNo;
        private System.Windows.Forms.Label lbSure;
        public System.Windows.Forms.Panel pnSure;
        private System.Windows.Forms.Panel pnWrongType;
        public System.Windows.Forms.Panel pnColor1;
        public System.Windows.Forms.Panel pnColor2;
        public System.Windows.Forms.Panel pnColor3;
        public System.Windows.Forms.Panel pnColor4;
    }
}
