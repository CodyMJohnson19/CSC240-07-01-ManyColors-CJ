using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CSC240_06_02_FiveColors2_CJ
{
    public partial class colorForm : Form
    {
        public colorForm()
        {
            InitializeComponent();

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            checkedColorCombo.Enabled = true;
            this.BackColor = Color.White;
            for (int i = 0; i < checkedColorCombo.Items.Count; i++)
            {
                checkedColorCombo.SetItemChecked(i, false);
            }
                
        }

        private void checkedColorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedColorCombo.CheckedItems.Count >= 2)
            {
                checkedColorCombo.Enabled = false;
            }
            else
            {
                checkedColorCombo.Enabled = true;
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            string[] colorArray = {"Red", "Yellow", "Blue", "Green", "Purple"};
            bool redChecked = checkedColorCombo.CheckedItems.Contains(colorArray[0]);
            bool yellowChecked = checkedColorCombo.CheckedItems.Contains(colorArray[1]);
            bool blueChecked = checkedColorCombo.CheckedItems.Contains(colorArray[2]);
            bool greenChecked = checkedColorCombo.CheckedItems.Contains(colorArray[3]);
            bool purpleChecked = checkedColorCombo.CheckedItems.Contains(colorArray[4]);
            //color combos
            if (redChecked && yellowChecked)
            {
                //red and yellow, yellow and red
                //orange
                this.BackColor = Color.Orange;
            }
            else if (redChecked && blueChecked)
            {
                //red and blue, blue and red
                //pink
                this.BackColor = Color.Pink;
            }
            else if (redChecked &&  greenChecked)
            {
                //red and green, green and red
                //brown
                this.BackColor = Color.Brown;
            }
            else if (redChecked && purpleChecked)
            {
                //red and purple, purple and red
                //magenta
                this.BackColor = Color.Magenta;
            }
            else if (yellowChecked && blueChecked)
            {
                //yellow and blue, blue and yellow
                //green
                this.BackColor = Color.Green;
            }
            else if (yellowChecked && greenChecked)
            {
                //yellow and green, green and yellow
                //lime
                this.BackColor = Color.Lime;
            }
            else if (yellowChecked && purpleChecked)
            {
                //yellow and purple, purple and yellow
                //brown
                this.BackColor = Color.Brown;
            }
            else if (blueChecked && greenChecked)
            {
                //blue and green, green and blue
                //cyan
                this.BackColor = Color.Cyan;
            }
            else if (blueChecked && purpleChecked)
            {
                //blue and purple, purple and blue
                //violet
                this.BackColor = Color.Violet;
            }
            else if (greenChecked && purpleChecked)
            {
                //green and purple, purple and green
                //brown
                this.BackColor = Color.Brown;
            }
            else
            {
                //singulars
                if (redChecked)
                {
                    this.BackColor = Color.Red;
                }
                if (yellowChecked)
                {
                    this.BackColor = Color.Yellow;
                }
                if (blueChecked)
                {
                    this.BackColor = Color.Blue;
                }
                if (greenChecked)
                {
                    this.BackColor = Color.Green;
                }
                if (purpleChecked)
                {
                    this.BackColor = Color.Purple;
                }
            }
        }
    }
}
