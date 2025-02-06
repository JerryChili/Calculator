using System;
using System.Collections;
using System.Collections.Generic;

namespace SickFuckingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textbox.TabStop = false;
        }

        string previousOperation;
        // POSSIBLE VALUES
        // value
        // point
        // operation
        // percent
        // parenthesis
        // _______________


        string operationString;
        bool canPlacePoint = true;
        
        int open;       // This are for making sure parenthesis are placed properly


        private void equals_Click(object sender, EventArgs e)
        {
            // LOGICFLOW:
            // 1. Put textbox input into a variable
            // 2. Parse string into a readable format
            // 3. Check for errors (Bad syntax, open parenthesis, etc) (if my code works how i want it to, these situations are hard to make)

            // POSSIBLE IMPROVEMENTS
            // 1. Have each number button call one function, that gets the value from the button label. Instead of having one function for each of the buttons

            List<string> expression = new List<string>();
        }

        private void add(char input)
        {
            textbox.Text += input;
            if (Char.IsDigit(input))
            {
                previousOperation = "value";
            }
            else
            {
                switch (input)
                {
                    case '.':
                        previousOperation = "point";
                        canPlacePoint = false;
                        break;

                    case '+':
                        previousOperation = "operation";
                        canPlacePoint = true;
                        break;

                    case '-':
                        previousOperation = "operation";
                        canPlacePoint = true;
                        break;

                    case '*':
                        previousOperation = "operation";
                        canPlacePoint = true;
                        break;

                    case '/':
                        previousOperation = "operation";
                        canPlacePoint = true;
                        break;

                    case '%':
                        previousOperation = "percent";
                        canPlacePoint = true;
                        break;

                    case '(':
                        previousOperation = "parenthesis";
                        canPlacePoint = true;
                        break;
                }
            }
        }

        private void append(char operationChar) // Appends the current operator with another one (like changing a * to +)
        {
            char[] expressionC = textbox.Text.ToCharArray();        // Turn the textbox string into a chararray
            expressionC[expressionC.Length - 1] = operationChar;    // Replace last entry with the given operator
            string expression = new string(expressionC);            // Make the chararray a string
            textbox.Text = expression.ToString();                   // Put the string into the textbox
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('1');
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('2');
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('3');
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('4');
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('5');
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('6');
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('7');
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('8');
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('9');
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (previousOperation != "percent")
            {
                add('0');
            }
            // fix 0000.512
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            string expression = textbox.Text;                               // Put textbox text into a string
            textbox.Text = expression.Remove(expression.Length - 1);        // Then put it back into the textbox while having removed the last character
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            previousOperation = "";
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (previousOperation == "value" && canPlacePoint)
            {
                add('.');
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (previousOperation != "point" && previousOperation != "operation" && previousOperation != "")
            {
                add('+');
            }

            else if (previousOperation == "operation") // APPEND operation if one was already put in (turning a + into a - for example)
            {
                append('+');
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (previousOperation != "point" && previousOperation != "operation")
            {
                add('-');
            }

            else if (previousOperation == "operation") // APPEND operation if one was already put in (turning a + into a - for example)
            {
                append('-');
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            if (previousOperation != "point" && previousOperation != "operation" && previousOperation != "")
            {
                add('*');
            }

            else if (previousOperation == "operation") // APPEND operation if one was already put in (turning a + into a - for example)
            {
                append('*');
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (previousOperation != "point" && previousOperation != "operation" && previousOperation != "")
            {
                add('/');
            }

            else if (previousOperation == "operation") // APPEND operation if one was already put in (turning a + into a - for example)
            {
                append('/');
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (previousOperation == "value")
            {
                add('%');
            }
        }

        private void openParenthesis_Click(object sender, EventArgs e)
        {
            if(previousOperation != "point")
            {
                add('(');
                open++;
                closingParenthesis.Enabled = (open > 0) ? true : false;
            }
            
        }

        private void closingParenthesis_Click(object sender, EventArgs e)
        {
            if (previousOperation != "point")
            {
                add(')');
                open--;
                closingParenthesis.Enabled = (open > 0) ? true : false;
            }
        }
    }
}
