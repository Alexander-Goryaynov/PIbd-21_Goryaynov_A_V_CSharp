using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsShip
{
    public partial class FormPier : Form
    {
        Pier<ITransport> pier;
        public FormPier()
        {
            InitializeComponent();
            pier = new Pier<ITransport>(20, pictureBoxPier.Width, pictureBoxPier.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPier.Width, pictureBoxPier.Height);
            Graphics gr = Graphics.FromImage(bmp);
            pier.Draw(gr);
            pictureBoxPier.Image = bmp;
        }
        private void buttonParkShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color, Color.Blue);
                int place = pier + ship;
                Draw();
            }
        }
        private void buttonParkDieselShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new DieselShip(100, 1000, dialog.Color, dialogDop.Color, 
                        Color.Yellow, true, true);
                    int place = pier + ship;
                    Draw();
                }
            }
        }
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = pier - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(100, 50, pictureBoxTake.Width, pictureBoxTake.Height);
                    ship.DrawShip(gr);
                    pictureBoxTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                Draw();
            }
        }
    }
}
