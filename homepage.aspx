<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="homepage.aspx.cs" Inherits="TicketBookingSystem.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="section1">
            <h1>Discover and book amazing events</h1>
            <p>
                Find tickets for concerts, sports, arts, theater, and more. Your next unforgettable<br />
                experience is just a click away.
            </p>
            <div class="search_fields">

                <div class="inputFields">

                    <div class="inputGroup">
                        <label for="eventOrVenue">Event or Venue</label>
                        <asp:TextBox CssClass="input" ID="TextBox1" runat="server" placeholder="Event or Venue"></asp:TextBox>
                    </div>
                    <div class="inputGroup">
                        <label for="location">Location</label>
                        <asp:TextBox CssClass="input" ID="TextBox2" runat="server" placeholder="Kathmandu, Nepal"></asp:TextBox>
                    </div>
                    <div class="inputGroup">
                        <label for="date">Date</label>
                        <asp:TextBox CssClass="input" ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="inputGroup">
                        <label for="category">Category</label>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="Choose Category" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Concert" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Sport" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Festivals" Value="3"></asp:ListItem>
                            <asp:ListItem Text="Theatre" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                    </div>


                </div>
                <div style="margin-top:20px;">
                    <asp:Button CssClass="btn" ID="Button2" runat="server" Text="Find Events" OnClick="Button2_Click" />
                    <asp:Button CssClass="btn" ID="Button3" runat="server" Text="Clear Form" OnClick="Button3_Click" />
                </div>
            </div>
        </div>
        <div class="section2">
            <div style="width: 60%; margin: 0 auto; display: flex; justify-content: center;">
                <asp:TextBox CssClass="input" ID="TextBox4" runat="server" placeholder="Event ID"></asp:TextBox>
                <asp:Button CssClass="btn" ID="Button1" runat="server" Text="Book Ticket" OnClick="Button1_Click" />
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
    </div>

</asp:Content>
