<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LoginMD5.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>LINQ CON SQL SERVER</title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            DATA GRIED VIEW CON CONEXION DE LINQ A SQL SERVER.
        </div>
        <br />
        <br />
        <div align="center">
            <asp:GridView ID="gdvLogin" runat="server"></asp:GridView>
        </div>
        <br />
        <br />
        <div align="center">
            <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Contraseña :"></asp:Label>
            <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BorderStyle="Outset" OnClick="Button1_Click" Text="Registrar nuevo" />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblRegistrofinal" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
