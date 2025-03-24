namespace SickFuckingCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            equals = new Button();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            openParenthesis = new Button();
            clear = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            zero = new Button();
            backspace = new Button();
            point = new Button();
            percent = new Button();
            textbox = new TextBox();
            closingParenthesis = new Button();
            SuspendLayout();
            // 
            // equals
            // 
            equals.Font = new Font("Segoe UI", 32F);
            equals.Location = new Point(247, 410);
            equals.Name = "equals";
            equals.Size = new Size(72, 72);
            equals.TabIndex = 0;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 32F);
            plus.Location = new Point(247, 332);
            plus.Name = "plus";
            plus.Size = new Size(72, 72);
            plus.TabIndex = 1;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 32F);
            minus.Location = new Point(247, 254);
            minus.Name = "minus";
            minus.Size = new Size(72, 72);
            minus.TabIndex = 2;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 32F);
            multiply.ImageAlign = ContentAlignment.BottomCenter;
            multiply.Location = new Point(247, 176);
            multiply.Name = "multiply";
            multiply.Size = new Size(72, 72);
            multiply.TabIndex = 3;
            multiply.Text = "*";
            multiply.TextAlign = ContentAlignment.BottomCenter;
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 20F);
            divide.Location = new Point(247, 98);
            divide.Name = "divide";
            divide.Size = new Size(72, 72);
            divide.TabIndex = 4;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // openParenthesis
            // 
            openParenthesis.Font = new Font("Segoe UI", 20F);
            openParenthesis.Location = new Point(90, 98);
            openParenthesis.Name = "openParenthesis";
            openParenthesis.Size = new Size(35, 72);
            openParenthesis.TabIndex = 6;
            openParenthesis.Text = "(";
            openParenthesis.UseVisualStyleBackColor = true;
            openParenthesis.Click += openParenthesis_Click;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 24F);
            clear.Location = new Point(12, 98);
            clear.Name = "clear";
            clear.Size = new Size(72, 72);
            clear.TabIndex = 7;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // nine
            // 
            nine.BackColor = SystemColors.Info;
            nine.Font = new Font("Segoe UI", 24F);
            nine.Location = new Point(168, 176);
            nine.Name = "nine";
            nine.Size = new Size(72, 72);
            nine.TabIndex = 8;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.BackColor = SystemColors.Info;
            eight.Font = new Font("Segoe UI", 24F);
            eight.Location = new Point(90, 176);
            eight.Name = "eight";
            eight.Size = new Size(72, 72);
            eight.TabIndex = 9;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.BackColor = SystemColors.Info;
            seven.Font = new Font("Segoe UI", 24F);
            seven.Location = new Point(12, 176);
            seven.Name = "seven";
            seven.Size = new Size(72, 72);
            seven.TabIndex = 10;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // six
            // 
            six.BackColor = SystemColors.Info;
            six.Font = new Font("Segoe UI", 24F);
            six.Location = new Point(168, 254);
            six.Name = "six";
            six.Size = new Size(72, 72);
            six.TabIndex = 11;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // five
            // 
            five.BackColor = SystemColors.Info;
            five.Font = new Font("Segoe UI", 24F);
            five.Location = new Point(90, 254);
            five.Name = "five";
            five.Size = new Size(72, 72);
            five.TabIndex = 12;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // four
            // 
            four.BackColor = SystemColors.Info;
            four.Font = new Font("Segoe UI", 24F);
            four.Location = new Point(12, 254);
            four.Name = "four";
            four.Size = new Size(72, 72);
            four.TabIndex = 13;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // three
            // 
            three.BackColor = SystemColors.Info;
            three.Font = new Font("Segoe UI", 24F);
            three.Location = new Point(168, 332);
            three.Name = "three";
            three.Size = new Size(72, 72);
            three.TabIndex = 14;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // two
            // 
            two.BackColor = SystemColors.Info;
            two.Font = new Font("Segoe UI", 24F);
            two.Location = new Point(90, 332);
            two.Name = "two";
            two.Size = new Size(72, 72);
            two.TabIndex = 15;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // one
            // 
            one.BackColor = SystemColors.Info;
            one.Font = new Font("Segoe UI", 24F);
            one.Location = new Point(12, 332);
            one.Name = "one";
            one.Size = new Size(72, 72);
            one.TabIndex = 16;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // zero
            // 
            zero.BackColor = SystemColors.Info;
            zero.Font = new Font("Segoe UI", 24F);
            zero.Location = new Point(90, 410);
            zero.Name = "zero";
            zero.Size = new Size(72, 72);
            zero.TabIndex = 17;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // backspace
            // 
            backspace.Font = new Font("Segoe UI", 24F);
            backspace.Location = new Point(168, 410);
            backspace.Name = "backspace";
            backspace.Size = new Size(72, 72);
            backspace.TabIndex = 18;
            backspace.Text = "⇐";
            backspace.UseVisualStyleBackColor = true;
            backspace.Click += backspace_Click;
            // 
            // point
            // 
            point.Font = new Font("Segoe UI", 24F);
            point.Location = new Point(12, 410);
            point.Name = "point";
            point.Size = new Size(72, 72);
            point.TabIndex = 19;
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            point.Click += point_Click;
            // 
            // percent
            // 
            percent.Font = new Font("Segoe UI", 24F);
            percent.Location = new Point(168, 98);
            percent.Name = "percent";
            percent.Size = new Size(72, 72);
            percent.TabIndex = 20;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            percent.Click += percent_Click;
            // 
            // textbox
            // 
            textbox.Font = new Font("Segoe UI", 24F);
            textbox.Location = new Point(12, 15);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.ReadOnly = true;
            textbox.Size = new Size(307, 58);
            textbox.TabIndex = 25;
            textbox.TabStop = false;
            textbox.TextAlign = HorizontalAlignment.Right;
            textbox.TextChanged += textbox_TextChanged;
            // 
            // closingParenthesis
            // 
            closingParenthesis.Enabled = false;
            closingParenthesis.Font = new Font("Segoe UI", 20F);
            closingParenthesis.Location = new Point(127, 98);
            closingParenthesis.Name = "closingParenthesis";
            closingParenthesis.Size = new Size(35, 72);
            closingParenthesis.TabIndex = 28;
            closingParenthesis.Text = ")";
            closingParenthesis.TextAlign = ContentAlignment.MiddleRight;
            closingParenthesis.UseVisualStyleBackColor = true;
            closingParenthesis.Click += closingParenthesis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 506);
            Controls.Add(closingParenthesis);
            Controls.Add(textbox);
            Controls.Add(percent);
            Controls.Add(point);
            Controls.Add(backspace);
            Controls.Add(zero);
            Controls.Add(one);
            Controls.Add(two);
            Controls.Add(three);
            Controls.Add(four);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(seven);
            Controls.Add(eight);
            Controls.Add(nine);
            Controls.Add(clear);
            Controls.Add(openParenthesis);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(equals);
            Name = "Form1";
            Text = "Sick fucking calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button equals;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button openParenthesis;
        private Button clear;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button six;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button one;
        private Button zero;
        private Button backspace;
        private Button point;
        private Button percent;
        private TextBox textbox;
        private Button closingParenthesis;
    }
}
