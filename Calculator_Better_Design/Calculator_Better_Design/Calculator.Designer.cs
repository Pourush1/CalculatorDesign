using System;

namespace Calculator_Better_Design
{
  partial class Calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.decimal_point = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.square_root = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(32, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 23);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 23);
            this.button4.TabIndex = 3;
            this.button4.Tag = "4";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 4;
            this.button5.Tag = "5";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 23);
            this.button6.TabIndex = 5;
            this.button6.Tag = "6";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(89, 142);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 23);
            this.button7.TabIndex = 6;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(89, 181);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 23);
            this.button8.TabIndex = 7;
            this.button8.Tag = "8";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(132, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 23);
            this.button9.TabIndex = 8;
            this.button9.Tag = "9";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(132, 103);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(51, 23);
            this.button0.TabIndex = 9;
            this.button0.Tag = "0";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // decimal_point
            // 
            this.decimal_point.Location = new System.Drawing.Point(132, 142);
            this.decimal_point.Name = "decimal_point";
            this.decimal_point.Size = new System.Drawing.Size(51, 62);
            this.decimal_point.TabIndex = 10;
            this.decimal_point.Tag = ".";
            this.decimal_point.Text = ".";
            this.decimal_point.UseVisualStyleBackColor = true;
            this.decimal_point.Click += new System.EventHandler(this.decimal_point_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(199, 62);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(43, 23);
            this.add.TabIndex = 12;
            this.add.Tag = "+";
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(199, 103);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(43, 23);
            this.subtract.TabIndex = 13;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(199, 142);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(43, 23);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(199, 181);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(43, 23);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(32, 234);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(302, 39);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(32, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(302, 20);
            this.display.TabIndex = 17;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
           // this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // square_root
            // 
            this.square_root.Location = new System.Drawing.Point(259, 62);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(75, 23);
            this.square_root.TabIndex = 18;
            this.square_root.Tag = "sqr_root";
            this.square_root.Text = "√";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.square_root_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.Location = new System.Drawing.Point(259, 103);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(75, 23);
            this.reciprocal.TabIndex = 19;
            this.reciprocal.Tag = "1/x";
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(259, 142);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 62);
            this.equals.TabIndex = 20;
            this.equals.Tag = "=";
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(431, 67);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(0, 13);
            this.history.TabIndex = 21;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.history);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.display);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.decimal_point);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Calculator";
            this.Text = "Calculator";
       //     this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

      

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button decimal_point;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label history;
    }
}

