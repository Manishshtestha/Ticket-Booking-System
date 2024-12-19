<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="AddUsers.aspx.cs" Inherits="TicketBookingSystem.AddUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 85vh; overflow-y: hidden;">
        <div class="addUsers">
            <h1>Add New User</h1>
            <label>
                Name
                <asp:TextBox CssClass="input" ID="TextBox1" runat="server"></asp:TextBox>
            </label>
            <label>
                Email
                <asp:TextBox CssClass="input" ID="TextBox2" runat="server"></asp:TextBox>
            </label>
            <label>
                Phone no.
                <asp:TextBox CssClass="input" ID="TextBox3" runat="server"></asp:TextBox>
            </label>
            <label>
                Password
                <asp:TextBox CssClass="input" ID="TextBox4" runat="server"></asp:TextBox>
            </label>
            <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Add User" OnClick="Button1_Click" />
            <a href="homepage.aspx" style="color: aquamarine; font-size: 12px;">👈Return to Home
</a>
        </div>
    </div>
</asp:Content>
