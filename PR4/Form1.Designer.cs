﻿namespace PR4
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
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.close_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation_button_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Russian_Select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIsOnRoute1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtRouteNumber = new System.Windows.Forms.TextBox();
            this.close_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Расчеты = new System.Windows.Forms.TabControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.меню.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Расчеты.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutTheProgram
            // 
            this.aboutTheProgram.BackColor = System.Drawing.Color.Cornsilk;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            // 
            // close_2
            // 
            this.close_2.BackColor = System.Drawing.Color.Cornsilk;
            this.close_2.Name = "close_2";
            this.close_2.Size = new System.Drawing.Size(135, 22);
            this.close_2.Text = "Выход";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Cornsilk;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 22);
            this.clear.Text = "Очистить";
            // 
            // calculation_button_2
            // 
            this.calculation_button_2.BackColor = System.Drawing.Color.Cornsilk;
            this.calculation_button_2.Name = "calculation_button_2";
            this.calculation_button_2.Size = new System.Drawing.Size(171, 22);
            this.calculation_button_2.Text = "Подсчитать очки!";
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
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.Cornsilk;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(517, 24);
            this.меню.TabIndex = 8;
            this.меню.Text = "menuStrip1";
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgram});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(65, 20);
            this.reference.Text = "Справка";
            // 
            // button_Russian_Select
            // 
            this.button_Russian_Select.BackColor = System.Drawing.Color.Cornsilk;
            this.button_Russian_Select.Location = new System.Drawing.Point(50, 203);
            this.button_Russian_Select.Name = "button_Russian_Select";
            this.button_Russian_Select.Size = new System.Drawing.Size(116, 23);
            this.button_Russian_Select.TabIndex = 8;
            this.button_Russian_Select.Text = "Добавить автобус";
            this.button_Russian_Select.UseVisualStyleBackColor = false;
            this.button_Russian_Select.Click += new System.EventHandler(this.button_Russian_Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                       Здравствуйте! \r\n                   Это про" +
    "грамма для работы со списком, \r\nкоторый содержит информацию о наличии автобусов " +
    "в парке.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите номер автобуса:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox2.Controls.Add(this.chkIsOnRoute1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDriverName);
            this.groupBox2.Controls.Add(this.txtBusNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRouteNumber);
            this.groupBox2.Controls.Add(this.button_Russian_Select);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 310);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные:";
            // 
            // chkIsOnRoute1
            // 
            this.chkIsOnRoute1.AutoSize = true;
            this.chkIsOnRoute1.Location = new System.Drawing.Point(15, 151);
            this.chkIsOnRoute1.Name = "chkIsOnRoute1";
            this.chkIsOnRoute1.Size = new System.Drawing.Size(221, 17);
            this.chkIsOnRoute1.TabIndex = 16;
            this.chkIsOnRoute1.Text = "Автобус на маршруте (иначе - в парке)\r\n";
            this.chkIsOnRoute1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите номер маршрута автобуса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите ФИО водителя:";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(16, 87);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(197, 20);
            this.txtDriverName.TabIndex = 13;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Location = new System.Drawing.Point(16, 48);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(197, 20);
            this.txtBusNumber.TabIndex = 12;
            // 
            // txtRouteNumber
            // 
            this.txtRouteNumber.Location = new System.Drawing.Point(16, 125);
            this.txtRouteNumber.Name = "txtRouteNumber";
            this.txtRouteNumber.Size = new System.Drawing.Size(197, 20);
            this.txtRouteNumber.TabIndex = 9;
            // 
            // close_1
            // 
            this.close_1.BackColor = System.Drawing.Color.Cornsilk;
            this.close_1.Location = new System.Drawing.Point(50, 259);
            this.close_1.Name = "close_1";
            this.close_1.Size = new System.Drawing.Size(148, 26);
            this.close_1.TabIndex = 8;
            this.close_1.Text = "Выход";
            this.close_1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подсчитанные очки:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.close_1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(257, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 310);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(508, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Расчеты
            // 
            this.Расчеты.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Расчеты.Controls.Add(this.tabPage1);
            this.Расчеты.ItemSize = new System.Drawing.Size(0, 1);
            this.Расчеты.Location = new System.Drawing.Point(0, 27);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.SelectedIndex = 0;
            this.Расчеты.Size = new System.Drawing.Size(516, 420);
            this.Расчеты.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Расчеты.TabIndex = 7;
            this.Расчеты.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 186);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 448);
            this.Controls.Add(this.меню);
            this.Controls.Add(this.Расчеты);
            this.Name = "Form1";
            this.Text = "Form1";
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.Расчеты.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
        private System.Windows.Forms.ToolStripMenuItem close_2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem calculation_button_2;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.Button button_Russian_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRouteNumber;
        private System.Windows.Forms.Button close_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Расчеты;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsOnRoute1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

