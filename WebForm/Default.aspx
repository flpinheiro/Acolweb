<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Tabuada</h1>

    <div>
        <p>Quantas tabuadas deseja gerar? <asp:TextBox runat="server" ID="Max" /></p>
        
        <asp:Button runat="server" ID="Gera" Text="Gerar Tabuadas" />
        <br />
        <asp:Label runat="server" ID="Tabuada"></asp:Label>
        <br />
    </div>

</asp:Content>
