﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_11A.Voucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="container text-center mt-5">
  <div class="mb-3">
    <label for="voucherInput" class="form-label fw-bold fs-5">INGRESÁ EL CÓDIGO DE TU VOUCHER</label>
    <asp:TextBox ID="voucherInput" runat="server" CssClass="form-control form-control-lg mx-auto" Style="max-width: 400px;" placeholder="XXXXXXXXXXXXX"/>
  </div>
       <asp:Button ID="btnAceptar" runat="server" Text="VALIDAR" CssClass="btn btn-primary text-white fw-bold px-4" OnClick="btnAceptar_Click" />
</div>
    
</asp:Content>
