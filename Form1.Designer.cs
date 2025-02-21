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
            resetButton = new Button();
            checkedColorCombo = new CheckedListBox();
            mergeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(113, 69);
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
            checkedColorCombo.Location = new Point(12, 32);
            checkedColorCombo.Name = "checkedColorCombo";
            checkedColorCombo.Size = new Size(91, 114);
            checkedColorCombo.TabIndex = 6;
            checkedColorCombo.SelectedIndexChanged += checkedColorCombo_SelectedIndexChanged;
            // 
            // mergeButton
            // 
            mergeButton.Location = new Point(109, 32);
            mergeButton.Name = "mergeButton";
            mergeButton.Size = new Size(94, 29);
            mergeButton.TabIndex = 7;
            mergeButton.Text = "Merge";
            mergeButton.UseVisualStyleBackColor = true;
            mergeButton.Click += mergeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 8;
            label1.Text = "Pick up to 2 colors!";
            // 
            // colorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(238, 159);
            Controls.Add(label1);
            Controls.Add(mergeButton);
            Controls.Add(checkedColorCombo);
            Controls.Add(resetButton);
            Margin = new Padding(2);
            Name = "colorForm";
            Text = "Color App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button resetButton;
        private CheckedListBox checkedColorCombo;
        private Button mergeButton;
        private Label label1;
    }
}
