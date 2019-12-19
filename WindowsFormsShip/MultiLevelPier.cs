using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormsShip
{
    class MultiLevelPier
    {
        List<Pier<ITransport>> pierStages;
        private const int countPlaces = 20;
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelPier(int countStages, int pictureWidth, int pictureHeight)
        {
            pierStages = new List<Pier<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                //Записываем количество уровней
                sw.WriteLine("CountLevels:" + pierStages.Count);
                foreach (var level in pierStages)
                {
                    //Начинаем уровень
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var ship = level[i];
                            if (ship != null)
                            {
                                if (ship.GetType().Name == "Ship")
                                {
                                    sw.Write(i + ":Ship:");
                                }
                                if (ship.GetType().Name == "DieselShip")
                                {
                                    sw.Write(i + ":DieselShip:");
                                }
                                //Записываемые параметры
                                sw.WriteLine(ship);
                            }
                        }
                        finally { }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buffer;
            using (StreamReader sr = new StreamReader(filename))
            {
                if ((buffer = sr.ReadLine()).Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(buffer.Split(':')[1]);
                    if (pierStages != null)
                    {
                        pierStages.Clear();
                    }
                    pierStages = new List<Pier<ITransport>>(count);
                }
                else 
                { 
                    throw new Exception("Неверный формат файла"); 
                }
                int counter = -1;
                ITransport ship = null;
                while ((buffer = sr.ReadLine()) != null)
                {
                    if (buffer == "Level")
                    {
                        counter++;
                        pierStages.Add(new Pier<ITransport>(countPlaces,
                            pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(buffer)) continue;
                    if (buffer.Split(':')[1] == "Ship")
                    {
                        Console.WriteLine(buffer.Split(':')[2]);
                        ship = new Ship(buffer.Split(':')[2]);
                    }
                    else if (buffer.Split(':')[1] == "DieselShip")
                    {
                        ship = new DieselShip(buffer.Split(':')[2]);
                    }
                    pierStages[counter][Convert.ToInt32(buffer.Split(':')[0])] = ship;
                }
                return true;
            }
        }
    }
}
