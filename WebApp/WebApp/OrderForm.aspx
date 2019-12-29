<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderForm.aspx.cs" Inherits="WebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/WebForm1.aspx" runat="server">Go to Central Page</asp:HyperLink>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Order Form"></asp:Label>
        <br />
        <br />
        <br />
        Customer Details&nbsp;&nbsp;&nbsp;
        <asp:Literal ID="InfoID" runat="server"></asp:Literal>
        <br />
        <br />
        Name:<asp:TextBox ID="Namebo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Address:<asp:TextBox ID="Addbo" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; TK:<asp:TextBox ID="Tkbo" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Literal ID="Exc" runat="server"></asp:Literal>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Orders" />
        <br />
        <br />
        <br />
        Products<br />
        <br />
        <asp:CheckBox ID="Milkbo" runat="server" Text="MILK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="MilCou" TextMode="Number" min="1" max="20" step="1" runat="server" Height="46px" Width="112px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="Cheesebo" runat="server" Text="CHEESE" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="CheeCou" TextMode="Number" min="1" max="20" step="1" runat="server" Height="46px" Width="112px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Orderbutt" runat="server" OnClick="Orderbutt_Click" Text="ORDER" />
    </form>
</body>
</html>
