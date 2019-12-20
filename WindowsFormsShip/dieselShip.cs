using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class DieselShip : Ship, IComparable<DieselShip>, IEquatable<DieselShip>
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
        public DieselShip(string info) : base(info)
        {
            string[] strs = info.Split(';');
            foreach(var i in strs)
            {
                Console.WriteLine(strs.Length.ToString());
                Console.WriteLine(i.ToString());
            }
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                LightsColor = Color.FromName(strs[4]);
                Pipe = Convert.ToBoolean(strs[5]);
                Lights = Convert.ToBoolean(strs[6]);
            }
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
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + LightsColor.Name + ";" + Pipe + ";" + Lights;
        }
        public int CompareTo(DieselShip other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Pipe != other.Pipe)
            {
                return Pipe.CompareTo(other.Pipe);
            }
            if (Lights != other.Lights)
            {
                return Lights.CompareTo(other.Lights);
            }            
            return 0;
        }
        public bool Equals(DieselShip other)
        {
            var res = (this as DieselShip).Equals(other as Ship);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Pipe != other.Pipe)
            {
                return false;
            }
            if (Lights != other.Lights)
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
            if (!(obj is DieselShip shipObj))
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
