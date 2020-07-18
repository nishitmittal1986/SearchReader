<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchReader.aspx.cs" Inherits="SearchReadV1.SearchReader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        
        <asp:RadioButton ID="GoogleRdb" GroupName="SearchEngine" runat="server" Text="Google" Checked="true" />
        <asp:RadioButton ID="BingRdb" GroupName="SearchEngine" runat="server"  Text="Bing"/>
        <br />
        <asp:TextBox ID="SearchTxt" runat="server" Width="188px" Text="online title search" ></asp:TextBox>
        <br />        
        <asp:Button ID="RunBtn" runat="server" Text="Run" OnClick="RunBtn_Click" />
        <br />        
        <asp:Label ID="ShowLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>

</body>
</html>
