using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class Pier<T> where T : class, ITransport
    {
        private T[] places;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int placeSizeWidth = 210;
        private const int placeSizeHeight = 80;
        public Pier(int sizes, int pictureWidth, int pictureHeight)
        {
            places = new T[sizes];
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            for (int i = 0; i < places.Length; i++)
            {
                places[i] = null;
            }
        }
        public static int operator +(Pier<T> p, T ship)
        {
            for (int i = 0; i < p.places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places[i] = ship;
                    p.places[i].SetPosition(5 + i / 5 * placeSizeWidth + 50, 
                        i % 5 * placeSizeHeight + 45, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Pier<T> p, int index)
        {
            if (index < 0 || index > p.places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T ship = p.places[index];
                p.places[index] = null;
                return ship;
            }
            return null;
        }
        private bool CheckFreePlace(int index)
        {
            return places[index] == null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    places[i].DrawShip(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (places.Length / 5) * placeSizeWidth, 480);
            for (int i = 0; i < places.Length / 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                    i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }

    }
}
