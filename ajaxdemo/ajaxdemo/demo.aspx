<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo.aspx.cs" Inherits="ajaxdemo.demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
                    <asp:ListItem Value="5000">Surat</asp:ListItem>
                    <asp:ListItem Value="60000">Mumbai</asp:ListItem>
                    <asp:ListItem Value="8000">Pune</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </ContentTemplate>
        </asp:UpdatePanel>
    
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="6000" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="StudId" DataSourceID="SqlDataSource1" EnableModelValidation="True" GridLines="Horizontal" PageSize="2">
                    <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>
                        <asp:BoundField DataField="StudId" HeaderText="StudId" InsertVisible="False" ReadOnly="True" SortExpression="StudId" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Std" HeaderText="Std" SortExpression="Std" />
                    </Columns>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                </asp:GridView>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
    </form>
    <div>

        </div>
</body>
</html>
