<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div _designerregion="0">
        Insert a list of numbers seperated by commas:<asp:TextBox ID="TextBox2" runat="server" Height="46px" Width="142px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sort" Width="80px" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>

</asp:Content>
