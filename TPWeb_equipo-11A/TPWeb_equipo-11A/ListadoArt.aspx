<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListadoArt.aspx.cs" Inherits="TPWeb_equipo_11A.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>--%>
    <div class="row">
        <asp:Repeater runat="server" ID="RepeaterProducto" OnItemDataBound="RepeaterProducto_ItemDataBound">
            <ItemTemplate>
                <div class="col-4">
                    <div class="card" style="width: 18rem;">
                        <asp:Repeater runat="server" ID="RepeaterImagen">
                            <ItemTemplate>
                                <asp:Image ID="Image" runat="server" ImageUrl='<%#Eval ("Url") %>'/>
                            </ItemTemplate>
                        </asp:Repeater>    
                        <div class="card-body">
                            <h5 class="card-title" ><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval ("Descripcion")%></p>
                            <a href="#" class="btn btn-primary">Go somewhere</a>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
