namespace PR2
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation_button_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.close_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.close_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calculation_button_1 = new System.Windows.Forms.Button();
            this.input_Data = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Расчеты = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.меню.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Расчеты.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Linen;
            this.calculate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation_button_2});
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 22);
            this.calculate.Text = "Вычислить";
            // 
            // calculation_button_2
            // 
            this.calculation_button_2.BackColor = System.Drawing.Color.Linen;
            this.calculation_button_2.Name = "calculation_button_2";
            this.calculation_button_2.Size = new System.Drawing.Size(160, 22);
            this.calculation_button_2.Text = "Найти элемент!";
            this.calculation_button_2.Click += new System.EventHandler(this.calculation_button_2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Linen;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 22);
            this.clear.Text = "Очистить";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close_2
            // 
            this.close_2.BackColor = System.Drawing.Color.Linen;
            this.close_2.Name = "close_2";
            this.close_2.Size = new System.Drawing.Size(135, 22);
            this.close_2.Text = "Выход";
            this.close_2.Click += new System.EventHandler(this.close_2_Click);
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgram});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(65, 20);
            this.reference.Text = "Справка";
            // 
            // aboutTheProgram
            // 
            this.aboutTheProgram.BackColor = System.Drawing.Color.Linen;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            this.aboutTheProgram.Click += new System.EventHandler(this.aboutTheProgram_Click);
            // 
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.Linen;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(516, 24);
            this.меню.TabIndex = 4;
            this.меню.Text = "menuStrip1";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(508, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Controls.Add(this.close_1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.result_1);
            this.groupBox3.Location = new System.Drawing.Point(257, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат:";
            // 
            // close_1
            // 
            this.close_1.BackColor = System.Drawing.Color.Lavender;
            this.close_1.Location = new System.Drawing.Point(52, 213);
            this.close_1.Name = "close_1";
            this.close_1.Size = new System.Drawing.Size(148, 26);
            this.close_1.TabIndex = 8;
            this.close_1.Text = "Выход";
            this.close_1.UseVisualStyleBackColor = false;
            this.close_1.Click += new System.EventHandler(this.close_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Элемент списка, который в искали:";
            // 
            // result_1
            // 
            this.result_1.Location = new System.Drawing.Point(31, 64);
            this.result_1.Name = "result_1";
            this.result_1.ReadOnly = true;
            this.result_1.Size = new System.Drawing.Size(187, 20);
            this.result_1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.calculation_button_1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.input_Data);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 266);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите номер элемента списка:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculation_button_1
            // 
            this.calculation_button_1.BackColor = System.Drawing.Color.Lavender;
            this.calculation_button_1.Location = new System.Drawing.Point(55, 213);
            this.calculation_button_1.Name = "calculation_button_1";
            this.calculation_button_1.Size = new System.Drawing.Size(148, 26);
            this.calculation_button_1.TabIndex = 7;
            this.calculation_button_1.Text = "Найти элемент!";
            this.calculation_button_1.UseVisualStyleBackColor = false;
            this.calculation_button_1.Click += new System.EventHandler(this.calculation_button_1_Click);
            // 
            // input_Data
            // 
            this.input_Data.Location = new System.Drawing.Point(39, 64);
            this.input_Data.Name = "input_Data";
            this.input_Data.Size = new System.Drawing.Size(175, 20);
            this.input_Data.TabIndex = 7;
            this.input_Data.TextChanged += new System.EventHandler(this.input_Data_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Элементы списка:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                             Здравствуйте! \r\n  В этой программе в" +
    "ы можете найти n-ый элемент списка с конца\r\n";
            // 
            // Расчеты
            // 
            this.Расчеты.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Расчеты.Controls.Add(this.tabPage1);
            this.Расчеты.ItemSize = new System.Drawing.Size(0, 1);
            this.Расчеты.Location = new System.Drawing.Point(0, 28);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.SelectedIndex = 0;
            this.Расчеты.Size = new System.Drawing.Size(516, 386);
            this.Расчеты.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Расчеты.TabIndex = 3;
            this.Расчеты.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Location = new System.Drawing.Point(55, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 385);
            this.Controls.Add(this.меню);
            this.Controls.Add(this.Расчеты);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск элемента в списке";
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Расчеты.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem calculation_button_2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem close_2;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button close_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calculation_button_1;
        private System.Windows.Forms.TextBox input_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Расчеты;
        private System.Windows.Forms.Button button1;
    }
}

