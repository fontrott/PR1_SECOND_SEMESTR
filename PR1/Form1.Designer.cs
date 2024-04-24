namespace PR1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Расчеты = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.close_1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.result_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculation_button_1 = new System.Windows.Forms.Button();
            this.input_Data = new System.Windows.Forms.TextBox();
            this.initial_Data_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.initial_Data_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Файл = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программыРасчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation_button_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.close_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Расчеты.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Файл.SuspendLayout();
            this.меню.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Расчеты
            // 
            this.Расчеты.Controls.Add(this.tabPage1);
            this.Расчеты.Location = new System.Drawing.Point(0, 27);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.SelectedIndex = 0;
            this.Расчеты.Size = new System.Drawing.Size(614, 422);
            this.Расчеты.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(606, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox3.Controls.Add(this.close_1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.result_2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.result_1);
            this.groupBox3.Location = new System.Drawing.Point(314, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 250);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат:";
            // 
            // close_1
            // 
            this.close_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_1.Location = new System.Drawing.Point(78, 176);
            this.close_1.Name = "close_1";
            this.close_1.Size = new System.Drawing.Size(148, 26);
            this.close_1.TabIndex = 8;
            this.close_1.Text = "Выход";
            this.close_1.UseVisualStyleBackColor = false;
            this.close_1.Click += new System.EventHandler(this.close1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена, ₽:";
            // 
            // result_2
            // 
            this.result_2.Location = new System.Drawing.Point(126, 71);
            this.result_2.Name = "result_2";
            this.result_2.ReadOnly = true;
            this.result_2.Size = new System.Drawing.Size(125, 20);
            this.result_2.TabIndex = 5;
            this.result_2.TextChanged += new System.EventHandler(this.result2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время печати, час:";
            // 
            // result_1
            // 
            this.result_1.Location = new System.Drawing.Point(126, 37);
            this.result_1.Name = "result_1";
            this.result_1.ReadOnly = true;
            this.result_1.Size = new System.Drawing.Size(125, 20);
            this.result_1.TabIndex = 1;
            this.result_1.TextChanged += new System.EventHandler(this.result1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.calculation_button_1);
            this.groupBox2.Controls.Add(this.input_Data);
            this.groupBox2.Controls.Add(this.initial_Data_1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.initial_Data_2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные:";
            // 
            // calculation_button_1
            // 
            this.calculation_button_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculation_button_1.Location = new System.Drawing.Point(72, 176);
            this.calculation_button_1.Name = "calculation_button_1";
            this.calculation_button_1.Size = new System.Drawing.Size(148, 26);
            this.calculation_button_1.TabIndex = 7;
            this.calculation_button_1.Text = "Выполнить расчёт!";
            this.calculation_button_1.UseVisualStyleBackColor = false;
            this.calculation_button_1.Click += new System.EventHandler(this.calculation_1);
            // 
            // input_Data
            // 
            this.input_Data.Location = new System.Drawing.Point(190, 97);
            this.input_Data.Name = "input_Data";
            this.input_Data.Size = new System.Drawing.Size(95, 20);
            this.input_Data.TabIndex = 7;
            this.input_Data.TextChanged += new System.EventHandler(this.inputData);
            // 
            // initial_Data_1
            // 
            this.initial_Data_1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.initial_Data_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.initial_Data_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initial_Data_1.Location = new System.Drawing.Point(190, 41);
            this.initial_Data_1.Name = "initial_Data_1";
            this.initial_Data_1.ReadOnly = true;
            this.initial_Data_1.Size = new System.Drawing.Size(95, 13);
            this.initial_Data_1.TabIndex = 6;
            this.initial_Data_1.Text = "500 листов/час";
            this.initial_Data_1.TextChanged += new System.EventHandler(this.initialData1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Цена за 1 лист:";
            // 
            // initial_Data_2
            // 
            this.initial_Data_2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.initial_Data_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.initial_Data_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initial_Data_2.Location = new System.Drawing.Point(190, 71);
            this.initial_Data_2.Name = "initial_Data_2";
            this.initial_Data_2.ReadOnly = true;
            this.initial_Data_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.initial_Data_2.Size = new System.Drawing.Size(95, 13);
            this.initial_Data_2.TabIndex = 0;
            this.initial_Data_2.Text = "12₽";
            this.initial_Data_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.initial_Data_2.TextChanged += new System.EventHandler(this.initialData2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите количество листов, \r\nкоторое необходимо распечатать:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Принтер печатает со скоростью: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                                           Здравствуйте! \r\n  Данн" +
    "ая программа поможет вам с расчётом времени печати и стоимости услуги.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Файл
            // 
            this.Файл.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычислитьToolStripMenuItem});
            this.Файл.Name = "contextMenuStrip1";
            this.Файл.Size = new System.Drawing.Size(136, 26);
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программыРасчетыToolStripMenuItem});
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // программыРасчетыToolStripMenuItem
            // 
            this.программыРасчетыToolStripMenuItem.Name = "программыРасчетыToolStripMenuItem";
            this.программыРасчетыToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.программыРасчетыToolStripMenuItem.Text = "Программы \"Расчеты\"";
            // 
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.Ivory;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(614, 24);
            this.меню.TabIndex = 2;
            this.меню.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculate,
            this.clear,
            this.close_2});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.fileClick);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Ivory;
            this.calculate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation_button_2});
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 22);
            this.calculate.Text = "Вычислить";
            // 
            // calculation_button_2
            // 
            this.calculation_button_2.BackColor = System.Drawing.Color.Ivory;
            this.calculation_button_2.Name = "calculation_button_2";
            this.calculation_button_2.Size = new System.Drawing.Size(179, 22);
            this.calculation_button_2.Text = "Выполнить расчёт!";
            this.calculation_button_2.Click += new System.EventHandler(this.calculation_2);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Ivory;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 22);
            this.clear.Text = "Очистить";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close_2
            // 
            this.close_2.BackColor = System.Drawing.Color.Ivory;
            this.close_2.Name = "close_2";
            this.close_2.Size = new System.Drawing.Size(135, 22);
            this.close_2.Text = "Выход";
            this.close_2.Click += new System.EventHandler(this.close2_Click);
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgram});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(65, 20);
            this.reference.Text = "Справка";
            this.reference.Click += new System.EventHandler(this.reference_Click);
            // 
            // aboutTheProgram
            // 
            this.aboutTheProgram.BackColor = System.Drawing.Color.Ivory;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            this.aboutTheProgram.Click += new System.EventHandler(this.aboutTheProgramClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 452);
            this.Controls.Add(this.меню);
            this.Controls.Add(this.Расчеты);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.меню;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печатное издание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Расчеты.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Файл.ResumeLayout(false);
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Расчеты;
        private System.Windows.Forms.ContextMenuStrip Файл;
        private System.Windows.Forms.ToolStripMenuItem вычислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программыРасчетыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem calculation_button_2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem close_2;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox result_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox input_Data;
        private System.Windows.Forms.TextBox initial_Data_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculation_button_1;
        private System.Windows.Forms.Button close_1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox initial_Data_2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

