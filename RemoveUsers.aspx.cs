using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBookingSystem {
    public partial class RemoveUsers : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e) {
            using (con = new SqlConnection(cs)) {
                SqlCommand cmd = new SqlCommand("SELECT * FROM users_tbl", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            using (con = new SqlConnection(cs)) {
                con.Open();
                if (TextBox1.Text != "") {
                    cmd = new SqlCommand("DELETE FROM users_tbl WHERE user_id = '" + TextBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('User Deleted!')</script>");
                } else {
                    Response.Write("<script>alert('Please Enter User ID')</script>");
                }
            }
        }
    }
}