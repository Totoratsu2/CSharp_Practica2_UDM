<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroFamilia.aspx.cs" Inherits="FormsAndUnitTesting.RegistroFamilia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">

        <center>
            <h1>Formulario de registro Familia</h1>
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
                    <asp:Label ID="lblIdentificacion" runat="server" Text="Identificación"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtIdentificacion" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEstrato" runat="server" Text="Estrato"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="ddlEstratos" runat="server" Width="264px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblBarrio" runat="server" Text="Barrio"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtBarrio" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtEdad" runat="server" Width="264px"></asp:TextBox>
                </td>
            </tr>
        </table>

        <center>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
        </center>
    </form>
</body>
</html>
