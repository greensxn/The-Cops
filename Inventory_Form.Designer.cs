namespace ThisIsThePolice_Test {
    partial class Inventory_Form {
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
            this.lbName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSubName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("AlphaSmart 3000", 33.75F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(709, 48);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "INVENTORY NAME";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(709, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "НАЗАД";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Back_Click);
            // 
            // pnItems
            // 
            this.pnItems.AutoScroll = true;
            this.pnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnItems.Location = new System.Drawing.Point(0, 94);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(735, 519);
            this.pnItems.TabIndex = 4;
            this.pnItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnItems_MouseClick);
            // 
            // lbSubName
            // 
            this.lbSubName.BackColor = System.Drawing.Color.Transparent;
            this.lbSubName.Font = new System.Drawing.Font("AlphaSmart 3000", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbSubName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbSubName.Location = new System.Drawing.Point(0, 51);
            this.lbSubName.Name = "lbSubName";
            this.lbSubName.Size = new System.Drawing.Size(705, 25);
            this.lbSubName.TabIndex = 1;
            this.lbSubName.Text = "INVENTORY SUB NAME";
            this.lbSubName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Inventory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 675);
            this.ControlBox = false;
            this.Controls.Add(this.pnItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSubName);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_Form";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Inventory_Form_Load);
            this.Shown += new System.EventHandler(this.Inventory_Form_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel pnItems;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSubName;
    }
}