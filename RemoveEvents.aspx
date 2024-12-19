<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="RemoveEvents.aspx.cs" Inherits="TicketBookingSystem.RemoveEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 90vh; overflow: hidden; text-align: center;">
        <h1>Events Available:</h1>
        <div style="width: 60%; margin: 0 auto; display: flex; justify-content: center;">
            <asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
            <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Remove Event" OnClick="Button1_Click" />
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
    </div>
</asp:Content>
