<%@ Page Title="" Language="C#" MasterPageFile="~/My.Master" AutoEventWireup="true" CodeBehind="Matiere.aspx.cs" Inherits="ControlleCodeFirst.Matiere1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="margin-left:30%;margin-top:2%">
        <asp:Label ID="lbTitre" runat="server" Text="Matière"></asp:Label>
    </h2>
    <p style="margin-left:30%;margin-top:2%">
&nbsp;
        <asp:TextBox ID="tbRechercher" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnRechercher" runat="server" Text="Rechercher" />
    </p>
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="524px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" DataKeyNames="Idm" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
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
    <asp:Label ID="lbAtomes" runat="server" Text="Atomes"></asp:Label>
&nbsp;&nbsp;&nbsp; 
    <asp:ListBox ID="lbAtome" runat="server" AppendDataBoundItems="True" OnInit="lbAtome_Init" OnSelectedIndexChanged="lbAtome_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:Label ID="lbEtat" runat="server" Text="Etat"></asp:Label>
&nbsp; 
    <asp:TextBox ID="tbEtat" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbName" runat="server" Text="Name"></asp:Label>
&nbsp;<asp:TextBox ID="tbName" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbMV" runat="server" Text="Mass Volumique"></asp:Label>
&nbsp;&nbsp; 
    <asp:TextBox ID="tbMV" runat="server" TextMode="Number"></asp:TextBox>
    <br />
&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>Rare</asp:ListItem>
        <asp:ListItem>Commun</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Button ID="btnAjouter" runat="server" Text="Ajouter" OnClick="btnAjouter_Click" />
    <asp:Button ID="btnModifier" runat="server" Text="Modifier" OnClick="btnModifier_Click" />
    <asp:Button ID="btnSupprimer" runat="server" Text="Supprimer" OnClick="btnSupprimer_Click" />
</asp:Content>
