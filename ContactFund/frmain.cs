using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Data.SQLite;
using System.Data.Entity.Core.Metadata.Edm;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ContactFund
{
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
            customizeDesign();
        }

        //SQLiteConnection con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["ContactFund.Properties.Settings.liteConnectionString"].ConnectionString);

        private void customizeDesign()
        {
            panelTransSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelTransSubmenu.Visible == true)
                panelTransSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void Loadform(Object Form)
        {
            if (this.panelmain.Controls.Count > 0)
                this.panelmain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(f);
            this.panelmain.Tag = f;
            f.Show();
        }



        private void btntransgate_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTransSubmenu);
        }



        // BTN LOAD FORMs EVENTs-----------------------------------------------------------------------------------------------------------------

        private void Btndashboard_Click(object sender, EventArgs e)
        {
            try
            {
                Loadform(new Home());
                //conn.Open();
                //txtconn.Text = conn.State.ToString();

                //if (con.State == ConnectionState.Open)
                //{
                //    Loadform(new Home());
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Loadform(new Home());
        }



        private void btndashboard_Click_1(object sender, EventArgs e)
        {
            Loadform(new Home());
        }

        private void btnonboarding_Click(object sender, EventArgs e)
        {
            Loadform(new Onboarding());
            hideSubMenu();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            Loadform(new Purchase());
            hideSubMenu();
        }

        private void btnredemption_Click(object sender, EventArgs e)
        {
            Loadform(new Redemption());
            hideSubMenu();
        }

        private void btnsim_Click(object sender, EventArgs e)
        {
            Loadform(new Simulation());
        }

        private void btninquiry_Click(object sender, EventArgs e)
        {
            Loadform(new Inquiry());
        }


        private void Frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmain_Load(object sender, EventArgs e)
        {
        }

    }
}
