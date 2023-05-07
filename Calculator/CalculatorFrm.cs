namespace Calculator
{
    public partial class CalculatorFrm : Form
    {
        private decimal saveOperand = 0;
        private char saveOperation = ' ';
        private bool isDecimal = false;
        private bool isOperand = false;

        public CalculatorFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {


                if (saveOperation != ' ')
                {
                    decimal currentOperand = decimal.Parse(result.Text);

                    if (saveOperation == '+')
                        saveOperand += currentOperand;

                    if (saveOperation == '-')
                        saveOperand -= currentOperand;

                    if (saveOperation == '*')
                        saveOperand *= currentOperand;

                    if (saveOperation == '/')
                    {
                        if (currentOperand != 0)
                        {
                            saveOperand /= currentOperand;
                        }
                        else
                        {
                            result.Text = "Divide can't zero";

                            saveOperand = 0;
                            saveOperation = ' ';

                            isDecimal = false;
                            isOperand = false;
                            return;
                        }
                    }

                    isDecimal = false;
                    isOperand = true;

                    result.Text = saveOperand.ToString();

                    saveOperation = ' ';
                    operationLabel.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {

            if (isOperand || result.Text == "0")
            {
                isOperand = false;

                result.Text = ((Button)sender).Text;

            }
            else
            {
                result.Text += ((Button)sender).Text;
            }
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!isDecimal)
            {
                result.Text += ".";
                isDecimal = true;
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            try
            {
                char operationChar = ((Button)sender).Text[0];
                if (saveOperation != ' ')
                {
                    Equal_Click(sender, e);
                }
                saveOperand = decimal.Parse(result.Text);
                saveOperation = operationChar;
                operationLabel.Text = ((Button)sender).Text;

                isDecimal = false;
                isOperand = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TabControl)sender).SelectedIndex == 0)
            {
                try
                {
                    string binaryNumber = result.Text;
                    int decimalNumber = Convert.ToInt32(binaryNumber, 2);
                    result.Text = decimalNumber.ToString();

                    isDecimal = false;
                    isOperand = true;
                }
                catch (Exception)
                {
                    result.Text = "Error";

                    isDecimal = false;
                    isOperand = true;
                }
            }
            if (((TabControl)sender).SelectedIndex == 1)
            {
                try
                {
                    int decimalNumber = int.Parse(result.Text);
                    if (decimalNumber >= 0)
                    {
                        result.Text = Convert.ToString(decimalNumber, 2);

                        isDecimal = false;
                        isOperand = true;
                    }
                    else
                    {
                        result.Text = "Error";

                        isDecimal = false;
                        isOperand = true;
                    }
                }
                catch (Exception)
                {
                    result.Text = "Error";

                    isDecimal = false;
                    isOperand = true;
                }
            }
            if (((TabControl)sender).SelectedIndex == 2)
            {
                try
                {
                    if (Decimal.TryParse(result.Text, out Decimal decValue))
                    {
                        string locValue = "";
                        int baseValue = 2;
                        while (decValue > 0)
                        {
                            Decimal remainder = decValue % baseValue;
                            locValue = remainder.ToString() + locValue;
                            decValue = (decValue - remainder) / baseValue;
                            baseValue++;
                        }
                        result.Text = locValue;
                    }
                    else
                    {
                        result.Text = "Error";
                    }

                    isDecimal = false;
                    isOperand = true;
                }
                catch (Exception)
                {
                    result.Text = "Error";

                    isDecimal = false;
                    isOperand = true;
                }
            }
        }
    }
}