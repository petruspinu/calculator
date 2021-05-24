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
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("Server=L-BKK9K13; Database=calculator; Trusted_Connection=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            

            double x1, x2;
            double delta;

            float a = float.Parse(TextBox1.Text);
            float b = float.Parse(TextBox2.Text);
            float c = float.Parse(TextBox3.Text);

            delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Delta e mai mic ca 0. X1 si X2 nu poate fi calculat. Introduceti alte valori.');", true);
            }
            else
            {
                if (delta == 0)
                {

                    x1 = (-b + Math.Sqrt(delta)) / (a * 2);
                    x2 = (-b - Math.Sqrt(delta)) / (a * 2);
                    Label1.Text = "x1 = x2 = " + String.Format("{0:0.##}", x1);
                    con.Open();
                    string newcon = " Insert into valori values ('"+ float.Parse(TextBox1.Text)+"','"+ float.Parse(TextBox2.Text) + "','" + float.Parse(TextBox3.Text) + "','" +delta+ "','" +String.Format("{0:0.##}", x1) + "','"+ String.Format("{0:0.##}", x2) + "')";
                    SqlCommand cmd = new SqlCommand(newcon, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (a * 2);
                    x2 = (-b - Math.Sqrt(delta)) / (a * 2);
                    Label1.Text = "x1 = " + String.Format("{0:0.##}", x1) + " iar x2 = " + String.Format("{0:0.##}", x2) + "";
                    con.Open();
                    string newcon = " Insert into valori values ('" + float.Parse(TextBox1.Text) + "','" + float.Parse(TextBox2.Text) + "','" + float.Parse(TextBox3.Text) + "','" + delta + "','" + String.Format("{0:0.##}", x1) + "','" + String.Format("{0:0.##}", x2) + "')";
                    SqlCommand cmd = new SqlCommand(newcon, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

        }
    }
}