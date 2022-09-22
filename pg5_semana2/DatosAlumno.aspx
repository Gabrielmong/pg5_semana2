<%@ Page 
    Language="C#"
    EnableEventValidation="false"
    AutoEventWireup="true"
    CodeBehind="DatosAlumno.aspx.cs"
    Inherits="pg5_semana2.WebForm1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div style="display: flex; flex-direction: column; align-items: center;">
            <asp:HiddenField runat="server" ID="hf_Control" />
            <div class ="Jumbotron">
                 <h3>Agregar un alumno</h3>
            </div>
            <p>Carné</p>
            <asp:TextBox ID="TxtCarne" runat="server"></asp:TextBox>
            <p>Nombre</p>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            <p>Edad</p>
            <asp:TextBox ID="TxtEdad" runat="server"></asp:TextBox>
            <p>Género</p>
            <asp:TextBox ID="TxtGenero" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="handleSave" style="margin-top: 1rem;"/>
            <h3>Mostrar Datos del alumno xd</h3>
            <asp:GridView  DataKeyNames="CARNE" ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:Panel ID="Panel1" runat="server" Visible="false">
                <div style="display: flex; flex-direction: column; align-items: center;">
                    <p>Carne</p>
                    <asp:TextBox ID="txtCarne1" runat="server"></asp:TextBox>
                    <p>Nombre</p>
                    <asp:TextBox ID="txtNombre1" runat="server"></asp:TextBox>
                    <div style="margin-top: 1rem;">
                        <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" OnClick="handleClose" />
                        <asp:Button ID="btnBorrar" runat="server" Text="Borrar" OnClick="handleDelete" />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
