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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string conString, qryString;

        private void btnproducts_Click(object sender, EventArgs e)
        {
            //listbox
            sqlcon.Open();

            qryString = "select productName from products";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read()) 
            {
                lstproducts.Items.Add(dr["productName"]);

            }
            dr.Close();
            sqlcon.Close();
           

        }

        private void cmbproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select UnitPrice from products where productName ='" +cmbproducts.Text +"'";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            sqlcon.Open();
            lblprice.Text = "Unit Price: " + sqlcmd.ExecuteScalar().ToString();
            //executeScalar method returns a single value from the data base
            sqlcon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
                sqlcon = new SqlConnection(conString);
            //combobox
            sqlcon.Open();

            qryString = "select productName from products";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
            {
                cmbproducts.Items.Add(dr["productName"]);

            }
            dr.Close();
            sqlcon.Close();
            //cmbproducts.Text = "all products";
        }
    }
}
