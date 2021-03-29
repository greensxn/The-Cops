namespace ThisIsThePolice_Test {
    partial class Storage_Form {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage_Form));
            this.btClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbStorage = new System.Windows.Forms.Label();
            this.pbStorage = new System.Windows.Forms.PictureBox();
            this.sellerBox2 = new ThisIsThePolice_Test.SellerBox();
            this.sellerBox1 = new ThisIsThePolice_Test.SellerBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F);
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(14, 284);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(926, 40);
            this.btClose.TabIndex = 3;
            this.btClose.TabStop = false;
            this.btClose.Text = "ЗАКРЫТЬ";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbStorage);
            this.panel2.Controls.Add(this.pbStorage);
            this.panel2.Location = new System.Drawing.Point(14, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 274);
            this.panel2.TabIndex = 0;
            // 
            // lbStorage
            // 
            this.lbStorage.AutoEllipsis = true;
            this.lbStorage.AutoSize = true;
            this.lbStorage.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbStorage.Font = new System.Drawing.Font("AlphaSmart 3000", 22F, System.Drawing.FontStyle.Bold);
            this.lbStorage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbStorage.Location = new System.Drawing.Point(99, 230);
            this.lbStorage.Name = "lbStorage";
            this.lbStorage.Size = new System.Drawing.Size(111, 33);
            this.lbStorage.TabIndex = 6;
            this.lbStorage.Text = "СКЛАД";
            this.lbStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbStorage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Storage_MouseClick);
            this.lbStorage.MouseEnter += new System.EventHandler(this.Storage_MouseEnter);
            this.lbStorage.MouseLeave += new System.EventHandler(this.Storage_MouseLeave);
            // 
            // pbStorage
            // 
            this.pbStorage.ErrorImage = null;
            this.pbStorage.Image = ((System.Drawing.Image)(resources.GetObject("pbStorage.Image")));
            this.pbStorage.Location = new System.Drawing.Point(0, 0);
            this.pbStorage.Name = "pbStorage";
            this.pbStorage.Size = new System.Drawing.Size(222, 274);
            this.pbStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStorage.TabIndex = 0;
            this.pbStorage.TabStop = false;
            this.pbStorage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Storage_MouseClick);
            this.pbStorage.MouseEnter += new System.EventHandler(this.Storage_MouseEnter);
            this.pbStorage.MouseLeave += new System.EventHandler(this.Storage_MouseLeave);
            // 
            // sellerBox2
            // 
            this.sellerBox2.Items = null;
            this.sellerBox2.Location = new System.Drawing.Point(240, 146);
            this.sellerBox2.Name = "sellerBox2";
            this.sellerBox2.SellerFirstName = "СУНЛИНЬ";
            this.sellerBox2.SellerFNFont = new System.Drawing.Font("AlphaSmart 3000", 15.75F, System.Drawing.FontStyle.Bold);
            this.sellerBox2.SellerFNLocationX = 165;
            this.sellerBox2.SellerLastName = "ЧЭН";
            this.sellerBox2.SellerLNFont = new System.Drawing.Font("AlphaSmart 3000", 30F, System.Drawing.FontStyle.Bold);
            this.sellerBox2.SellerLNLocationX = 172;
            this.sellerBox2.SellerPicture = ((System.Drawing.Image)(resources.GetObject("sellerBox2.SellerPicture")));
            this.sellerBox2.Size = new System.Drawing.Size(700, 135);
            this.sellerBox2.TabIndex = 4;
            this.sellerBox2.Type = ThisIsThePolice_Test.StorageItem.ItemType.Legal;
            this.sellerBox2.IsSellerMouseClick += new System.EventHandler(this.Seller_MouseClick);
            this.sellerBox2.IsSellerMouseEnter += new System.EventHandler(this.Seller_MouseEnter);
            this.sellerBox2.IsSellerMouseLeave += new System.EventHandler(this.Seller_MouseLeave);
            this.sellerBox2.IsAnswerMouseClick += new System.EventHandler<bool>(this.Answer_MouseClick);
            this.sellerBox2.IsAnswerMouseEnter += new System.EventHandler(this.Answer_MouseEnter);
            this.sellerBox2.IsAnswerMouseLeave += new System.EventHandler(this.Answer_MouseLeave);
            this.sellerBox2.IsCancelMouseClick += new System.EventHandler(this.Cancel_MouseClick);
            this.sellerBox2.IsCancelMouseEnter += new System.EventHandler(this.Cancel_MouseEnter);
            this.sellerBox2.IsCancelMouseLeave += new System.EventHandler(this.Cancel_MouseLeave);
            // 
            // sellerBox1
            // 
            this.sellerBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sellerBox1.Items = null;
            this.sellerBox1.Location = new System.Drawing.Point(240, 8);
            this.sellerBox1.Name = "sellerBox1";
            this.sellerBox1.SellerFirstName = "МУСТАФА";
            this.sellerBox1.SellerFNFont = new System.Drawing.Font("AlphaSmart 3000", 15.75F, System.Drawing.FontStyle.Bold);
            this.sellerBox1.SellerFNLocationX = 225;
            this.sellerBox1.SellerLastName = "БЛЭК";
            this.sellerBox1.SellerLNFont = new System.Drawing.Font("AlphaSmart 3000", 30F, System.Drawing.FontStyle.Bold);
            this.sellerBox1.SellerLNLocationX = 230;
            this.sellerBox1.SellerPicture = ((System.Drawing.Image)(resources.GetObject("sellerBox1.SellerPicture")));
            this.sellerBox1.Size = new System.Drawing.Size(700, 135);
            this.sellerBox1.TabIndex = 4;
            this.sellerBox1.Type = ThisIsThePolice_Test.StorageItem.ItemType.Trash;
            this.sellerBox1.IsSellerMouseClick += new System.EventHandler(this.Seller_MouseClick);
            this.sellerBox1.IsSellerMouseEnter += new System.EventHandler(this.Seller_MouseEnter);
            this.sellerBox1.IsSellerMouseLeave += new System.EventHandler(this.Seller_MouseLeave);
            this.sellerBox1.IsAnswerMouseClick += new System.EventHandler<bool>(this.Answer_MouseClick);
            this.sellerBox1.IsAnswerMouseEnter += new System.EventHandler(this.Answer_MouseEnter);
            this.sellerBox1.IsAnswerMouseLeave += new System.EventHandler(this.Answer_MouseLeave);
            this.sellerBox1.IsCancelMouseClick += new System.EventHandler(this.Cancel_MouseClick);
            this.sellerBox1.IsCancelMouseEnter += new System.EventHandler(this.Cancel_MouseEnter);
            this.sellerBox1.IsCancelMouseLeave += new System.EventHandler(this.Cancel_MouseLeave);
            // 
            // Storage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 538);
            this.Controls.Add(this.sellerBox2);
            this.Controls.Add(this.sellerBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Storage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage_Form";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Storage_Form_Load);
            this.Shown += new System.EventHandler(this.Storage_Form_Shown);
            this.MouseEnter += new System.EventHandler(this.Storage_Form_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Storage_Form_MouseEnter);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbStorage;
        private System.Windows.Forms.PictureBox pbStorage;
        private SellerBox sellerBox1;
        private SellerBox sellerBox2;
    }
}