<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sendmail.aspx.cs" Inherits="sendmail.sendmail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
            <td>TO</td>
            <td><asp:TextBox ID="to" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td>Subject</td>
            <td><asp:TextBox ID="subject" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
            <td>Subject</td>
            <td><asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
            <td><asp:Button ID="btnsend" runat="server" Text="send" onclick="btnsend_Click"></asp:Button></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
