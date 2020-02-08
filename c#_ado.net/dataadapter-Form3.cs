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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        string conString, qryString;

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            sqlcon.Open();
            sqlcmd = new SqlCommand();
            sqlcmd.CommandText = "getcustomersbycountry";
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Connection = sqlcon;

            SqlParameter p = new SqlParameter();
            p.ParameterName = "@counrty";
            p.DbType = DbType.String;
            p.Value = cmbcountry.Text;

            sqlcmd.Parameters.Add(p);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "customersbycountry");

            dgcounrty.DataSource=ds;
            dgcounrty.DataMember = "customersbycountry";
            sqlcon.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            ds = new DataSet();
            sqlcon.Open();
            qryString = "select distinct country from customers";
            sqlcmd = new SqlCommand(qryString, sqlcon);

            dr = sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (dr.Read())
            {
                cmbcountry.Items.Add(dr["country"]);

            }



            dr.Close();
            sqlcon.Close();
        }
    }
}
