<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ASP.NET_Playground.Pages.ViewState" MasterPageFile="~/Master/Master.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="cphMain">
    <asp:Label ID="lblCounter" runat="server"></asp:Label>
    <asp:Button ID="btnPost" runat="server" Text="Click to postback" OnClick="btnPost_Click" />
</asp:Content>
