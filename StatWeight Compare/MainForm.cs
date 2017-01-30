using System;
using System.Windows.Forms;

namespace StatWeight_Compare
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public float a;
        public float b;
        public float c;
        public float d;
        public float f;
        

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cmbSubClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubClass.SelectedIndex == 0)
            {
                txtOutput.Text = ("class1 selected");
                a = 1.00F;
                b = 2.00F;
                c = 3.00F;
                d = 4.00F;
                f = 5.00F;
                
            }
            if (cmbSubClass.SelectedIndex == 1)
            {
                txtOutput.Text = ("class2 selected");
                a = 0.00F;
                b = 0.00F;
                c = 0.00F;
                d = 0.00F;
                f = 0.00F;
            }
            if (cmbSubClass.SelectedIndex == 2)
            {
                txtOutput.Text = ("class3 selected");
                a = 1.00F;
                b = 1.00F;
                c = 1.00F;
                d = 1.00F;
                f = 1.00F;

            }
        }

        private void cmbPreLoad1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPreLoad1.Text == "Pre-Load1")
            {
                txtValue1.Text = ("380");
                txtValue2.Text = ("1150");
                txtValue3.Text = ("976");
            }
            if (cmbPreLoad1.Text == "Pre-Load2")
            {
                txtValue1.Text = ("450 ");
                txtValue2.Text = ("970");
                txtValue3.Text = ("976");
            }
        }

        private void cmbPreLoad2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPreLoad2.Text == "Pre-Load1")
            {
                txtValue21.Text = ("380");
                txtValue22.Text = ("1150");
                txtValue23.Text = ("976");
            }
            if (cmbPreLoad2.Text == "Pre-Load2")
            {
                txtValue21.Text = ("450 ");
                txtValue22.Text = ("970");
                txtValue23.Text = ("976");
            }
        }

        private void btnWeigh_Click(object sender, EventArgs e)
        {
            Int32 val1 = Convert.ToUInt16(txtValue1.Text);
            Int32 val2 = Convert.ToUInt16(txtValue2.Text);
            Int32 val3 = Convert.ToUInt16(txtValue3.Text);

            Int32 val21 = Convert.ToUInt16(txtValue21.Text);
            Int32 val22 = Convert.ToUInt16(txtValue22.Text);
            Int32 val23 = Convert.ToUInt16(txtValue23.Text);

            float weight1Float1 = (b * val1) + (d * val2) + (f * val3);
            txtWeight1.Text = Convert.ToString(weight1Float1);

            float weight1Float2 = (a * val21) + (c * val22) + (f * val23);
            txtWeight2.Text = Convert.ToString(weight1Float2);

            if (weight1Float1 > weight1Float2)
            {
                txtOutput.Text = ("" + cmbPreLoad1.Text + " Weighs More than " + cmbPreLoad2.Text + "");
            }

            if (weight1Float1 < weight1Float2)
            {
                txtOutput.Text = ("" + cmbPreLoad2.Text + " Weighs More than " + cmbPreLoad1.Text + "");
            }

            if (weight1Float1 == weight1Float2)
            {
                txtOutput.Text = ("" + cmbPreLoad2.Text + " and " + cmbPreLoad1.Text + " Weigh the same!");
            }
        }


    }
}