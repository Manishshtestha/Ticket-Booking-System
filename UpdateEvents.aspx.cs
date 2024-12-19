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
    public partial class UpdateEvents : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e) {
            using (con = new SqlConnection(cs)) {

                SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        void LoadEvents() {
            using (con = new SqlConnection(cs)) {

                SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl", con);
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }   
        }

        protected void Button2_Click(object sender, EventArgs e) {
            using (con = new SqlConnection(cs)) {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "") {
                    con.Open();
                    cmd = new SqlCommand("UPDATE events_tbl SET event_date='" + TextBox2.Text + "',event_location='" + TextBox3.Text + "',ticket_price='" + TextBox4.Text + "' WHERE event_id='" + TextBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Event Updated Successfully')</script>");
                    LoadEvents();

                } else {
                    Response.Write("<script>alert('Please Fill All the Details')</script>");
                }
            }
        }
    }
}