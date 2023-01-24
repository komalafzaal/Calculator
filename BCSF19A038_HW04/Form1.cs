namespace BCSF19A038_HW04
{
    public partial class Calculator : Form
    {

        double num1, num2, result;
        string op = "";
        public Calculator()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if(inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "7";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "7";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "7";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "5";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "5";
            }
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputTextField.Text = inputTextField.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "3";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "3";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "2";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "1";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(inputTextField.Text == "0" && inputTextField.Text != null)
            {
                    inputTextField.Text = "6";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "4";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "4";
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "8";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "8";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (inputTextField.Text == "0" && inputTextField.Text != null)
            {
                inputTextField.Text = "9";
            }
            else
            {
                inputTextField.Text = inputTextField.Text + "9";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (result !=0)
            {
                num1 = result;
                inputTextField.Clear();
                op = "-";
            }
            else
            {
                num1 = double.Parse(inputTextField.Text);
                inputTextField.Clear();
                op = "-";
            }
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                inputTextField.Clear();
                op = "+";
            }
            else
            {
                num1 = double.Parse(inputTextField.Text);
                inputTextField.Clear();
                op = "+";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                inputTextField.Clear();
                op = "/";
            }
            else
            {
                num1 = double.Parse(inputTextField.Text);
                inputTextField.Clear();
                op = "/";
            }
                
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                num1 = result;
                inputTextField.Clear();
                op = "*";
            }
            else
            {
                num1 = double.Parse(inputTextField.Text);
                inputTextField.Clear();
                op = "*";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(inputTextField.Text);
            if (op == "-")
            {
                result = num1 - num2;
                outputTextField.Text = num1.ToString() + "-" + num2.ToString() + "=" + result.ToString();
                num1 = result;
            }
            else if (op == "+")
            {
                result = num1 + num2;
                outputTextField.Text = num1.ToString() + "+" + num2.ToString() + "=" + result.ToString();
                num1 = result;

            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    inputTextField.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (num1 / num2);
                    outputTextField.Text = num1.ToString() + "/" + num2.ToString() + "=" + result.ToString();
                    num1 = result;
                }
            }
            else if (op == "*")
            {
                result = num1 * num2;
                outputTextField.Text = num1.ToString() + "*" + num2.ToString() + "=" + result.ToString();
                num1 = result;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputTextField.Clear();
            outputTextField.Clear();
            result = 0;
            op = "";
        }
    }
}