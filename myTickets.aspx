<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="myTickets.aspx.cs" Inherits="TicketBookingSystem.myTickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="height: 90vh; overflow: hidden;text-align:center;">
        <h1>Tickets Bought:</h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BorderWidth="0">
            <Columns>
                <asp:BoundField DataField="ticket_id" HeaderText="Ticket ID" />
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
