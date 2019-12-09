using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsShip
{
    class Ship : SeaVehicle, IComparable<Ship>, IEquatable<Ship>
    {
        protected const int shipWidth = 90;
        protected const int shipHeight = 50;        
        public Ship (int maxSpeed, int weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
        }
        public Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.Blue;
            }
        }
        public override void MoveShip (Direction dir)
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
        public override void DrawShip (Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush main = new SolidBrush(MainColor);
            Brush dop = new SolidBrush(DopColor);      
            //  first deck
            g.FillRectangle(main, startPosX - 35, startPosY, 70, 10);
            g.DrawRectangle(pen, startPosX - 35, startPosY, 70, 10);
            for (int i = startPosX - 30; i <= startPosX + 20; i += 25)
            {
                g.FillRectangle(dop, i, startPosY + 3, 10, 5);
                g.DrawRectangle(pen, i, startPosY + 3, 10, 5);                    
            }
            // basement
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
            pen.Dispose();
            main.Dispose();
            dop.Dispose();            
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public int CompareTo(Ship other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Ship shipObj))
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
