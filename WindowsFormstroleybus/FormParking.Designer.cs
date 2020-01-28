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
            this.buttonCreateTrolleybus = new System.Windows.Forms.Button();
            this.groupBoxTakeBusOrTrolleybus = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeBus = new System.Windows.Forms.PictureBox();
            this.TakeBusOrTrolleybus = new System.Windows.Forms.Button();
            this.maskedTextBoxTakeBusOrTrolleybus = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeBusOrTrolleybus = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.menuStripSaveOrLoadFile = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeBusOrTrolleybus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).BeginInit();
            this.menuStripSaveOrLoadFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 21);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1251, 607);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonCreateTrolleybus
            // 
            this.buttonCreateTrolleybus.Location = new System.Drawing.Point(1277, 164);
            this.buttonCreateTrolleybus.Name = "buttonCreateTrolleybus";
            this.buttonCreateTrolleybus.Size = new System.Drawing.Size(242, 180);
            this.buttonCreateTrolleybus.TabIndex = 2;
            this.buttonCreateTrolleybus.Text = "Заказать Транспорт";
            this.buttonCreateTrolleybus.UseVisualStyleBackColor = true;
            this.buttonCreateTrolleybus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // groupBoxTakeBusOrTrolleybus
            // 
            this.groupBoxTakeBusOrTrolleybus.Controls.Add(this.pictureBoxTakeBus);
            this.groupBoxTakeBusOrTrolleybus.Controls.Add(this.TakeBusOrTrolleybus);
            this.groupBoxTakeBusOrTrolleybus.Controls.Add(this.maskedTextBoxTakeBusOrTrolleybus);
            this.groupBoxTakeBusOrTrolleybus.Controls.Add(this.labelTakeBusOrTrolleybus);
            this.groupBoxTakeBusOrTrolleybus.Location = new System.Drawing.Point(1257, 350);
            this.groupBoxTakeBusOrTrolleybus.Name = "groupBoxTakeBusOrTrolleybus";
            this.groupBoxTakeBusOrTrolleybus.Size = new System.Drawing.Size(283, 278);
            this.groupBoxTakeBusOrTrolleybus.TabIndex = 3;
            this.groupBoxTakeBusOrTrolleybus.TabStop = false;
            // 
            // pictureBoxTakeBus
            // 
            this.pictureBoxTakeBus.Location = new System.Drawing.Point(4, 105);
            this.pictureBoxTakeBus.Name = "pictureBoxTakeBus";
            this.pictureBoxTakeBus.Size = new System.Drawing.Size(270, 163);
            this.pictureBoxTakeBus.TabIndex = 3;
            this.pictureBoxTakeBus.TabStop = false;
            // 
            // TakeBusOrTrolleybus
            // 
            this.TakeBusOrTrolleybus.Location = new System.Drawing.Point(59, 58);
            this.TakeBusOrTrolleybus.Name = "TakeBusOrTrolleybus";
            this.TakeBusOrTrolleybus.Size = new System.Drawing.Size(171, 41);
            this.TakeBusOrTrolleybus.TabIndex = 2;
            this.TakeBusOrTrolleybus.Text = "Забрать";
            this.TakeBusOrTrolleybus.UseVisualStyleBackColor = true;
            this.TakeBusOrTrolleybus.Click += new System.EventHandler(this.buttonTakeBus_Click);
            // 
            // maskedTextBoxTakeBusOrTrolleybus
            // 
            this.maskedTextBoxTakeBusOrTrolleybus.Location = new System.Drawing.Point(59, 32);
            this.maskedTextBoxTakeBusOrTrolleybus.Name = "maskedTextBoxTakeBusOrTrolleybus";
            this.maskedTextBoxTakeBusOrTrolleybus.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBoxTakeBusOrTrolleybus.TabIndex = 1;
            // 
            // labelTakeBusOrTrolleybus
            // 
            this.labelTakeBusOrTrolleybus.AutoSize = true;
            this.labelTakeBusOrTrolleybus.Location = new System.Drawing.Point(56, 16);
            this.labelTakeBusOrTrolleybus.Name = "labelTakeBusOrTrolleybus";
            this.labelTakeBusOrTrolleybus.Size = new System.Drawing.Size(174, 13);
            this.labelTakeBusOrTrolleybus.TabIndex = 0;
            this.labelTakeBusOrTrolleybus.Text = "Забрать автобус или троллейбус";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(1277, 24);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(241, 121);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // menuStripSaveOrLoadFile
            // 
            this.menuStripSaveOrLoadFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripSaveOrLoadFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripSaveOrLoadFile.Name = "menuStripSaveOrLoadFile";
            this.menuStripSaveOrLoadFile.Size = new System.Drawing.Size(1543, 24);
            this.menuStripSaveOrLoadFile.TabIndex = 5;
            this.menuStripSaveOrLoadFile.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 640);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxTakeBusOrTrolleybus);
            this.Controls.Add(this.buttonCreateTrolleybus);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStripSaveOrLoadFile);
            this.MainMenuStrip = this.menuStripSaveOrLoadFile;
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeBusOrTrolleybus.ResumeLayout(false);
            this.groupBoxTakeBusOrTrolleybus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeBus)).EndInit();
            this.menuStripSaveOrLoadFile.ResumeLayout(false);
            this.menuStripSaveOrLoadFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonCreateTrolleybus;
        private System.Windows.Forms.GroupBox groupBoxTakeBusOrTrolleybus;
        private System.Windows.Forms.PictureBox pictureBoxTakeBus;
        private System.Windows.Forms.Button TakeBusOrTrolleybus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTakeBusOrTrolleybus;
        private System.Windows.Forms.Label labelTakeBusOrTrolleybus;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.MenuStrip menuStripSaveOrLoadFile;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}