<%@ Page Title="" Language="C#" MasterPageFile="~/My.Master" AutoEventWireup="true" CodeBehind="Produits.aspx.cs" Inherits="ControlleCodeFirst.Produits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="margin-left:30%;margin-top:2%">
        <asp:Label ID="lbProduit" runat="server" Text="Produit"></asp:Label>
    </h2>
    <p style="margin-left:30%;margin-top:2%">
&nbsp;
        <asp:TextBox ID="tbRechercher" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" />
    </p>
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="524px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" DataKeyNames="Idp" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
    <asp:Label ID="lbMatiere" runat="server" Text="Matieres"></asp:Label>
&nbsp;&nbsp;&nbsp; 
    <asp:ListBox ID="lbMatieres" runat="server" AppendDataBoundItems="True" OnInit="lbmat_Init" OnSelectedIndexChanged="lbAtome_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbName" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp; 
    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
    <br />&nbsp;<br />
    <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click" />
    <asp:Button ID="btnModifier" runat="server" Text="Modifier" OnClick="btnModifier_Click" />
    <asp:Button ID="btnSupprimer" runat="server" Text="Supprimer" OnClick="btnSupprimer_Click" />
</asp:Content>
