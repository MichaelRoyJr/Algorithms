<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #000066; background-color: #99CCFF">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFFFF; font-family: Arial, Helvetica, sans-serif; font-size: medium; color: #000066">
        <div style="font-family: Arial, Helvetica, sans-serif; font-size: xx-large; font-weight: bold; color: #000066; text-align: center; background-color: #99CCFF;">
            Exam Date Selection</div>
              
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 465px; top: 194px; position: absolute; height: 65px; width: 379px" Text="Label"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="#99CCFF" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="#000066" Height="190px" NextPrevFormat="FullMonth" style="z-index: 1; left: 88px; top: 133px; position: absolute; height: 188px; width: 259px" Width="350px" OnSelectionChanged="Page_Load">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" BackColor="#99CCFF" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="White" ForeColor="#000066" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#99CCFF" />
        </asp:Calendar>
        
    </form>
</body>
</html>
