<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormsControls.aspx.cs" Inherits="ASP.NET_Playground.Pages.WebFormsControls" MasterPageFile="~/Master/Master.Master" %>
<%@ Register Src="~/Controls/CtrlBasicControls.ascx" TagPrefix="ctrl" TagName="Basic" %>

<asp:Content runat="server" ContentPlaceHolderID="cphMain">
    <ctrl:Basic ID="ctrlBasic" runat="server" />
</asp:Content>
