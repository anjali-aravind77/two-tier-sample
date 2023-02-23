<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllData.aspx.cs" Inherits="TwotierArchitecture.AllData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td>Name :</td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Age:</td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("age") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Photo:</td>
                            <td>
                                <asp:Image ID="Image1" runat="server" Height="106px" ImageUrl='<%# Eval("photo") %>' Width="102px" />
                            </td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
