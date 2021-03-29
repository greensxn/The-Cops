using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class NotifyOnMap : UserControl {

        public event EventHandler IsMouseEnter;
        public event EventHandler IsMouseLeave;
        public event EventHandler<NotifyArgs> IsMouseClick;
        private GameMission gameMission;
        private Animation.Mission_Anim animMission;

        public NotifyOnMap(GameMission gameMission, Animation.Mission_Anim animMission) {
            this.gameMission = gameMission;
            this.animMission = animMission;

            InitializeComponent();

            label1.MouseLeave += Label1_MouseLeave;
            label1.MouseEnter += Label1_MouseEnter;
            label1.MouseClick += Label1_MouseClick;
        }

        private void Label1_MouseLeave(object sender, EventArgs e) {
            IsMouseLeave(this, EventArgs.Empty);
        }

        private void Label1_MouseEnter(object sender, EventArgs e) {
            IsMouseEnter(this, EventArgs.Empty);
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e) {
            IsMouseClick(this, new NotifyArgs(gameMission, animMission));
        }

        public String TimeText {
            get {
                return label1.Text;
            }
            set {
                label1.Text = value;
            }
        }

        public new Color ForeColor {
            get {
                return label1.ForeColor;
            }
            set {
                label1.ForeColor = value;
            }
        }

        public new Color BackColor {
            get {
                return panel1.BackColor;
            }
            set {
                panel1.BackColor = value;
            }
        }
    }
}
