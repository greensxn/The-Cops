using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class Storage_Form : Form {

        public static bool AnimEnd { get; set; }
        private Inventory_Form form_Inventory;
        private Animation.Form_Anim animStorage;
        private bool IsEnter = false;

        public Storage_Form() {
            animStorage = new Animation.Form_Anim();
            InitializeComponent();
            lbStorage.Parent = pbStorage;
            lbStorage.BackColor = Color.Transparent;
        }

        private void HideStorage() {
            for (int i = 40; i >= 0; i--)
                Location = new Point(Location.X, Location.Y - i - (i / 4));
        }

        private async void Storage_MouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsEnter = true;
                lbStorage.ForeColor = Color.White;
                for (int i = 0; i < 4; i++, await Task.Delay(1)) {
                    pbStorage.Size = new Size(pbStorage.Size.Width + 4, pbStorage.Size.Height + 4);
                    pbStorage.Location = new Point(pbStorage.Location.X - 2, pbStorage.Location.Y - 2);
                }
            }
        }

        private async void Storage_MouseLeave(object sender, EventArgs e) {
            if (panel2.ClientRectangle.Contains(panel2.PointToClient(Control.MousePosition)))
                return;
            else if (IsEnter) {
                IsEnter = false;
                lbStorage.ForeColor = Color.Gainsboro;
                for (int i = 0; i < 4; i++, await Task.Delay(1)) {
                    pbStorage.Size = new Size(pbStorage.Size.Width - 4, pbStorage.Size.Height - 4);
                    pbStorage.Location = new Point(pbStorage.Location.X + 2, pbStorage.Location.Y + 2);
                }
            }
        }

        public void Seller_MouseClick(object sender, EventArgs e) {
            SellerBox seller = sender as SellerBox;
            seller.Items = (seller.Type == StorageItem.ItemType.Trash) ? DataTransfer.Seller1Items : (seller.Type == StorageItem.ItemType.Legal) ? DataTransfer.Seller2Items : DataTransfer.Seller3Items;
            animStorage.Seller_MouseClick(seller, this);
        }

        private void Seller_MouseEnter(object sender, EventArgs e) => animStorage.Seller_Event(sender as SellerBox, true);

        private void Seller_MouseLeave(object sender, EventArgs e) => animStorage.Seller_Event(sender as SellerBox, false);

        private void Storage_Form_MouseEnter(object sender, EventArgs e) => Storage_MouseLeave(this, null);

        private async void Storage_MouseClick(object sender, MouseEventArgs e) {
            if (AnimEnd) {
                await animStorage.ClearSellerAsync(null, this);
                AnimEnd = false;
                await HideStorageAsync(false);
                ShowInventory(this, "СКЛАД", "ВАШЕ ХРАНИЛИЩЕ", DataTransfer.StorageItems, false, false);
            }
        }

        private async void btClose_Click(object sender, EventArgs e) {
            await animStorage.ClearSellerAsync(null, this);
            HideStorageAsync(true);
            ((Darken_Form)Tag).HideDarken(true);
        }

        private async Task HideStorageAsync(bool isClose) {
            if (isClose) {
                await animStorage.StorageFirstAsync(this, false);
                DataTransfer.GamePause = false;
                Close();
            }
            else
                await animStorage.StorageAsync(this, false);
        }

        private async void ShowInventory(Storage_Form form_Storage, String InventoryName, String InventorySubName, List<StorageItem> ItemsForLoad, bool IsClick, bool IsBuy, SellerBox Seller = null) {
            form_Inventory = new Inventory_Form(form_Storage, InventoryName, InventorySubName, ItemsForLoad, IsClick, IsBuy, Seller);
            form_Inventory.ShowDialog();
            await Task.Delay(1);
        }

        private async void Storage_Form_Shown(object sender, EventArgs e) {
            await animStorage.StorageFirstAsync(this, true);
            AnimEnd = true;
        }

        private void Storage_Form_Load(object sender, EventArgs e) => HideStorage();

        private async void Cancel_MouseClick(object sender, EventArgs e) => await animStorage.Cancel_ClickAsync(sender as SellerBox);

        private void Cancel_MouseEnter(object sender, EventArgs e) => animStorage.Cancel_Event(sender as Label, true);

        private void Cancel_MouseLeave(object sender, EventArgs e) => animStorage.Cancel_Event(sender as Label, false);

        private async void Answer_MouseClick(object sender, bool IsBuy) {
            await animStorage.ClearSellerAsync(null, this);
            if (AnimEnd) {
                AnimEnd = false;
                await HideStorageAsync(false);
                ShowInventory(
                    this,
                    (IsBuy) ? "КУПИТЬ" : "ПРОДАТЬ",
                    $"{(sender as SellerBox).SellerFirstName} {(sender as SellerBox).SellerLastName}",
                    (sender as SellerBox).Items,
                    true,
                    IsBuy,
                    Seller: sender as SellerBox
                );
            }
        }

        private void Answer_MouseEnter(object sender, EventArgs e) => animStorage.Answer_Event(sender as Label, true);

        private void Answer_MouseLeave(object sender, EventArgs e) => animStorage.Answer_Event(sender as Label, false);
    }
}
