using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class CopSay : Form {

        Animation.Form_Anim animForm;


        public CopSay() {
            animForm = new Animation.Form_Anim();
            InitializeComponent();
        }

        private void CopSay_Load(object sender, EventArgs e) {
            Location = new Point(-1100, Location.Y);
        }

        public void SetValue(Cop cop, String MainText, String Description, Color color) {
            copBox1.CopName = cop.FirstName;
            pnStatus.BackColor = color;
            lbStatusText.ForeColor= color.GetColorLabel_MT();
            copBox1.CopProfesionalism = cop.Professionalism.ToString();
            copBox1.CopPhoto = cop.Photo;
            copBox1.CopColorBackColor = cop.Controls.CopColorBackColor;
            copBox1.CopEnergyProcent = cop.Controls.CopEnergyProcent;
            copBox1.IsDead = cop.IsDead;
            copBox1.IsAlcoholic = cop.IsAlcoholic;
            copBox1.IsWeed = cop.IsWeed;
            copBox1.IsOld = cop.IsOld;
            lbStatusText.Text = MainText;
            lbDescription.Text = Description;

            pnStatus.BackColor = color;
            btClose.BackColor = color;
            btClose.ForeColor = color.GetColorLabel_MT();
        }

        private async void btClose_Click(object sender, EventArgs e) {
            ((Darken_Form)Tag).HideDarken(true);
            await animForm.OtherForm(this, false, false);
            Close();
        }

        private async void CopSay_Shown(object sender, EventArgs e) => await animForm.OtherForm(this, true, true);
    }
}
