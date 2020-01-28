using System.Drawing;
namespace WindowsFormstroleybus
{
    public class Bus : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Bus(int maxSpeed, float weight, Color mainColor, int doors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            Doors = doors;


        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)

                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawBus(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Brush Mainbrush = new SolidBrush(MainColor);
            Brush doorBrush = new SolidBrush(Color.LightGray);
            g.FillEllipse(brush, _startPosX + 100, _startPosY + 8, 20, 20);
            g.FillEllipse(brush, _startPosX + 100 + DoorX * Doors * 2, _startPosY + 8, 20, 20);

            g.FillRectangle(Mainbrush, _startPosX + 80, _startPosY - 21, 60 + DoorX * Doors * 2, 35);

            for (int i = 0; i < Doors; i++)
            {
                g.FillRectangle(doorBrush, _startPosX + 120 + i * 40, _startPosY - 15, DoorX, DoorY);
            }
            g.FillRectangle(brush, _startPosX + 130 + +DoorX * Doors * 2, _startPosY - 21, 10, 20);


        }
    }
}