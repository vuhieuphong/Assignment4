using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class BMICalculator : Form
    {
        public string outputString { get; set; }
        public bool decimalExists { get; set; }
        public float outputValue { get; set; }
        public bool heightTextBoxClicked { get; set; }
        public bool weightTextBoxClicked { get; set; }
        public bool imperialRadioChecked { get; set; }
        public float bmi { get; set; }

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int buttonValue;
            bool resultCondition = int.TryParse(tag, out buttonValue);
            if (resultCondition)
            {
                int maxSize = 3;
                if (decimalExists)
                {
                    maxSize = 5;
                }
                if ((outputString != "0") && (ResultLabel.Text.Count() < maxSize))
                {
                    outputString += tag;
                    ResultLabel.Text = outputString;
                }
                if(outputString=="0")
                {
                    outputString = string.Empty;
                }
            }
            //if the user pressed a button that is not a number
            if (!resultCondition)
            {
                switch (tag)
                {
                    case "clear":
                        ClearNumericKeyboard();
                        break;
                    case "back":
                        removeLastCharacterFromResultLabel();
                        break;
                    case "done":
                        finalizeOutput();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
        }
        /// <summary>
        /// this method adds a decimal to the result label
        /// </summary>
        private void addDecimalToResultLabel()
        {
            if (!decimalExists)
            {
                if (ResultLabel.Text == "0")
                {                   
                    outputString = "0";
                }
                outputString += ".";
                decimalExists = true;
            }
        }
        /// <summary>
        /// this method finalizes the calculation for the label
        /// </summary>
        private void finalizeOutput()
        {
            if (outputString == string.Empty)
            {
                outputString = "0";
            }
            outputValue = float.Parse(outputString);
            if(heightTextBoxClicked==true)
            {
                HeightTextBox.Text = outputValue.ToString();
                heightTextBoxClicked = false;
            }
            if(weightTextBoxClicked==true)
            {
                WeightTextBox.Text = outputValue.ToString();
                weightTextBoxClicked = false;
            }
            ClearNumericKeyboard();
            CalculatorButtonTableLayoutPanel.Visible = false;
        }
        /// <summary>
        /// this method removes the last character from the result label
        /// </summary>
        private void removeLastCharacterFromResultLabel()
        {
            if (outputString.Length > 0)
            {
                var lastChar = outputString.Substring(outputString.Length - 1);
                if (lastChar == ".")
                {
                    decimalExists = false;
                }
                outputString = outputString.Remove(outputString.Length - 1);
                if (outputString.Length == 0)
                {
                    ResultLabel.Text = "0";
                    outputString = string.Empty;
                }
                else
                {
                    ResultLabel.Text = outputString;
                }
                
            }
        }
        /// <summary>
        /// this method clears the numeric keyboard
        /// </summary>
        private void ClearNumericKeyboard()
        {
            ResultLabel.Text = "0";
            outputString = string.Empty;
            decimalExists = false;
            outputValue = 0.0f;
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
        }

        private void HeightTextBox_Click(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            CalculatorButtonTableLayoutPanel.Visible = true;
            heightTextBoxClicked = true;
            weightTextBoxClicked = false;
        }

        private void WeightTextBox_Click(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
            CalculatorButtonTableLayoutPanel.Visible = true;
            weightTextBoxClicked = true;
            heightTextBoxClicked = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            WeightTextBox.Text = string.Empty;
            HeightTextBox.Text = string.Empty;
            BMITextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            CalculatorButtonTableLayoutPanel.Visible = false;
            BMIProgressBar.Value = 0;
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            imperialRadioChecked = true;          
            HeightLabel.Text = "Height(in)";
            WeightLabel.Text = "Weight(lb)";
            BMITextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            BMIProgressBar.Value = 0;
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            imperialRadioChecked = false;
            HeightLabel.Text = "Height(m)";
            WeightLabel.Text = "Weight(kg)";
            BMITextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            BMIProgressBar.Value = 0;
        }
        
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            float _height;
            float _weight;
            bool _heightValid = float.TryParse(HeightTextBox.Text, out _height);
            bool _weightValid = float.TryParse(WeightTextBox.Text, out _weight);

            if (_heightValid && _weightValid)
            {
                if (imperialRadioChecked == true)
                {
                    bmi = _weight * 703 / _height / _height;
                    BMITextBox.Text = Math.Round(bmi, 1).ToString();
                    bmiProgressBarDisplay();
                }
                if (imperialRadioChecked == false)
                {
                    bmi = _weight / _height / _height;
                    BMITextBox.Text = Math.Round(bmi, 1).ToString();
                    bmiProgressBarDisplay();
                }
                resultDisplay();
            }
            if(!_heightValid||!_weightValid)
            {
                BMITextBox.Text = string.Empty;
                ResultTextBox.Text = string.Empty;
                BMIProgressBar.Value = 0;
            }
        }

        private void bmiProgressBarDisplay()
        {
            if((int)Math.Round(bmi)>30)
            {
                bmi = 30;
            }
            if ((int)Math.Round(bmi) < 0)
            {
                bmi = 0;
            }
            BMIProgressBar.Value = (int)Math.Round(bmi);

        }

        private void resultDisplay()
        {
            if (bmi < 18.5)
            {
                ResultTextBox.Text = "Underweight";              
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                ResultTextBox.Text = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                ResultTextBox.Text = "Overweight";
            }
            else if (bmi >= 30)
            {
                ResultTextBox.Text = "Obese";
            }
        }
        //this is the validation for the textbox when pressing a key
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch==46&&HeightTextBox.Text.IndexOf(".")!=-1)
            {
                e.Handled = true;
            }
            if(!char.IsDigit(ch)&& ch!=8&&ch!=46)
            {
                e.Handled = true;
            }
            if(HeightTextBox.Text.Length>=3&&ch!=8&&ch!=46&& HeightTextBox.Text.IndexOf(".") == -1)
            {
                e.Handled = true;
            }
            if (HeightTextBox.Text.Length >= 5 && ch != 8 && HeightTextBox.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
            }
            if(HeightTextBox.Text==string.Empty&&ch==46)
            {
                e.Handled = true;
            }
            if(HeightTextBox.Text=="0"&&ch==48)
            {
                e.Handled = true;
            }
            if(HeightTextBox.Text=="0"&&ch!=48&&ch!=46)
            {
                HeightTextBox.Text = string.Empty;
            }
        }

        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && WeightTextBox.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            if (WeightTextBox.Text.Length >= 3 && ch != 8 && ch != 46 && WeightTextBox.Text.IndexOf(".") == -1)
            {
                e.Handled = true;
            }
            if (WeightTextBox.Text.Length >= 5 && ch != 8 && WeightTextBox.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
            }
            if (WeightTextBox.Text == string.Empty && ch == 46)
            {
                e.Handled = true;
            }
            if (WeightTextBox.Text == "0" && ch == 48)
            {
                e.Handled = true;
            }
            if (WeightTextBox.Text == "0" && ch != 48 && ch != 46)
            {
                WeightTextBox.Text = string.Empty;
            }
        }
    }
}
