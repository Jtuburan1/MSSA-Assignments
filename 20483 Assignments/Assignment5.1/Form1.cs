namespace Assignment5._1
{
    public partial class CalculatorWindow : Form
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }
        int startingNumber;
        int result;
        int caseNumber;
        public class Calculator : ICalculator
        {
            public int Addition(int firstNum, int secondNum)
            {
                return firstNum + secondNum;
            }

            public int Subtraction(int firstNum, int secondNum)
            {
                return firstNum - secondNum;
            }

            public int Multiplication(int firstNum, int secondNum)
            {
                return firstNum * secondNum;
            }

            public int Division(int firstNum, int secondNum)
            {
                return firstNum / secondNum;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            startingNumber = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            caseNumber = 4;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            startingNumber = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            caseNumber = 3;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            startingNumber = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            caseNumber = 2;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            startingNumber = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            caseNumber = 1;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            EqualsButton(caseNumber);
        }

        private void EqualsButton(int caseNumber)
        {
            switch(caseNumber)
            {
                case 1:
                    Calculator subtract = new Calculator();
                    result = subtract.Subtraction(startingNumber, int.Parse(textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;
                case 2:
                    Calculator add = new Calculator();
                    result = add.Addition(startingNumber, int.Parse(textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;
                case 3:
                    Calculator multiply = new Calculator();
                    result = multiply.Multiplication(startingNumber, int.Parse(textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;
                case 4:
                    Calculator divide = new Calculator();
                    result = divide.Division(startingNumber, int.Parse(textBox1.Text));
                    textBox1.Text = result.ToString();
                    break;
                default:
                    textBox1.Text = "You can only perform a function on 2 numbers.";
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}