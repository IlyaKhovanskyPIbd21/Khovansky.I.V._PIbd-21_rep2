namespace WindowsFormstroleybus
{
    partial class FormParking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.SetBus = new System.Windows.Forms.Button();
            this.SetTrolleybus = new System.Windows.Forms.Button();
            this.groupBoxTakeBus = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeBus = new System.Windows.Forms.PictureBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.maskedTextBoxNumberOfBus = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeBusOrTrolleybus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(853, 448);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // SetBus
            // 
            this.SetBus.Location = new System.Drawing.Point(859, 0);
            this.SetBus.Name = "SetBus";
            this.SetBus.Size = new System.Drawing.Size(194, 62);
            this.SetBus.TabIndex = 1;
            this.SetBus.Text = "Припарковать автобус";
            this.SetBus.UseVisualStyleBackColor = true;
            this.SetBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // SetTrolleybus
            // 
            this.SetTrolleybus.Location = new System.Drawing.Point(859, 68);
            this.SetTrolleybus.Name = "SetTrolleybus";
            this.SetTrolleybus.Size = new System.Drawing.Size(194, 63);
            this.SetTrolleybus.TabIndex = 2;
            this.SetTrolleybus.Text = "Припарковать троллейбус";
            this.SetTrolleybus.UseVisualStyleBackColor = true;
            this.SetTrolleybus.Click += new System.EventHandler(this.buttonSetTrolleybus_Click);
            // 
            // groupBoxTakeBus
            // 
            this.groupBoxTakeBus.Controls.Add(this.pictureBoxTakeBus);
            this.groupBoxTakeBus.Controls.Add(this.buttonTakeBus);
            this.groupBoxTakeBus.Controls.Add(this.maskedTextBoxNumberOfBus);
            this.groupBoxTakeBus.Controls.Add(this.labelTakeBusOrTrolleybus);
            this.groupBoxTakeBus.Location = new System.Drawing.Point(859, 137);
            this.groupBoxTakeBus.Name = "groupBoxTakeBus";
            this.groupBoxTakeBus.Size = new System.Drawing.Size(194, 311);
            this.groupBoxTakeBus.TabIndex = 3;
            this.groupBoxTakeBus.TabStop = false;
            // 
            // pictureBoxTakeBus
            // 
            this.pictureBoxTakeBus.Location = new System.Drawing.Point(6, 90);
            this.pictureBoxTakeBus.Name = "pictureBoxTakeBus";
            this.pictureBoxTakeBus.Size = new System.Drawing.Size(179, 220);
            this.pictureBoxTakeBus.TabIndex = 3;
            this.pictureBoxTakeBus.TabStop = false;
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(14, 58);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(171, 26);
            this.buttonTakeBus.TabIndex = 2;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click);
            // 
            // maskedTextBoxNumberOfBus
            // 
            this.maskedTextBoxNumberOfBus.Location = new System.Drawing.Point(14, 32);
            this.maskedTextBoxNumberOfBus.Name = "maskedTextBoxNumberOfBus";
            this.maskedTextBoxNumberOfBus.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBoxNumberOfBus.TabIndex = 1;
            // 
            // labelTakeBusOrTrolleybus
            // 
            this.labelTakeBusOrTrolleybus.AutoSize = true;
            this.labelTakeBusOrTrolleybus.Location = new System.Drawing.Point(11, 16);
            this.labelTakeBusOrTrolleybus.Name = "labelTakeBusOrTrolleybus";
            this.labelTakeBusOrTrolleybus.Size = new System.Drawing.Size(174, 13);
            this.labelTakeBusOrTrolleybus.TabIndex = 0;
            this.labelTakeBusOrTrolleybus.Text = "Забрать автобус или троллейбус";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 466);
            this.Controls.Add(this.groupBoxTakeBus);
            this.Controls.Add(this.SetTrolleybus);
            this.Controls.Add(this.SetBus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeBus.ResumeLayout(false);
            this.groupBoxTakeBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button SetBus;
        private System.Windows.Forms.Button SetTrolleybus;
        private System.Windows.Forms.GroupBox groupBoxTakeBus;
        private System.Windows.Forms.PictureBox pictureBoxTakeBus;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberOfBus;
        private System.Windows.Forms.Label labelTakeBusOrTrolleybus;
    }
}