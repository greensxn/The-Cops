using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThisIsThePolice_Test.Properties;

namespace ThisIsThePolice_Test {
    public partial class Form1 : Form {

        private MissionDescription_Form form_Description;
        private Report_Form form_Report;
        private Loading_Form form_Loading;
        private CopChoice_Form form_ChoiceACop;
        private Storage_Form form_Storage;
        private Darken_Form form_Darken;



        private Animation anim;

        public Form1() {
            InitializeComponent();

            anim = new Animation();

            form_Loading = new Loading_Form();
            form_Loading.ShowDialog();

            form_Storage = new Storage_Form();
            form_ChoiceACop = new CopChoice_Form(this);

            panel2
                .Controls.OfType<NotifyBorder>().ToList().ForEach(b =>
                 Controls.OfType<Panel>().Where(a => a.Name == "panel2").First()
                .Controls.Remove(b));

            pnStorage.Location = new Point(pnStorage.Location.X, pnStorage.Location.Y - pnStorage.Size.Height);
            lbDate.Location = new Point(lbDate.Location.X, lbDate.Location.Y - 40);
            lbMoney.Location = new Point(lbMoney.Location.X, lbMoney.Location.Y - 40);
            lbGameTime.Location = new Point(lbGameTime.Location.X, lbGameTime.Location.Y - 40);
            pnCall.Location = new Point(pnCall.Location.X - 242, pnCall.Location.Y);
            pnReport.Location = new Point(pnReport.Location.X + 242, pnReport.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataTransfer.Money = new GameCash(lbMoney, 500);
            lbDate.Text = $"{DateTime.Now.Day} Января";
        }

        private void CopsAdd_Click(object sender, EventArgs e) {
            form_ChoiceACop.IsOkBtnClick = false;
            form_Darken = new Darken_Form(form_ChoiceACop, Darken_Form.Side.Down, this);
            lbAddCops.Visible = false;
            form_Darken.ShowDialog();
        }

        public async Task ShowGameControlsAsync() {
            anim.ShowControl(pnCall, 11, 22, 0);
            await Task.Delay(100);
            anim.ShowControl(pnReport, 11, -22, 0);
            await Task.Delay(120);
            anim.ShowControl(pnStorage, 10, 0, 6);
            await Task.Delay(100);
            anim.ShowControl(lbDate, 10, 0, 4);
            await Task.Delay(100);
            anim.ShowControl(lbGameTime, 10, 0, 4);
            await Task.Delay(100);
            anim.ShowControl(lbMoney, 10, 0, 4);
            await Task.Delay(2000);
        }

        private void GameTimer(object sender, EventArgs e) {           //GAME TIME
            if (DataTransfer.GamePause)
                return;

            int Minutes = int.Parse(lbGameTime.Text.Split(':')[0]);
            int Sec = int.Parse(lbGameTime.Text.Split(':')[1]);

            if (Sec == 59) {
                Minutes++;
                Sec = -1;
            }
            if (Minutes == 24)
                Minutes = 0;

            lbGameTime.Text = $"{((Minutes < 10) ? "0" : "")}{Minutes}:{((Sec < 9) ? "0" : "")}{++Sec}";

            if (Minutes == 1) {
                Pause_Click(button1, null);
                lbGameTime.ForeColor = Color.Brown;
                GameTime.Enabled = false;
            }
        }

        private int Counter = 0;
        public async void NewMission() {
            while (true) {
                await Task.Delay(new Random().Next(2000, 6000));
                GameMission GameMission = new GameMission(DataTransfer.Missions[Counter]);
                if (!DataTransfer.GamePause) {
                    Animation.Mission_Anim Mission = new Animation.Mission_Anim(
                               panel2,
                               new Point(new Random().Next((panel2.Size.Width / 2) - 400, (panel2.Size.Width / 2) + 400),
                               new Random().Next(75, Size.Height - 340)),
                               GameMission);
                    Mission.NewMission();

                    Mission.MapNotify.IsMouseClick += Mission_MouseClick;
                    Mission.NotifyMessage.IsMouseClick += Mission_MouseClick;
                    Mission.NotifyReport.IsMouseClick += Report_MouseClick;

                    Counter++;
                }
                if (Counter == DataTransfer.Missions.Count)
                    break;
            }
        }

        private void Report_MouseClick(object sender, NotifyArgs e) {
            DataTransfer.GamePause = true;
            form_Report = new Report_Form(e.animMission, this, e.gameMission);
            form_Darken = new Darken_Form(form_Report, Darken_Form.Side.Left, this);
            form_Darken.ShowDialog();
        }

        private void Mission_MouseClick(object sender, NotifyArgs e) {
            DataTransfer.GamePause = true;
            form_Description = new MissionDescription_Form(e.gameMission, e.animMission, this);
            form_Darken = new Darken_Form(form_Description, Darken_Form.Side.Left, this);
            form_Darken.ShowDialog();
        }

        // FOR LABEL (ADD COPS) --->
        private void Label1_MouseEnter(object sender, EventArgs e) {
            lbAddCops.ForeColor = Color.White;
        }

        private void LbAddCops_MouseLeave(object sender, EventArgs e) {
            lbAddCops.ForeColor = Color.Gray;
        }
        // <---

        private void Panel2_MouseEnter(object sender, EventArgs e) {
            foreach (NotifyBorder n in panel2.Controls.OfType<NotifyBorder>())
                if (n.Size.Width == 241)
                    n.OnMouseLeave(n, EventArgs.Empty);
        }

        private async void Storage_MouseEnter(object sender, EventArgs e) {
            for (int i = 0; i < 8; i++, await Task.Delay(1))
                pnStorage.Size = new Size(pnStorage.Size.Width, pnStorage.Size.Height + 1);
        }

        private async void Storage_MouseLeave(object sender, EventArgs e) {
            for (int i = 0; i < 8; i++, await Task.Delay(1))
                pnStorage.Size = new Size(pnStorage.Size.Width, pnStorage.Size.Height - 1);
        }

        private void pnStorage_MouseClick(object sender, MouseEventArgs e) {
            DataTransfer.GamePause = true;
            form_Darken = new Darken_Form(form_Storage, Darken_Form.Side.Down, this, opacity: 0.4f);
            form_Darken.ShowDialog();
        }

        private void Pause_Click(object sender, EventArgs e) {
            DataTransfer.GamePause = !DataTransfer.GamePause;

            if (button1.Text == "PAUSE") {
                GameTime.Enabled = false;
                button1.Text = "CONTINUE";
                //DataTransfer.player.Stop();
            }
            else {
                GameTime.Enabled = true;
                button1.Text = "PAUSE";
                //DataTransfer.player.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e) => Close();

        private void Sound_Click(object sender, EventArgs e) {
            if (lbSound.Text == "SOUND: MUTE") {
                lbSound.Text = "SOUND: UNMUTE";
                DataTransfer.BackSound.Stop();
            }
            else {
                lbSound.Text = "SOUND: MUTE";
                DataTransfer.BackSound.PlayLooping();
            }
        }
    }
}
