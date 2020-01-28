using System;
using System.Drawing;
namespace WindowsFormstroleybus
{
    /// <summary>
    /// Класс отрисовки гоночного автомобиля
    /// </summary>
    public class Trolleybus : Bus
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>

        /// <summary>
        /// Количество полос
        /// </summary>

        /// <summary>
        /// Количество полос
        /// </summary>
        /// 


        public bool Diski { private set; get; }

        public bool Okno { private set; get; }

        public bool DopStupeny { private set; get; }

        public int Doors { private set; get; }

        public const int DoorY = 30;
        public const int DoorX = 20;
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public Trolleybus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool diski, bool okno, bool dopStupeny, int doors, bool roga) :
        base(maxSpeed, weight, mainColor, doors)
        {
            DopColor = dopColor;
            Diski = diski;
            Okno = okno;
            DopStupeny = dopStupeny;
            Doors = doors;
            Roga = roga;
        }
        public Trolleybus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                Doors = Convert.ToInt32(strs[3]);
                DopColor = Color.FromName(strs[4]);
                Diski = Convert.ToBoolean(strs[5]);
                DopStupeny = Convert.ToBoolean(strs[6]);
                Roga = Convert.ToBoolean(strs[7]);

            }
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Diski + ";" +
           DopStupeny + ";" + Roga;
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;

        }
        public override void DrawBus(Graphics g)
        {

            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(DopColor);
            Brush dopBrush = new SolidBrush(DopColor);
            Brush Mainbrush = new SolidBrush(MainColor);
            Brush doorBrush = new SolidBrush(Color.LightGray);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка автомобиля на него "легла")

            // и боковые

            // теперь отрисуем основной кузов автомобиля

            base.DrawBus(g);

            // рисуем гоночные полоски

            if (Diski)
            {
                g.FillEllipse(doorBrush, _startPosX + 102, _startPosY + 10, 16, 16);
                g.FillEllipse(doorBrush, _startPosX + 102 + DoorX * Doors * 2, _startPosY + 10, 16, 16);
            }
            if (Okno)
            {
                g.FillRectangle(brush, _startPosX + 90, _startPosY - 15, DoorX, 20);
            }
            // рисуем задний спойлер автомобиля
            if (DopStupeny)
            {
                for (int i = 0; i < Doors; i++)
                {
                    g.FillRectangle(brush, _startPosX + 120 + i * 40, _startPosY + 11, DoorX, 4);
                }
            }
            if (Roga)
            {
                g.DrawLine(pen, _startPosX + 98, _startPosY - 32, _startPosX + 116, _startPosY - 22);
                g.DrawLine(pen, _startPosX + 105, _startPosY - 32, _startPosX + 123, _startPosY - 22);
            }
        }
    }
}