<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="TPWeb_equipo_11A.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">

 <div class="container mt-5">
     <h2 class="text-center mb-4">Ingresá tus datos</h2>

     <div class="row mb-3">
         <div class="col-md-4">
             <label for="txtDNI" class="form-label">DNI</label>
             <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="99888777"  />
         </div>
     </div>

     <div class="row mb-3">
         <div class="col-md-4">
             <label for="txtNombre" class="form-label">Nombre</label>
             <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" />
         </div>
         <div class="col-md-4">
             <label for="txtApellido" class="form-label">Apellido</label>
             <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido"/>
         </div>
         <div class="col-md-4">
             <label for="txtEmail" class="form-label">Email</label>
             <div class="input-group">
                 <span class="input-group-text">@</span>
                 <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="nombre@mail.com"/>
             </div>
         </div>
     </div>

     <div class="row mb-3">
         <div class="col-md-4">
             <label for="txtDireccion" class="form-label">Dirección</label>
             <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Calle 123" />
         </div>
         <div class="col-md-4">
             <label for="txtCiudad" class="form-label">Ciudad</label>
             <asp:TextBox ID="txtCiudad" runat="server" CssClass="form-control" placeholder="Ciudad" />
         </div>
         <div class="col-md-4">
             <label for="txtCP" class="form-label">CP</label>
             <asp:TextBox ID="txtCP" runat="server" CssClass="form-control" placeholder="xxxx" />
         </div>
     </div>

     <div class="form-check">
         <input class="form-check-input" type="checkbox" value="" id="checkDefault">
         <label class="form-check-label" for="checkDefault">
             Acepto los términos y condiciones
         </label>
     </div>

      <asp:ScriptManager ID="Registro" runat="server"></asp:ScriptManager>
     <asp:Button ID="btnParticipar" runat="server" Text="¡Participar!" CssClass="btn btn-primary" OnClick="btnParticipar_Click" />
 </div>

</asp:Content>
