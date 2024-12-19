using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBookingSystem {
    public partial class Festival : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e) {
            using (con = new SqlConnection(cs)) {
                SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '4'", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e) {
            if (Session["user_id"] != null) {
                string uid = Session["user_id"].ToString();
                if (TextBox1.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        cmd = new SqlCommand("INSERT INTO tickets_tbl(event_id,customer_id) VALUES('" + TextBox1.Text + "','" + uid + "')", con);

                        cmd.ExecuteNonQuery();
                        Response.Write("<script>alert('Ticket Booked Successfully!')</script>");
                        con.Close();
                    }
                } else {
                    Response.Write("<script>alert('Please Enter Event ID!')</script>");
                }
            } else {
                Response.Write("<script>alert('Please fill all the details!')</script>");
            }
        }
    }
}