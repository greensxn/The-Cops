using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class MissionDescription_Form : Form {

        private Complication_form form_Complication;
        private Darken_Form form_Darken;
        private CopSay form_CopSay;
        private Animation.CopBox_Anim CopAnim;
        private GameMission gameMission;
        private Animation.Mission_Anim Mission;
        private Animation.Form_Anim formAnim;
        private CopMission CopMission;
        private Form MainForm;
        private Random random;
        private bool IsItemContains { get; set; } = false;
        private int CopDieTime { get; set; } = -1;
        private int CopWeedTime { get; set; } = -1;
        public int CopOldTime { get; set; } = -1;

        public MissionDescription_Form(GameMission gameMission, Animation.Mission_Anim Mission, Form MainForm) {
            this.gameMission = gameMission;
            this.Mission = Mission;
            this.MainForm = MainForm;
            formAnim = new Animation.Form_Anim();
            random = new Random();
            InitializeComponent();
            SetValue();
        }

        private void SetValue() {
            lbCrimeName.Text = gameMission.Name.ToUpper();
            lbCrimePlace.Text = gameMission.Place.Name.ToUpper();
            tbDesc.Text = gameMission.Description;
            if (gameMission.Slot != 6) {
                lbCountCopSelected.Visible = true;
                lbCountCopSelected.Text = $"{DataTransfer.SelectedCopList.Count}/{gameMission.Slot}";
            }

            pbCrimeImage.Image = gameMission.Picture;

            lbOptimalProfesionalism.Text = $"★{gameMission.Professionalism}";
            lbProfesionalismNow.Text = "★0";

            tbDesc.GotFocus += (s, a) => { pnCrimeDesc.Focus(); };

            //color form
            Color formColor = gameMission.Type.GetColor_MT();
            pnStatus.BackColor = formColor;
            pnDescriptionLine.BackColor = formColor;
            pnCopLine.BackColor = formColor;
            lbCrimeName.ForeColor = formColor.GetColorLabel_MT();
            //

            btProceed.MouseClick += BtProceed_MouseClick;
            btCLOSE.MouseClick += BtClose_MouseClick;

            ShowCop Cops = new ShowCop(panel3, true, DataTransfer.FreeCopList, gameMission, new Point(30, 63), true, true, true);
            Cops.CopAdded += Cops_CopAdded;
        }

        private void Cops_CopAdded(object sender, CopAddedArgs e) {
            double NumAdd = Convert.ToInt32(lbProfesionalismNow.Text.Replace("★", "")) + ((e.isAdd) ? e.copInfo.Professionalism : -e.copInfo.Professionalism);
            lbProfesionalismNow.Text = $"★{NumAdd}";

            if (gameMission.Slot != 6)
                lbCountCopSelected.Text = $"{DataTransfer.SelectedCopList.Count}/{gameMission.Slot}";

            double Procent = (gameMission.Professionalism == 0) ? 100 : NumAdd * 100 / gameMission.Professionalism;
            int Shift = Convert.ToInt32(Procent) * 462 / 100;

            if (NumAdd == 0) {
                lbProfesionalismNow.Location = new Point(3, 32);
                pnBorderLeft.Location = new Point(0, 31);
            }
            else {
                if (Procent >= 100) {
                    lbProfesionalismNow.Location = new Point(381 + (5 - lbProfesionalismNow.Text.Length) * 14, 32);
                    pnBorderLeft.Location = new Point(462, 31);
                }
                else {
                    pnBorderLeft.Location = new Point(Shift, 31);
                    lbProfesionalismNow.Location = new Point(pnBorderLeft.Location.X - ((gameMission.Professionalism / 2 > NumAdd) ? -3 : (lbProfesionalismNow.Size.Width)), 32);
                }
            }

            pnBorderRight.BackColor = btProceed.BackColor = ((gameMission.Professionalism <= Convert.ToInt32(lbProfesionalismNow.Text.Replace("★", ""))) ? (gameMission.CopNeed > DataTransfer.SelectedCopList.Count && gameMission.Slot != 6 /*|| gameMission.Slot != 6 && gameMission.CopNeed != 1*/) ? Color.Gray : gameMission.Type.GetColor_MT() : Color.Gray);
            lbProfesionalismNow.ForeColor = (gameMission.Professionalism <= Convert.ToInt32(lbProfesionalismNow.Text.Replace("★", ""))) ? Color.White : Color.Gray;
            pnBorderLeft.BackColor = (gameMission.Professionalism <= Convert.ToInt32(lbProfesionalismNow.Text.Replace("★", ""))) ? (btProceed.BackColor == Color.Gray) ? Color.White : gameMission.Type.GetColor_MT() : Color.Gray;
            btProceed.ForeColor = btProceed.BackColor.GetColorLabel_MT();
            lbOptimalProfesionalism.ForeColor = (btProceed.BackColor == Color.Gray) ? Color.Gray : Color.White;
            lbCountCopSelected.ForeColor = (gameMission.CopNeed <= DataTransfer.SelectedCopList.Count) ? Color.White : Color.Gray;
        }

        private void BtProceed_MouseClick(object sender, MouseEventArgs e) {
            if ((sender as Button).BackColor == Color.Gray)
                return;

            if (DataTransfer.SelectedCopList.Count < gameMission.CopNeed) {
                ShowCopTelling(
                    DataTransfer.SelectedCopList.First(),
                    "ГНЕВ",
                    $"Шеф, я {((DataTransfer.SelectedCopList.First().Gender == Cop.CopGender.Male) ? "сам" : "сама")} туда не поеду",
                    gameMission.Type.GetColor_MT());
                return;
            }

            CopMission = new CopMission(DataTransfer.SelectedCopList, gameMission);
            CopMission.Stop();
            CopMission.StartGoToPolice += Cops_StartGoToPolice;
            CopMission.StartGoToCrime += Cops_StartGoToCrime;
            CopMission.MotionToPolice += Cops_MotionToPolice;
            CopMission.MotionToCrime += Cops_MotionToCrime;
            CopMission.ArrivedToPolice += Cops_ArrivedToPolice;
            CopMission.ArrivedToCrime += Cops_ArrivedToCrime;
            CopMission.Drive(true);
            DataTransfer.CopsOnAMissionList.Add(gameMission.Name, CopMission.Cops);
            DataTransfer.SelectedCopList.Clear();

            Mission.NotifyDelete(Mission.NotifyMessage, true);
            Mission.NotifyOnMapDelete(Mission.MapNotify);
            HideForm(true, true);
        }

        private CopSay ShowCopTelling(Cop cop, String Name, String text, Color color) {
            form_CopSay = new CopSay();
            form_CopSay.SetValue(cop, Name, text, color);
            form_Darken = new Darken_Form(form_CopSay, Darken_Form.Side.Right, MainForm, new Size(MainForm.Size.Width, 290), new Point(form_CopSay.Location.X, form_CopSay.Location.Y), Color.Black);
            form_Darken.ShowDialog();
            return form_CopSay;
        }

        private void BtClose_MouseClick(object sender, MouseEventArgs e) {
            foreach (CopBox cop in panel3.Controls.OfType<CopBox>().ToArray()) {
                if (cop.CopNameColor != Color.White) {
                    DataTransfer.CopsOnAMissionList.Remove(Name);
                    DataTransfer.FreeCopList.Add(DataTransfer.Cops.Where(a => a.FirstName == cop.CopName).First());
                }
            }
            DataTransfer.SelectedCopList.Clear();
            HideForm(true, false);
        }

        // COP EVENTS -->
        private void Cops_MotionToPolice(object sender, CopMissionArgs e) {
            int Procent = 100 - (e.RoadTimeNow * 100 / e.RoadTimeTotal);
            foreach (CopBox ChoicenCop in DataTransfer.ChosenCopBoxList)
                foreach (Cop CopDrived in e.Cops)
                    if (ChoicenCop.Name == CopDrived.ID) {
                        ChoicenCop.SetDrive(Procent);
                        break;
                    }
        }

        private void Cops_MotionToCrime(object sender, CopMissionArgs e) {
            int Procent = e.RoadTimeNow * 100 / e.RoadTimeTotal;

            setCopDie(Procent, e.Cops); //if the cop is drunk
            setCopWeedSay(Procent, e.Cops); //if the cop is weed
            setCopOld(Procent, e.Cops); //if the cop is old

            foreach (CopBox ChoicenCop in DataTransfer.ChosenCopBoxList)
                foreach (Cop CopDrived in e.Cops)
                    if (ChoicenCop.Name == CopDrived.ID) {
                        ChoicenCop.SetDrive(Procent);
                        break;
                    }
        }

        private void Cops_ArrivedToPolice(object sender, CopMissionArgs e) {
            CopAnim = new Animation.CopBox_Anim();
            setCopActive(true, e.Cops);
            DataTransfer.CopsOnAMissionList.Remove(e.gameMission.Name);
        }

        private async void Cops_ArrivedToCrime(object sender, CopMissionArgs e) {
            for (int i = 0; i < 50; i++, await Task.Delay(1))
                while (DataTransfer.GamePause)
                    await Task.Delay(1);

            e.gameMission.IsDriveToMisssion = e.Cops.Count > 0;
            if (e.gameMission.IsDriveToMisssion && !checkComplication(e.gameMission))
                setMissionOver(e.gameMission, e.Cops);
            Mission.ShowReport();
            CopMission.Drive(false);
        }

        private void Cops_StartGoToCrime(object sender, CopMissionArgs e) {
            checkItems(e.gameMission);  //CHECK ITEMS (if mission with items need)
            checkDieCops(e.Cops);
            checkWeedCops(e.Cops);
            checkOldCops(e.Cops);
            setCopActive(false, e.Cops, e.gameMission);
        }

        private void Cops_StartGoToPolice(object sender, CopMissionArgs e) {
            if (e.Cops == null || e.Cops.Count < 1)
                return;

            Cop RandomCop = e.Cops[new Random().Next(0, e.Cops.Count)];

            if (e.gameMission.Complications != null) {
                int answer = e.gameMission.Answer.Last();
                String Descriprion = (e.gameMission.Complications.Addition == null) ? e.gameMission.Report.Answer[e.gameMission.Answer[e.gameMission.Answer.Count - 1]] : e.gameMission.Report.Answer[e.gameMission.Answer[e.gameMission.Answer.Count - 1]].Split(';')[e.gameMission.Answer[e.gameMission.Answer.Count - ((e.gameMission.Answer.Count > 1) ? 2 : 1)]];

                if (Descriprion.Contains("{") && Descriprion.Contains("}")) {

                    if (Descriprion.Contains("{COP}") || Descriprion.Contains("{cop}"))
                        gameMission.Report.SetTag(answer, RandomCop);

                    if (Descriprion.Contains("{COP DEAD}")) {
                        RandomCop.IsDead = true;
                        RandomCop.Controls.CopDriveVisible = false;
                        e.Cops.Remove(RandomCop);
                        e.gameMission.Report.Answer[answer] = e.gameMission.Report.Answer[answer].Replace("{COP DEAD}", String.Empty);
                    }
                }
            }

            if (e.gameMission.Report.AcceptedDescription.Contains("{") && e.gameMission.Report.AcceptedDescription.Contains("}")) {

                if (e.gameMission.Report.AcceptedDescription.Contains("{COP}") || e.gameMission.Report.AcceptedDescription.Contains("{cop}"))
                    gameMission.Report.SetTag(RandomCop);

                if (e.gameMission.Report.AcceptedDescription.Contains("{COP DEAD}")) {
                    RandomCop.IsDead = true;
                    RandomCop.Controls.CopDriveVisible = false;
                    e.Cops.Remove(RandomCop);
                    e.gameMission.Report.AcceptedDescription = e.gameMission.Report.AcceptedDescription.Replace("{COP DEAD}", String.Empty);
                }
            }
        }
        // <-- COP EVENTS 

        private void MissionDescription_Form_Load(object sender, EventArgs e) => HideForm(false, false);

        private async void HideForm(bool isClose, bool IsRight) {
            if (isClose) {
                ((Darken_Form)Tag).HideDarken(true);
                await formAnim.OtherForm(this, IsRight, false);
                Close();
                DataTransfer.GamePause = false;
            }
            else
                for (int i = 40; i >= 0; i--)
                    Location = new Point(Location.X - i - (i / 2) - (i / 2) - (i / 4), Location.Y);
        }

        private void checkItems(GameMission GM) {
            if (GM.ItemsNeed != null)
                foreach (GameMission.MissionItems Item in GM.ItemsNeed) {  //CHECK ITEMS in STORAGE
                    StorageItem IsItem = DataTransfer.StorageItems.Where(a => a.Name == Item.Name).FirstOrDefault();
                    IsItemContains = (IsItem != null && IsItem.Count >= Item.Count);
                    if (!IsItemContains)
                        break;
                }
            if (IsItemContains) {
                foreach (GameMission.MissionItems Item in GM.ItemsNeed) { // DELETE ITEM WHEN COP ON MISSION
                    StorageItem IsItem = DataTransfer.StorageItems.Where(a => a.Name == Item.Name).First();
                    DataTransfer.StorageItems.Where(a => a.Name == Item.Name).First().Count -= Item.Count;
                    if (DataTransfer.StorageItems.Where(a => a.Name == Item.Name).First().Count == 0)
                        DataTransfer.StorageItems.Remove(DataTransfer.StorageItems.Where(a => a.Name == Item.Name).First());
                }
            }
        }

        private void setCopActive(bool isActive, List<Cop> Cops, GameMission gameMission = null) {
            if (isActive) {
                Cops.ForEach(a => {
                    DataTransfer.FreeCopList.Add(a);
                    a.Controls.BlockCop = true;
                    a.Controls.CopDriveVisible = false;
                    CopAnim.ArrivedToPolice(a.Controls);
                });
            }
            else {
                foreach (CopBox cb in DataTransfer.ChosenCopBoxList)
                    foreach (Cop cop in Cops)
                        if (cb.Name == cop.ID) {
                            cb.CopDriveVisible = true;
                            cb.CopDriveColor = gameMission.Type.GetColor_MT();
                            break;
                        }
            }
        }

        private void setMissionOver(GameMission GM, List<Cop> Cops) {
            if (GM.IsTrueCall) {
                if (GM.ItemsNeed == null) {
                    Cops.ForEach(a => a.AddProfesionalism(10));
                    GM.IsComplete = true;
                }
                else {
                    Cops.ForEach(a => a.AddProfesionalism((IsItemContains) ? 10 : -10));
                    GM.IsComplete = IsItemContains;
                }
            }
        }

        private bool checkComplication(GameMission GM) {
            if (GM.Complications != null && GM.ItemsNeed == null) {
                DataTransfer.GamePause = true;
                form_Complication = new Complication_form(GM, Mission, CopMission, MainForm);
                form_Darken = new Darken_Form(form_Complication, Darken_Form.Side.Left, MainForm);
                form_Darken.ShowDialog();
                return true;
            }
            return false;
        }

        private void checkDieCops(List<Cop> cops) {
            int chance = 16;
            List<Cop> alcCops = cops.Where(c => c.IsAlcoholic).ToList();
            if (alcCops != null && alcCops.Count > 0) {
                Cop cop = alcCops.GetRandom();
                if (random.Next(1, 101) <= chance) {
                    cop.IsNeedDead = true;
                }
            }
        }

        private void checkOldCops(List<Cop> cops) {
            int chance = 16;
            List<Cop> oldCops = cops.Where(c => c.IsOld).ToList();
            if (oldCops != null && oldCops.Count > 0) {
                Cop cop = oldCops.GetRandom();
                if (random.Next(1, 101) <= chance) {
                    cop.IsNeedOld = true;
                }
            }
        }

        private void checkWeedCops(List<Cop> cops) {
            int chance = 18;
            List<Cop> weedCops = cops.Where(c => c.IsWeed).ToList();
            if (weedCops != null && weedCops.Count > 0) {
                Cop cop = weedCops.GetRandom();
                if (random.Next(1, 101) <= chance) {
                    cop.IsNeedWeed = true;
                }
            }
        }

        private void setCopDie(int procent, List<Cop> cops) {
            if (CopDieTime != -2) {
                Cop deadCop = cops.Where(c => c.IsNeedDead).FirstOrDefault();
                if (cops.Contains(deadCop)) {
                    if (CopDieTime == -1)
                        CopDieTime = new Random().Next(28, 100);
                    if (procent == CopDieTime) {
                        DataTransfer.GamePause = true;
                        deadCop.IsDead = true;
                        ShowCopTelling(
                            deadCop,
                            "Погиб",
                            "Шеф, я же был пьян, зачем ты меня отправил на задание...",
                            Color.FromArgb(165, 42, 42));
                        DataTransfer.GamePause = false;
                        deadCop.Controls.CopDriveVisible = false;
                        cops.Remove(deadCop);
                        CopDieTime = -2;
                    }
                }
            }
        }

        private void setCopOld(int procent, List<Cop> cops) {
            if (CopOldTime != -2) {
                Cop oldCop = cops.Where(c => c.IsNeedOld).FirstOrDefault();
                if (cops.Contains(oldCop)) {
                    if (CopOldTime == -1)
                        CopOldTime = new Random().Next(40, 100);
                    if (procent == CopOldTime) {
                        DataTransfer.GamePause = true;
                        oldCop.IsDead = true;
                        ShowCopTelling(
                            oldCop,
                            "Погиб",
                            "Шеф, у меня прихватило сердце, я завтра не выйду на работу...",
                            Color.FromArgb(165, 42, 42));
                        DataTransfer.GamePause = false;
                        oldCop.Controls.CopDriveVisible = false;
                        cops.Remove(oldCop);
                        CopOldTime = -2;
                    }
                }
            }
        }

        private void setCopWeedSay(int procent, List<Cop> cops) {
            if (CopWeedTime != -2) {
                Cop weedCop = cops.Where(c => c.IsNeedWeed).FirstOrDefault();
                if (CopWeedTime == -1)
                    CopWeedTime = new Random().Next(15, 100);
                if (cops.Contains(weedCop) && procent == CopWeedTime) {
                    DataTransfer.GamePause = true;
                    ShowCopTelling(
                        weedCop,
                        "Коробка конфет",
                        "Шеф, по дороге на место преступления, я кое-что нашел для тебя. Надеюсь эта коробка конфет тебе пригодится.",
                        Color.FromArgb(20, 60, 49));
                    DataTransfer.GamePause = false;
                    CopWeedTime = -2;
                }
            }
        }

        private async void MissionDescription_Form_Shown(object sender, EventArgs e) => await formAnim.OtherForm(this, true, true);
    }
}
