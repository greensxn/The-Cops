using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ThisIsThePolice_Test.Properties;

namespace ThisIsThePolice_Test {
    public partial class Report_Form : Form {

        private Form1 MainForm;
        private Animation.Mission_Anim animMission;
        private Animation.Form_Anim animForm;
        private GameMission gameMission;

        public Report_Form(Animation.Mission_Anim animMission, Form1 MainForm, GameMission gameMission) {
            this.MainForm = MainForm;
            this.animMission = animMission;
            this.gameMission = gameMission;
            animForm = new Animation.Form_Anim();
            InitializeComponent();
            SetValue();
        }

        private void SetValue() {
            Color color;
            Color colorTransparent;
            if (gameMission.Type != GameMission.MissionType.Personal) {
                color = (gameMission.IsComplete && gameMission.IsDriveToMisssion || !gameMission.IsTrueCall) ? Color.FromArgb(19, 46, 37) : Color.FromArgb(165, 42, 42);
                colorTransparent = (gameMission.IsComplete && gameMission.IsDriveToMisssion || !gameMission.IsTrueCall) ? Color.FromArgb(180, 19, 46, 37) : Color.FromArgb(180, 165, 42, 42);
            }
            else {
                color = gameMission.Type.GetColor_MT();
                colorTransparent = Color.FromArgb(180, gameMission.Type.GetColor_MT());
            }

            pnName.BackColor = color;
            pnStatus.BackColor = colorTransparent;
            btClose.BackColor = color;

            if (gameMission.IsDriveToMisssion && gameMission.IsTrueCall) {
                if (gameMission.Complications == null || gameMission.ItemsNeed != null) {
                    if (gameMission.IsComplete) {
                        lbResult.Text = gameMission.Report.CompleteResult;
                        lbDescription.Text = gameMission.Report.AcceptedDescription;
                    }
                    else {
                        lbResult.Text = gameMission.Report.NotCompleteResult;
                        lbDescription.Text = gameMission.Report.NotAcceptedDescription;
                    }
                }
                else {
                    String[] Result = gameMission.Report.CompleteResult.Split('-');
                    String[] Descr = gameMission.Report.Answer[gameMission.Answer[gameMission.Answer.Count - 1]].Split(';');
                    if (gameMission.Complications.Addition != null)
                        Result = Result[gameMission.Answer[gameMission.Answer.Count - ((gameMission.Answer.Count > 1) ? 2 : 1)]].Split(';');

                    lbResult.Text = Result[gameMission.Answer[gameMission.Answer.Count - 1]];
                    lbDescription.Text = Descr[(gameMission.Complications.Addition == null) ? 0 : gameMission.Answer[gameMission.Answer.Count - ((gameMission.Answer.Count > 1) ? 2 : 1)]];
                }
            }
            else {
                lbResult.Text = gameMission.Report.NotCompleteResult;
                lbDescription.Text = gameMission.Report.NotAcceptedDescription;
            }
            lbName.Text = $"{gameMission.Place.Name.ToUpper()} - {gameMission.Name.ToUpper()}";
            pnPicture.BackgroundImage = (gameMission.Report.Picture) ?? ((gameMission.IsTrueCall) ? (gameMission.IsComplete) ? Resources.Pic_CriminalCatch : Resources.Pic_CriminalEscaped : Resources.Pic_FalseCall);
        }

        private void Button1_Click(object sender, EventArgs e) {
            HideForm(true);
            animMission.NotifyDelete(animMission.NotifyReport, false);
        }

        private void NotAcceptedMission_Form_Load(object sender, EventArgs e) => HideForm(false);

        private async void NotAcceptedMission_Form_Shown(object sender, EventArgs e) => await animForm.OtherForm(this, false, true);

        private async void HideForm(bool isClose) {
            if (isClose) {
                ((Darken_Form)Tag).HideDarken(true);
                await animForm.OtherForm(this, true, false);
                Close();
                DataTransfer.GamePause = false;
            }
            else
                for (int i = 40; i >= 0; i--)
                    Location = new Point(Location.X + i + (i / 2) + (i / 2) + (1 / 2) + (1 / 2) + (i / 4), Location.Y);
        }
    }
}
