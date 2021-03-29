using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class SellerBox : UserControl {

        public event EventHandler IsSellerMouseClick;
        public event EventHandler IsSellerMouseEnter;
        public event EventHandler IsSellerMouseLeave;

        public event EventHandler<bool> IsAnswerMouseClick;
        public event EventHandler IsAnswerMouseEnter;
        public event EventHandler IsAnswerMouseLeave;

        public event EventHandler IsCancelMouseClick;
        public event EventHandler IsCancelMouseEnter;
        public event EventHandler IsCancelMouseLeave;

        private bool IsEnter = false;
        private List<StorageItem> items;
        private StorageItem.ItemType type;


        public SellerBox() {
            InitializeComponent();
            pnBuy.Location = new Point(0, 0);
            pnCell.Location = new Point(350, 0);
            pnCancel.Location = new Point(0, 111);

            SetEvent(this, pnBuy, pnCell, pnCancel, lbBuy, lbSale, lbCancel);

            lbFirstName.Parent = pbImage;
            lbFirstName.BackColor = Color.Transparent;
            lbLastName.Parent = pbImage;
            lbLastName.BackColor = Color.Transparent;
        }

        public StorageItem.ItemType Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        public List<StorageItem> Items {
            get {
                return items;
            }
            set {
                items = value;
            }
        }

        private void SetEvent(Control mainControl, params Control[] Exceptions) {
            foreach (Control control in mainControl.Controls)
                SetEvent(control, Exceptions);

            if (!Exceptions.Contains(mainControl)) {
                mainControl.MouseClick += OnMouseClick;
                mainControl.MouseEnter += OnMouseEnter;
                mainControl.MouseLeave += OnMouseLeave;
            }
        }

        private void OnMouseClick(object sender, EventArgs e) {
            IsSellerMouseClick?.Invoke(this, e);
        }

        private void OnMouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsEnter = true;
                IsSellerMouseEnter?.Invoke(this, e);
            }
        }

        private void OnMouseLeave(object sender, EventArgs e) {
            if (ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                return;
            else {
                IsEnter = false;
                IsSellerMouseLeave?.Invoke(this, e);
            }
        }

        private void OnAnswerMouseClick(object sender, bool IsBuy) {
            IsAnswerMouseClick?.Invoke(this, IsBuy);
        }

        private void OnAnswerMouseEnter(object sender, EventArgs e) {
            IsAnswerMouseEnter?.Invoke(sender, e);
        }

        private void OnAnswerMouseLeave(object sender, EventArgs e) {
            IsAnswerMouseLeave?.Invoke(sender, e);
        }

        private void OnCancelMouseClick(object sender, MouseEventArgs e) {
            IsCancelMouseClick?.Invoke(this, e);
        }

        private void OnCancelMouseEnter(object sender, EventArgs e) {
            IsCancelMouseEnter?.Invoke(sender, e);
        }

        private void OnCancelMouseLeave(object sender, EventArgs e) {
            IsCancelMouseLeave?.Invoke(sender, e);
        }

        public String SellerFirstName {
            get {
                return lbFirstName.Text;
            }
            set {
                lbFirstName.Text = value;
            }
        }

        public String SellerLastName {
            get {
                return lbLastName.Text;
            }
            set {
                lbLastName.Text = value;
            }
        }

        public Image SellerPicture {
            get {
                return pbImage.Image;
            }
            set {
                pbImage.Image = value;
            }
        }

        public new Color ForeColor {
            get {
                return lbFirstName.ForeColor;
            }
            set {
                lbFirstName.ForeColor = value;
                lbLastName.ForeColor = value;
            }
        }

        public Font SellerLNFont {
            get {
                return lbFirstName.Font;
            }
            set {
                lbFirstName.Font = value;
            }
        }
        public Font SellerFNFont {
            get {
                return lbLastName.Font;
            }
            set {
                lbLastName.Font = value;
            }
        }

        public int SellerFNLocationX {
            get {
                return lbFirstName.Location.X;
            }
            set {
                lbFirstName.Location = new Point(value, lbFirstName.Location.Y);
            }
        }

        public int SellerLNLocationX {
            get {
                return lbLastName.Location.X;
            }
            set {
                lbLastName.Location = new Point(value, lbLastName.Location.Y);
            }
        }

        private void Buy_MouseClick(object sender, MouseEventArgs e) {
            OnAnswerMouseClick(sender, true);
        }

        private void Sale_MouseClick(object sender, MouseEventArgs e) {
            OnAnswerMouseClick(sender, false);
        }
    }
}
