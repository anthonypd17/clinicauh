<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medico.aspx.cs" Inherits="clinicaUH.cVista.medico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css\menu.css" rel="stylesheet" />
    <link href="css\medico.css" rel="stylesheet" />
    <title></title>
</head>
<body>
<div class="menu-container">
    <a href="inicio.aspx" class="menu-item">Inicio</a>
    <a href="medico.aspx" class="menu-item">Médicos</a>
    <a href="paciente.aspx" class="menu-item">Pacientes</a>
    <a href="consulta.aspx" class="menu-item">Consultas</a>
</div>

    <form id="form1" runat="server">
        <div>
        <div class="form-container">
            <h1>Gestión de Médicos</h1>
            <div class="form-group">
                <label for="txtNombre">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEspecialidad">Especialidad:</label>
                <asp:TextBox ID="txtEspecialidad" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-buttons">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-agregar" OnClick="btnAgregar_Click" />
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-modificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-eliminar" OnClick="btnEliminar_Click" />
            </div>
            <asp:GridView ID="GridViewMedicos" runat="server" AutoGenerateColumns="false" CssClass="grid-view">
                <Columns>
                    <asp:BoundField DataField="id_medico" HeaderText="ID Médico" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="especialidad" HeaderText="Especialidad" />
                </Columns>
            </asp:GridView>
        </div>
            </div>
    </form>
</body>
</html>
