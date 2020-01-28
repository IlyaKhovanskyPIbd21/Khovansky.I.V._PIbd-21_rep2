using System.Drawing;
namespace WindowsFormstroleybus
{
    public abstract class Vehicle : ITrolleybus
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        //Высота окна отрисовки
        protected int _pictureHeight;

        private const int trolleybusWidth = 90;

        private const int trolleybusHeight = 50;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }

        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { protected set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        /// 
        public Color DopColor { protected set; get; }

        public Color MainColor { protected set; get; }

        public bool Diski { protected set; get; }

        public bool Okno { protected set; get; }

        public bool DopStupeny { protected set; get; }

        public int Doors { protected set; get; }

        public bool Roga { protected set; get; }

        public const int DoorY = 30;
        public const int DoorX = 20;

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void DrawBus(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
