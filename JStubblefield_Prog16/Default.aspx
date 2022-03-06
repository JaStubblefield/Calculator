<%--
Jason Stubblefield
Program 16, Due 5/8/18
Partner names: None
Description: This program prints the greeting and the text boxes for a basic calculator
--%>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JStubblefield_Prog16.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
        Response.Write("<h1>Welcome to the CIS 139 Calculator App<h1>");
         %>
        <p style="font-size: 12pt">
        What is your name? <asp:TextBox ID="Name" runat="server"></asp:TextBox><br />
        What operation would you like to do? Enter addition, subtraction, multiplication, or division: 
        <asp:TextBox ID="Operation" runat="server"></asp:TextBox><br />
        Enter the first number: <asp:TextBox ID="X" runat="server"></asp:TextBox><br />
        Enter the second number: <asp:TextBox ID="Y" runat="server"></asp:TextBox><br />
        <asp:Button ID="Calculate" runat="server" Text="Calculate!" />
        </p>
    </div>
    </form>
</body>
</html>
