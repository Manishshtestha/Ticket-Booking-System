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
    public partial class WebForm2 : System.Web.UI.Page {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e) {

        }


        protected void Button1_Click(object sender, EventArgs e) {
            if (Session["user_id"] != null) {
                string uid = Session["user_id"].ToString();
                if (TextBox4.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        cmd = new SqlCommand("INSERT INTO tickets_tbl(event_id,customer_id) VALUES('" + TextBox4.Text + "','" + uid + "')", con);

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

        protected void Button2_Click(object sender, EventArgs e) {
            if (DropDownList1.SelectedItem.Value == "0") {
                if (TextBox1.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_name LIKE '" + TextBox1.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox2.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_location LIKE '" + TextBox2.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox3.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_date = '" + TextBox3.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox2.Text != "" && TextBox3.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_location LIKE '" + TextBox2.Text + "' AND event_date ='" + TextBox3.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_name LIKE '" + TextBox1.Text + "' AND event_location LIKE '" + TextBox2.Text + "' AND event_date = '" + TextBox3.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else {
                    Response.Write("<script>alert('Please fill at least one detail')</script>");
                }
            } 
            else {
                if (TextBox1.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '" + DropDownList1.SelectedItem.Value + "' AND event_name LIKE '" + TextBox1.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox2.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '" + DropDownList1.SelectedItem.Value + "' AND event_location LIKE '" + TextBox2.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox3.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '" + DropDownList1.SelectedItem.Value + "' AND event_date = '" + TextBox3.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox2.Text != "" && TextBox3.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '" + DropDownList1.SelectedItem.Value + "' AND event_location LIKE '" + TextBox2.Text + "' AND event_date ='" + TextBox3.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox1.Text == "" && TextBox2.Text == "" && TextBox3.Text == "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '" + DropDownList1.SelectedItem.Value + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                } else if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "") {
                    using (con = new SqlConnection(cs)) {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM events_tbl WHERE event_type = '" + DropDownList1.SelectedItem.Value + "' AND event_name LIKE '" + TextBox1.Text + "' AND event_location LIKE '" + TextBox2.Text + "' AND event_date = '" + TextBox3.Text + "'", con);
                        SqlDataAdapter d = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                        con.Close();
                    }
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e) {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedIndex = 0;
        }
    }
}