<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="about.aspx.cs" Inherits="TicketBookingSystem.about" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 90%; margin: 0 auto;">
        <h2>About Eventhub</h2>
        <div style="display: flex; justify-content: space-between;">

            <div class="left" style="width: 48%;">
                <br />
                <h2 style="margin: 0;">Our Mission</h2>
                <p style="font-size: 1.2em; text-align: justify;">
                    At EventHub, our mission is to connect people with unforgettable experiences. We
                    believe that live events have the power to inspire, unite, and create lasting memories.
                    Our platform makes it easy for fans to discover and attend the events they love,
                    while providing event organizers with the tools they need to reach their audience.
                </p>
                <br />
                <h2>What We Offer</h2>
                <ul style="list-style: circle; font-size: 1.2em;">
                    <li style="margin-left: 40px;">A vast selection of events across various categories
                    </li>
                    <li style="margin-left: 40px;">User-friendly ticket purchasing and management</li>
                    <li style="margin-left: 40px;">Secure transactions and fraud protection</li>
                    <li style="margin-left: 40px;">Dedicated customer support</li>
                    <li style="margin-left: 40px;">Tools for event organizers to list and manage their events
                    </li>
                </ul>
            </div>
            <div class="right" style="width: 50%;">
                <img src="./images/pexels-wolfgang-1002140-2747449.jpg" width="650px" />
            </div>
        </div>
        <h2>Why Choose EventHub</h2>
        <div class="cards" style="display: flex; gap: 10px;">
            <div class="card" style="display: flex; flex-direction: column; border: 1px solid black;
                width: 32%; padding: 10px;">
                <h2>Global Reach</h2>
                <p>Access events from around the world, all in one place.</p>
            </div>
            <div class="card" style="display: flex; flex-direction: column; border: 1px solid black;
                width: 32%; padding: 10px;">
                <h2>Secure Booking</h2>
                <p>Our platform ensures safe and secure transactions for all users.</p>
            </div>
            <div class="card" style="display: flex; flex-direction: column; border: 1px solid black;
                width: 32%; padding: 10px;">
                <h2>24/7 Support</h2>
                <p>Our dedicated team is always ready to assist you with any queries.</p>
            </div>
        </div>
    </div>
</asp:Content>
