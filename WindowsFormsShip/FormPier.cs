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
        MultiLevelPier pier;
        FormShipConfig form;
        private const int countLevel = 5;
        public FormPier()
        {
            InitializeComponent();
            pier = new MultiLevelPier(countLevel, pictureBoxPier.Width, pictureBoxPier.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPier.Width, pictureBoxPier.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pier[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxPier.Image = bmp;
            }
        }
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if ((listBoxLevels.SelectedIndex > -1) && 
                (maskedTextBox.Text != ""))
            {
                var ship = pier[listBoxLevels.SelectedIndex] -
                    Convert.ToInt32(maskedTextBox.Text);
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
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            form = new FormShipConfig();
            form.AddEvent(AddShip);
            form.Show();
        }
        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = pier[listBoxLevels.SelectedIndex] + ship;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Корабль не удалось поставить");
                }
            }
        }
    }
}
