﻿namespace _6._2
{
    partial class Form2
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
            this.virusName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // virusName2
            // 
            this.virusName2.Location = new System.Drawing.Point(72, 116);
            this.virusName2.Name = "virusName2";
            this.virusName2.ReadOnly = true;
            this.virusName2.Size = new System.Drawing.Size(247, 20);
            this.virusName2.TabIndex = 0;
            this.virusName2.TextChanged += new System.EventHandler(this.virusName2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 408);
            this.Controls.Add(this.virusName2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox virusName2;
    }
}