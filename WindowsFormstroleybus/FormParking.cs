using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormstroleybus
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        Parking<ITrolleybus> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITrolleybus>(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Random rnd = new Random();
                var bus = new Bus(100, 1000, dialog.Color, rnd.Next(1, 4));
                int place = parking + bus;
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTrolleybus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    Random rnd = new Random();
                    var bus = new Trolleybus(100, 1000, dialog.Color, dialogDop.Color, true, true, true, rnd.Next(1, 4), true); ;
                    int place = parking + bus;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeBus_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumberOfBus.Text != "")
            {
                var bus = parking - Convert.ToInt32(maskedTextBoxNumberOfBus.Text);
                if (bus != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    bus.SetPosition(5, 5, pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    bus.DrawBus(gr);
                    pictureBoxTakeBus.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeBus.Width,
                   pictureBoxTakeBus.Height);
                    pictureBoxTakeBus.Image = bmp;
                }
                Draw();
            }
        }
    }
}