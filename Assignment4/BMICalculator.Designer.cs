namespace Assignment4
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMITablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.CalculatorButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NineButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.BMITablePanel.SuspendLayout();
            this.CalculatorButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITablePanel
            // 
            this.BMITablePanel.ColumnCount = 2;
            this.BMITablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITablePanel.Controls.Add(this.ResetButton, 1, 3);
            this.BMITablePanel.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMITablePanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.BMITablePanel.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.BMITablePanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMITablePanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMITablePanel.Controls.Add(this.ResultTextBox, 1, 4);
            this.BMITablePanel.Controls.Add(this.BMITextBox, 0, 4);
            this.BMITablePanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.BMITablePanel.Controls.Add(this.HeightTextBox, 1, 1);
            this.BMITablePanel.Controls.Add(this.BMIProgressBar, 0, 5);
            this.BMITablePanel.Location = new System.Drawing.Point(0, 2);
            this.BMITablePanel.Name = "BMITablePanel";
            this.BMITablePanel.RowCount = 6;
            this.BMITablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.BMITablePanel.Size = new System.Drawing.Size(304, 243);
            this.BMITablePanel.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.Salmon;
            this.ResetButton.Font = new System.Drawing.Font("Arial", 18F);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(155, 123);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 34);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(155, 83);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(146, 38);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.Click += new System.EventHandler(this.WeightTextBox_Click);
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.ForeColor = System.Drawing.Color.Black;
            this.MetricRadioButton.Location = new System.Drawing.Point(155, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(146, 34);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(146, 34);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.WeightLabel.ForeColor = System.Drawing.Color.Black;
            this.WeightLabel.Location = new System.Drawing.Point(3, 80);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(146, 40);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "Weight(lb):";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.HeightLabel.ForeColor = System.Drawing.Color.Black;
            this.HeightLabel.Location = new System.Drawing.Point(3, 40);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(146, 40);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height(in):";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Arial", 15F);
            this.ResultTextBox.ForeColor = System.Drawing.Color.Black;
            this.ResultTextBox.Location = new System.Drawing.Point(155, 163);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(146, 34);
            this.ResultTextBox.TabIndex = 7;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMITextBox.BackColor = System.Drawing.Color.White;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.Color.Black;
            this.BMITextBox.Location = new System.Drawing.Point(3, 163);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(146, 38);
            this.BMITextBox.TabIndex = 6;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.MediumPurple;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Arial", 18F);
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 123);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(146, 34);
            this.CalculateBMIButton.TabIndex = 6;
            this.CalculateBMIButton.Text = "Calculate";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.Location = new System.Drawing.Point(155, 43);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(146, 38);
            this.HeightTextBox.TabIndex = 3;
            this.HeightTextBox.Click += new System.EventHandler(this.HeightTextBox_Click);
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightTextBox_KeyPress);
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMITablePanel.SetColumnSpan(this.BMIProgressBar, 2);
            this.BMIProgressBar.Location = new System.Drawing.Point(3, 203);
            this.BMIProgressBar.Maximum = 30;
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(298, 37);
            this.BMIProgressBar.TabIndex = 10;
            // 
            // CalculatorButtonTableLayoutPanel
            // 
            this.CalculatorButtonTableLayoutPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CalculatorButtonTableLayoutPanel.ColumnCount = 4;
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 0);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.ClearButton, 3, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.BackButton, 3, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.DoneButton, 3, 3);
            this.CalculatorButtonTableLayoutPanel.Font = new System.Drawing.Font("Arial", 20F);
            this.CalculatorButtonTableLayoutPanel.Location = new System.Drawing.Point(0, 248);
            this.CalculatorButtonTableLayoutPanel.Name = "CalculatorButtonTableLayoutPanel";
            this.CalculatorButtonTableLayoutPanel.RowCount = 5;
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorButtonTableLayoutPanel.Size = new System.Drawing.Size(304, 193);
            this.CalculatorButtonTableLayoutPanel.TabIndex = 1;
            this.CalculatorButtonTableLayoutPanel.Visible = false;
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.Font = new System.Drawing.Font("Arial", 18F);
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(155, 41);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(70, 32);
            this.NineButton.TabIndex = 1;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatorButtonTableLayoutPanel.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 24F);
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(298, 38);
            this.ResultLabel.TabIndex = 13;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.Font = new System.Drawing.Font("Arial", 18F);
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(79, 41);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(70, 32);
            this.EightButton.TabIndex = 4;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.Font = new System.Drawing.Font("Arial", 18F);
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 41);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(70, 32);
            this.SevenButton.TabIndex = 3;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.Font = new System.Drawing.Font("Arial", 18F);
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(79, 79);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(70, 32);
            this.FiveButton.TabIndex = 6;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.Font = new System.Drawing.Font("Arial", 18F);
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(155, 79);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(70, 32);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.Font = new System.Drawing.Font("Arial", 18F);
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 79);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(70, 32);
            this.FourButton.TabIndex = 2;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.Font = new System.Drawing.Font("Arial", 18F);
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 117);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(70, 32);
            this.OneButton.TabIndex = 7;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.Font = new System.Drawing.Font("Arial", 18F);
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(79, 117);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(70, 32);
            this.TwoButton.TabIndex = 10;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.Font = new System.Drawing.Font("Arial", 18F);
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(155, 117);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(70, 32);
            this.ThreeButton.TabIndex = 9;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 12F);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(231, 79);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(70, 32);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.Font = new System.Drawing.Font("Arial", 18F);
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(155, 155);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(70, 35);
            this.DecimalButton.TabIndex = 15;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackButton.BackgroundImage = global::Assignment4.Properties.Resources.backbutton;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(231, 41);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 32);
            this.BackButton.TabIndex = 16;
            this.BackButton.Tag = "back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CalculatorButtonTableLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Font = new System.Drawing.Font("Arial", 18F);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 155);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(146, 35);
            this.ZeroButton.TabIndex = 12;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.YellowGreen;
            this.DoneButton.Font = new System.Drawing.Font("Arial", 12F);
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(231, 117);
            this.DoneButton.Name = "DoneButton";
            this.CalculatorButtonTableLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(70, 73);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.CalculatorButtonTableLayoutPanel);
            this.Controls.Add(this.BMITablePanel);
            this.Font = new System.Drawing.Font("Arial", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculatorForm";
            this.BMITablePanel.ResumeLayout(false);
            this.BMITablePanel.PerformLayout();
            this.CalculatorButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITablePanel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TableLayoutPanel CalculatorButtonTableLayoutPanel;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
    }
}

