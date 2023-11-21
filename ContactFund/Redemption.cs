using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ContactFund
{
    public partial class Redemption : Form
    {
        public Redemption()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["ContactFund.Properties.Settings.liteConnectionString"].ConnectionString);

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmdview = new SQLiteCommand("select clientID, [clientname], ICs from ICholding where clientID = @id", con);
                cmdview.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdview);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtid.Text = dt.Rows[0][0].ToString();
                txtname.Text = dt.Rows[0][1].ToString();
                txtic.Text = Convert.ToDecimal(dt.Rows[0][2]).ToString("N0");


                SQLiteCommand cmdpend = new SQLiteCommand("select clientID, quantity FROM prepost_transaction where clientID = @id AND type = 'Redemption'", con);
                cmdpend.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmdpend);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);


                if(dt2.Rows.Count > 0)
                {
                    txtredemption.Text = Convert.ToDecimal(dt2.Rows[0][1]).ToString("N0");
                    txticava.Text = (Convert.ToDecimal(txtic.Text) - Convert.ToDecimal(txtredemption.Text)).ToString("N0");
                }
                else
                {
                    txticava.Text = Convert.ToDecimal(txtic.Text).ToString("N0");
                }



            }
            catch
            {
                MessageBox.Show("Client ID doesn't exist");
            }

        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtredic.Text) > double.Parse(txticava.Text))
                {
                    MessageBox.Show("Redemption ICs can't exceed available ICs");
                }
                else
                {
                    MessageBox.Show("Transaction Posted");
                }
            }
            catch
            {
                MessageBox.Show("Please enter ICs to redeem");
            }
        }
    }
}
