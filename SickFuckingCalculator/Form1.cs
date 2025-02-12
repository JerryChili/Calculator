using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SickFuckingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // THIS DICTIONARY DEFINES OPERATOR PRECEDENCES AND FUNCTIONS
        static Dictionary<string, (int precedence, Func<double, double, double> operation)> OPERATORS = new Dictionary<string, (int, Func<double, double, double>)>
        {
            { "+", (1, (a, b) => a + b) },
            { "-", (1, (a, b) => a - b) },
            { "*", (2, (a, b) => a * b) },
            { "/", (2, (a, b) => a / b) },
            { "%", (2, (a, b) => (a * b) / 100) } // For example: "50% of 200" -> 100

        };

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
            // 4. Calculate
            // 5. It just works

            // POSSIBLE IMPROVEMENTS
            // 1. Have each number button call one function, that gets the value from the button label. Instead of having one function for each of the buttons

            if (string.IsNullOrEmpty(textbox.Text)) return;

            try
            {
                double result = Evaluate(textbox.Text);
                textbox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        // Turns the given expression (input from textbox) into a list of "tokens" aka the thangs
        static List<string> Tokenize(string expression)
        {
            // Regular expression to match numbers (including decimals) and operators
            string pattern = @"\d+\.\d+|\d+|[%*/+\-()]";
            MatchCollection matches = Regex.Matches(expression.Replace(" ", ""), pattern);


            // Creates the list of "tokens" aka the expression split into individual numbers and operations
            // (like 50 + 5.1 * 2 turns into "50", "+", "5.1", "*", "2")
            List<string> tokens = new List<string>();
            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }

            // Insert "*" for implicit multiplication
            List<string> updatedTokens = new List<string>();
            for (int i = 0; i < tokens.Count; i++)
            {
                if (i > 0 &&
                    ((double.TryParse(tokens[i], out _) && tokens[i - 1] == ")") ||
                    (double.TryParse(tokens[i - 1], out _) && tokens[i] == "(") ||
                    (tokens[i - 1] == ")" && tokens[i] == "(")))
                {
                    updatedTokens.Add("*");
                }
                updatedTokens.Add(tokens[i]);
            }

            return updatedTokens;
        }

        static bool ValidateTokens(List<string> tokens)
        {
            if (tokens.Count == 0) return false; // Empty input

            int parenCount = 0;
            bool lastWasOperator = true; // Assume first token shouldnt be an operator (except '-')

            for (int i = 0; i < tokens.Count; i++)
            {
                string token = tokens[i];

                if (double.TryParse(token, out _)) // If its a number
                {
                    lastWasOperator = false;
                }
                else if (OPERATORS.ContainsKey(token)) // If its an operator
                {
                    if (lastWasOperator)
                    {
                        if (token == "-" && (i == 0 || tokens[i - 1] == "("))
                        {
                            // Allow "-" at the start or after "(" (e.g., "-5", "( -5 )")
                            lastWasOperator = false;
                        }
                        else
                        {
                            return false; // Prevent cases like "6 + * 3" or "* 4"
                        }
                    }
                    else
                    {
                        lastWasOperator = true;
                    }
                }
                else if (token == "(")
                {
                    parenCount++;
                    lastWasOperator = true;
                }
                else if (token == ")")
                {
                    parenCount--;
                    if (parenCount < 0) return false; // More closing parentheses than opening
                    lastWasOperator = false;
                }
                else
                {
                    return false; // Invalid character
                }
            }

            return parenCount == 0 && !lastWasOperator; // Ensure parentheses match & no hanging operator
        }

        static double Evaluate(string expression)
        {
            List<string> tokens = Tokenize(expression);
            if (!ValidateTokens(tokens))
            {
                throw new Exception("Syntax error!");
            }

            Stack<double> numStack = new Stack<double>();   // Stack for numbers
            Stack<string> opStack = new Stack<string>();    // Stack for operators

            void ApplyOperation()
            {
                if (numStack.Count < 2 || opStack.Count == 0) return;
                double b = numStack.Pop();  // Pop() removes item at the top of the stack, while returning it
                double a = numStack.Pop();
                string op = opStack.Pop();
                numStack.Push(OPERATORS[op].operation(a, b));
            }

            bool hasHigherPrecedence(string op1, string op2)
            {
                // Check if the first operation has a higher precedence than the other from the declared dictionary
                return OPERATORS.ContainsKey(op1) && OPERATORS.ContainsKey(op2) && OPERATORS[op1].precedence >= OPERATORS[op2].precedence;
            }

            for (int i = 0; i < tokens.Count; i++)
            {
                string token = tokens[i];

                if (double.TryParse(token, out double num)) // If token is a number
                {
                    numStack.Push(num);
                }
                else if (OPERATORS.ContainsKey(token))      // If token is an operator
                {
                    while (opStack.Count > 0 && opStack.Peek() != "(" && hasHigherPrecedence(opStack.Peek(), token)) // Peek() returns object at the top of the stack without removing it
                    {
                        ApplyOperation();
                    }
                    opStack.Push(token);
                }
                else if (token == "(") // If token is an opening parenthesis
                {
                    opStack.Push(token);
                }
                else if (token == ")") // If token is a closing parenthesis
                {
                    while(opStack.Count > 0 && opStack.Peek() != "(")
                    {
                        ApplyOperation();
                    }
                    opStack.Pop(); // Remove "("
                }
            }

            while (opStack.Count > 0) // Apply remaining operators
            {
                ApplyOperation();
            }

            return numStack.Count > 0 ? numStack.Pop() : 0; // Final result
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
            // or dont idrc it works anyway
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length > 0)
            {
                string expression = textbox.Text;                               // Put textbox text into a string
                textbox.Text = expression.Remove(expression.Length - 1);        // Then put it back into the textbox while having removed the last character
            }
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
                // Fix not being able to place point when using Clear or backspace
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
