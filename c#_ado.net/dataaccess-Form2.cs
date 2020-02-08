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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataReader dr;
        string conString, qryString;

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();

            qryString = "select distinct country from customers";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader();

            while (dr.Read())
            {
                cmbcountry.Items.Add (dr["country"]);

            }



            dr.Close();
           



            sqlcon.Close();
        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlcon.Open();

            qryString = "select ContactName from customers where country='"+cmbcountry.Text+"'";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader();
            lstcontactname.Items.Clear();

            while (dr.Read())
            {
                lstcontactname.Items.Add(dr["contactname"]);

            }
           
            dr.Close();
           

            sqlcon.Close();
        }
    }
}
