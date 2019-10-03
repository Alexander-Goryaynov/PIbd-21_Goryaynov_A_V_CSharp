using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsShip
{
    class Ship
    {
        private int startPosX;
        private int startPosY;
        private int pictureWidth;
        private int pictureHeight;
        private const int shipWidth = 90;
        private const int shipHeight = 50;
        public int MaxSpeed { private set; get; }
        public int Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool FirstDeck { private set; get; }
        public bool SecondDeck { private set; get; }
        public bool ThirdDeck { private set; get; }
        public bool Pipe { private set; get; }
        public bool Lights { private set; get; }
        public Ship (int maxSpeed, int weight, Color mainColor, Color dopColor, 
            bool firstDeck, bool secondDeck, bool thirdDeck, bool pipe, bool lights)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FirstDeck = firstDeck;
            SecondDeck = secondDeck;
            ThirdDeck = thirdDeck;
            Pipe = pipe;
            Lights = lights;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            startPosX = x;
            startPosY = y;
            pictureWidth = width;
            pictureHeight = height;
        }
        public void MoveShip (Direction dir)
        {
            int step = MaxSpeed * 100 / Weight;
            switch (dir)
            {
                case Direction.Right:
                    if (startPosX + step < pictureWidth - shipWidth)
                    {
                        startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (startPosX - 3*step > 0)
                    {
                        startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (startPosY - 2*step > 0)
                    {
                        startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (startPosY + step < pictureHeight - shipHeight)
                    {
                        startPosY += step;
                    }
                    break;
            }
        }
        public void Draw (Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush main = new SolidBrush(MainColor);
            Brush dop = new SolidBrush(DopColor);
            Brush lights = new SolidBrush(Color.Yellow);
            Brush pipe = new SolidBrush(Color.Black);
            if (Pipe)
            {
                g.FillRectangle(pipe, startPosX - 20, startPosY - 25, 15, 50);
            }
            if (ThirdDeck)
            {
                g.FillRectangle(main, startPosX - 25, startPosY - 20, 50, 10);
                g.DrawRectangle(pen, startPosX - 25, startPosY - 20, 50, 10);
                for (int i = startPosX - 20; i <= startPosX + 10; i += 15) 
                {
                    g.FillRectangle(dop, i, startPosY - 17, 10, 5);
                    g.DrawRectangle(pen, i, startPosY - 17, 10, 5);                    
                }
            }
            if (SecondDeck)
            {
                g.FillRectangle(main, startPosX - 30, startPosY - 10, 60, 10);
                g.DrawRectangle(pen, startPosX - 30, startPosY - 10, 60, 10);                
                for (int i = startPosX - 25; i <= startPosX + 15; i += 20)
                {
                    g.FillRectangle(dop, i, startPosY - 7, 10, 5);
                    g.DrawRectangle(pen, i, startPosY - 7, 10, 5);                    
                }
            }
            if (FirstDeck)
            {
                g.FillRectangle(main, startPosX - 35, startPosY, 70, 10);
                g.DrawRectangle(pen, startPosX - 35, startPosY, 70, 10);
                for (int i = startPosX - 30; i <= startPosX + 20; i += 25)
                {
                    g.FillRectangle(dop, i, startPosY + 3, 10, 5);
                    g.DrawRectangle(pen, i, startPosY + 3, 10, 5);                    
                }
            }
            Point point1 = new Point(startPosX - 45, startPosY + 10);
            Point point2 = new Point(startPosX + 45, startPosY + 10);
            Point point3 = new Point(startPosX + 30, startPosY + 25);
            Point point4 = new Point(startPosX - 40, startPosY + 25);
            Point[] trapezePoints = { point1, point2, point3, point4 };
            g.FillPolygon(main, trapezePoints);
            g.DrawPolygon(pen, trapezePoints);
            for (int i = startPosX-35; i <= startPosX + 25; i += 15)
            {
                g.FillEllipse(dop, i, startPosY + 17, 3, 3);
                g.DrawEllipse(pen, i, startPosY + 17, 3, 3);
            }
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
