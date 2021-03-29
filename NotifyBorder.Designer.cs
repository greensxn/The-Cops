namespace ThisIsThePolice_Test {
    partial class NotifyBorder {
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
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPlace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbTimer.Font = new System.Drawing.Font("AlphaSmart 3000", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(175, 10);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(45, 28);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.Text = "0:00";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbName
            // 
            this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("AlphaSmart 3000", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(5, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(166, 54);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Вид преступности";
            // 
            // lbPlace
            // 
            this.lbPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlace.BackColor = System.Drawing.Color.Transparent;
            this.lbPlace.Font = new System.Drawing.Font("AlphaSmart 3000", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbPlace.ForeColor = System.Drawing.Color.White;
            this.lbPlace.Location = new System.Drawing.Point(3, 69);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPlace.Size = new System.Drawing.Size(215, 39);
            this.lbPlace.TabIndex = 2;
            this.lbPlace.Text = "Место";
            this.lbPlace.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // NotifyBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::ThisIsThePolice_Test.Properties.Resources.Notify_City;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbPlace);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(241, 111);
            this.MinimumSize = new System.Drawing.Size(225, 111);
            this.Name = "NotifyBorder";
            this.Size = new System.Drawing.Size(225, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPlace;
    }
}
