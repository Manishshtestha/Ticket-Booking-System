<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="sports.aspx.cs" Inherits="TicketBookingSystem.Sport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 90vh; overflow: hidden;text-align:center;">
        <h1>Sports Avaiable:</h1>
        <div style="width: 60%; margin: 0 auto; display: flex; justify-content: center;">
            <asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="Event ID"></asp:TextBox>
            <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Book Ticket" OnClick="Button1_Click1" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BorderWidth="0">
            <Columns>
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="event_name" HeaderText="Event Name" />
                <asp:BoundField DataField="event_date" HeaderText="Event Date" />
                <asp:BoundField DataField="event_location" HeaderText="Location" />
                <asp:BoundField DataField="ticket_price" HeaderText="Price" />

            </Columns>
        </asp:GridView>
        <a href="allEvents.aspx">View All Events</a>
    </div>

</asp:Content>
