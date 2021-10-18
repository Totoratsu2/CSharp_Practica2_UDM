<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FormsAndUnitTesting.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
        <h1>Fe con obras de Amor</h1>
    </center>

    <a href="/Index.aspx">Inicio</a>
    <a href="/RegistroFamilia.aspx">Registro Familia</a>
    <a href="/RegistroFundacion.aspx">Registro Fundacion</a>
    <a href="/RegistroBenefactor.aspx">Registro Benefactor</a>
    <hr />

    <div>
        <h3>Total ayudas por estrato</h3>
        <ul>
            <li>
                <asp:Label ID="lblEstrato1" runat="server"></asp:Label></li>
            <li>
                <asp:Label ID="lblEstrato2" runat="server"></asp:Label></li>
            <li>
                <asp:Label ID="lblEstrato3" runat="server"></asp:Label></li>
            <li>
                <asp:Label ID="lblEstrato4" runat="server"></asp:Label></li>
            <li>
                <asp:Label ID="lblEstrato5" runat="server"></asp:Label></li>
            <li>
                <asp:Label ID="lblEstrato6" runat="server"></asp:Label></li>
        </ul>

        <h3>Edad promedio responsables de las familias</h3>
        <asp:Label ID="lblEdadPromedio" runat="server"></asp:Label>

        <h3>Cantidad de familias sin ayudas</h3>
        <asp:Label ID="lblFamiliasNoAyuda" runat="server"></asp:Label>

        <h3>Total ayudas</h3>
        <asp:Label ID="lblTotalAyudas" runat="server"></asp:Label>
    </div>

    <h3>Enviar ayuda a familia</h3>
    <center>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </center>
    <form id="form1" runat="server">

        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="lblIdentificacion" runat="server" Text="Identificacion de la familia"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtIdFamilia" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblValorAyuda" runat="server" Text="Valor ayuda"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtValorAporte" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
        </table>

        <center>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </center>

    </form>

</body>
</html>
