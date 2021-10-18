<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroBenefactor.aspx.cs" Inherits="FormsAndUnitTesting.RegistroBenefactor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 306px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <center>
            <h1>Formulario de registro Benefactor</h1>
        </center>

        <a href="/Index.aspx">Inicio</a>
        <a href="/RegistroFamilia.aspx">Registro Familia</a>
        <a href="/RegistroFundacion.aspx">Registro Fundacion</a>
        <a href="/RegistroBenefactor.aspx">Registro Benefactor</a>
        <hr />

        <center>
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </center>

        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="lblIdentificacion" runat="server" Text="Identificación"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIdentificacion" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAyuda" runat="server" Text="Ayuda"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAyuda" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
        </table>

        <center>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </center>

    </form>
</body>
</html>
