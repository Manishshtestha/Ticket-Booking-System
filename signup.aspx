<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="signup.aspx.cs" Inherits="TicketBookingSystem.signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 90vh; overflow-y: hidden;">
        <div class="signupCard">
            <h1>Register Form</h1>
            <div class="image-container">
                <img src="Images/member.png" />
            </div>

            <asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="Name"></asp:TextBox>
            <asp:TextBox CssClass="input" ID="TextBox2" runat="server" TextMode="Email" placeholder="Email"></asp:TextBox>
            <asp:TextBox CssClass="input" ID="TextBox3" runat="server" TextMode="Phone" placeholder="Phone"></asp:TextBox>
            <asp:TextBox CssClass="input" ID="TextBox4" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>

            <p style="color: red">
                **<i>Terms</i> and <i>Conditions</i> apply**
            </p>
            <span style="display: flex; justify-content: space-evenly;">
                <asp:Button CssClass="btn" ID="register" runat="server" Text="Register" OnClick="register_Click"
                     />
            </span>

            <a href="homepage.aspx" style="color: aquamarine; font-size: 12px;">👈Return to Home
            </a>
        </div>
    </div>

</asp:Content>
