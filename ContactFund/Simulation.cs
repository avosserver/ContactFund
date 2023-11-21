using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ContactFund
{
    public partial class Simulation : Form
    {
        public Simulation()
        {
            InitializeComponent();
        }


        private void Simulation_Load(object sender, EventArgs e)
        {
            cbtype.SelectedIndex = 0;
            txtrate.Text = "19";
            txttnr.Text = "12";
            txtrate2.Text = "19";
            txttnr2.Text = "12";
            txtpv.Text = "0";
            txtpv2.Text = "0";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal rate = decimal.Parse(txtrate.Text) / 12 / 100;
                int nper = int.Parse(txttnr.Text);

                if (string.IsNullOrEmpty(txtfv.Text))
                {
                    double pmt = double.Parse(txtpmt.Text);
                    double pv = double.Parse(txtpv.Text);
                    
                    // Calculate future value
                    double fv = Financial.FV((double)rate, nper, -pmt, -pv, DueDate.BegOfPeriod);
                    txtfv.Text = fv.ToString("N2");
                    txtpv.Text = pv.ToString("N2");
                    txtpmt.Text = pmt.ToString("N2");
                }
                else if (string.IsNullOrEmpty(txtpv.Text))
                {
                    double pmt = double.Parse(txtpmt.Text);
                    double fv = double.Parse(txtfv.Text);
                    
                    // Calculate present value
                    double pv = Financial.PV((double)rate, nper, pmt, -fv, DueDate.BegOfPeriod);
                    txtfv.Text = fv.ToString("N2");
                    txtpv.Text = pv.ToString("N2");
                    txtpmt.Text = pmt.ToString("N2");
                }
                else if (string.IsNullOrEmpty(txtpmt.Text))
                {
                    double fv = double.Parse(txtfv.Text);
                    double pv = double.Parse(txtpv.Text);
                    
                    // Calculate Payment
                    double pmt = Financial.Pmt((double)rate, nper, pv, -fv, DueDate.BegOfPeriod);
                    txtfv.Text = fv.ToString("N2");
                    txtpv.Text = pv.ToString("N2");
                    txtpmt.Text = pmt.ToString("N2");
                }

                txttotinv.Text = (decimal.Parse(txtpv.Text) + decimal.Parse(txtpmt.Text) * nper).ToString("N2");
                txtreturn.Text = (decimal.Parse(txtfv.Text) - decimal.Parse(txttotinv.Text)).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message:" + " " + "Please insert valid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal rate = decimal.Parse(txtrate2.Text) / 12 / 100;
                int nper = int.Parse(txttnr2.Text);

                if (string.IsNullOrEmpty(txtpv2.Text))
                {
                    double pmt = double.Parse(txtpmt2.Text);
                    double fv = double.Parse(txtfv2.Text);

                    // Calculate present value
                    double pv = Financial.PV((double)rate, nper, pmt, -fv, DueDate.EndOfPeriod);
                    txtpmt2.Text = fv.ToString("N2");
                    txtpv2.Text = pv.ToString("N2");
                    txtfv2.Text = pmt.ToString("N2");
                }
                else if (string.IsNullOrEmpty(txtpmt2.Text))
                {
                    double fv = double.Parse(txtfv2.Text);
                    double pv = double.Parse(txtpv2.Text);

                    // Calculate Payment
                    double pmt = Financial.Pmt((double)rate, nper, -pv, fv, DueDate.EndOfPeriod);
                    txtfv2.Text = fv.ToString("N2");
                    txtpv2.Text = pv.ToString("N2");
                    txtpmt2.Text = pmt.ToString("N2");
                }


                txttotinv2.Text = decimal.Parse(txtpv2.Text).ToString("N2");

                if (cbtype.SelectedIndex == 0)
                {
                    txtreturn2.Text = (decimal.Parse(txtpmt2.Text) * nper).ToString("N2");
                }
                else if (cbtype.SelectedIndex == 1)
                {
                    txtreturn2.Text = ((decimal.Parse(txtpmt2.Text) * nper) - decimal.Parse(txttotinv2.Text)).ToString("N2");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message:" + " " + "Please insert valid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toggletype()
        {
            if (cbtype.SelectedIndex == 0)
            {
                txtfv2.Text = txtpv2.Text;
            }
            else if (cbtype.SelectedIndex == 1)
            {
                txtfv2.Text = "0";
            }
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            toggletype();
        }

        private void txtpv2_TextChanged(object sender, EventArgs e)
        {
            toggletype();
        }
    }
}
