<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="RemoveUsers.aspx.cs" Inherits="TicketBookingSystem.RemoveUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 90vh; overflow: hidden; text-align: center;">
        <h1>Users Avaiable:</h1>
        <div style="width: 60%; margin: 0 auto; display: flex; justify-content: center;">
            <asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
            <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Delete User" OnClick="Button1_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BorderWidth="0">
            <Columns>
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
                <asp:BoundField DataField="user_name" HeaderText="User Name" />
                <asp:BoundField DataField="user_email" HeaderText="Email Address" />
                <asp:BoundField DataField="user_phone" HeaderText="Phone No." />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
