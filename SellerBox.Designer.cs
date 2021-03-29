namespace ThisIsThePolice_Test {
    partial class SellerBox {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.pnBuy = new System.Windows.Forms.Panel();
            this.lbBuy = new System.Windows.Forms.Label();
            this.pnCell = new System.Windows.Forms.Panel();
            this.lbSale = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.lbCancel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnBuy.SuspendLayout();
            this.pnCell.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(700, 135);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(154, 62);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(181, 37);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "МУСТАФА";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(164, 107);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(70, 25);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "БЛЭК";
            // 
            // pnBuy
            // 
            this.pnBuy.BackColor = System.Drawing.Color.Gold;
            this.pnBuy.Controls.Add(this.lbBuy);
            this.pnBuy.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnBuy.Location = new System.Drawing.Point(-350, 0);
            this.pnBuy.Name = "pnBuy";
            this.pnBuy.Size = new System.Drawing.Size(350, 135);
            this.pnBuy.TabIndex = 2;
            this.pnBuy.Visible = false;
            // 
            // lbBuy
            // 
            this.lbBuy.BackColor = System.Drawing.Color.Gold;
            this.lbBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBuy.Font = new System.Drawing.Font("AlphaSmart 3000", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbBuy.Location = new System.Drawing.Point(0, 0);
            this.lbBuy.Name = "lbBuy";
            this.lbBuy.Size = new System.Drawing.Size(350, 135);
            this.lbBuy.TabIndex = 3;
            this.lbBuy.Text = "КУПИТЬ";
            this.lbBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBuy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buy_MouseClick);
            this.lbBuy.MouseEnter += new System.EventHandler(this.OnAnswerMouseEnter);
            this.lbBuy.MouseLeave += new System.EventHandler(this.OnAnswerMouseLeave);
            // 
            // pnCell
            // 
            this.pnCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnCell.Controls.Add(this.lbSale);
            this.pnCell.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnCell.Location = new System.Drawing.Point(700, 0);
            this.pnCell.Name = "pnCell";
            this.pnCell.Size = new System.Drawing.Size(350, 135);
            this.pnCell.TabIndex = 2;
            this.pnCell.Visible = false;
            // 
            // lbSale
            // 
            this.lbSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSale.Font = new System.Drawing.Font("AlphaSmart 3000", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbSale.ForeColor = System.Drawing.Color.DarkGray;
            this.lbSale.Location = new System.Drawing.Point(0, 0);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(350, 135);
            this.lbSale.TabIndex = 0;
            this.lbSale.Text = "ПРОДАТЬ";
            this.lbSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sale_MouseClick);
            this.lbSale.MouseEnter += new System.EventHandler(this.OnAnswerMouseEnter);
            this.lbSale.MouseLeave += new System.EventHandler(this.OnAnswerMouseLeave);
            // 
            // pnCancel
            // 
            this.pnCancel.BackColor = System.Drawing.Color.Brown;
            this.pnCancel.Controls.Add(this.lbCancel);
            this.pnCancel.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnCancel.Location = new System.Drawing.Point(0, 135);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(700, 24);
            this.pnCancel.TabIndex = 0;
            this.pnCancel.Visible = false;
            // 
            // lbCancel
            // 
            this.lbCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCancel.Font = new System.Drawing.Font("AlphaSmart 3000", 12F);
            this.lbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbCancel.Location = new System.Drawing.Point(0, 0);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(700, 24);
            this.lbCancel.TabIndex = 0;
            this.lbCancel.Text = "ОТМЕНА";
            this.lbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnCancelMouseClick);
            this.lbCancel.MouseEnter += new System.EventHandler(this.OnCancelMouseEnter);
            this.lbCancel.MouseLeave += new System.EventHandler(this.OnCancelMouseLeave);
            // 
            // SellerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.pnCell);
            this.Controls.Add(this.pnBuy);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.pbImage);
            this.Name = "SellerBox";
            this.Size = new System.Drawing.Size(700, 135);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnBuy.ResumeLayout(false);
            this.pnCell.ResumeLayout(false);
            this.pnCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbSale;
        private System.Windows.Forms.Label lbBuy;
        private System.Windows.Forms.Label lbCancel;
        public System.Windows.Forms.PictureBox pbImage;
        public System.Windows.Forms.Panel pnBuy;
        public System.Windows.Forms.Panel pnCell;
        public System.Windows.Forms.Panel pnCancel;
    }
}
