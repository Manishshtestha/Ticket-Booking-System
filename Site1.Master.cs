using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBookingSystem {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            try {
                string role = Session["role"] as string;

                switch (role) {
                    //case "":
                    //    LinkButton5.Visible = true;
                    //    LinkButton7.Visible = false;
                    //    LinkButton8.Visible = false;
                    //    LinkButton9.Visible = false;
                    //    LinkButton10.Visible = false;
                    //    LinkButton11.Visible = false;
                    //    LinkButton12.Visible = false;
                    //    LinkButton13.Visible = false;
                    //    break;

                    case "user":
                        LinkButton5.Visible = false;
                        LinkButton7.Visible = true;
                        LinkButton8.Visible = false;
                        LinkButton9.Visible = false;
                        LinkButton10.Visible = false;
                        LinkButton11.Visible = false;
                        LinkButton12.Visible = false;
                        LinkButton13.Visible = true;
                        break;

                    case "admin":
                        LinkButton5.Visible = false;
                        LinkButton7.Visible = true;
                        LinkButton8.Visible = true;
                        LinkButton9.Visible = true;
                        LinkButton10.Visible = true;
                        LinkButton11.Visible = true;
                        LinkButton12.Visible = true;
                        LinkButton13.Visible = false;
                        break;

                    default:
                        LinkButton5.Visible = true;
                        LinkButton7.Visible = false;
                        LinkButton8.Visible = false;
                        LinkButton9.Visible = false;
                        LinkButton10.Visible = false;
                        LinkButton11.Visible = false;
                        LinkButton12.Visible = false;
                        LinkButton13.Visible = false;
                        break;
                }

            } catch (Exception ex) {
                Response.Write(ex.ToString());
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e) {
            Response.Redirect("concerts.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e) {
            Response.Redirect("sports.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e) {
            Response.Redirect("festivals.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e) {
            Response.Redirect("theatre.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e) {
            Response.Redirect("loginPage.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e) {
            Session["username"] = "";
            Session["role"] = "";
            Session["user_id"] = "";

            LinkButton5.Visible = true;
            LinkButton7.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton11.Visible = false;
            LinkButton12.Visible = false;
            LinkButton13.Visible = false;

            Response.Redirect("homepage.aspx");

        }
        protected void LinkButton8_Click(object sender, EventArgs e) {
            Response.Redirect("UpdateEvents.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e) {
            Response.Redirect("RemoveEvents.aspx");
        }
        protected void LinkButton10_Click(object sender, EventArgs e) {
            Response.Redirect("AddEvents.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e) {
            Response.Redirect("AddUsers.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e) {
            Response.Redirect("RemoveUsers.aspx");
        }

        protected void LinkButton13_Click(object sender, EventArgs e) {
            Response.Redirect("myTickets.aspx");
        }

    }
}