using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class StorageItemBox : UserControl {

        public event EventHandler IsItemMouseEnter;
        public event EventHandler IsItemMouseLeave;
        public event EventHandler IsItemMouseClick;

        public event EventHandler<bool> IsAnswerMouseClick;
        public event EventHandler IsAnswerMouseLeave;
        public event EventHandler IsAnswerMouseEnter;

        public event EventHandler IsCancelMouseEnter;
        public event EventHandler IsCancelMouseLeave;
        public event EventHandler IsCancelMouseClick;

        public event EventHandler<ColorArgs> IsColorClick;

        private bool IsEnter = false;
        private bool isWrongType = false;
        private bool isNoMoney = false;
        private bool isPanelColor = false;
        private String TempSaveName;
        private Panel[] ColorsPanelArray;
        public StorageItem.ItemType ItemType;
        public Dictionary<Color, Image> ItemColorAssociation;

        public StorageItemBox() {
            InitializeComponent();
            ColorsPanelArray = pnBackImage.Controls.OfType<Panel>().Where(a => a.Name.Contains("pnColor")).ToArray();
            ItemColorAssociation = new Dictionary<Color, Image>();
            SetEvent(this, pnLeft, pnRight, lbAnswerYes, lbAnswerNo, lbSure, pnSure, pnColor1, pnColor2, pnColor3, pnColor4, pnWrongType);
            pnLeft.Location = new Point(0, 0);
            pnRight.Location = new Point(175, 0);
            pnSure.Location = new Point(0, 0);
            pnWrongType.Location = new Point(0, 0);
            TempSaveName = lbName.Text;
            pnWrongType.Parent = pbImage;
        }

        private void SetEvent(Control mainControl, params Control[] Exceptions) {
            foreach (Control control in mainControl.Controls)
                SetEvent(control, Exceptions);

            if (!Exceptions.Contains(mainControl)) {
                mainControl.MouseEnter += OnItemMouseEnter;
                mainControl.MouseLeave += OnItemMouseLeave;
                mainControl.MouseClick += OnItemMouseClick;
            }
        }

        private void OnItemMouseClick(object sender, EventArgs e) {
            IsItemMouseClick?.Invoke(this, e);
        }

        private void OnItemMouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsEnter = true;
                IsItemMouseEnter?.Invoke(this, e);
            }
        }

        private void OnItemMouseLeave(object sender, EventArgs e) {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                return;
            else {
                IsEnter = false;
                IsItemMouseLeave?.Invoke(this, e);
            }
        }

        private void OnAnswerMouseClick(object sender, bool Answer) {
            IsAnswerMouseClick?.Invoke(this, Answer);
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

        private void OnColorClick(object sender, ColorArgs e) {
            IsColorClick?.Invoke(this, e);
        }

        public int ItemPriceInt { get; set; }
        public String ItemPrice {
            get {
                return lbPrice.Text;
            }
            set {
                lbPrice.Text = value;

                if (value.Contains('$'))
                    ItemPriceInt = int.Parse(value.Remove(0, 1));
                else
                    ItemPriceInt = int.Parse(value);
            }
        }

        public String ItemName {
            get {
                return lbName.Text;
            }
            set {
                lbName.Text = value;
                TempSaveName = value;
            }
        }

        private String staticName;
        public String ItemNameStatic {
            get {
                return staticName;
            }
            set {
                staticName = value;
                TempSaveName = value;
            }
        }

        public int ItemCount {
            get {
                return int.Parse(lbCountItem.Text);
            }
            set {
                lbCountItem.Text = value.ToString();
            }
        }

        public Image ItemPicture {
            get {
                return pbImage.Image;
            }
            set {
                pbImage.Image = value;
            }
        }

        public Color ChosenColor { get; set; }
        private Color[] itemColors;
        public Color[] ItemColors {
            get {
                return itemColors;
            }
            set {
                itemColors = value;

                if (value != null)
                    for (int i = 0; i < 4; i++) {
                        ColorsPanelArray[i].BackColor = (value != null && value.Length > i) ? value[i] : Color.Transparent;
                        ColorsPanelArray[i].Visible = (ColorsPanelArray[i].BackColor == Color.Transparent);
                    }
                else
                    for (int i = 0; i < 4; i++)
                        ColorsPanelArray[i].Visible = false;
            }
        }

        private Image[] itemPictures;
        public Image[] ItemPictures {
            get {
                return itemPictures;
            }
            set {
                itemPictures = value;
                pbImage.Image = itemPictures[0];
            }
        }

        public bool IsPanelColor {
            get {
                return isPanelColor;
            }
            set {
                isPanelColor = value;
                pnColor1.Visible = value;
                pnColor2.Visible = value;
                pnColor3.Visible = value;
                pnColor4.Visible = value;
            }
        }

        public Color ItemColor1 {
            get {
                return pnColor1.BackColor;
            }
            set {
                pnColor1.BackColor = value;
            }
        }

        public Color ItemColor2 {
            get {
                return pnColor2.BackColor;
            }
            set {
                pnColor2.BackColor = value;
            }
        }

        public Color ItemColor3 {
            get {
                return pnColor3.BackColor;
            }
            set {
                pnColor3.BackColor = value;
            }
        }

        public Color ItemColor4 {
            get {
                return pnColor4.BackColor;
            }
            set {
                pnColor4.BackColor = value;
            }
        }

        private String[] colorsName;
        public String[] ItemColorsName {
            get {
                return colorsName;
            }
            set {
                colorsName = value;
            }
        }

        public bool IsItemWrongType {
            get {
                return isWrongType;
            }
            set {
                isWrongType = value;

                Color ItemColor = (isWrongType) ? Color.DimGray : Color.SeaGreen;
                pnDock.BackColor = ItemColor;
                pnCountItem.BackColor = ItemColor;

                lbName.Text = (isWrongType) ? "ЭТОТ ТОВАР МЕНЯ НЕ ИНТЕРЕСУЕТ" : TempSaveName;
                lbName.Size = new Size((isWrongType) ? 350 : 209, 48);
                lbName.Location = new Point((isWrongType) ? 10 : 17, 0);
                lbPrice.Location = new Point((isWrongType) ? 400 : 226, 0);
                pnWrongType.Visible = isWrongType;
            }
        }

        public bool IsNoMoney {
            get {
                return isNoMoney;
            }
            set {
                isNoMoney = value;

                Color ItemColor = (isNoMoney) ? Color.DimGray : Color.SeaGreen;
                pnDock.BackColor = ItemColor;
                pnCountItem.BackColor = ItemColor;
                pnWrongType.Visible = isNoMoney;
            }
        }

        private void AnswerYes_MouseClick(object sender, MouseEventArgs e) {
            OnAnswerMouseClick(this, true);
        }

        private void AnswerNo_MouseClick(object sender, MouseEventArgs e) {
            OnAnswerMouseClick(this, false);
        }

        private void pnColor2_MouseClick(object sender, MouseEventArgs e) {
            OnColorClick(this, new ColorArgs((sender as Panel).BackColor, int.Parse((sender as Panel).Name.Remove(0, 7))));
        }
    }

    public class ColorArgs {

        public Color Color;
        public int ColorNum;

        public ColorArgs(Color Color, int ColorNum) {
            this.Color = Color;
            this.ColorNum = ColorNum;
        }
    }
}
