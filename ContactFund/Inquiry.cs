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
    public partial class Inquiry : Form
    {
        public Inquiry()
        {
            InitializeComponent();
        }



        SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["ContactFund.Properties.Settings.liteConnectionString"].ConnectionString);
        private void Inquiry_Load(object sender, EventArgs e)
        {

        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            txtpendingpurchase.Text = "";
            txtpendingredemption.Text = "";

            try
            {
                SQLiteCommand cmdview = new SQLiteCommand("select clientID, [clientname], ICs, Cost, fundprice, marketvalue, unrealizedreturn, pricedate, cashbalance_unstored, nationalID, address from ICholding where clientID = @id", con);
                cmdview.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmdview);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtid.Text = dt.Rows[0][0].ToString();
                txtname.Text = dt.Rows[0][1].ToString();
                txtic.Text = Convert.ToDecimal(dt.Rows[0][2]).ToString("N0");
                txtinv.Text = Convert.ToDecimal(dt.Rows[0][3]).ToString("N2");
                txtprice.Text = Convert.ToDecimal(dt.Rows[0][4]).ToString("N5");
                txtvalue.Text = Convert.ToDecimal(dt.Rows[0][5]).ToString("N2");
                txtreturn.Text = Convert.ToDecimal(dt.Rows[0][6]).ToString("N2");
                txtdate.Text = Convert.ToDateTime(dt.Rows[0][7]).ToString("MM/dd/yyyy");
                txtcash.Text = Convert.ToDecimal(dt.Rows[0][8]).ToString("N2");
                txtnatid.Text = dt.Rows[0]["nationalID"].ToString();
                txtaddress.Text = dt.Rows[0]["address"].ToString();




                SQLiteCommand cmdhist = new SQLiteCommand("select settdate,qty_adj as ICs, value, fundprice, IC_holding,Market_Value, ((return -1) * 365 / interval) * 100 As annReturn from sysdateprice where clientID = @id", con);
                cmdhist.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmdhist);
                DataTable dt1 = new DataTable();
                dt1.Clear();
                da1.Fill(dt1);
                dgv.DataSource = dt1;

                //format
                dgv.Columns["ICs"].DefaultCellStyle.Format = "N0";
                dgv.Columns["value"].DefaultCellStyle.Format = "N2";
                dgv.Columns["fundprice"].DefaultCellStyle.Format = "N5";
                dgv.Columns["IC_holding"].DefaultCellStyle.Format = "N0";
                dgv.Columns["Market_Value"].DefaultCellStyle.Format = "N2";
                //format issuedate dd/mm/yyyy date only without time
                dgv.Columns["settdate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv.Columns["annReturn"].DefaultCellStyle.Format = "N2";


                //alignment
                dgv.Columns["ICs"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["value"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["fundprice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["IC_holding"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns["Market_Value"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (Exception)
            {
                MessageBox.Show("Inquiry Error");
            }

            try
            {
                SQLiteCommand cmdpendpurchase = new SQLiteCommand("select clientID, value FROM prepost_transaction where clientID = @id AND type = 'Purchase'", con);
                cmdpendpurchase.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da1 = new SQLiteDataAdapter(cmdpendpurchase);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                SQLiteCommand cmdpendredemption = new SQLiteCommand("select clientID, quantity FROM prepost_transaction where clientID = @id AND type = 'Redemption'", con);
                cmdpendredemption.Parameters.AddWithValue("id", txtid.Text);
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(cmdpendredemption);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);


                if (dt1.Rows.Count > 0)
                {
                    txtpendingpurchase.Text = Convert.ToDecimal(dt1.Rows[0][1]).ToString("N2");
                }
                else if (dt2.Rows.Count > 0)
                {
                    txtpendingredemption.Text = Convert.ToDecimal(dt2.Rows[0][1]).ToString("N0");
                }

                dt1.Clear();
                dt2.Clear();


            }
            catch (Exception)
            {
                MessageBox.Show("Pending transaction error");
            }

            twr();
        }

        private void twr()
        {
            try
            {
                // Calculate time-weighted return from teansaction history
                DataTable dt = (DataTable)dgv.DataSource;

                // Convert the 'fundprice' column to a list of decimal
                List<double> fundPrices = dt.AsEnumerable()
                    .Select(row => double.Parse(row["fundprice"].ToString()))
                    .ToList();

                // Convert the 'settdate' column to a list of DateTime
                List<DateTime> settDates = dt.AsEnumerable().Select(row => DateTime.Parse(row["settdate"].ToString())).ToList();

                // Print the difference in days
                txttnr.Text = (DateTime.Parse(txtdate.Text) - settDates.First()).Days.ToString();

                // Print the time-weighted return
                txttwr.Text = (((double.Parse(txtprice.Text)/fundPrices.First()) - 1) * (365 / double.Parse(txttnr.Text)) * 100).ToString("N2");


            }
            catch (Exception)
            {
                MessageBox.Show("No transaction history found");
            }

        }

    }
}
