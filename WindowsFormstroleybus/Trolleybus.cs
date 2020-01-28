using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormstroleybus
{
    
    class Trolleybus
    {
        private float _startPosX;

        private float _startPosY;

        private int _pictureWidth;

        private int _pictureHeight;

        private const int trolleybusWidth = 90;

        private const int trolleybusHeight = 50;

        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }
        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool Diski { private set; get; }

        public bool Okno { private set; get; }

        public bool DopStupeny { private set; get; }

        public int Doors { private set; get; }

        public const int DoorY = 30;
        public const int DoorX = 20;

        public Trolleybus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool diski, bool okno, bool dopStupeny, int doors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Diski = diski;
            Okno = okno;
            DopStupeny = dopStupeny;
            Doors = doors;
        }

        public void SetPosition (int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - trolleybusWidth-165)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > -85)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 50)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - trolleybusHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTrolleybus(Graphics g)
        {

            Pen pen = new Pen(DopColor);
            Brush brush = new SolidBrush(DopColor);
            Brush Mainbrush = new SolidBrush(MainColor);
            Brush doorBrush = new SolidBrush(Color.LightGray);
            g.FillEllipse(brush, _startPosX + 100, _startPosY + 8, 20, 20);
            g.FillEllipse(brush, _startPosX + 100 + DoorX * Doors * 2, _startPosY + 8, 20, 20);
            if (Diski == true)
            {
                g.FillEllipse(doorBrush, _startPosX + 102, _startPosY + 10, 16, 16);
                g.FillEllipse(doorBrush, _startPosX + 102 + DoorX * Doors * 2, _startPosY + 10, 16, 16);
            }
            g.FillRectangle(Mainbrush, _startPosX + 80, _startPosY - 21, 60 + DoorX * Doors * 2, 35);
            g.DrawLine(pen, _startPosX + 98, _startPosY - 32, _startPosX + 116, _startPosY - 22);
            g.DrawLine(pen, _startPosX + 105, _startPosY - 32, _startPosX + 123, _startPosY - 22);
            for (int i = 0; i < Doors; i++)
            {
                g.FillRectangle(doorBrush, _startPosX + 120 + i*40, _startPosY - 15, DoorX, DoorY);
            }
            g.FillRectangle(brush, _startPosX + 130 + +DoorX * Doors * 2, _startPosY - 21, 10, 20);
            if (DopStupeny == true)
            {
                for (int i = 0; i < Doors; i++)
                {
                    g.FillRectangle(brush, _startPosX + 120 + i * 40, _startPosY + 11, DoorX, 4);
                }
            }
            if (Okno == true)
            {
                g.FillRectangle(brush, _startPosX + 90, _startPosY - 15, DoorX, 20);
            }

        }
    }
}
