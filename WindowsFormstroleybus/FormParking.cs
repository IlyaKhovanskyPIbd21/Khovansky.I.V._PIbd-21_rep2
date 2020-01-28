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
        MultiLevelParking parking;

        /// <summary>
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(20, pictureBoxParking.Width,
           pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
            Draw();

        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пунктне будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементуlistBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
               pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Random rnd = new Random();
                    var bus = new Bus(100, 1000, dialog.Color, rnd.Next(1, 4));
                    int place = parking[listBoxLevels.SelectedIndex] + bus;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }

        }

        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetTrolleybus_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        Random rnd = new Random();
                        var bus = new Trolleybus(100, 1000, dialog.Color, dialogDop.Color, true, true, true, rnd.Next(1, 4), true); ;
                        int place = parking[listBoxLevels.SelectedIndex] + bus;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
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
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxTakeBus.Text != "")
                {
                    var bus = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBoxTakeBus.Text);
                    if (bus != null)
                    {
                        Bitmap bmp = new Bitmap(TakeBusOrTrolleybus.Width,
                       TakeBusOrTrolleybus.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        bus.SetPosition(5, 5, TakeBusOrTrolleybus.Width,
                       TakeBusOrTrolleybus.Height);
                        bus.DrawBus(gr);
                        TakeBusOrTrolleybus.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(TakeBusOrTrolleybus.Width,
                       TakeBusOrTrolleybus.Height);
                        TakeBusOrTrolleybus.Image = bmp;
                    }
                    Draw();
                }
            }

        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();

        }

    }
}
