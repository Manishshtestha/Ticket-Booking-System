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
    public partial class myTickets : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e) {
            if (Session["user_id"] != null) {
                string id = Session["user_id"].ToString();
                using (con = new SqlConnection(cs)) {
                    cmd = new SqlCommand("SELECT * FROM tickets_tbl WHERE customer_id = '" + id + "'", con);
                    SqlDataAdapter d = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    d.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            } else {
                Response.Write("<script>alert('Please Login First!')</script>");
            }
        }
    }
}