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

            SetFormFocus();

        }

        private void Decimal_Click(object sender, EventArgs e)
        {


            if (!isDecimal)
            {
                result.Text += ".";
                isDecimal = true;
            }
            SetFormFocus();
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            SetFormFocus();

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

        private void CalculatorFrm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)

            {
                buttonNum0.PerformClick();
            }

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                buttonNum1.PerformClick();
            }

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                buttonNum2.PerformClick();
            }

            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                buttonNum3.PerformClick();
            }

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                buttonNum4.PerformClick();
            }

            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                buttonNum5.PerformClick();
            }

            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                buttonNum6.PerformClick();
            }

            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                buttonNum7.PerformClick();

            }

            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                buttonNum8.PerformClick();
            }

            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                buttonNum9.PerformClick();
            }

            if (e.KeyCode == Keys.Decimal || e.KeyCode==Keys.OemPeriod)
            {
                buttonDecimal.PerformClick();
            }

            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                Add.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                Sub.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                Mul.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                Divide.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {


                Equal.PerformClick();
            }
        }

        private void SetFormFocus()
        {
            foreach (Control control in this.Controls)
            {
                control.TabStop = false;
            }

            this.TabStop = true;


            this.ActiveControl = null;

            this.Focus();
        }
        private void CalculatorFrm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            SetFormFocus();
        }
    }
}