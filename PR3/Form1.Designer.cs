﻿namespace PR3
{
    partial class Scrabble
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
            this.Расчеты = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.close_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_English_Select = new System.Windows.Forms.Button();
            this.button_Russian_Select = new System.Windows.Forms.Button();
            this.calculation_button_1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_Data1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation_button_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.close_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.Расчеты.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.меню.SuspendLayout();
            this.SuspendLayout();
            // 
            // Расчеты
            // 
            this.Расчеты.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Расчеты.Controls.Add(this.tabPage1);
            this.Расчеты.ItemSize = new System.Drawing.Size(0, 1);
            this.Расчеты.Location = new System.Drawing.Point(0, 27);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.SelectedIndex = 0;
            this.Расчеты.Size = new System.Drawing.Size(516, 365);
            this.Расчеты.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Расчеты.TabIndex = 5;
            this.Расчеты.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(508, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
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
            this.close_1.BackColor = System.Drawing.Color.Cornsilk;
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
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подсчитанные очки:";
            // 
            // result_1
            // 
            this.result_1.Location = new System.Drawing.Point(31, 55);
            this.result_1.Name = "result_1";
            this.result_1.ReadOnly = true;
            this.result_1.Size = new System.Drawing.Size(187, 20);
            this.result_1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_English_Select);
            this.groupBox2.Controls.Add(this.button_Russian_Select);
            this.groupBox2.Controls.Add(this.calculation_button_1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.input_Data1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 266);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите язык:";
            // 
            // button_English_Select
            // 
            this.button_English_Select.BackColor = System.Drawing.Color.Cornsilk;
            this.button_English_Select.Location = new System.Drawing.Point(39, 53);
            this.button_English_Select.Name = "button_English_Select";
            this.button_English_Select.Size = new System.Drawing.Size(75, 23);
            this.button_English_Select.TabIndex = 7;
            this.button_English_Select.Text = "Английский\r\n\r\n";
            this.button_English_Select.UseVisualStyleBackColor = false;
            this.button_English_Select.Click += new System.EventHandler(this.button_English_Select_Click);
            // 
            // button_Russian_Select
            // 
            this.button_Russian_Select.BackColor = System.Drawing.Color.Cornsilk;
            this.button_Russian_Select.Location = new System.Drawing.Point(139, 53);
            this.button_Russian_Select.Name = "button_Russian_Select";
            this.button_Russian_Select.Size = new System.Drawing.Size(75, 23);
            this.button_Russian_Select.TabIndex = 8;
            this.button_Russian_Select.Text = "Русский";
            this.button_Russian_Select.UseVisualStyleBackColor = false;
            this.button_Russian_Select.Click += new System.EventHandler(this.button_Russian_Select_Click);
            // 
            // calculation_button_1
            // 
            this.calculation_button_1.BackColor = System.Drawing.Color.Cornsilk;
            this.calculation_button_1.Location = new System.Drawing.Point(51, 213);
            this.calculation_button_1.Name = "calculation_button_1";
            this.calculation_button_1.Size = new System.Drawing.Size(148, 26);
            this.calculation_button_1.TabIndex = 7;
            this.calculation_button_1.Text = "Подсчитать очки!";
            this.calculation_button_1.UseVisualStyleBackColor = false;
            this.calculation_button_1.Click += new System.EventHandler(this.calculation_button_1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите слово:";
            // 
            // input_Data1
            // 
            this.input_Data1.Location = new System.Drawing.Point(39, 119);
            this.input_Data1.Name = "input_Data1";
            this.input_Data1.Size = new System.Drawing.Size(175, 20);
            this.input_Data1.TabIndex = 9;
            this.input_Data1.TextChanged += new System.EventHandler(this.input_Data1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
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
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                   Здравствуйте! \r\nВ этой программе вы можете пои" +
    "грать в игру \"Scrabble\"!";
            // 
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.Cornsilk;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(518, 24);
            this.меню.TabIndex = 6;
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
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Cornsilk;
            this.calculate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation_button_2});
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 22);
            this.calculate.Text = "Вычислить";
            // 
            // calculation_button_2
            // 
            this.calculation_button_2.BackColor = System.Drawing.Color.Cornsilk;
            this.calculation_button_2.Name = "calculation_button_2";
            this.calculation_button_2.Size = new System.Drawing.Size(171, 22);
            this.calculation_button_2.Text = "Подсчитать очки!";
            this.calculation_button_2.Click += new System.EventHandler(this.calculation_button_2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Cornsilk;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 22);
            this.clear.Text = "Очистить";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close_2
            // 
            this.close_2.BackColor = System.Drawing.Color.Cornsilk;
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
            this.aboutTheProgram.BackColor = System.Drawing.Color.Cornsilk;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            this.aboutTheProgram.Click += new System.EventHandler(this.aboutTheProgram_Click);
            // 
            // Scrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 404);
            this.Controls.Add(this.Расчеты);
            this.Controls.Add(this.меню);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scrabble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrabble";
            this.Расчеты.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Расчеты;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button close_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calculation_button_1;
        private System.Windows.Forms.TextBox input_Data1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem calculation_button_2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem close_2;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_English_Select;
        private System.Windows.Forms.Button button_Russian_Select;
    }
}

