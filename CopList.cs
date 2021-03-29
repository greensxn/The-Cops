using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class CopChoice_Form : Form {

        private Form1 MainForm;
        private Animation.CopBox_Anim copAnim;
        public bool IsOkBtnClick = false;
        private int CountCopAdded = 0;

        public CopChoice_Form(Form1 MainForm) {
            this.MainForm = MainForm;
            copAnim = new Animation.CopBox_Anim();
            InitializeComponent();
            ShowCop copShop = new ShowCop(panel1, true, DataTransfer.Cops, null, new Point(32, 65), true, true, false, isMainPanel: false);
            copShop.CopAdded += CopShop_CopAdded;
            lbCountCops.Text = $"{CountCopAdded}/{DataTransfer.Cops.Count} ВЫБРАНО";
        }

        private void CopShop_CopAdded(object sender, CopAddedArgs e) {
            CountCopAdded += ((e.isAdd) ? 1 : -1);
            lbCountCops.Text = $"{CountCopAdded}/{DataTransfer.Cops.Count} ВЫБРАНО";
        }

        private async void ButtonOK_Click(object sender, EventArgs e) {
            if (IsOkBtnClick)
                return;
            IsOkBtnClick = true;
            new ShowCop(MainForm.panel1, false, DataTransfer.SelectedCopList, null, new Point(30, 32), isCanClick: false, isSelect: true, isMissionSend: true, isMainPanel: true, isAnimation: true);
            await HideFormAsync();

            MainForm.panel1
                .Controls.OfType<CopBox>().ToList()
                .ForEach(b => {
                    DataTransfer.ChosenCopBoxList.Add(b);
                }); // ADD CHOICEN COPS (BORDER)

            if (DataTransfer.ChosenCopBoxList.Count != 0) {

                CheckForIllegalCrossThreadCalls = false;
                for (int i = 0; i < MainForm.panel1.Controls.OfType<CopBox>().ToList().Count; i++, await Task.Delay(50)) {
                    CopBox cop = MainForm.panel1.Controls.OfType<CopBox>().ToList()[i];
                    new Thread(async () => {
                        for (int j = 20; j >= 0; j--, await Task.Delay(1))
                            cop.Location = new Point(cop.Location.X, cop.Location.Y - j - (j / 4) - (j / 6));
                    }).Start();
                }

                DataTransfer.ChosenCopBoxList.ForEach(a => {
                    DataTransfer.FreeCopList.Add(DataTransfer.Cops.Where(b => b.ID == a.Name).First());
                    DataTransfer.ChosenCopList.Add(DataTransfer.Cops.Where(b => b.ID == a.Name).First());
                });
                await MainForm.ShowGameControlsAsync();
                MainForm.GameTime.Enabled = true;
                MainForm.NewMission();
                DataTransfer.BackSound.PlayLooping();
            }
            else
                MainForm.lbAddCops.Visible = true;

            DataTransfer.SelectedCopList.Clear();
        }

        private async void CopChoice_Form_Shown(object sender, EventArgs e) {
            for (int i = 40; i >= 0; i--, await Task.Delay(1))
                Location = new Point(Location.X, Location.Y - i - (i / 4) - (i / 6));
        }

        private void CopChoice_Form_Load(object sender, EventArgs e) {
            HideForm();
        }

        private async Task HideFormAsync() {
            ((Darken_Form)Tag).HideDarken(true);
            for (int i = 0; i <= 40; i++, await Task.Delay(1))
                Location = new Point(Location.X, Location.Y + i + (i / 4) + (i / 6));
            Close();
            DataTransfer.GamePause = false;
        }

        private void HideForm() {
            for (int i = 40; i >= 0; i--)
                Location = new Point(Location.X, Location.Y + i + (i / 4) + (i / 6));
        }
    }
}
