namespace CSC240_06_02_FiveColors2_CJ
{
    partial class colorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            redButton = new RadioButton();
            yellowButton = new RadioButton();
            blueButton = new RadioButton();
            greenButton = new RadioButton();
            purpleButton = new RadioButton();
            resetButton = new Button();
            checkedColorCombo = new CheckedListBox();
            mergeButton = new Button();
            SuspendLayout();
            // 
            // redButton
            // 
            redButton.AutoSize = true;
            redButton.Location = new Point(28, 26);
            redButton.Margin = new Padding(2);
            redButton.Name = "redButton";
            redButton.Size = new Size(56, 24);
            redButton.TabIndex = 0;
            redButton.TabStop = true;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.CheckedChanged += redButton_CheckedChanged;
            // 
            // yellowButton
            // 
            yellowButton.AutoSize = true;
            yellowButton.Location = new Point(28, 54);
            yellowButton.Margin = new Padding(2);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(73, 24);
            yellowButton.TabIndex = 1;
            yellowButton.TabStop = true;
            yellowButton.Text = "Yellow";
            yellowButton.UseVisualStyleBackColor = true;
            yellowButton.CheckedChanged += yellowButton_CheckedChanged;
            // 
            // blueButton
            // 
            blueButton.AutoSize = true;
            blueButton.Location = new Point(28, 82);
            blueButton.Margin = new Padding(2);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(59, 24);
            blueButton.TabIndex = 2;
            blueButton.TabStop = true;
            blueButton.Text = "Blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.CheckedChanged += blueButton_CheckedChanged;
            // 
            // greenButton
            // 
            greenButton.AutoSize = true;
            greenButton.Location = new Point(28, 110);
            greenButton.Margin = new Padding(2);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(69, 24);
            greenButton.TabIndex = 3;
            greenButton.TabStop = true;
            greenButton.Text = "Green";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.CheckedChanged += greenButton_CheckedChanged;
            // 
            // purpleButton
            // 
            purpleButton.AutoSize = true;
            purpleButton.Location = new Point(28, 138);
            purpleButton.Margin = new Padding(2);
            purpleButton.Name = "purpleButton";
            purpleButton.Size = new Size(72, 24);
            purpleButton.TabIndex = 4;
            purpleButton.TabStop = true;
            purpleButton.Text = "Purple";
            purpleButton.UseVisualStyleBackColor = true;
            purpleButton.CheckedChanged += purpleButton_CheckedChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(123, 26);
            resetButton.Margin = new Padding(2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(90, 27);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // checkedColorCombo
            // 
            checkedColorCombo.FormattingEnabled = true;
            checkedColorCombo.Items.AddRange(new object[] { "Red", "Yellow", "Blue", "Green", "Purple" });
            checkedColorCombo.Location = new Point(28, 198);
            checkedColorCombo.Name = "checkedColorCombo";
            checkedColorCombo.Size = new Size(91, 114);
            checkedColorCombo.TabIndex = 6;
            checkedColorCombo.SelectedIndexChanged += checkedColorCombo_SelectedIndexChanged;
            // 
            // mergeButton
            // 
            mergeButton.Location = new Point(125, 198);
            mergeButton.Name = "mergeButton";
            mergeButton.Size = new Size(94, 29);
            mergeButton.TabIndex = 7;
            mergeButton.Text = "Merge";
            mergeButton.UseVisualStyleBackColor = true;
            mergeButton.Click += mergeButton_Click;
            // 
            // colorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(419, 358);
            Controls.Add(mergeButton);
            Controls.Add(checkedColorCombo);
            Controls.Add(resetButton);
            Controls.Add(purpleButton);
            Controls.Add(greenButton);
            Controls.Add(blueButton);
            Controls.Add(yellowButton);
            Controls.Add(redButton);
            Margin = new Padding(2);
            Name = "colorForm";
            Text = "Color App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton redButton;
        private RadioButton yellowButton;
        private RadioButton blueButton;
        private RadioButton greenButton;
        private RadioButton purpleButton;
        private Button resetButton;
        private CheckedListBox checkedColorCombo;
        private Button mergeButton;
    }
}
