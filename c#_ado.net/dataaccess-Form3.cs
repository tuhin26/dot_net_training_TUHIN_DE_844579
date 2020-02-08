using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dataaccess
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string conString, qryString;

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select UnitPrice from products where productName ='" + cmbproduct.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            sqlcon.Open();
            lblprice.Text =  sqlcmd.ExecuteScalar().ToString();
            //executeScalar method returns a single value from the data base
            sqlcon.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            qryString = "Update products set unitprice = " + Convert.ToDouble(txtnewprice.Text) + "where productname = '" + cmbproduct.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            sqlcon.Open();
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("price updated");
            sqlcon.Close();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();

            qryString = "select productName from products";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
            {
                cmbproduct.Items.Add(dr["productName"]);

            }
            dr.Close();
            sqlcon.Close();

            cmbproduct.Text = "All Products";

        }
    }
}
