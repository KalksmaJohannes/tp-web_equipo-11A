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
                        <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
                            <div class="carousel-inner">
                                <asp:Repeater runat="server" ID="RepeaterImagen">
                                    <ItemTemplate>
                                        <div class="carousel-item <%# Container.ItemIndex == 0 ? "active" : "" %>">
                                            <asp:Image ID="Image" runat="server" ImageUrl='<%#Eval ("Url") %>' />
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval ("Descripcion")%></p>
                            <asp:Button Text="CANJEAR" ID="btnCanjear" runat="server" CssClass="btn btn-primary" CommandArgument= '<%#Eval ("Id")%>' CommandName="ArticuloId" OnClick="btnCanjear_Click"/>
  
                            
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
