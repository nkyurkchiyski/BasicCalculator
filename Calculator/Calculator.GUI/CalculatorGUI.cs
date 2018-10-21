using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.App;

namespace Calculator.GUI
{
    public partial class CalculatorGUI : Form
    {
        private const string ErrorMessage = "ERROR";
        private const float VisibleTime = 5f;

        private float timeToShow;

        private bool newExpression;
        private bool returnResult;

        private string[] arguments;
        private BasicCalculator calculator;

        private string operationSymbol;
        private string number;
        private string operation;

        public CalculatorGUI()
        {
            InitializeComponent();
        }

        private void CalculatorGUI_Load(object sender, EventArgs e)
        {
            SetUpToolTips();

            this.newExpression = true;
            this.returnResult = false;

            this.timeToShow = VisibleTime;
            this.arguments = new string[3];
            this.calculator = new BasicCalculator();
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (this.returnResult)
            {
                GetResult();
            }
            else
            {
                this.operation = button.AccessibleName;
                this.arguments[0] = this.operation;
                this.arguments[1] = this.inputLabel.Text;

                this.enteredInputLabel.Text = this.inputLabel.Text + $" {button.Text}";
                this.operationSymbol = button.Text;
                this.newExpression = true;
                this.returnResult = true;
            }

        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (this.arguments.Count(x => x != null) > 1)
            {
                GetResult();
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.AccessibleName == "0" && this.inputLabel.Text == "0")
            {
                return;
            }

            if (newExpression)
            {
                this.inputLabel.Text = button.AccessibleName;
                newExpression = false;
            }
            else
            {
                if (this.inputLabel.Text == "0")
                {

                    this.inputLabel.Text = button.AccessibleName;
                }
                else
                {
                    this.inputLabel.Text += button.AccessibleName;
                }
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!this.inputLabel.Text.Contains("."))
            {
                this.inputLabel.Text += this.dotButton.AccessibleName;
                newExpression = false;
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            string command = GetCommand(sender);
            string result = this.calculator
                .ProcessInput(new string[] { command, this.operationSymbol });

            ShowMessage(result);
            this.operationSymbol = "";
        }

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            string command = GetCommand(sender);
            this.number = inputLabel.Text;
            string result = this.calculator
                .ProcessInput(new string[] { command, this.number });
            ShowMessage(result);
        }

        private void RetrieveMemoryButton_Click(object sender, EventArgs e)
        {
            string command = GetCommand(sender);
            string result = this.calculator.ProcessInput(new string[] { command });
            this.inputLabel.Text = result;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.inputLabel.Text = "0";
            this.newExpression = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.inputLabel.Text != "0")
            {
                this.inputLabel.Text = this.inputLabel.Text.Substring(0, this.inputLabel.Text.Length - 1);

                if (this.inputLabel.Text.Length == 0 || this.inputLabel.Text == "-")
                {
                    this.inputLabel.Text = "0";
                    this.newExpression = true;
                }
            }
        }

        private void ChangeSignButton_Click(object sender, EventArgs e)
        {
            string input = this.inputLabel.Text;
            if (input != "0")
            {
                if (input.Contains("-"))
                {
                    this.inputLabel.Text = input.Substring(1, input.Length - 1);
                }
                else
                {
                    this.inputLabel.Text = input.Insert(0, "-");
                }
            }
        }

        private void RetriveHistoryButton_Click(object sender, EventArgs e)
        {
            string command = GetCommand(sender);
            string result = this.calculator.ProcessInput(new string[] { command });

            if (result.Contains(ErrorMessage))
            {
                ShowMessage(result);
            }
            else
            {
                History history = new History(result);
                history.ShowDialog();
                history.Focus();
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            this.arguments = ClearArguments();
            this.inputLabel.Text = "0";
            this.enteredInputLabel.Text = "0";
        }

        private void MessageTimer_Tick(object sender, EventArgs e)
        {
            if (this.timeToShow > 0)
            {
                this.timeToShow -= 0.1f;
            }
            else
            {
                this.messagePanel.Visible = false;
                messageTimer.Stop();
            }

        }

        private void MessagePanel_VisibleChanged(object sender, EventArgs e)
        {
            this.timeToShow = VisibleTime;
            messageTimer.Start();
        }

        private string[] ClearArguments()
        {
            return new string[3];
        }

        private string[] CreateHistoryEntry(string[] args, string result)
        {
            List<string> temp = new List<string>(arguments);
            temp.Insert(0, "AddOperation");
            temp.Add(result);
            return temp.ToArray();
        }

        private void SetUpToolTips()
        {
            this.toolTip.SetToolTip(this.retrieveHistoryButton, "Retrieve History");
            this.toolTip.SetToolTip(this.clearHistoryButton, "Clear History");
            this.toolTip.SetToolTip(this.addMemoryButton, "Memory Add");
            this.toolTip.SetToolTip(this.subtractMemoryButton, "Memory Subtract");
            this.toolTip.SetToolTip(this.clearMemoryButton, "Clear Memory");
            this.toolTip.SetToolTip(this.retrieveMemoryButton, "Retrieve Memory");

        }

        private string GetCommand(object sender)
        {
            Button button = (Button)sender;
            return button.AccessibleName;
        }

        private void ShowMessage(string message)
        {
            this.messageLabel.Text = message;
            this.messagePanel.Visible = true;
        }

        private void GetResult()
        {
            this.enteredInputLabel.Text = "";
            this.arguments[2] = this.inputLabel.Text;
            string result = this.calculator.ProcessInput(this.arguments);

            if (result.Split().Length != 1)
            {
                ShowMessage(result);
            }
            else
            {
                this.inputLabel.Text = result;
                ShowMessage(this.calculator.ProcessInput(CreateHistoryEntry(this.arguments, this.inputLabel.Text)));
            }

            this.number = this.inputLabel.Text;
            this.arguments = ClearArguments();
            this.newExpression = true;
            this.returnResult = false;

        }
    }
}
