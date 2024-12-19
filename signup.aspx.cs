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
    public partial class signup : System.Web.UI.Page {

        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void register_Click(object sender, EventArgs e) {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "") {
                using (con = new SqlConnection(cs)) {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO users_tbl(user_name,user_email,user_phone,user_pass) VALUES(@username,@useremail,@userphone,@userpass)",con);
                    cmd.Parameters.AddWithValue("@username", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@useremail", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@userphone",TextBox3.Text);
                    cmd.Parameters.AddWithValue("@userpass", TextBox4.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Registration Successful! please login now')</script>");
                }
            } else {
                Response.Write("<script>alert('Please fill all the details!')</script>");
            }
        }



    }
}