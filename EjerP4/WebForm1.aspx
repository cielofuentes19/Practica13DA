<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Try3.WebForm1" %>
<link rel="stylesheet" href="bootstrap2.min.css">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <p>
        <br />
&nbsp;&nbsp; TABLAS DE NORTHWIND</p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CATEGORÍA Y PRODUCTOS</p>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCategorias" TypeName="Try3.WebService1"></asp:ObjectDataSource>
            <br />
            <br />
            <asp:GridView ID="GridView2" runat="server" DataSourceID="ObjectDataSource2">
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetProductos" TypeName="Try3.WebService1"></asp:ObjectDataSource>
            <br />
            <br />
            <br />
        </div>
        <div class="auto-style1">
            <br />
            DETALLE DE CATEGORÍA<br />
            <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="ObjectDataSource1" Height="50px" Width="223px">
            </asp:DetailsView>
        </div>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DETALLE DE PRODUCTOS</p>
        <div class="auto-style1">
            <asp:DetailsView ID="DetailsView2" runat="server" DataSourceID="ObjectDataSource2" Height="50px" Width="222px">
            </asp:DetailsView>
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
