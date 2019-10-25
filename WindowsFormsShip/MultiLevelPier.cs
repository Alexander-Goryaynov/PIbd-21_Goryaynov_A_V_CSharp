using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsShip
{
    class MultiLevelPier
    {
        List<Pier<ITransport>> pierStages;
        private const int countPlaces = 20;
        public MultiLevelPier(int countStages, int pictureWidth, int pictureHeight)
        {
            pierStages = new List<Pier<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                pierStages.Add(new Pier<ITransport>(countPlaces, pictureWidth,
                    pictureHeight));
            }
        }
        public Pier<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < pierStages.Count)
                {
                    return pierStages[ind];
                }
                return null;
            }
        }
    }
}
