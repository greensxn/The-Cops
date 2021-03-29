using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class Inventory_Form : Form {

        private Storage_Form form_Storage;
        private Animation.Form_Anim animForm;
        private String InventoryName;
        private String InventorySubName;
        private bool IsClick;
        private bool IsBuy;
        private SellerBox Seller;
        private List<StorageItem> ItemsForLoad;
        private List<StorageItem> SellerItems;

        public Inventory_Form(Storage_Form form_Storage, String InventoryName, String InventorySubName, List<StorageItem> ItemsForLoad, bool IsClick, bool IsBuy, SellerBox Seller = null) {
            this.form_Storage = form_Storage;
            this.InventoryName = InventoryName;
            this.InventorySubName = InventorySubName;
            this.IsClick = IsClick;
            this.IsBuy = IsBuy;
            this.Seller = Seller;
            SellerItems = (Seller == null) ? null : (Seller.Type == StorageItem.ItemType.Trash) ? DataTransfer.Seller1Items : (Seller.Type == StorageItem.ItemType.Legal) ? DataTransfer.Seller2Items : DataTransfer.Seller3Items;
            this.ItemsForLoad = (IsBuy) ? SellerItems : DataTransfer.StorageItems;
            animForm = new Animation.Form_Anim();
            InitializeComponent();
            SetValue();
        }

        private void SetValue() {
            lbName.Text = InventoryName;
            lbSubName.Text = InventorySubName;
            foreach (StorageItem Item in ItemsForLoad)
                pnItems.Controls.Add(Item.Control);
            FormClosed += Inventory_Form_FormClosed;
        }

        private void Inventory_Form_FormClosed(object sender, FormClosedEventArgs e) {
            ItemsForLoad.ForEach(a => {

                if (!a.Control.IsItemWrongType && !a.Control.IsNoMoney) {
                    if (IsClick) {
                        a.Control.IsItemMouseClick -= Item_MouseClick;
                        a.Control.IsColorClick -= ItemColor_Click;
                    }
                    a.Control.IsItemMouseEnter -= Item_MouseEnter;
                    a.Control.IsItemMouseLeave -= Item_MouseLeave;
                }

                a.Control.IsAnswerMouseClick -= Answer_MouseClick;
                a.Control.IsAnswerMouseEnter -= Answer_MouseEnter;
                a.Control.IsAnswerMouseLeave -= Answer_MouseLeave;

                a.Control.IsCancelMouseClick -= Cancel_MouseClick;
                a.Control.IsCancelMouseEnter -= Cancel_MouseEnter;
                a.Control.IsCancelMouseLeave -= Cancel_MouseLeave;

            });
        }

        private async void Inventory_Form_Shown(object sender, EventArgs e) {
            await animForm.OtherForm(this, true, true);
            Storage_Form.AnimEnd = true;
        }

        private async void Back_Click(object sender, EventArgs e) {
            animForm.ClearItem(pnItems, null);
            if (Storage_Form.AnimEnd) {
                Storage_Form.AnimEnd = false;
                await animForm.OtherForm(this, false, false);
                Close();
                await animForm.StorageAsync(form_Storage, true);
                Storage_Form.AnimEnd = true;
            }
        }

        private void Inventory_Form_Load(object sender, EventArgs e) {
            ItemsForLoad.ForEach(a => {
                a.Control.IsItemWrongType = (Seller != null && !IsBuy && a.Type != Seller.Type);
                if (!a.Control.IsItemWrongType)
                    a.Control.IsNoMoney = (Seller != null && IsBuy && a.Price > DataTransfer.Money.GetCash());
                a.Control.IsPanelColor = (Seller != null && IsBuy && a.Colors != null);
                pnItems.Controls.Add(a.Control);

                if (!a.Control.IsItemWrongType && !a.Control.IsNoMoney) {
                    if (IsClick) {
                        a.Control.IsItemMouseClick += Item_MouseClick;
                        a.Control.IsColorClick += ItemColor_Click;
                    }
                    a.Control.IsItemMouseEnter += Item_MouseEnter;
                    a.Control.IsItemMouseLeave += Item_MouseLeave;
                }

                a.Control.IsAnswerMouseClick += Answer_MouseClick;
                a.Control.IsAnswerMouseEnter += Answer_MouseEnter;
                a.Control.IsAnswerMouseLeave += Answer_MouseLeave;

                a.Control.IsCancelMouseClick += Cancel_MouseClick;
                a.Control.IsCancelMouseEnter += Cancel_MouseEnter;
                a.Control.IsCancelMouseLeave += Cancel_MouseLeave;

            });
            HideForm();
        }

        private void ItemColor_Click(object sender, ColorArgs e) {
            StorageItemBox Item = sender as StorageItemBox;
            Item.ChosenColor = e.Color;
            Item.pbImage.Image = Item.ItemColorAssociation[e.Color];
            Item.ItemName = $"{Item.ItemColorsName[e.ColorNum - 1]} {Item.ItemNameStatic}";
        }

        private void Item_MouseEnter(object sender, EventArgs e) => animForm.Item_Event(sender as StorageItemBox, true);

        private void Item_MouseLeave(object sender, EventArgs e) => animForm.Item_Event(sender as StorageItemBox, false);

        private void Item_MouseClick(object sender, EventArgs e) => animForm.Item_Click(pnItems, sender as StorageItemBox);

        private bool IsClickAnswer = false;
        private async void Answer_MouseClick(object sender, bool IsTrue) {
            if (IsClickAnswer)
                return;
            IsClickAnswer = true;
            StorageItemBox Item = (sender as StorageItemBox);
            await animForm.HideItemAnswerAsync(Item);
            StorageItem NewItem = new StorageItem(Item);
            if (IsTrue && IsBuy) {

                if (NewItem.Colors != null)
                    NewItem.Control.pbImage.Image = NewItem.Control.ItemColorAssociation[NewItem.Control.ChosenColor];

                if (DataTransfer.StorageItems.Where(a => a.Name == NewItem.Name).FirstOrDefault() != null)
                    DataTransfer.StorageItems.Where(a => a.Name == NewItem.Name).First().Count += 1;
                else
                    DataTransfer.StorageItems.Add(NewItem);

                DataTransfer.Money.AddCash(-Item.ItemPriceInt);

                foreach (StorageItem item in SellerItems) {
                    if (item.Price > DataTransfer.Money.GetCash() && !item.Control.IsNoMoney) {
                        item.Control.IsNoMoney = true;
                        item.Control.IsItemMouseClick -= Item_MouseClick;
                        item.Control.IsItemMouseEnter -= Item_MouseEnter;
                        item.Control.IsItemMouseLeave -= Item_MouseLeave;
                    }
                }

                SellerItems.Where(a => a.NameStatic == NewItem.NameStatic).First().Count -= 1;
                if (SellerItems.Where(a => a.NameStatic == Item.ItemNameStatic).First().Count == 0) {
                    pnItems.Controls.Remove(Item);
                    SellerItems.Remove(ItemsForLoad.Where(a => a.NameStatic == Item.ItemNameStatic).First());
                }
            }
            else if (IsTrue && !IsBuy) {

                if (SellerItems.Where(a => a.NameStatic == NewItem.NameStatic).FirstOrDefault() != null)
                    SellerItems.Where(a => a.NameStatic == NewItem.NameStatic).First().Count += 1;
                else
                    SellerItems.Add(NewItem);

                DataTransfer.Money.AddCash(Item.ItemPriceInt);

                DataTransfer.StorageItems.Where(a => a.Name == Item.ItemName).First().Count -= 1;
                if (DataTransfer.StorageItems.Where(a => a.Name == Item.ItemName).First().Count == 0) {
                    pnItems.Controls.Remove(Item);
                    DataTransfer.StorageItems.Remove(DataTransfer.StorageItems.Where(a => a.Name == Item.ItemName).First());
                }
            }
            IsClickAnswer = false;
        }

        private void Answer_MouseEnter(object sender, EventArgs e) => animForm.Answer_Event(sender as Label, true);

        private void Answer_MouseLeave(object sender, EventArgs e) => animForm.Answer_Event(sender as Label, false);

        private async void Cancel_MouseClick(object sender, EventArgs e) => await animForm.HideItemAnswerAsync(sender as StorageItemBox);

        private void Cancel_MouseEnter(object sender, EventArgs e) => animForm.Cancel_Event(sender as Label, true);

        private void Cancel_MouseLeave(object sender, EventArgs e) => animForm.Cancel_Event(sender as Label, false);

        private void HideForm() {
            for (int i = 40; i > 0; i--)
                Location = new Point(Location.X - i - (i / 2) - (i / 2) - (1 / 2) - (1 / 2) - (i / 4), Location.Y);
        }

        private void pnItems_MouseClick(object sender, MouseEventArgs e) => Item_MouseClick(null, null);
    }
}
