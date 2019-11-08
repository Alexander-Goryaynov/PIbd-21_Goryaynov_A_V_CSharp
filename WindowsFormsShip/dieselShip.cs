using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class DieselShip : Ship
    {
        private Color lightsColor;
        public Color LightsColor {
            get { return lightsColor; }
            private set { if (value != Color.Black) this.lightsColor = value; }
        }
        public bool Pipe { private set; get; }
        public bool Lights { private set; get; }
        public DieselShip (int maxSpeed, int weight, Color mainColor, 
            Color dopColor, Color lightsColor, bool pipe, bool lights) : 
            base (maxSpeed, weight, mainColor, dopColor)
        {
            LightsColor = lightsColor;
            Pipe = pipe;
            Lights = lights;
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override void DrawShip(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush main = new SolidBrush(MainColor);
            Brush dop = new SolidBrush(DopColor);
            Brush lights = new SolidBrush(LightsColor);
            Brush pipe = new SolidBrush(Color.Black);
            // pipe
            if (Pipe)
            {
                g.FillRectangle(pipe, startPosX - 20, startPosY - 25, 15, 50);
            }
            // third deck
            g.FillRectangle(main, startPosX - 25, startPosY - 20, 50, 10);
            g.DrawRectangle(pen, startPosX - 25, startPosY - 20, 50, 10);
            for (int i = startPosX - 20; i <= startPosX + 10; i += 15)
            {
                g.FillRectangle(dop, i, startPosY - 17, 10, 5);
                g.DrawRectangle(pen, i, startPosY - 17, 10, 5);
            }
            // second deck
            g.FillRectangle(main, startPosX - 30, startPosY - 10, 60, 10);
            g.DrawRectangle(pen, startPosX - 30, startPosY - 10, 60, 10);
            for (int i = startPosX - 25; i <= startPosX + 15; i += 20)
            {
                g.FillRectangle(dop, i, startPosY - 7, 10, 5);
                g.DrawRectangle(pen, i, startPosY - 7, 10, 5);
            }
            //basement and first deck
            base.DrawShip(g);
            if (Lights)
            {
                g.FillEllipse(lights, startPosX + 35, startPosY + 10, 5, 5);
                g.FillEllipse(lights, startPosX - 5, startPosY + 10, 5, 5);
                g.FillEllipse(lights, startPosX - 43, startPosY + 10, 5, 5);
            }
            pen.Dispose();
            main.Dispose();
            dop.Dispose();
            lights.Dispose();
            pipe.Dispose();
        }
    }
}
