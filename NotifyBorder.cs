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
    public partial class NotifyBorder : UserControl {

        private bool IsEnter { get; set; } = false;
        public event EventHandler IsMouseEnter;
        public event EventHandler IsMouseLeave;
        public event EventHandler<NotifyArgs> IsMouseClick;

        private GameMission gameMission;
        private Animation.Mission_Anim animMission;


        public NotifyBorder() {
            gameMission = new GameMission();
            animMission = new Animation.Mission_Anim();

            InitializeComponent();

            SetEvent(this);
            animMission = new Animation.Mission_Anim();
        }

        private void SetEvent(Control mainControl) {
            foreach (Control control in mainControl.Controls)
                SetEvent(control);
            mainControl.MouseEnter += OnMouseEnter;
            mainControl.MouseLeave += OnMouseLeave;
            mainControl.MouseClick += OnMouseClickTemp;
        }

        public void OnMouseClick(object sender, NotifyArgs e) {
            IsMouseClick?.Invoke(this, e);
        }

        public GameMission GameMission {
            get {
                return gameMission;
            }
            set {
                gameMission = value;
            }
        }

        public Animation.Mission_Anim Mission {
            get {
                return animMission;
            }
            set {
                animMission = value;
            }
        }

        public String TimerText {
            get {
                return lbTimer.Text;
            }
            set {
                lbTimer.Text = value;
            }
        }

        public String NameText {
            get {
                return lbName.Text;
            }
            set {
                lbName.Text = value;
            }
        }

        public String PlaceText {
            get {
                return lbPlace.Text;
            }
            set {
                lbPlace.Text = value;
            }
        }

        public new Color ForeColor {
            get {
                return lbName.ForeColor;
            }
            set {
                lbName.ForeColor = value;
                lbPlace.ForeColor = value;
                lbTimer.ForeColor = value;
            }
        }

        private GameMission.MissionType MT = GameMission.MissionType.Usual;
        public GameMission.MissionType MissionType {
            get {
                return MT;
            }
            set {
                MT = value;
                IsC = true;
                BackgroundImage = MT.GetNotifyRes();
                BackColor = MT.GetColor_MT();
                lbPlace.ForeColor = BackColor.GetColorLabel_MT();
                lbTimer.ForeColor = BackColor.GetColorLabel_MT();
                lbName.ForeColor = BackColor.GetColorLabel_MT();
            }
        }

        public Color NameColor {
            get {
                return lbName.ForeColor;
            }
            set {
                lbName.ForeColor = value;
            }
        }

        private bool IsC = false;
        public bool IsCall {
            get {
                return IsC;
            }
            set {
                IsC = value;
                lbTimer.Visible = IsC;
                if (!IsC) {
                    BackgroundImage = Properties.Resources.Notify_Message;
                    BackColor = Color.DimGray;
                    lbPlace.ForeColor = Color.Gainsboro;
                    NameColor = Color.White;
                    lbPlace.Text = "ОТЧЕТ";
                }
                else {
                    BackgroundImage = MT.GetNotifyRes();
                    BackColor = MT.GetColor_MT();
                    lbPlace.ForeColor = BackColor.GetColorLabel_MT();
                    lbTimer.ForeColor = BackColor.GetColorLabel_MT();
                    lbName.ForeColor = BackColor.GetColorLabel_MT();
                    lbPlace.Text = "МЕСТО";
                }
            }
        }

        //EVENT ---------------------------------
        private void OnMouseClickTemp(object sender, MouseEventArgs e) {
            OnMouseClick(this, new NotifyArgs(gameMission, animMission));
        }

        public void OnMouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsMouseEnter?.Invoke(this, e);
                IsEnter = true;
            }
        }

        public void OnMouseLeave(object sender, EventArgs e) {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else {
                IsEnter = false;
                IsMouseLeave?.Invoke(this, e);
            }
        }
    }

    public class NotifyArgs {

        public GameMission gameMission;
        public Animation.Mission_Anim animMission;


        public NotifyArgs(GameMission gameMission, Animation.Mission_Anim animMission) {
            this.gameMission = gameMission;
            this.animMission = animMission;
        }
    }
}
