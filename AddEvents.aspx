<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="AddEvents.aspx.cs" Inherits="TicketBookingSystem.ManageEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 88vh; overflow-y: hidden;">

        <div class="addEventCard">

            <h1>Add New Event</h1>
            <label>
                Event Name<asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="Event Name"></asp:TextBox>
            </label>
            <label>
                Event Date<asp:TextBox CssClass="input" ID="TextBox2" TextMode="Date" runat="server" placeholder="Event Date"></asp:TextBox>
            </label>
            <label>
                Event Location<asp:TextBox CssClass="input" ID="TextBox3" runat="server" placeholder="Location"></asp:TextBox>
            </label>
            <label>
                Event Type<asp:DropDownList CssClass="input" ID="DropDownList1" runat="server">
                    <asp:ListItem Text="Concert" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Sport" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Festivals" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Theatre" Value="4"></asp:ListItem>
                </asp:DropDownList>
            </label>
            <label>
                Price<asp:TextBox CssClass="input" ID="TextBox4" runat="server" TextMode="Number" placeholder="Price"></asp:TextBox>
            </label>
            <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Add Event" OnClick="Button1_Click" />
            <a href="homepage.aspx" style="color: aquamarine; font-size: 12px;">👈Return to Home
</a>
        </div>

    </div>
</asp:Content>
