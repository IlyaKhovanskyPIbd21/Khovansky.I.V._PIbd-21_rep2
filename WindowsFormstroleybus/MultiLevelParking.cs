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
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                //Записываем количество уровней
                WriteToFile("CountLeveles:" + parkingStages.Count +
               Environment.NewLine, fs);

                foreach (var level in parkingStages)
                {

                    //Начинаем уровень
                    WriteToFile("Level" + Environment.NewLine, fs);
                    foreach (ITrolleybus bus in level)
                    {




                        if (bus?.GetType().Name == "Bus")
                        {
                            WriteToFile(":Bus:" + bus + Environment.NewLine, fs);
                        }

                        if (bus?.GetType().Name == "Trolleybus")
                        {
                            WriteToFile(":Trolleybus:" + bus + Environment.NewLine, fs);
                        }


                    }
                }
            }

        }
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                //считываем количество уровней
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (parkingStages != null)
                {
                    parkingStages.Clear();
                }
                parkingStages = new List<Parking<ITrolleybus>>(count);
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new Exception("Неверный формат файла");

            }
            int counter = -1;
            int counterCar = 0;
            ITrolleybus bus = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i] == "Level")
                {
                    //начинаем новый уровень
                    counter++;
                    counterCar = 0;
                    parkingStages.Add(new Parking<ITrolleybus>(countPlaces, PictureWidth, PictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Bus")
                {

                    bus = new Bus(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "Trolleybus")
                {

                    bus = new Trolleybus(strs[i].Split(':')[2]);

                }
                parkingStages[counter][counterCar++] = bus;
            }

        }
        public void Sort()
        {
            parkingStages.Sort();
        }

    }

}
