﻿namespace Controller
{
    partial class Intro
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
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Location = new Point(177, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(447, 130);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(429, 306);
            button2.Name = "button2";
            button2.Size = new Size(101, 44);
            button2.TabIndex = 5;
            button2.Text = "종료";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(265, 306);
            button1.Name = "button1";
            button1.Size = new Size(101, 44);
            button1.TabIndex = 4;
            button1.Text = "출력";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Intro";
            Text = "Intro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}