using System.Collections.Generic;
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
    }
}
