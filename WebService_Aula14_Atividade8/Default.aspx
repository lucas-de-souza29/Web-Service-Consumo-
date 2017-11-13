<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebService_Aula14_Atividade8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h1>Instituição</h1>
   <asp:GridView ID="GridView1" runat ="server" AutoGenerateColumns="false">
   <Columns>        
           <asp:BoundField DataField ="cepInstituicao" HeaderText ="Cep"/>
           <asp:BoundField DataField="cidadeInstituicao" HeaderText="Cidade"/>
           <asp:BoundField DataField="enderecoInstituicao" HeaderText="Endereco"/>
           <asp:BoundField DataField="estadoInstituicao" HeaderText="Estado"/>
           <asp:BoundField DataField="idInstituicao" HeaderText="IdInstituicao"/>
           <asp:BoundField DataField="idStatusInstituicao" HeaderText="IdStatus"/>
           <asp:BoundField DataField="nomeInstituicao" HeaderText="Nome"/>
           <asp:BoundField DataField="telefoneInstituicao" HeaderText="Telefone"/>
   </Columns>
   </asp:GridView>

</asp:Content>
