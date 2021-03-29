using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ThisIsThePolice_Test {
    class ShowCop {

        private Panel mainPanel;
        public CopBox copBox;

        private GameMission gameMission;
        private Animation.CopBox_Anim copAnim;
        private List<Cop> cops;
        private Point dots;
        private readonly bool isCanClick;
        private readonly bool isSelect;
        private readonly bool isMissionSend;
        private readonly bool isShiftDown;
        private readonly bool isMainPanel;
        private readonly bool isAnimation;

        public event EventHandler<CopAddedArgs> CopAdded;
        public event EventHandler CopMouseEnter;
        public event EventHandler CopMouseLeave;


        public ShowCop(Panel mainPanel, bool isShiftDown, List<Cop> cops, GameMission gameMission, Point dots, bool isCanClick, bool isSelect, bool isMissionSend, bool isMainPanel = false, bool isAnimation = false) {
            this.dots = dots;
            this.isShiftDown = isShiftDown;
            this.cops = cops;
            this.gameMission = gameMission;
            this.mainPanel = mainPanel;
            this.isCanClick = isCanClick;
            this.isMissionSend = isMissionSend;
            this.isSelect = isSelect;
            this.isMainPanel = isMainPanel;
            this.isAnimation = isAnimation;
            copAnim = new Animation.CopBox_Anim();

            AddCop();
        }

        private void OnCopAdded(object sender, CopAddedArgs cop) {
            CopAdded?.Invoke(sender, cop);
        }

        private void OnCopEnter(object sender, EventArgs e) {
            CopMouseEnter?.Invoke(sender, e);
        }

        private void OnCopLeave(object sender, EventArgs e) {
            CopMouseLeave?.Invoke(sender, e);
        }

        private void AddCop() {
            List<CopBox> listCopTemp = new List<CopBox>();
            for (int f = 0; f < cops.Count; f++) {
                copBox = new CopBox {
                    CopName = cops[f].FirstName,
                    CopProfesionalism = $"★{cops[f].Professionalism}",
                    CopPhoto = cops[f].Photo,
                    CopColorBackColor = cops[f].Views.GetColorPoliticalViews(),
                    CopEnergyProcent = cops[f].Energy,
                    CopDriveVisible = false,
                    IsAlcoholic = cops[f].IsAlcoholic,
                    IsWeed = cops[f].IsWeed,
                    IsOld = cops[f].IsOld,
                    Name = $"{cops[f].ID}"
                };
                copBox.SetDrive(0);

                if (isCanClick)
                    copBox.IsMouseClick += Cop_MouseClick;

                if (isSelect) {
                    copBox.IsMouseEnter += Cop_MouseEnter;
                    copBox.IsMouseLeave += Cop_MouseLeave;
                }

                if (isMainPanel)
                    DataTransfer.Cops.Where(a => a.ID == copBox.Name).First().Controls = copBox;

                listCopTemp.Add(copBox);
            }

            listCopTemp.Sort((x, y) => int.Parse(x.CopProfesionalism.Replace("★", "")).CompareTo(int.Parse(y.CopProfesionalism.Replace("★", ""))));
            listCopTemp.Reverse();
            for (int i = 0; i < listCopTemp.Count; i++) {
                int Count = mainPanel.Controls.OfType<CopBox>().ToArray().Length;

                int X = dots.X;
                int Y = dots.Y;

                if (isShiftDown) {
                    for (int j = 0; j < Count % 6; j++)
                        X += 145;
                    for (int j = 0; j < Count / 6; j++)
                        Y += 217;
                }
                else
                    for (int j = 0; j < Count % 100; j++)
                        X += 145;
                if (isAnimation)
                    for (int j = 20; j >= 0; j--)
                        Y = Y + j + (j / 4) + (j / 6);

                listCopTemp[i].Location = new Point(X, Y);
                mainPanel.Controls.Add(listCopTemp[i]);
            }

            foreach (var x in DataTransfer.Cops)
                foreach (var y in cops)
                    if (x.ID == y.ID)
                        x.Controls = y.Controls;
        }

        private void Cop_MouseEnter(object sender, EventArgs e) {
            Cop_MouseEvent((CopBox)sender, true);
        }

        private void Cop_MouseLeave(object sender, EventArgs e) {
            Cop_MouseEvent((CopBox)sender, false);
        }

        private void Cop_MouseEvent(CopBox cop, bool isEnter) {
            copAnim.MouseEvent(cop, isEnter);
        }

        private void Cop_MouseClick(object sender, EventArgs e) {
            CopBox copSelected = (CopBox)sender;

            if (copSelected.CopNameColor == Color.White) {
                if (gameMission == null || DataTransfer.SelectedCopList.Count < gameMission.Slot) {
                    DataTransfer.SelectedCopList.Add(DataTransfer.Cops.Where(a => a.ID == copSelected.Name).First());
                    copSelected.CopNameColor = Color.GreenYellow;
                    if (isMissionSend)
                        DataTransfer.FreeCopList.Remove(DataTransfer.ChosenCopList.Where(a => a.ID == copSelected.Name).First());
                    OnCopAdded(this, new CopAddedArgs() {
                        copInfo = DataTransfer.Cops.Where(b => b.ID == copSelected.Name).First(),
                        isAdd = true,
                    });
                }
            }
            else {
                DataTransfer.SelectedCopList.Remove(DataTransfer.Cops.Where(a => a.ID == copSelected.Name).First());
                copSelected.CopNameColor = Color.White;
                if (isMissionSend)
                    DataTransfer.FreeCopList.Add(DataTransfer.ChosenCopList.Where(a => a.ID == copSelected.Name).First());
                OnCopAdded(this, new CopAddedArgs() {
                    copInfo = DataTransfer.Cops.Where(a => a.ID == copSelected.Name).First(),
                    isAdd = false,
                });
            }
        }
    }

    class CopAddedArgs {
        public Cop copInfo;
        public bool isAdd;
    }
}
