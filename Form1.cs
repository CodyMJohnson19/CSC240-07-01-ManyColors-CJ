namespace CSC240_06_02_FiveColors2_CJ
{
    public partial class colorForm : Form
    {
        public colorForm()
        {
            InitializeComponent();

        }

        private void blueButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            redButton.Checked = false;
            greenButton.Checked = false;
            yellowButton.Checked = false;
            purpleButton.Checked = false;
        }

        private void redButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            blueButton.Checked = false;
            greenButton.Checked = false;
            yellowButton.Checked = false;
            purpleButton.Checked = false;
        }

        private void yellowButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            blueButton.Checked = false;
            redButton.Checked = false;
            greenButton.Checked = false;
            purpleButton.Checked = false;
        }

        private void greenButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            blueButton.Checked = false;
            redButton.Checked = false;
            yellowButton.Checked = false;
            purpleButton.Checked = false;
        }

        private void purpleButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            blueButton.Checked = false;
            redButton.Checked = false;
            greenButton.Checked = false;
            yellowButton.Checked = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            blueButton.Checked = false;
            redButton.Checked = false;
            greenButton.Checked = false;
            yellowButton.Checked = false;
            purpleButton.Checked = false;
            this.BackColor = Color.White;
        }
    }
}
