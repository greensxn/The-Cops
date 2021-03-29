namespace ThisIsThePolice_Test {
    partial class Form1 {
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAddCops = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnStorage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbGameTime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSound = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnReport = new System.Windows.Forms.Panel();
            this.lbReport = new System.Windows.Forms.Label();
            this.pnCall = new System.Windows.Forms.Panel();
            this.lbCall = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnStatus.SuspendLayout();
            this.pnReport.SuspendLayout();
            this.pnCall.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.lbAddCops);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 267);
            this.panel1.TabIndex = 0;
            // 
            // lbAddCops
            // 
            this.lbAddCops.AutoSize = true;
            this.lbAddCops.Font = new System.Drawing.Font("AlphaSmart 3000", 21.75F);
            this.lbAddCops.ForeColor = System.Drawing.Color.Gray;
            this.lbAddCops.Location = new System.Drawing.Point(25, 22);
            this.lbAddCops.Name = "lbAddCops";
            this.lbAddCops.Size = new System.Drawing.Size(235, 32);
            this.lbAddCops.TabIndex = 2;
            this.lbAddCops.Text = "Выбрать копов";
            this.lbAddCops.Click += new System.EventHandler(this.CopsAdd_Click);
            this.lbAddCops.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            this.lbAddCops.MouseLeave += new System.EventHandler(this.LbAddCops_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = " СООБЩЕНИЯ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameTime
            // 
            this.GameTime.Interval = 80;
            this.GameTime.Tick += new System.EventHandler(this.GameTimer);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pnStorage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pnStatus);
            this.panel2.Controls.Add(this.pnReport);
            this.panel2.Controls.Add(this.pnCall);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 515);
            this.panel2.TabIndex = 4;
            this.panel2.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            // 
            // pnStorage
            // 
            this.pnStorage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.pnStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnStorage.BackgroundImage")));
            this.pnStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnStorage.Location = new System.Drawing.Point(559, 0);
            this.pnStorage.Name = "pnStorage";
            this.pnStorage.Size = new System.Drawing.Size(95, 60);
            this.pnStorage.TabIndex = 13;
            this.pnStorage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnStorage_MouseClick);
            this.pnStorage.MouseEnter += new System.EventHandler(this.Storage_MouseEnter);
            this.pnStorage.MouseLeave += new System.EventHandler(this.Storage_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Google Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(1060, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "t.me/CMETAHKA";
            // 
            // pnStatus
            // 
            this.pnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnStatus.Controls.Add(this.lbDate);
            this.pnStatus.Controls.Add(this.lbMoney);
            this.pnStatus.Controls.Add(this.lbGameTime);
            this.pnStatus.Controls.Add(this.button2);
            this.pnStatus.Controls.Add(this.lbSound);
            this.pnStatus.Controls.Add(this.button1);
            this.pnStatus.Location = new System.Drawing.Point(0, 0);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(1197, 37);
            this.pnStatus.TabIndex = 7;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("AlphaSmart 3000", 18F, System.Drawing.FontStyle.Bold);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(25, 5);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(147, 27);
            this.lbDate.TabIndex = 13;
            this.lbDate.Text = "30 Ноября";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbMoney.Font = new System.Drawing.Font("AlphaSmart 3000", 18F, System.Drawing.FontStyle.Bold);
            this.lbMoney.ForeColor = System.Drawing.Color.Gold;
            this.lbMoney.Location = new System.Drawing.Point(313, 5);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(132, 27);
            this.lbMoney.TabIndex = 13;
            this.lbMoney.Text = "$1000000";
            // 
            // lbGameTime
            // 
            this.lbGameTime.AutoSize = true;
            this.lbGameTime.BackColor = System.Drawing.Color.Transparent;
            this.lbGameTime.Font = new System.Drawing.Font("AlphaSmart 3000", 18F, System.Drawing.FontStyle.Bold);
            this.lbGameTime.ForeColor = System.Drawing.Color.White;
            this.lbGameTime.Location = new System.Drawing.Point(197, 5);
            this.lbGameTime.Name = "lbGameTime";
            this.lbGameTime.Size = new System.Drawing.Size(87, 27);
            this.lbGameTime.TabIndex = 13;
            this.lbGameTime.Text = "09:00";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1129, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 37);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSound
            // 
            this.lbSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbSound.FlatAppearance.BorderSize = 0;
            this.lbSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSound.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.lbSound.ForeColor = System.Drawing.Color.White;
            this.lbSound.Location = new System.Drawing.Point(814, 0);
            this.lbSound.Name = "lbSound";
            this.lbSound.Size = new System.Drawing.Size(191, 37);
            this.lbSound.TabIndex = 11;
            this.lbSound.TabStop = false;
            this.lbSound.Text = "SOUND: MUTE";
            this.lbSound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSound.UseVisualStyleBackColor = false;
            this.lbSound.Click += new System.EventHandler(this.Sound_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("AlphaSmart 3000", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1011, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "PAUSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Pause_Click);
            // 
            // pnReport
            // 
            this.pnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnReport.Controls.Add(this.lbReport);
            this.pnReport.Location = new System.Drawing.Point(955, 78);
            this.pnReport.Name = "pnReport";
            this.pnReport.Size = new System.Drawing.Size(242, 37);
            this.pnReport.TabIndex = 4;
            // 
            // lbReport
            // 
            this.lbReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbReport.Font = new System.Drawing.Font("AlphaSmart 3000", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbReport.ForeColor = System.Drawing.Color.White;
            this.lbReport.Location = new System.Drawing.Point(0, 0);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(242, 37);
            this.lbReport.TabIndex = 0;
            this.lbReport.Text = " СООБЩЕНИЯ";
            this.lbReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnCall
            // 
            this.pnCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnCall.Controls.Add(this.lbCall);
            this.pnCall.Location = new System.Drawing.Point(0, 78);
            this.pnCall.Name = "pnCall";
            this.pnCall.Size = new System.Drawing.Size(242, 37);
            this.pnCall.TabIndex = 4;
            // 
            // lbCall
            // 
            this.lbCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCall.Font = new System.Drawing.Font("AlphaSmart 3000", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbCall.ForeColor = System.Drawing.Color.White;
            this.lbCall.Location = new System.Drawing.Point(0, 0);
            this.lbCall.Name = "lbCall";
            this.lbCall.Size = new System.Drawing.Size(242, 37);
            this.lbCall.TabIndex = 0;
            this.lbCall.Text = "ВЫЗОВЫ ";
            this.lbCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1197, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnStatus.ResumeLayout(false);
            this.pnStatus.PerformLayout();
            this.pnReport.ResumeLayout(false);
            this.pnCall.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnCall;
        private System.Windows.Forms.Label lbCall;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnReport;
        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbGameTime;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Panel pnStorage;
        public System.Windows.Forms.Timer GameTime;
        public System.Windows.Forms.Label lbAddCops;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button lbSound;
    }
}

