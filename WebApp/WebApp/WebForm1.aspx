<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/OrderForm.aspx" runat="server">Make An Order</asp:HyperLink>
            &nbsp; OR&nbsp;
            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/RegisterForm.aspx" runat="server">Register Customer</asp:HyperLink>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Customers" Width="200px" />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Orders" />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink3" NavigateUrl="~/OrderForm.aspx" runat="server">Delete An Order</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
