using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBookingSystem {
    public partial class AddUsers : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "") {
                using (con = new SqlConnection(cs)) {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO users_tbl(user_name,user_email,user_phone,user_pass) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    //Response.Write(cmd.CommandText);
                    con.Close();
                    Response.Write("<script>alert('User Added')</script>");
                }
            } else {
                Response.Write("<script>alert('Fill All the details!')</scrikpt>");
            }
        }
    }
}