using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Inventory
{
    public partial class PurchaseInvoice : MetroForm
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void Puchase_Invoice_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["InvtDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);

            //Dealers Loaded In Dropdown
            SqlDataAdapter sda = new SqlDataAdapter("Select Name From Dealers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbDealers.ValueMember = "Name";
            cmbDealers.DisplayMember = "Name";
            cmbDealers.DataSource = dt;


            //Categories Loaded In Dropdown            
            SqlDataAdapter sdaC = new SqlDataAdapter("Select CategoryName From Category", con);
            DataTable dtC = new DataTable();
            sdaC.Fill(dtC);
            cmbCategory.ValueMember = "CategoryName";
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.DataSource = dtC;


            //Brands Loaded In Dropdown
            SqlDataAdapter sdaB = new SqlDataAdapter("Select BrandName From Brand", con);
            DataTable dtB = new DataTable();
            sdaB.Fill(dtB);
            cmbBrand.ValueMember = "BrandName";
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.DataSource = dtB;

            //Load Products
            LoadProduct();
        }

        public void LoadProduct()
        {
            var connection = ConfigurationManager.ConnectionStrings["InvtDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);

            SqlDataAdapter sdaC = new SqlDataAdapter("Select ProductName From ProductInventory", con);
            DataTable dtC = new DataTable();
            sdaC.Fill(dtC);
            cmbProductName.ValueMember = "ProductName";
            cmbProductName.DisplayMember = "ProductName";
            cmbProductName.DataSource = dtC;
        }


        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
