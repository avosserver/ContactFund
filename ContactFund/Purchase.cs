using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactFund
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["ContactFund.Properties.Settings.liteConnectionString"].ConnectionString);

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SQLiteCommand cmdview = new SQLiteCommand("select clientID, [clientname], cashbalance_unstored from clientfund where clientID = @id", con);
                cmdview.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdview);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtid.Text = dt.Rows[0][0].ToString();
                txtname.Text = dt.Rows[0][1].ToString();
                txtcash.Text = Convert.ToDecimal(dt.Rows[0][2]).ToString("N2");

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
                if (txtcash.Text == "0.00")
                {
                    MessageBox.Show("Please deposit");
                }
                else
                {
                    MessageBox.Show("Transaction Posted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
