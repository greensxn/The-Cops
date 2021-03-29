using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class NewItem_Form : Form {

        private Animation.Form_Anim animForm;

        //  CREATED BY 
        //  t.me/CMETAHKA
        //  instagram.com/pripa.doc


        public NewItem_Form() {
            animForm = new Animation.Form_Anim();
            InitializeComponent();
        }

        public void SetValue(StorageItem Item, String Headline, String From) {
            lbName.Text = Headline;
            pnPicture.BackgroundImage = Item.Picture;
            lbItemName.Text = Item.Name;
            lbFrom.Text = From;
        }

        private void NewItem_Form_Load(object sender, EventArgs e) {
            for (int i = 40; i >= 0; i--)
                Location = new Point(Location.X, Location.Y - i - (i / 4));
        }

        private async void NewItem_Form_Shown(object sender, EventArgs e) => await animForm.StorageFirstAsync(this, true);

        private async void btClose_Click(object sender, EventArgs e) {
            ((Darken_Form)Tag).HideDarken(true);
            await animForm.StorageFirstAsync(this, false);
            Close();
        }
    }
}
