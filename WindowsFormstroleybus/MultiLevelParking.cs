using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WindowsFormstroleybus
{
    /// <summary>
    /// Класс-хранидище парковок
    /// </summary>
    public class MultiLevelParking
    {
        /// <summary>
        /// Список с уровнями парковки
        /// </summary>
        List<Parking<ITrolleybus>> parkingStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        /// 
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight;

        private const int countPlaces = 20;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй парковки</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITrolleybus>>();
            for (int i = 0; i < countStages; ++i)
            {

                parkingStages.Add(new Parking<ITrolleybus>(countPlaces, pictureWidth,
               pictureHeight));

            }
            foreach (var level in parkingStages)
            {
                Console.WriteLine(parkingStages.Count);
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<ITrolleybus> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
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
            using (StreamWriter fs = new StreamWriter(File.OpenWrite(filename)))
            {

                fs.WriteLine($"CountLevels:{parkingStages.Count}");
                foreach (var level in parkingStages)
                {
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var bus = level[i];
                        if (bus != null)
                        {
                            if (bus.GetType().Name == "Bus")
                            {
                                fs.WriteLine($"{i}:Bus:" + bus);
                            }
                            if (bus.GetType().Name == "Trolleybus")
                            {
                                fs.WriteLine($"{i}:Trolleybus:" + bus);
                            }
                        }
                    }
                }
            }
            return true;
        }



        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string buff = "";
            using (StreamReader fs = new StreamReader(File.OpenRead(filename)))
            {
                buff = fs.ReadLine();
                if (buff.Split(':')[0] == "CountLevels")
                {
                    int countLevel = Convert.ToInt32(buff.Split(':')[1]);
                    if (parkingStages != null)
                        parkingStages.Clear();
                    parkingStages = new List<Parking<ITrolleybus>>(countLevel);
                }
                else
                    return false;
                int count = -1;
                while (!fs.EndOfStream)
                {
                    buff = fs.ReadLine();
                    ITrolleybus bus = null;
                    if (buff == "Level")
                    {
                        count++;
                        parkingStages.Add(new Parking<ITrolleybus>(countPlaces, PictureWidth, PictureHeight));
                        continue;
                    }
                    if (buff.Split(':')[1] == "Bus")
                    {
                        bus = new Bus(buff.Split(':')[2]);
                        parkingStages[count][Convert.ToInt32(buff.Split(':')[0])] = bus;
                    }
                    if (buff.Split(':')[1] == "Trolleybus")
                    {
                        bus = new Trolleybus(buff.Split(':')[2]);
                        parkingStages[count][Convert.ToInt32(buff.Split(':')[0])] = bus;
                    }
                }
            }
            return true;
        }
    }

}
