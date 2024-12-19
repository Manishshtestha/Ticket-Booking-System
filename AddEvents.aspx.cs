using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBookingSystem {
    public partial class ManageEvents : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "") {
                using (con = new SqlConnection(cs)) {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO events_tbl(event_name,event_date,event_type,event_location,ticket_price) VALUES('"+TextBox1.Text+"','"+TextBox2.Text+"','"+DropDownList1.SelectedItem.Value+"','"+TextBox3.Text+"','"+TextBox4.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    //Response.Write(cmd.CommandText);
                    con.Close();
                    Response.Write("<script>alert('Event Added')</script>");
                }
            } else {
                Response.Write("<script>alert('Please Fill all the fields!')</script>");
            }
        }
    }
}