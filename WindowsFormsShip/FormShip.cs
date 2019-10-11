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
    public partial class FormShip : Form
    {
        private ITransport ship;
        public FormShip()
        {
            InitializeComponent();
        }
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new Ship(rnd.Next(20, 50), rnd.Next(140, 200), 
                Color.Gray, Color.Blue);
            ship.SetPosition(rnd.Next(50, 100), rnd.Next(50, 100), 
                pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ship.DrawShip(gr);
            pictureBoxShip.Image = bmp;
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    ship.MoveShip(Direction.Up);
                    break;
                case "buttonDown":
                    ship.MoveShip(Direction.Down);
                    break;
                case "buttonLeft":
                    ship.MoveShip(Direction.Left);
                    break;
                case "buttonRight":
                    ship.MoveShip(Direction.Right);
                    break;
            }
            Draw();
        }

        private void ButtonCreateDieselShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ship = new DieselShip(rnd.Next(20, 50), rnd.Next(140, 200),
                Color.Gray, Color.Blue, Color.Yellow, true, true);
            ship.SetPosition(rnd.Next(50, 100), rnd.Next(50, 100),
                pictureBoxShip.Width, pictureBoxShip.Height);
            Draw();
        }
    }
}
