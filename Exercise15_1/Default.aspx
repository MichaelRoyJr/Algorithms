<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color: #99CCFF; font-family: Arial; font-size: x-large; font-weight: bold; color: #000066;">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        .auto-style1 {
            font-size: xx-large;
            font-weight: normal;
        }
        #Text1 {
            width: 211px;
            height: 22px;
        }
        #Text2 {
            width: 211px;
            height: 22px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <h1 style="text-align: center" class="auto-style1">
            <strong>Exam Date Selector</strong></h1>
        <hr />
        <p style="text-align: left">
            &nbsp;</p>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" Height="34px" OnClick="Button1_Click" Text="Button" Width="72px" style="font-weight: 700; position: relative; text-align: center" />
        </p>
        <p>
            &nbsp;</p>
        <p style="width: auto; position: absolute; font-family: Arial; font-size: medium; font-weight: normal; color: #FF0000;">
            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p style="text-align: left">
            Name:
            <asp:TextBox ID="txtBxName" runat="server" Height="26px" Width="159px"></asp:TextBox>
        </p>
        <p style="text-align: left">
            Email:
            <asp:TextBox ID="txtBxEmail" runat="server" Height="26px" Width="157px"></asp:TextBox>
        </p>
    </form>
    
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    
</body>
</html>
