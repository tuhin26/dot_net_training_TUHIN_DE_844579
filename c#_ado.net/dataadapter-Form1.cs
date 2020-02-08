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

namespace dataadapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        DataSet ds;
        string conString, qryString;

        private void btnproduct_Click(object sender, EventArgs e)
        {
            qryString = "select productid,productname,unitprice,quantityperunit,categoryid from products";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "productinfo");
            dgproducs.DataSource = ds;
            dgproducs.DataMember = "productinfo";
        }

        private void btncatagory_Click(object sender, EventArgs e)
        {
            qryString = "select * from categories";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "categoriesinfo");
            dgproducs.DataSource = ds;
            dgproducs.DataMember = "categoriesinfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            ds = new DataSet();
           
        }
    }
}
