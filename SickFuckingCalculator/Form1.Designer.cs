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
            preset = new Button();
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
            memoryclear = new Button();
            memoryreset = new Button();
            memoryplus = new Button();
            memoryminus = new Button();
            textbox = new TextBox();
            log = new Button();
            poweroften = new Button();
            closingParenthesis = new Button();
            SuspendLayout();
            // 
            // equals
            // 
            equals.Font = new Font("Segoe UI", 32F);
            equals.Location = new Point(894, 394);
            equals.Name = "equals";
            equals.Size = new Size(72, 148);
            equals.TabIndex = 0;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 32F);
            plus.Location = new Point(894, 316);
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
            minus.Location = new Point(894, 238);
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
            multiply.Location = new Point(893, 160);
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
            divide.Location = new Point(815, 160);
            divide.Name = "divide";
            divide.Size = new Size(72, 72);
            divide.TabIndex = 4;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // preset
            // 
            preset.Font = new Font("Segoe UI", 24F);
            preset.Location = new Point(242, 341);
            preset.Name = "preset";
            preset.Size = new Size(72, 72);
            preset.TabIndex = 5;
            preset.Text = "T";
            preset.UseVisualStyleBackColor = true;
            // 
            // openParenthesis
            // 
            openParenthesis.Font = new Font("Segoe UI", 20F);
            openParenthesis.Location = new Point(659, 160);
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
            clear.Location = new Point(581, 160);
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
            nine.Location = new Point(815, 238);
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
            eight.Location = new Point(737, 238);
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
            seven.Location = new Point(659, 238);
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
            six.Location = new Point(815, 316);
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
            five.Location = new Point(737, 316);
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
            four.Location = new Point(659, 316);
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
            three.Location = new Point(815, 394);
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
            two.Location = new Point(737, 394);
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
            one.Location = new Point(659, 394);
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
            zero.Location = new Point(737, 470);
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
            backspace.Location = new Point(815, 470);
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
            point.Location = new Point(659, 470);
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
            percent.Location = new Point(737, 160);
            percent.Name = "percent";
            percent.Size = new Size(72, 72);
            percent.TabIndex = 20;
            percent.Text = "%";
            percent.UseVisualStyleBackColor = true;
            percent.Click += percent_Click;
            // 
            // memoryclear
            // 
            memoryclear.Font = new Font("Segoe UI", 16F);
            memoryclear.Location = new Point(335, 341);
            memoryclear.Name = "memoryclear";
            memoryclear.Size = new Size(72, 72);
            memoryclear.TabIndex = 21;
            memoryclear.Text = "MC";
            memoryclear.UseVisualStyleBackColor = true;
            // 
            // memoryreset
            // 
            memoryreset.Font = new Font("Segoe UI", 16F);
            memoryreset.Location = new Point(581, 316);
            memoryreset.Name = "memoryreset";
            memoryreset.Size = new Size(72, 72);
            memoryreset.TabIndex = 22;
            memoryreset.Text = "MR";
            memoryreset.UseVisualStyleBackColor = true;
            // 
            // memoryplus
            // 
            memoryplus.Font = new Font("Segoe UI", 16F);
            memoryplus.Location = new Point(581, 394);
            memoryplus.Name = "memoryplus";
            memoryplus.Size = new Size(72, 72);
            memoryplus.TabIndex = 23;
            memoryplus.Text = "M+";
            memoryplus.UseVisualStyleBackColor = true;
            // 
            // memoryminus
            // 
            memoryminus.Font = new Font("Segoe UI", 16F);
            memoryminus.Location = new Point(581, 470);
            memoryminus.Name = "memoryminus";
            memoryminus.Size = new Size(72, 72);
            memoryminus.TabIndex = 24;
            memoryminus.Text = "M-";
            memoryminus.UseVisualStyleBackColor = true;
            // 
            // textbox
            // 
            textbox.Font = new Font("Segoe UI", 24F);
            textbox.Location = new Point(12, 77);
            textbox.Multiline = true;
            textbox.Name = "textbox";
            textbox.ReadOnly = true;
            textbox.Size = new Size(954, 58);
            textbox.TabIndex = 25;
            textbox.TextAlign = HorizontalAlignment.Right;
            textbox.TextChanged += textbox_TextChanged;
            // 
            // log
            // 
            log.Font = new Font("Segoe UI", 16F);
            log.Location = new Point(503, 160);
            log.Name = "log";
            log.Size = new Size(72, 72);
            log.TabIndex = 26;
            log.Text = "log";
            log.UseVisualStyleBackColor = true;
            // 
            // poweroften
            // 
            poweroften.Font = new Font("Segoe UI", 16F);
            poweroften.Location = new Point(503, 238);
            poweroften.Name = "poweroften";
            poweroften.Size = new Size(72, 72);
            poweroften.TabIndex = 27;
            poweroften.Text = "10^x";
            poweroften.UseVisualStyleBackColor = true;
            // 
            // closingParenthesis
            // 
            closingParenthesis.Enabled = false;
            closingParenthesis.Font = new Font("Segoe UI", 20F);
            closingParenthesis.Location = new Point(696, 160);
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
            ClientSize = new Size(978, 554);
            Controls.Add(closingParenthesis);
            Controls.Add(poweroften);
            Controls.Add(log);
            Controls.Add(textbox);
            Controls.Add(memoryminus);
            Controls.Add(memoryplus);
            Controls.Add(memoryreset);
            Controls.Add(memoryclear);
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
            Controls.Add(preset);
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
        private Button preset;
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
        private Button memoryclear;
        private Button memoryreset;
        private Button memoryplus;
        private Button memoryminus;
        private TextBox textbox;
        private Button log;
        private Button poweroften;
        private Button closingParenthesis;
    }
}
