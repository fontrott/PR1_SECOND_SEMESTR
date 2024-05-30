namespace PR333333333
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Close2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation_button_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.FillMatrixButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatrixSizeTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.btn_Close1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Расчеты = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangeTheMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.меню.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Расчеты.SuspendLayout();
            this.SuspendLayout();
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
            this.aboutTheProgram.BackColor = System.Drawing.Color.GhostWhite;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            // 
            // btn_Close2
            // 
            this.btn_Close2.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Close2.Name = "btn_Close2";
            this.btn_Close2.Size = new System.Drawing.Size(180, 22);
            this.btn_Close2.Text = "Выход";
            this.btn_Close2.Click += new System.EventHandler(this.btn_Close2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.GhostWhite;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 22);
            this.clear.Text = "Очистить";
            // 
            // calculation_button_2
            // 
            this.calculation_button_2.BackColor = System.Drawing.Color.GhostWhite;
            this.calculation_button_2.Name = "calculation_button_2";
            this.calculation_button_2.Size = new System.Drawing.Size(178, 22);
            this.calculation_button_2.Text = "Подсчитать буквы!";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.GhostWhite;
            this.calculate.Checked = true;
            this.calculate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.calculate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation_button_2});
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(180, 22);
            this.calculate.Text = "Вычислить";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculate,
            this.clear,
            this.btn_Close2});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.GhostWhite;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(578, 24);
            this.меню.TabIndex = 12;
            this.меню.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "                                                        Здравствуйте! \r\n  В этой " +
    "программе вы сможете подсчитать количество  букв, введенных в строку!\r\n";
            // 
            // FillMatrixButton
            // 
            this.FillMatrixButton.BackColor = System.Drawing.Color.GhostWhite;
            this.FillMatrixButton.Location = new System.Drawing.Point(12, 446);
            this.FillMatrixButton.Name = "FillMatrixButton";
            this.FillMatrixButton.Size = new System.Drawing.Size(116, 26);
            this.FillMatrixButton.TabIndex = 7;
            this.FillMatrixButton.Text = "Создать матрицу!";
            this.FillMatrixButton.UseVisualStyleBackColor = false;
            this.FillMatrixButton.Click += new System.EventHandler(this.FillMatrixButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите размерность матрицы:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // MatrixSizeTextBox
            // 
            this.MatrixSizeTextBox.Location = new System.Drawing.Point(12, 420);
            this.MatrixSizeTextBox.Name = "MatrixSizeTextBox";
            this.MatrixSizeTextBox.Size = new System.Drawing.Size(244, 20);
            this.MatrixSizeTextBox.TabIndex = 9;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.BackColor = System.Drawing.Color.LightPink;
            this.groupBoxMatrix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxMatrix.Location = new System.Drawing.Point(3, 81);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(564, 320);
            this.groupBoxMatrix.TabIndex = 5;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Исходные данные:";
            // 
            // btn_Close1
            // 
            this.btn_Close1.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_Close1.Location = new System.Drawing.Point(359, 467);
            this.btn_Close1.Name = "btn_Close1";
            this.btn_Close1.Size = new System.Drawing.Size(148, 26);
            this.btn_Close1.TabIndex = 8;
            this.btn_Close1.Text = "Выход";
            this.btn_Close1.UseVisualStyleBackColor = false;
            this.btn_Close1.Click += new System.EventHandler(this.btn_Close1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.btn_ChangeTheMatrix);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.MatrixSizeTextBox);
            this.tabPage1.Controls.Add(this.btn_Close1);
            this.tabPage1.Controls.Add(this.FillMatrixButton);
            this.tabPage1.Controls.Add(this.groupBoxMatrix);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(570, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            // 
            // Расчеты
            // 
            this.Расчеты.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Расчеты.Controls.Add(this.tabPage1);
            this.Расчеты.ItemSize = new System.Drawing.Size(0, 1);
            this.Расчеты.Location = new System.Drawing.Point(0, 27);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.SelectedIndex = 0;
            this.Расчеты.Size = new System.Drawing.Size(578, 518);
            this.Расчеты.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Расчеты.TabIndex = 11;
            this.Расчеты.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // btn_ChangeTheMatrix
            // 
            this.btn_ChangeTheMatrix.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_ChangeTheMatrix.Location = new System.Drawing.Point(140, 446);
            this.btn_ChangeTheMatrix.Name = "btn_ChangeTheMatrix";
            this.btn_ChangeTheMatrix.Size = new System.Drawing.Size(116, 26);
            this.btn_ChangeTheMatrix.TabIndex = 11;
            this.btn_ChangeTheMatrix.Text = "Изменить матрицу!";
            this.btn_ChangeTheMatrix.UseVisualStyleBackColor = false;
            this.btn_ChangeTheMatrix.Click += new System.EventHandler(this.btn_ChangeTheMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 547);
            this.Controls.Add(this.меню);
            this.Controls.Add(this.Расчеты);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Расчеты.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
        private System.Windows.Forms.ToolStripMenuItem btn_Close2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem calculation_button_2;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FillMatrixButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MatrixSizeTextBox;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.Button btn_Close1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Расчеты;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangeTheMatrix;
    }
}

