<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="font-family: 'Courier New', Courier, monospace; color: #663300; background-color: #FFFF99;">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 'Courier New', Courier, monospace; background-color: #FFFF99; color: #663300;">
        <div style="font-family: 'Courier New', Courier, monospace; font-size: xx-large; font-weight: bold; color: #000000; text-align: center;">
            Computer Club T-Shirt Order Form</div>
        
        <p>
&nbsp;<asp:TextBox ID="txtBxFName" runat="server" style="z-index: 1; left: 189px; top: 189px; position: absolute; height: 20px; width: 154px;"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtBxEmail" runat="server" style="z-index: 1; left: 136px; top: 322px; position: absolute; bottom: 206px; width: 207px;"></asp:TextBox>
            <asp:RadioButton ID="rdoSmall" runat="server" style="z-index: 1; left: 598px; top: 195px; position: absolute; height: 21px" Text="Small" />
        </p>
        <asp:RadioButton ID="rdoMedium" runat="server" style="z-index: 1; left: 599px; top: 236px; position: absolute" Text="Medium" />
        <asp:RadioButton ID="rdoLarge" runat="server" style="z-index: 1; left: 599px; top: 281px; position: absolute; height: 20px; width: 70px;" Text="Large" />
        <asp:Label ID="lblSize" runat="server" style="z-index: 1; left: 620px; top: 139px; position: absolute; bottom: 391px;" Text="Size" Font-Size="Large" Font-Underline="True"></asp:Label>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 741px; top: 140px; position: absolute; height: 19px;" Text="Quantity" Font-Underline="True"></asp:Label>
        <asp:TextBox ID="txtBxSmall" runat="server" style="z-index: 1; left: 760px; top: 194px; position: absolute; width: 26px; height: 20px; bottom: 330px;"></asp:TextBox>
        <asp:TextBox ID="txtBxMedium" runat="server" style="z-index: 1; left: 761px; top: 234px; position: absolute" height="20px" width="26px"></asp:TextBox>
        <asp:TextBox ID="txtBxLarge" runat="server" style="z-index: 1; left: 760px; top: 279px; position: absolute" height="20px" width="26px"></asp:TextBox>
        <asp:TextBox ID="txtBxXLarge" runat="server" style="z-index: 1; left: 760px; top: 324px; position: absolute" height="20px" width="26px"></asp:TextBox>
        <p>
            <asp:TextBox ID="tvtBxPhone" runat="server" style="z-index: 1; left: 206px; top: 278px; position: absolute; height: 20px; width: 137px;"></asp:TextBox>
            <asp:Label ID="lblFName" runat="server" style="z-index: 1; left: 73px; top: 191px; position: absolute; height: 20px; width: 132px" Text="First Name"></asp:Label>
            <asp:Label ID="lblCustInfo" runat="server" style="z-index: 1; left: 108px; top: 140px; position: absolute; right: 631px;" Text="Customer Information" Font-Size="Large" Font-Underline="True"></asp:Label>
        </p>
        <asp:TextBox ID="txtBxLName" runat="server" style="z-index: 1; left: 175px; top: 234px; position: absolute; height: 20px; width: 169px;"></asp:TextBox>
        <asp:Label ID="lblLName" runat="server" style="z-index: 1; left: 74px; top: 235px; position: absolute; height: 21px;" Text="Last Name"></asp:Label>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 74px; top: 280px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 76px; top: 325px; position: absolute" Text="Email"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButton ID="rdoXLarge" runat="server" style="z-index: 1; left: 600px; top: 325px; position: absolute; height: 20px" Text="XLarge" />
        </p>
        <asp:Button ID="btnOrder" runat="server" Font-Bold="True" Font-Names="Courier New" Font-Size="X-Large" style="z-index: 1; left: 620px; top: 427px; position: absolute; height: 64px; width: 182px" Text="Place Order" BackColor="#FF9900" OnClick="btnOrder_Click" />
        <asp:Label ID="lblConfirm" runat="server" style="z-index: 1; left: 63px; top: 412px; position: absolute; height: 97px; width: 348px" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
