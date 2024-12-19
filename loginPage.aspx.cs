using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBookingSystem {
    public partial class loginPage : System.Web.UI.Page {

        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void signin_Click(object sender, EventArgs e) {
            if (TextBox1.Text != "" && TextBox2.Text != "") {
                if (!CheckBox1.Checked) {

                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        cmd = new SqlCommand("SELECT * FROM users_tbl WHERE user_email ='" + TextBox1.Text + "' AND user_pass = '" + TextBox2.Text + "'", con);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows) {
                            while (dr.Read()) {
                                Response.Write("<script>alert('Login Successful!')</script>");
                                Session["username"] = dr.GetValue(1).ToString();
                                Session["role"] = "user";
                                Session["user_id"] = dr.GetValue(0).ToString();
                            }
                            Response.Redirect("homepage.aspx");
                        } else {
                            Response.Write("<script>alert('Invalid Credentials!')</script>");
                        }

                    }
                } else {
                    if (TextBox1.Text == "admin@gmail.com" && TextBox2.Text == "admin123") {
                        Response.Write("<script>alert('Successfully logged in as Admin!')</script>");
                        Session["username"] = "admin";
                        Session["role"] = "admin";
                        Response.Redirect("homepage.aspx");
                    } else {
                        Response.Write("<script>alert('Invalid Credentials')</script>");
                    }
                }
            } else {
                Response.Write("<script>alert('Please enter your email and password!')</script>");
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e) {

        }
    }
}