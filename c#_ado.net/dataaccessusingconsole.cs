using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dataaccessusingconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string conString, qryString;
            //    conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            //    SqlConnection sqlcon = new SqlConnection(conString);


            //    sqlcon.Open();

            //    qryString = "select productName from products";
            //   SqlCommand sqlcmd = new SqlCommand(qryString, sqlcon);
            //    SqlDataReader dr = sqlcmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        Console.WriteLine("productname {0}",dr["productName"]);

            //    }
            //    dr.Close();
            //    sqlcon.Close();
            SqlConnection sqlcon;
            SqlCommand sqlcmd;
            SqlDataAdapter da;
            DataSet ds;

           
            string conString, qryString;

            conString = "data source= BLT10145\\SQLEXPRESS2014; Initial Catalog =Northwind;Integrated security=True";
            sqlcon = new SqlConnection(conString);
            ds = new DataSet();
            qryString = "select * from customers";
            sqlcon.Open();
            sqlcmd = new SqlCommand(qryString, sqlcon);
            da = new SqlDataAdapter(sqlcmd);
            ds.Clear();
            da.Fill(ds, "customersinfo");

            DataTable dt = ds.Tables["customersinfo"];
            var customer = from customers in dt.AsEnumerable()
                           where customers.Field<string>("country")=="USA"
                           select new
                           {
                               customerid = customers["customerid"],
                               contactname = customers["contactname"],
                              country = customers["country"],
                               city = customers["city"]
                           };
            foreach (var c in customer)
            {
                Console.WriteLine("customerid = " + c.customerid + " ,contactname = " + c.contactname + " ,country = " + c.country + " ,city = " + c.city);
            }
            sqlcon.Close();

        }
         
    }
}
