<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="UpdateEvents.aspx.cs" Inherits="TicketBookingSystem.UpdateEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 80%; margin: 0 auto; display: flex; justify-content: center;">
        <asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="Event ID"></asp:TextBox>
        <asp:TextBox CssClass="input" ID="TextBox2" runat="server" placeholder="Event Date" TextMode="Date"></asp:TextBox>
        <asp:TextBox CssClass="input" ID="TextBox3" runat="server" placeholder="Event Location"></asp:TextBox>
        <asp:TextBox CssClass="input" ID="TextBox4" runat="server" placeholder="Ticket Price" TextMode="Number"></asp:TextBox>
        <asp:Button CssClass="btn" ID="Button2" runat="server" Text="Update Event" OnClick="Button2_Click" />
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
</asp:Content>
