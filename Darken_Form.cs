using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsThePolice_Test {
    public partial class Darken_Form : Form {

        private Form form;
        private Side side;
        private float op;

        public Darken_Form(Form form, Side side, Control Parent, Size size = default(Size), Point location = default(Point), Color color = default(Color), float opacity = default(float)) {
            this.form = form;
            this.side = side;
            form.Tag = this;
            InitializeComponent();
            Size = Parent.Size;
            Location = Parent.Location;
            if (size != default(Size))
                Size = size;
            if (location != default(Point))
                Location = location;
            if (opacity != default(float)) {
                op = opacity;
                Opacity = opacity;
            }
            else
                op = default(float);
            BackColor = (color == default(Color)) ? Color.Black : color;
        }

        private void Darken_Form_Shown(object sender, EventArgs e) {
            FormShow();
            form.ShowDialog();
        }

        private async void FormShow() {
            for (int i = 40; i >= 0; i--, await Task.Delay(1)) {
                Location = new Point(
                    Location.X + ((side == Side.Right) ? i + (i / 2) + (i / 2) + (i / 4) + (i / 6) : (side == Side.Left) ? -i - (i / 2) - (i / 2) - (i / 4) - (i / 6) : 0),
                    Location.Y + ((side == Side.Down) ? i + (i / 4) + (i / 6) : (side == Side.Up) ? -i - (i / 4) - (i / 6) : 0)
                );
                if (op == default(float))
                    Opacity = (40 - double.Parse(i.ToString())) * 2 / 100 + 0.1f;
            }
        }

        private void Darken_Form_Load(object sender, EventArgs e) => HideDarken(false);

        public async void HideDarken(bool isClose) {
            if (isClose) {
                for (int i = 0; i <= 40; i++, await Task.Delay(1)) {
                    Location = new Point(
                        Location.X + ((side == Side.Right) ? -i - (i / 2) - (i / 2) - (i / 4) - (i / 6) : (side == Side.Left) ? i + (i / 2) + (i / 2) + (i / 4) + (i / 6) : 0),
                        Location.Y + ((side == Side.Down) ? -i - (i / 4) - (i / 6) : (side == Side.Up) ? i + (i / 4) + (i / 6) : 0)
                    );
                    if (op == default(float))
                        Opacity = double.Parse((40 - i).ToString()) * 2 / 100;
                }
                Close();
            }
            else
                for (int i = 0; i <= 40; i++)
                    Location = new Point(
                        Location.X + ((side == Side.Right) ? -i - (i / 2) - (i / 2) - (i / 4) - (i / 6) : (side == Side.Left) ? i + (i / 2) + (i / 2) + (i / 4) + (i / 6) : 0),
                        Location.Y + ((side == Side.Down) ? -i - (i / 4) - (i / 6) : (side == Side.Up) ? i + (i / 4) + (i / 6) : 0)
                    );
        }

        public enum Side {
            Right, Left, Up, Down
        }
    }
}
