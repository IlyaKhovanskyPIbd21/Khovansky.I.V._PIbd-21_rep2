using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormstroleybus
{
    public partial class FormTrolleybus : Form
    {
        public FormTrolleybus()
        {
            InitializeComponent();
        }

        private Trolleybus trolleybus;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrolleybus));
            this.pictureBoxTrolleybus = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrolleybus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrolleybus
            // 
            this.pictureBoxTrolleybus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTrolleybus.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrolleybus.Name = "pictureBoxTrolleybus";
            this.pictureBoxTrolleybus.Size = new System.Drawing.Size(1136, 610);
            this.pictureBoxTrolleybus.TabIndex = 0;
            this.pictureBoxTrolleybus.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Cоздать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(1038, 512);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 40);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonRight.Image")));
            this.buttonRight.Location = new System.Drawing.Point(1084, 558);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeft.Image")));
            this.buttonLeft.Location = new System.Drawing.Point(992, 558);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(1038, 558);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 40);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormTrolleybus
            // 
            this.ClientSize = new System.Drawing.Size(1136, 610);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxTrolleybus);
            this.Name = "FormTrolleybus";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrolleybus)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            trolleybus = new Trolleybus(rnd.Next(100,300),rnd.Next(1000,2000), Color.Red, Color.Black, (rnd.Next(0, 101) <= 50 ? true : false), (rnd.Next(0, 101) <= 50 ? true : false), (rnd.Next(0,101) <= 50 ? true : false), rnd.Next(1,4));
            trolleybus.SetPosition(rnd.Next(10,100) , rnd.Next(10, 100), pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    trolleybus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    trolleybus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    trolleybus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    trolleybus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTrolleybus.Width, pictureBoxTrolleybus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            trolleybus.DrawTrolleybus(gr);
            pictureBoxTrolleybus.Image = bmp;
        }
    }
}
