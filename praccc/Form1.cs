using System.Data;

namespace praccc
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            AppendNumber("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            AppendNumber("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            AppendNumber("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            AppendNumber("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            AppendNumber("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            AppendNumber("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            AppendNumber("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            AppendNumber("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            AppendNumber("9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            AppendNumber("0");
        }

        private void AppendNumber(string number)
        {
            if (textBox1.Text == "0" || string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text += number;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AppendOperator("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            AppendOperator("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            AppendOperator("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            AppendOperator("/");
        }

        private void AppendOperator(string op)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !IsOperatorAtEnd(textBox1.Text))
            {
                textBox1.Text += op;
                Operation = op;
            }
        }

        private bool IsOperatorAtEnd(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            char lastChar = text[text.Length - 1];
            return lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/';
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = 0;
            Operation = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                var result = new DataTable().Compute(expression, null);
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }
    }
}
