<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="FormToDB.Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
           <table>
               <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Hva er ram?"></asp:Label></td><td>
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Hvordan kobler vi til wifi?"></asp:Label></td><td>
                       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Hva er en db?"></asp:Label></td><td>
                       <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   <td></td><td>
                       <asp:Button ID="ButtonSubmit" runat="server" Text="Send inn" OnClick="ButtonSubmit_Click" /></td>
               </tr>
           </table>

        </div>
    </form>
</body>
</html>
