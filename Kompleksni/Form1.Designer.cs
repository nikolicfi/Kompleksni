﻿
namespace Kompleksni
{
    partial class Form1
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
            this.tbRe1 = new System.Windows.Forms.TextBox();
            this.tbIm1 = new System.Windows.Forms.TextBox();
            this.tbRe2 = new System.Windows.Forms.TextBox();
            this.tbIm2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbRez = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbRe1
            // 
            this.tbRe1.Location = new System.Drawing.Point(52, 73);
            this.tbRe1.Name = "tbRe1";
            this.tbRe1.Size = new System.Drawing.Size(67, 20);
            this.tbRe1.TabIndex = 0;
            this.tbRe1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbIm1
            // 
            this.tbIm1.Location = new System.Drawing.Point(144, 73);
            this.tbIm1.Name = "tbIm1";
            this.tbIm1.Size = new System.Drawing.Size(67, 20);
            this.tbIm1.TabIndex = 1;
            // 
            // tbRe2
            // 
            this.tbRe2.Location = new System.Drawing.Point(335, 73);
            this.tbRe2.Name = "tbRe2";
            this.tbRe2.Size = new System.Drawing.Size(67, 20);
            this.tbRe2.TabIndex = 2;
            this.tbRe2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbIm2
            // 
            this.tbIm2.Location = new System.Drawing.Point(426, 73);
            this.tbIm2.Name = "tbIm2";
            this.tbIm2.Size = new System.Drawing.Size(67, 20);
            this.tbIm2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prvi kompleksan broj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drugi kompleksan broj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(217, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "i";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(499, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "i";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.Location = new System.Drawing.Point(183, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button2.Location = new System.Drawing.Point(248, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button3.Location = new System.Drawing.Point(313, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbRez
            // 
            this.tbRez.Enabled = false;
            this.tbRez.Location = new System.Drawing.Point(52, 207);
            this.tbRez.Name = "tbRez";
            this.tbRez.Size = new System.Drawing.Size(441, 20);
            this.tbRez.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 245);
            this.Controls.Add(this.tbRez);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIm2);
            this.Controls.Add(this.tbRe2);
            this.Controls.Add(this.tbIm1);
            this.Controls.Add(this.tbRe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRe1;
        private System.Windows.Forms.TextBox tbIm1;
        private System.Windows.Forms.TextBox tbRe2;
        private System.Windows.Forms.TextBox tbIm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbRez;
    }
}

