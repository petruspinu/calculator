using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace calculator
{
    public partial class About : Page
    {
        SqlConnection con = new SqlConnection("Server=L-BKK9K13; Database=calculator; Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            /*con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM valori", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "valori");
            GridView1.DataSource = ds.Tables["valori"].DefaultView;*/


            /*con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM valori ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();*/

            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM valori"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            con.Close();
        }
    }
}