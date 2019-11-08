using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    public abstract class SeaVehicle : ITransport
    {
        protected int startPosX;
        protected int startPosY;
        protected int pictureWidth;
        protected int pictureHeight;
        public int MaxSpeed { protected set; get; }
        public int Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public Color DopColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public abstract void DrawShip(Graphics g);
        public abstract void MoveShip(Direction direction);
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
    }
}
