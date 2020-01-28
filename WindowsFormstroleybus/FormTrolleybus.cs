using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormstroleybus
{
    public partial class FormTrolleybus : Form
    {
        private ITrolleybus Bus;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTrolleybus()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки машины
        /// </summary>

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Bus.DrawBus(gr);
            pictureBoxTrolleybus.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Bus = new Bus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red, rnd.Next(1, 4));
            Bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateTrolleybus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Bus = new Trolleybus(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red,
           Color.LightGray, true, true, true, rnd.Next(1, 4), true);
            Bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTrolleybus.Width,
           pictureBoxTrolleybus.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    Bus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    Bus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    Bus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    Bus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrolleybus));
            this.CreateBus = new System.Windows.Forms.Button();
            this.CreateTrolleybus = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.pictureBoxTrolleybus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrolleybus)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBus
            // 
            this.CreateBus.Location = new System.Drawing.Point(1139, 70);
            this.CreateBus.Name = "CreateBus";
            this.CreateBus.Size = new System.Drawing.Size(135, 52);
            this.CreateBus.TabIndex = 0;
            this.CreateBus.Text = "Создать автобус";
            this.CreateBus.UseVisualStyleBackColor = true;
            this.CreateBus.Click += new System.EventHandler(this.buttonCreateBus_Click);
            // 
            // CreateTrolleybus
            // 
            this.CreateTrolleybus.Location = new System.Drawing.Point(1139, 12);
            this.CreateTrolleybus.Name = "CreateTrolleybus";
            this.CreateTrolleybus.Size = new System.Drawing.Size(135, 52);
            this.CreateTrolleybus.TabIndex = 1;
            this.CreateTrolleybus.Text = "Создать троллейбус";
            this.CreateTrolleybus.UseVisualStyleBackColor = true;
            this.CreateTrolleybus.Click += new System.EventHandler(this.buttonCreateTrolleybus_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(1185, 464);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(1139, 510);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1185, 510);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(1234, 510);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxTrolleybus
            // 
            this.pictureBoxTrolleybus.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTrolleybus.Name = "pictureBoxTrolleybus";
            this.pictureBoxTrolleybus.Size = new System.Drawing.Size(1121, 536);
            this.pictureBoxTrolleybus.TabIndex = 6;
            this.pictureBoxTrolleybus.TabStop = false;
            // 
            // FormTrolleybus
            // 
            this.ClientSize = new System.Drawing.Size(1286, 560);
            this.Controls.Add(this.pictureBoxTrolleybus);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.CreateTrolleybus);
            this.Controls.Add(this.CreateBus);
            this.Name = "FormTrolleybus";
            this.Click += new System.EventHandler(this.buttonMove_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrolleybus)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
