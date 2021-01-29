using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers_and_Counters
{
    public partial class FormRandomCounter : Form
    {
        Random generator = new Random();
        int counter, number, maximum, minimum;

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            nudMax.Value = 0;
            nudMin.Value = 0;
            lblRandomNumber.Text = "0";
            lblRandomCounter.Text = "0 random numbers made.";
        }

        private void FormRandomCounter_Load(object sender, EventArgs e)
        {
            counter = 0;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            minimum = (int)nudMin.Value;
            maximum = (int)nudMax.Value;
            if (maximum >= minimum)
            {
                number = generator.Next(minimum, maximum + 1);
                lblRandomNumber.Text = number + "";
                counter += 1;
                lblRandomCounter.Text = counter + " random numbers made.";
            }
            else
            {
                lblRandomCounter.Text = "Please ensure that max >= min";
            }         
        }

        public FormRandomCounter()
        {
            InitializeComponent();
        }
    }
}
