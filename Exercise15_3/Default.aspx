<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size: medium">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 19px; width: 891px">
    <form id="form1" runat="server">
        <div style="text-align: center; font-size: xx-large;">
            To Do List</div>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 68px; top: 243px; position: absolute; right: 777px;" Text="Name"></asp:Label>
        <asp:Label ID="lblItem" runat="server" style="z-index: 1; left: 68px; top: 317px; position: absolute; height: 19px" Text="Task to add"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 212px; top: 242px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtItem" runat="server" style="z-index: 1; left: 212px; top: 316px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 150px; top: 500px; position: absolute; height: 39px; width: 140px" Text="Add Task" OnClick="btnAdd_Click" />
        <asp:ListBox ID="lstTasks" runat="server" style="z-index: 1; left: 570px; top: 174px; position: absolute; height: 261px; width: 242px"></asp:ListBox>
        <asp:Button ID="btnRemove" runat="server" style="z-index: 1; left: 621px; top: 500px; position: absolute" Text="Remove Task" height="39px" OnClick="btnRemove_Click" width="140px" />
        <asp:Label ID="lblTasks" runat="server" style="z-index: 1; left: 658px; top: 128px; position: absolute" Text="Tasks" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 376px; top: 591px; position: absolute"></asp:Label>
    </form>
</body>
</html>
