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
    public partial class CopBox : UserControl {

        public event EventHandler IsMouseEnter;
        public event EventHandler IsMouseLeave;
        public event EventHandler IsMouseClick;

        private List<Panel> listBadge = new List<Panel>();

        private bool IsEnter { get; set; } = false;
        private bool isOld { get; set; } = false;
        private bool isAlcoholic { get; set; } = false;
        private bool isWeed { get; set; } = false;
        private bool isDead { get; set; } = false;
        private int Energy { get; set; } = 0;


        public CopBox() {
            InitializeComponent();
            SetEvent(this, true);

            pnDead.Parent = pnCopPicture;
            pnDead.Dock = DockStyle.Fill;
            pnDead.BackColor = Color.FromArgb(120,255,255,255);

            pnBadgeAlcohol.Parent = pnCopPicture;
            pnBadgeOld.Parent = pnCopPicture;
            pnBadgeWeed.Parent = pnCopPicture;
        }

        private void SetEvent(Control mainControl, bool isSet) {
            if (isSet) {
                foreach (Control control in mainControl.Controls)
                    SetEvent(control, true);
                mainControl.MouseEnter += OnMouseEnter;
                mainControl.MouseLeave += OnMouseLeave;
                mainControl.MouseClick += OnMouseClick;
            }
            else {
                foreach (Control control in mainControl.Controls)
                    SetEvent(control, false);
                mainControl.MouseEnter -= OnMouseEnter;
                mainControl.MouseLeave -= OnMouseLeave;
                mainControl.MouseClick -= OnMouseClick;
            }
        }

        public void OnMouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsEnter = true;
                IsMouseEnter?.Invoke(this, e);
            }
        }

        public void OnMouseClick(object sender, EventArgs e) {
            IsMouseClick?.Invoke(this, e);
        }

        protected void OnMouseLeave(object sender, EventArgs e) {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else {
                IsEnter = false;
                IsMouseLeave?.Invoke(this, e);
            }
        }

        public String CopName {
            get {
                return lbCopName.Text;
            }
            set {
                lbCopName.Text = value;
            }
        }

        public Color CopNameColor {
            get {
                return lbCopName.ForeColor;
            }
            set {
                lbCopName.ForeColor = value;
            }
        }

        public String CopProfesionalism {
            get {
                return lbCopProfessionalism.Text;
            }
            set {
                lbCopProfessionalism.Text = value;
            }
        }

        public int CopEnergyProcent {
            get {
                return Convert.ToInt32(pnCopEnergy.Size.Width * 100 / (this.Size.Width - pnDrive.Size.Width));
            }
            set {
                pnCopEnergy.Size = new Size(value * Size.Width / 100, 10);
            }
        }

        public Color CopColorBackColor {
            get {
                return pnCopPicture.BackColor;
            }
            set {
                pnCopPicture.BackColor = value;
            }
        }

        public Image CopPhotoBackColor {
            get {
                return pnCopPicture.BackgroundImage;
            }
            set {
                pnCopPicture.BackgroundImage = value;
            }
        }

        public Image CopPhoto {
            get {
                return pnCopPicture.Image;
            }
            set {
                pnCopPicture.Image = value;
            }
        }

        public int CopDriveProcent {
            get {
                return Convert.ToInt32(pnDrive.Size.Height * 100 / Size.Height);
            }
            set {
                pnDrive.Size = new Size(5, value * Size.Height / 100 + 1);
                pnDrive.Location = new Point(125, (100 - value) * 189 / 100);
            }
        }

        public Color CopDriveColor {
            get {
                return pnDrive.BackColor;
            }
            set {
                pnDrive.BackColor = value;
            }
        }

        public bool CopDriveVisible {
            get {
                return pnDrive.Visible;
            }
            set {
                pnDrive.Visible = value;
                if (value)
                    Size = new Size(130, Height);
                else
                    Size = new Size(125, Height);
            }
        }

        public bool IsAlcoholic {
            get {
                return isAlcoholic;
            }
            set {
                pnBadgeAlcohol.Visible = value;
                Badge(pnBadgeAlcohol, value);
                isAlcoholic = value;
            }
        }

        public bool IsDead {
            get {
                return isDead;
            }
            set {
                isDead = value;
                pnDead.Visible = isDead;
                Energy = (isDead) ? CopEnergyProcent : Energy;
                CopEnergyProcent = (isDead) ? 100 : Energy;
                pnCopEnergy.BackColor = (isDead) ? Color.Black : Color.FromArgb(65, 169, 58);
                lbDead.Visible = isDead;
                SetEvent(this, !value);

                if (isDead) 
                    pnBadgeAlcohol.Parent = pnBadgeOld.Parent = pnBadgeWeed.Parent = pnDead;
                else
                    pnBadgeAlcohol.Parent = pnBadgeOld.Parent = pnBadgeWeed.Parent = pnCopPicture;

                
            }
        }

        public bool IsOld {
            get {
                return isOld;
            }
            set {
                pnBadgeOld.Visible = value;
                Badge(pnBadgeOld, value);
                isOld = value;
            }
        }

        public bool IsWeed {
            get {
                return isWeed;
            }
            set {
                pnBadgeWeed.Visible = value;
                Badge(pnBadgeWeed, value);
                isWeed = value;
            }
        }

        private void Badge(Panel Badge, bool IsAdd) {
            if (IsAdd) {
                int CountBadges = listBadge.Count;
                int PositionY = (CountBadges * 22) + (3 * (CountBadges + 1));

                Badge.Location = new Point(3, PositionY);

                listBadge.Add(Badge);
            }
            else if (listBadge.Contains(Badge)) {
                int Index = listBadge.Select((s, i) => new { i, s }).Where(t => t.s == Badge).Select(t => t.i).First();

                for (int i = Index; i < listBadge.Count; i++)
                    listBadge[i].Location = new Point(3, listBadge[i].Location.Y - 25);

                listBadge.Remove(Badge);
            }
        }

        public void SetDrive(int Procent) {
            CopDriveProcent = Procent;
        }

        private bool isBlock = false;
        public bool BlockCop {
            get {
                return isBlock;
            }
            set {
                isBlock = value;
                //lbCopName.Enabled = !isBlock;
                //lbCopProfessionalism.Enabled = !isBlock;
                //pnCopPicture.Enabled = !isBlock;
                //pnCopEnergy.Enabled = !isBlock;
                //pnCopEnergyBack.Enabled = !isBlock;
                //pnBadgeWeed.Enabled = !isBlock;
                //pnBadgeAlcohol.Enabled = !isBlock;
                //pnBadgeOld.Enabled = !isBlock;
                //pnDead.Enabled = !isBlock;
                //lbDead.Enabled = !isBlock;
            }
        }
    }
}
