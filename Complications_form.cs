using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class Complication_form : Form {

        private GameMission gameMission;
        private CopMission CopMission;
        private Animation.Mission_Anim Mission;
        private Animation.Form_Anim formAnim;
        private Form mainForm;
        private Color ColorType;

        public Complication_form(GameMission gameMission, Animation.Mission_Anim Mission, CopMission CopMission, Form mainForm) {
            this.gameMission = gameMission;
            this.CopMission = CopMission;
            this.Mission = Mission;
            this.mainForm = mainForm;
            formAnim = new Animation.Form_Anim();
            InitializeComponent();

            SetValue(gameMission.Complications.Description, new string[] { gameMission.Complications.ResponseOptions[0], gameMission.Complications.ResponseOptions[1], gameMission.Complications.ResponseOptions[2] }, gameMission.Complications.Picture);
        }

        public void SetValue(String Description, String[] answers, Image Picture) {
            lbName.Text = $"{gameMission.Place.Name.ToUpper()} - {gameMission.Name.ToUpper()}";
            lbDescription.Text = Description;
            pbImage.Image = Picture;

            ColorType = gameMission.Type.GetColor_MT();

            foreach (AnswerBox answerBox in BackPanel.Controls.OfType<AnswerBox>()) {
                answerBox.AnswerText = answers[int.Parse(answerBox.Name.Remove(0, 6)) - 1];
                answerBox.IsMouseEnter += LbAnswer1_MouseEnter;
                answerBox.IsMouseLeave += LbAnswer1_MouseLeave;
                answerBox.MouseClick += Answer_MouseClick;
                answerBox.BackColor = ColorType;
                answerBox.ForeColor = ColorType.GetColorLabel_MT();
                answerBox.Cloud = new AnswerArgs(CopMission.Cops, gameMission);
            }

            pnComplicationName.BackColor = ColorType;
            lbName.ForeColor = ColorType.GetColorLabel_MT();
        }

        private void LbAnswer1_MouseEnter(object sender, EventArgs e) {
            ((AnswerBox)sender).BackColor = Color.FromArgb(19, 46, 37);
            ((AnswerBox)sender).ForeColor = Color.White;
        }

        private void LbAnswer1_MouseLeave(object sender, EventArgs e) {
            ((AnswerBox)sender).BackColor = ColorType;
            ((AnswerBox)sender).ForeColor = ((AnswerBox)sender).BackColor.GetColorLabel_MT();
        }

        private async void Answer_MouseClick(object sender, AnswerArgs e) {
            foreach (AnswerBox answerBox in BackPanel.Controls.OfType<AnswerBox>()) {
                answerBox.IsMouseEnter -= LbAnswer1_MouseEnter;
                answerBox.IsMouseLeave -= LbAnswer1_MouseLeave;
                answerBox.MouseClick -= Answer_MouseClick;
            }

            e.gameMission.Answer.Add(int.Parse((sender as Control).Name[6].ToString()) - 1);
            int LastAnswer = e.gameMission.Answer[e.gameMission.Answer.Count - 1];

            int Answer = (e.gameMission.Complications.Addition == null) ? 0 : e.gameMission.Answer[e.gameMission.Answer.Count - 1];
            bool isNotFind = e.gameMission.Complications.CorrectAnswerOptions[Answer, 0] == -1 &&
                             e.gameMission.Complications.CorrectAnswerOptions[Answer, 1] == -1 &&
                             e.gameMission.Complications.CorrectAnswerOptions[Answer, 2] == -1;

            if (e.gameMission.Complications.Addition != null && e.gameMission.Complications.Addition.Answer == -1 && !isNotFind) {
                e.gameMission.Complications.Addition.Answer = LastAnswer;
                await formAnim.OtherForm(this, true, false);
                SetValue(e.gameMission.Complications.Addition.Descriptions[LastAnswer],
                    new string[] {
                            e.gameMission.Complications.Addition.ResponseOptions[LastAnswer].Split(';')[0],
                            e.gameMission.Complications.Addition.ResponseOptions[LastAnswer].Split(';')[1],
                            e.gameMission.Complications.Addition.ResponseOptions[LastAnswer].Split(';')[2]
                    },
                    e.gameMission.Complications.Addition.Pictures[LastAnswer]
                );
                await HideForm(false);
                await formAnim.OtherForm(this, true, true);
            }
            else {
                await HideForm(true);

                int[,] CorrectAnswer = DataTransfer.Missions.Where(a => a.Name == e.gameMission.Name).First().Complications.CorrectAnswerOptions;
                if (e.gameMission.IsTrueCall) {

                    Answer = (e.gameMission.Complications.Addition == null) ? 0 : (e.gameMission.Answer.Count > 1) ? e.gameMission.Answer[e.gameMission.Answer.Count - 2] : e.gameMission.Answer[e.gameMission.Answer.Count - 1];
                    bool IsComplete = (e.gameMission.Complications.CorrectAnswerOptions[Answer, 0] == e.gameMission.Answer[e.gameMission.Answer.Count - 1] + 1 ||
                                       e.gameMission.Complications.CorrectAnswerOptions[Answer, 1] == e.gameMission.Answer[e.gameMission.Answer.Count - 1] + 1 ||
                                       e.gameMission.Complications.CorrectAnswerOptions[Answer, 2] == e.gameMission.Answer[e.gameMission.Answer.Count - 1] + 1);

                    e.Cops.ForEach(a => a.AddProfesionalism((IsComplete) ? 10 : -10));
                    e.gameMission.IsComplete = IsComplete;
                }
                else
                    e.gameMission.IsComplete = true;
            }
        }

        private async Task HideForm(bool isClose) {
            if (isClose) {
                ((Darken_Form)Tag).HideDarken(true);
                await formAnim.OtherForm(this, true, false);
                Close();
                DataTransfer.GamePause = false;
            }
            else {
                Location = new Point((mainForm.Size.Width / 2) - (Size.Width / 2) - 1810, Location.Y);
                await Task.Delay(1);
            }
        }

        private async void Complication_form_Shown(object sender, EventArgs e) => await formAnim.OtherForm(this, true, true);

        private async void Complication_form_Load(object sender, EventArgs e) => await HideForm(false);
    }
}
