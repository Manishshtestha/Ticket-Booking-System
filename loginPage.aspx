<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="loginPage.aspx.cs" Inherits="TicketBookingSystem.loginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 90vh; overflow-y: hidden;">

        <div class="loginCard">
            <h1>Login Form</h1>
            <div>
                <img src="Images/member.png" />
            </div>
            <div style="display: none">
                <img src="Images/admin.png" />
            </div>
            <asp:TextBox CssClass="input" ID="TextBox1" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
            <asp:TextBox CssClass="input" ID="TextBox2" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>

            <span class="input" style="text-align:center;">
                <label for="adminCheck">
                    Is Admin?

                <asp:CheckBox ID="CheckBox1" runat="server" />
                </label>
            </span>
            <p style="color: red">
                **Logged in users must follow <i>terms</i> and <i>conditions</i>**
            </p>
            <span style="display: flex; justify-content: space-evenly;">
                <asp:Button CssClass="btn" ID="signin" runat="server" Text="Login" OnClick="signin_Click" />
                <a href="signup.aspx">
                    <input class="btn" id="signup" type="button" value="Register" /></a>
            </span>

            <a href="homepage.aspx" style="color: aquamarine; font-size: 12px;">👈Return to Home
            </a>
        </div>
    </div>
</asp:Content>
