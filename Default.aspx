<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Archivos_Json._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                Carne:&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
            </p>
            <p>
                Nombre:<asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </p>
            <p>
                Apellido:<asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            </p>
            <p>
                Nota:&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxNota" runat="server"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="ButtonAddNotas" runat="server" OnClick="ButtonAddNotas_Click" Text="Agregar Notas" />
            </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Agregar Datos Alumno" />
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>&nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
