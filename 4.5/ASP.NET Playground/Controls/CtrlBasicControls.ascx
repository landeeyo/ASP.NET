<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CtrlBasicControls.ascx.cs" Inherits="ASP.NET_Playground.Controls.CtrlBasicControls" %>

<asp:ScriptManager ID="scmMain" runat="server">
</asp:ScriptManager>

<asp:Label ID="lblLabel" runat="server"></asp:Label>
<br />
<asp:TextBox ID="txtTextBox" runat="server"></asp:TextBox>
<br />
<asp:DropDownList ID="ddlDropDownList" runat="server"></asp:DropDownList>
<br />
<asp:RadioButtonList ID="rblRadioButtonList" runat="server"></asp:RadioButtonList>
<br />
<asp:LinkButton ID="lbtLinkButton" runat="server" OnClick="lbtLinkButton_Click"></asp:LinkButton>
<br />
<asp:Button ID="btnButton" runat="server" OnClick="btnButton_Click" />
<br />
<asp:UpdatePanel ID="upaUpdatePanel" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Label ID="lblUpdatePanelLabel" runat="server" Text="Original text"></asp:Label>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnButton" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>