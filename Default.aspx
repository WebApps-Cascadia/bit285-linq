<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET LINQ example</title>
</head>
<body>
  <h1>ASP.NET LINQ example</h1>
    <form id="form1" runat="server">
    <div>

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
<asp:GridView ID="ClassGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="ClassID" DataSourceID="LinqDataSource1">
    <Columns>
        <asp:BoundField DataField="ClassID" HeaderText="ClassID" ReadOnly="True" SortExpression="ClassID" />
        <asp:BoundField DataField="ClassName" HeaderText="ClassName" SortExpression="ClassName" />
    </Columns>
        </asp:GridView>
    </div>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="StudentsDatabaseDataContext" EntityTypeName="" TableName="Classes">
        </asp:LinqDataSource>
    </form>
</body>
</html>
