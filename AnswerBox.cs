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
    public partial class AnswerBox : UserControl {

        public new event EventHandler<AnswerArgs> MouseClick;
        public event EventHandler IsMouseEnter;
        public event EventHandler IsMouseLeave;
        public AnswerArgs Cloud;
        private bool IsEnter = false;

        private void SetEvent(Control mainControl) {
            foreach (Control control in mainControl.Controls)
                SetEvent(control);
            mainControl.MouseEnter += OnMouseEnter;
            mainControl.MouseLeave += OnMouseLeave;
            mainControl.MouseClick += MainControl_MouseClick;
        }

        private void MainControl_MouseClick(object sender, MouseEventArgs e) {
            OnMouseClick(this, Cloud);
        }

        public void OnMouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsEnter = true;
                IsMouseEnter?.Invoke(this, e);
            }
        }

        private void OnMouseClick(object sender, AnswerArgs e) {
            MouseClick?.Invoke(this, e);
        }

        protected void OnMouseLeave(object sender, EventArgs e) {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else {
                IsEnter = false;
                IsMouseLeave?.Invoke(this, e);
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

        public new Color ForeColor {
            get {
                return label1.ForeColor;
            }
            set {
                label1.ForeColor = value;
            }
        }

        public new Font Font {
            get {
                return label1.Font;
            }
            set {
                label1.Font = value;
            }
        }

        public String AnswerText {
            get {
                return label1.Text;
            }
            set {
                label1.Text = value;
            }
        }

        public AnswerBox() {
            InitializeComponent();
            SetEvent(this);
            //panel1.MouseClick += Panel1_MouseClick;
            //label1.MouseClick += Panel1_MouseClick;
        }

        //private void Panel1_MouseClick(object sender, MouseEventArgs e) {
        //    OnMouseClick(this, new AnswerArgs(Cloud.Cops, Cloud.gameMission));
        //}
    }

    public class AnswerArgs {

        public List<Cop> Cops;
        public GameMission gameMission;

        public AnswerArgs(List<Cop> cop, GameMission gameMission) {
            this.Cops = cop;
            this.gameMission = gameMission;
        }
    }
}
