<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crud2.aspx.cs" Inherits="CrudOperationNew.Crud2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 72%;
            height: 211px;
            margin-left: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Employee ID</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Emaployee Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Employee Salary</td>
                <td>
                    <asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="SAVE" OnClick="btnSave_Click" />
                    <asp:Button ID="btnFind" runat="server" Text="FIND" OnClick="btnFind_Click" />
                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnDel" runat="server" Text="DELETE" OnClick="btnDel_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
