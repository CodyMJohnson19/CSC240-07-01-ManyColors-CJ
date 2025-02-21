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
            SuspendLayout();
            // 
            // redButton
            // 
            redButton.AutoSize = true;
            redButton.Location = new Point(35, 32);
            redButton.Name = "redButton";
            redButton.Size = new Size(67, 29);
            redButton.TabIndex = 0;
            redButton.TabStop = true;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.CheckedChanged += redButton_CheckedChanged;
            // 
            // yellowButton
            // 
            yellowButton.AutoSize = true;
            yellowButton.Location = new Point(35, 67);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(86, 29);
            yellowButton.TabIndex = 1;
            yellowButton.TabStop = true;
            yellowButton.Text = "Yellow";
            yellowButton.UseVisualStyleBackColor = true;
            yellowButton.CheckedChanged += yellowButton_CheckedChanged;
            // 
            // blueButton
            // 
            blueButton.AutoSize = true;
            blueButton.Location = new Point(35, 102);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(70, 29);
            blueButton.TabIndex = 2;
            blueButton.TabStop = true;
            blueButton.Text = "Blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.CheckedChanged += blueButton_CheckedChanged;
            // 
            // greenButton
            // 
            greenButton.AutoSize = true;
            greenButton.Location = new Point(35, 137);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(83, 29);
            greenButton.TabIndex = 3;
            greenButton.TabStop = true;
            greenButton.Text = "Green";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.CheckedChanged += greenButton_CheckedChanged;
            // 
            // purpleButton
            // 
            purpleButton.AutoSize = true;
            purpleButton.Location = new Point(35, 172);
            purpleButton.Name = "purpleButton";
            purpleButton.Size = new Size(87, 29);
            purpleButton.TabIndex = 4;
            purpleButton.TabStop = true;
            purpleButton.Text = "Purple";
            purpleButton.UseVisualStyleBackColor = true;
            purpleButton.CheckedChanged += purpleButton_CheckedChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(154, 32);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(112, 34);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // colorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(278, 243);
            Controls.Add(resetButton);
            Controls.Add(purpleButton);
            Controls.Add(greenButton);
            Controls.Add(blueButton);
            Controls.Add(yellowButton);
            Controls.Add(redButton);
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
    }
}
