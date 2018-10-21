namespace Calculator.GUI
{
    partial class CalculatorGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorGUI));
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputLabel = new System.Windows.Forms.Label();
            this.enteredInputLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.equalsButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.changeSignButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addMemoryButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.subtractMemoryButton = new System.Windows.Forms.Button();
            this.retrieveHistoryButton = new System.Windows.Forms.Button();
            this.retrieveMemoryButton = new System.Windows.Forms.Button();
            this.clearMemoryButton = new System.Windows.Forms.Button();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputPanel.ColumnCount = 1;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputPanel.Controls.Add(this.inputLabel, 0, 1);
            this.inputPanel.Controls.Add(this.enteredInputLabel, 0, 0);
            this.inputPanel.Location = new System.Drawing.Point(12, 111);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 2;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.inputPanel.Size = new System.Drawing.Size(643, 127);
            this.inputPanel.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Roboto", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(3, 64);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(47, 52);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "0";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // enteredInputLabel
            // 
            this.enteredInputLabel.AutoSize = true;
            this.enteredInputLabel.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enteredInputLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.enteredInputLabel.Location = new System.Drawing.Point(3, 3);
            this.enteredInputLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.enteredInputLabel.Name = "enteredInputLabel";
            this.enteredInputLabel.Size = new System.Drawing.Size(34, 37);
            this.enteredInputLabel.TabIndex = 1;
            this.enteredInputLabel.Text = "0";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 4;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonsPanel.Controls.Add(this.equalsButton, 3, 6);
            this.buttonsPanel.Controls.Add(this.additionButton, 3, 5);
            this.buttonsPanel.Controls.Add(this.subtractionButton, 3, 4);
            this.buttonsPanel.Controls.Add(this.multiplicationButton, 3, 3);
            this.buttonsPanel.Controls.Add(this.divisionButton, 3, 2);
            this.buttonsPanel.Controls.Add(this.zeroButton, 1, 6);
            this.buttonsPanel.Controls.Add(this.dotButton, 0, 6);
            this.buttonsPanel.Controls.Add(this.nineButton, 2, 3);
            this.buttonsPanel.Controls.Add(this.eightButton, 1, 3);
            this.buttonsPanel.Controls.Add(this.sevenButton, 0, 3);
            this.buttonsPanel.Controls.Add(this.oneButton, 0, 5);
            this.buttonsPanel.Controls.Add(this.fourButton, 0, 4);
            this.buttonsPanel.Controls.Add(this.twoButton, 1, 5);
            this.buttonsPanel.Controls.Add(this.fiveButton, 1, 4);
            this.buttonsPanel.Controls.Add(this.threeButton, 2, 5);
            this.buttonsPanel.Controls.Add(this.sixButton, 2, 4);
            this.buttonsPanel.Controls.Add(this.changeSignButton, 2, 6);
            this.buttonsPanel.Controls.Add(this.clearAllButton, 0, 2);
            this.buttonsPanel.Controls.Add(this.clearButton, 1, 2);
            this.buttonsPanel.Controls.Add(this.deleteButton, 2, 2);
            this.buttonsPanel.Controls.Add(this.addMemoryButton, 0, 0);
            this.buttonsPanel.Controls.Add(this.percentButton, 3, 1);
            this.buttonsPanel.Controls.Add(this.subtractMemoryButton, 0, 1);
            this.buttonsPanel.Controls.Add(this.retrieveHistoryButton, 2, 0);
            this.buttonsPanel.Controls.Add(this.retrieveMemoryButton, 1, 0);
            this.buttonsPanel.Controls.Add(this.clearMemoryButton, 1, 1);
            this.buttonsPanel.Controls.Add(this.clearHistoryButton, 2, 1);
            this.buttonsPanel.Controls.Add(this.powerButton, 3, 0);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 244);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 7;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsPanel.Size = new System.Drawing.Size(643, 322);
            this.buttonsPanel.TabIndex = 1;
            // 
            // equalsButton
            // 
            this.equalsButton.AccessibleName = "Equals";
            this.equalsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equalsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equalsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.equalsButton.FlatAppearance.BorderSize = 0;
            this.equalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.equalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalsButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(484, 279);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(154, 40);
            this.equalsButton.TabIndex = 0;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.AccessibleName = "Addition";
            this.additionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.additionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.additionButton.FlatAppearance.BorderSize = 0;
            this.additionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additionButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionButton.Location = new System.Drawing.Point(484, 233);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(154, 40);
            this.additionButton.TabIndex = 33;
            this.additionButton.TabStop = false;
            this.additionButton.Text = "&+";
            this.additionButton.UseVisualStyleBackColor = false;
            this.additionButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.AccessibleName = "Subtraction";
            this.subtractionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtractionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.subtractionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.subtractionButton.FlatAppearance.BorderSize = 0;
            this.subtractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractionButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractionButton.Location = new System.Drawing.Point(484, 187);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(154, 40);
            this.subtractionButton.TabIndex = 32;
            this.subtractionButton.TabStop = false;
            this.subtractionButton.Text = "&-";
            this.subtractionButton.UseVisualStyleBackColor = false;
            this.subtractionButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.AccessibleName = "Multiplication";
            this.multiplicationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplicationButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplicationButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.multiplicationButton.FlatAppearance.BorderSize = 0;
            this.multiplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicationButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplicationButton.Location = new System.Drawing.Point(484, 141);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(154, 40);
            this.multiplicationButton.TabIndex = 31;
            this.multiplicationButton.TabStop = false;
            this.multiplicationButton.Text = "&*";
            this.multiplicationButton.UseVisualStyleBackColor = false;
            this.multiplicationButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.AccessibleName = "Division";
            this.divisionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divisionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divisionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.divisionButton.FlatAppearance.BorderSize = 0;
            this.divisionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divisionButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divisionButton.Location = new System.Drawing.Point(484, 95);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(154, 40);
            this.divisionButton.TabIndex = 30;
            this.divisionButton.TabStop = false;
            this.divisionButton.Text = "&/";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.AccessibleName = "0";
            this.zeroButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zeroButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroButton.FlatAppearance.BorderSize = 0;
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(163, 279);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(154, 40);
            this.zeroButton.TabIndex = 28;
            this.zeroButton.TabStop = false;
            this.zeroButton.Text = "&0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.AccessibleName = ".";
            this.dotButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dotButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dotButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.dotButton.FlatAppearance.BorderSize = 0;
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotButton.Location = new System.Drawing.Point(3, 279);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(154, 40);
            this.dotButton.TabIndex = 27;
            this.dotButton.TabStop = false;
            this.dotButton.Text = "&.";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.AccessibleName = "9";
            this.nineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nineButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineButton.FlatAppearance.BorderSize = 0;
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(323, 141);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(154, 40);
            this.nineButton.TabIndex = 13;
            this.nineButton.TabStop = false;
            this.nineButton.Text = "&9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.AccessibleName = "8";
            this.eightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightButton.FlatAppearance.BorderSize = 0;
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(163, 141);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(154, 40);
            this.eightButton.TabIndex = 12;
            this.eightButton.TabStop = false;
            this.eightButton.Text = "&8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.AccessibleName = "7";
            this.sevenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sevenButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sevenButton.FlatAppearance.BorderSize = 0;
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(3, 141);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(154, 40);
            this.sevenButton.TabIndex = 11;
            this.sevenButton.TabStop = false;
            this.sevenButton.Text = "&7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.AccessibleName = "1";
            this.oneButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oneButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneButton.FlatAppearance.BorderSize = 0;
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(3, 233);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(154, 40);
            this.oneButton.TabIndex = 23;
            this.oneButton.TabStop = false;
            this.oneButton.Text = "&1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.AccessibleName = "4";
            this.fourButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourButton.FlatAppearance.BorderSize = 0;
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(3, 187);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(154, 40);
            this.fourButton.TabIndex = 15;
            this.fourButton.TabStop = false;
            this.fourButton.Text = "&4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.AccessibleName = "2";
            this.twoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoButton.FlatAppearance.BorderSize = 0;
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(163, 233);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(154, 40);
            this.twoButton.TabIndex = 24;
            this.twoButton.TabStop = false;
            this.twoButton.Text = "&2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.AccessibleName = "5";
            this.fiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveButton.FlatAppearance.BorderSize = 0;
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(163, 187);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(154, 40);
            this.fiveButton.TabIndex = 16;
            this.fiveButton.TabStop = false;
            this.fiveButton.Text = "&5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.AccessibleName = "3";
            this.threeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeButton.FlatAppearance.BorderSize = 0;
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(323, 233);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(154, 40);
            this.threeButton.TabIndex = 25;
            this.threeButton.TabStop = false;
            this.threeButton.Text = "&3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.AccessibleName = "6";
            this.sixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixButton.FlatAppearance.BorderSize = 0;
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(323, 187);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(154, 40);
            this.sixButton.TabIndex = 17;
            this.sixButton.TabStop = false;
            this.sixButton.Text = "&6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // changeSignButton
            // 
            this.changeSignButton.AccessibleName = "ChangeSign";
            this.changeSignButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeSignButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.changeSignButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.changeSignButton.FlatAppearance.BorderSize = 0;
            this.changeSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSignButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSignButton.Location = new System.Drawing.Point(323, 279);
            this.changeSignButton.Name = "changeSignButton";
            this.changeSignButton.Size = new System.Drawing.Size(154, 40);
            this.changeSignButton.TabIndex = 20;
            this.changeSignButton.TabStop = false;
            this.changeSignButton.Text = "+/-";
            this.changeSignButton.UseVisualStyleBackColor = false;
            this.changeSignButton.Click += new System.EventHandler(this.ChangeSignButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearAllButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.clearAllButton.Location = new System.Drawing.Point(3, 95);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(154, 40);
            this.clearAllButton.TabIndex = 35;
            this.clearAllButton.TabStop = false;
            this.clearAllButton.Text = "CE";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AccessibleName = "Clear";
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(163, 95);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(154, 40);
            this.clearButton.TabIndex = 19;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleName = "Delete";
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(323, 95);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 40);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.TabStop = false;
            this.deleteButton.Text = "DEL";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addMemoryButton
            // 
            this.addMemoryButton.AccessibleName = "AddMemory";
            this.addMemoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addMemoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addMemoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.addMemoryButton.FlatAppearance.BorderSize = 0;
            this.addMemoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemoryButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMemoryButton.Location = new System.Drawing.Point(3, 3);
            this.addMemoryButton.Name = "addMemoryButton";
            this.addMemoryButton.Size = new System.Drawing.Size(154, 40);
            this.addMemoryButton.TabIndex = 7;
            this.addMemoryButton.TabStop = false;
            this.addMemoryButton.Text = "M+";
            this.addMemoryButton.UseVisualStyleBackColor = false;
            this.addMemoryButton.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // percentButton
            // 
            this.percentButton.AccessibleName = "Percent";
            this.percentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.percentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.percentButton.FlatAppearance.BorderSize = 0;
            this.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentButton.Location = new System.Drawing.Point(484, 49);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(154, 40);
            this.percentButton.TabIndex = 29;
            this.percentButton.TabStop = false;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // subtractMemoryButton
            // 
            this.subtractMemoryButton.AccessibleName = "SubtractMemory";
            this.subtractMemoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtractMemoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.subtractMemoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.subtractMemoryButton.FlatAppearance.BorderSize = 0;
            this.subtractMemoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subtractMemoryButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subtractMemoryButton.Location = new System.Drawing.Point(3, 49);
            this.subtractMemoryButton.Name = "subtractMemoryButton";
            this.subtractMemoryButton.Size = new System.Drawing.Size(154, 40);
            this.subtractMemoryButton.TabIndex = 8;
            this.subtractMemoryButton.TabStop = false;
            this.subtractMemoryButton.Text = "M-";
            this.subtractMemoryButton.UseVisualStyleBackColor = false;
            this.subtractMemoryButton.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // retrieveHistoryButton
            // 
            this.retrieveHistoryButton.AccessibleName = "RetrieveHistory";
            this.retrieveHistoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retrieveHistoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.retrieveHistoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.retrieveHistoryButton.FlatAppearance.BorderSize = 0;
            this.retrieveHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrieveHistoryButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retrieveHistoryButton.Location = new System.Drawing.Point(323, 3);
            this.retrieveHistoryButton.Name = "retrieveHistoryButton";
            this.retrieveHistoryButton.Size = new System.Drawing.Size(154, 40);
            this.retrieveHistoryButton.TabIndex = 2;
            this.retrieveHistoryButton.TabStop = false;
            this.retrieveHistoryButton.Text = "HR";
            this.retrieveHistoryButton.UseVisualStyleBackColor = false;
            this.retrieveHistoryButton.Click += new System.EventHandler(this.RetriveHistoryButton_Click);
            // 
            // retrieveMemoryButton
            // 
            this.retrieveMemoryButton.AccessibleName = "RetrieveMemory";
            this.retrieveMemoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retrieveMemoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.retrieveMemoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.retrieveMemoryButton.FlatAppearance.BorderSize = 0;
            this.retrieveMemoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retrieveMemoryButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retrieveMemoryButton.Location = new System.Drawing.Point(163, 3);
            this.retrieveMemoryButton.Name = "retrieveMemoryButton";
            this.retrieveMemoryButton.Size = new System.Drawing.Size(154, 40);
            this.retrieveMemoryButton.TabIndex = 9;
            this.retrieveMemoryButton.TabStop = false;
            this.retrieveMemoryButton.Text = "MR";
            this.retrieveMemoryButton.UseVisualStyleBackColor = false;
            this.retrieveMemoryButton.Click += new System.EventHandler(this.RetrieveMemoryButton_Click);
            // 
            // clearMemoryButton
            // 
            this.clearMemoryButton.AccessibleName = "ClearMemory";
            this.clearMemoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearMemoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearMemoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearMemoryButton.FlatAppearance.BorderSize = 0;
            this.clearMemoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearMemoryButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearMemoryButton.Location = new System.Drawing.Point(163, 49);
            this.clearMemoryButton.Name = "clearMemoryButton";
            this.clearMemoryButton.Size = new System.Drawing.Size(154, 40);
            this.clearMemoryButton.TabIndex = 10;
            this.clearMemoryButton.TabStop = false;
            this.clearMemoryButton.Text = "MC";
            this.clearMemoryButton.UseVisualStyleBackColor = false;
            this.clearMemoryButton.Click += new System.EventHandler(this.MemoryButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.AccessibleName = "ClearHistory";
            this.clearHistoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearHistoryButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearHistoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearHistoryButton.FlatAppearance.BorderSize = 0;
            this.clearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHistoryButton.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearHistoryButton.Location = new System.Drawing.Point(323, 49);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(154, 40);
            this.clearHistoryButton.TabIndex = 3;
            this.clearHistoryButton.TabStop = false;
            this.clearHistoryButton.Text = "HC";
            this.clearHistoryButton.UseVisualStyleBackColor = false;
            this.clearHistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.AccessibleName = "Pow";
            this.powerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.powerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.powerButton.FlatAppearance.BorderSize = 0;
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Roboto", 10.8F);
            this.powerButton.Location = new System.Drawing.Point(483, 3);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(157, 40);
            this.powerButton.TabIndex = 36;
            this.powerButton.TabStop = false;
            this.powerButton.Text = "^";
            this.powerButton.UseVisualStyleBackColor = false;
            this.powerButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // messagePanel
            // 
            this.messagePanel.Controls.Add(this.messageLabel);
            this.messagePanel.Location = new System.Drawing.Point(12, 63);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(643, 42);
            this.messagePanel.TabIndex = 2;
            this.messagePanel.Visible = false;
            this.messagePanel.VisibleChanged += new System.EventHandler(this.MessagePanel_VisibleChanged);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(3, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(92, 24);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "message";
            // 
            // messageTimer
            // 
            this.messageTimer.Tick += new System.EventHandler(this.MessageTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // CalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.inputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CalculatorGUI";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorGUI_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label enteredInputLabel;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.Button retrieveHistoryButton;
        private System.Windows.Forms.Button clearMemoryButton;
        private System.Windows.Forms.Button retrieveMemoryButton;
        private System.Windows.Forms.Button subtractMemoryButton;
        private System.Windows.Forms.Button addMemoryButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeSignButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

