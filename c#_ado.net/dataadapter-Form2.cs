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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        string conString, qryString;

        private void btncustomer_Click(object sender, EventArgs e)
        {
          
            qryString = "select c.customerid,c.companyname,c.contactname,c.address,c.country,o.orderid,o.orderdate,o.shippeddate from customers c join orders o on c.customerid=o.customerid";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "customersordersinfo");
            dgcustomer.DataSource = ds;
            dgcustomer.DataMember = "customersordersinfo";
        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            qryString = "select * from customers  where country ='" + cmbcountry.Text + "'";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "customersinfo");
            dgcustomer.DataSource = ds;
            dgcustomer.DataMember = "customersinfo";
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            qryString = "select p.productid,p.productname,p.supplierid,p.categoryid,p.unitprice,c.categoryname,c.picture,c.description from products p  join categories c on p.categoryid =c.categoryid";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            //ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "productcategoryinfo");
            dgcustomer.DataSource = ds;
            dgcustomer.DataMember = "productcategoryinfo";
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            qryString = "select count(orderid) from orders  ";
            sqlcmd = new SqlCommand(qryString, sqlcon);
            MessageBox.Show("total order "+sqlcmd.ExecuteScalar().ToString());
            sqlcon.Close();

        }

        private void btnlinq_Click(object sender, EventArgs e)
        {
            qryString = "select * from products";
            sqlcon.Open();
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "productsinfo");

            DataTable dt = ds.Tables["productsinfo"];
            var products = from product in dt.AsEnumerable()
                           where product.Field<decimal>("unitprice") >= 50
                           select new
                           {
                               productid = product["productid"],
                               productname = product["productname"],
                               price = product["unitprice"],
                               quantity = product["quantityperunit"]
                           };
            foreach(var product in products)
            {
                MessageBox.Show("productid =" + product.productid + "productname =" + product.productname + "price =" + product.price + "quantity =" + product.quantity);
            }
            sqlcon.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            ds = new DataSet();

            sqlcon.Open();

            qryString = "select distinct country from customers  ";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
            {
                cmbcountry.Items.Add(dr["country"]);

            }



            dr.Close();
            sqlcon.Close();

        }
    }
}
