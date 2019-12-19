using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class Pier<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Pier<T>> where T : class, ITransport
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int placeSizeWidth = 210;
        private const int placeSizeHeight = 80;
        public Pier(int sizes, int pictureWidth, int pictureHeight)
        {
            maxCount = sizes;
            places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        public static int operator +(Pier<T> p, T ship)
        {
            if (p.places.Count == p.maxCount)
            {
                throw new PierOverflowException();
            }
            if (p.places.ContainsValue(ship))
            {
                throw new PierAlreadyHaveException();
            }
            for (int i = 0; i < p.maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, ship);
                    p.places[i].SetPosition(5 + i / 5 * placeSizeWidth + 50, 
                        i % 5 * placeSizeHeight + 45, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Pier<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T ship = p.places[index];
                p.places.Remove(index);
                return ship;
            }
            throw new PierNotFoundException(index);
        }
        private bool CheckFreePlace(int index)
        {
            return !(places.ContainsKey(index));
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach (var ship in places)
            {
                ship.Value.DrawShip(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (maxCount / 5) * placeSizeWidth, 480);
            for (int i = 0; i < maxCount / 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                    i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    places.Add(ind, value);
                    places[ind].SetPosition(5 + ind / 5 * placeSizeWidth + 50,
                        ind % 5 * placeSizeHeight + 50, PictureWidth, PictureHeight);
                } else
                {
                    throw new PierOccupiedPlaceException(ind);
                }
            }
        }
        private int currentIndex;
        public int GetKey
        {
            get
            {
                return places.Keys.ToList()[currentIndex];
            }
        }
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
            places.Clear();
        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(Pier<T> other)
        {
            if (places.Count > other.places.Count)
            {
                return -1;
            }
            else if (places.Count < other.places.Count)
            {
                return 1;
            }
            else if (places.Count > 0)
            {
                var thisKeys = places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < places.Count; ++i)
                {
                    if (places[thisKeys[i]] is Ship && other.places[thisKeys[i]] is DieselShip)
                    {
                        return 1;
                    }
                    if (places[thisKeys[i]] is DieselShip && other.places[thisKeys[i]] is Ship)
                    {
                        return -1;
                    }
                    if (places[thisKeys[i]] is Ship && other.places[thisKeys[i]] is Ship)
                    {
                        return (places[thisKeys[i]] is Ship).CompareTo(other.places[thisKeys[i]] is Ship);
                    }
                    if (places[thisKeys[i]] is DieselShip && other.places[thisKeys[i]] is DieselShip)
                    {
                        return (places[thisKeys[i]] is DieselShip).CompareTo(other.places[thisKeys[i]] is DieselShip);
                    }
                }
            }
            return 0;
        }
    }
}
