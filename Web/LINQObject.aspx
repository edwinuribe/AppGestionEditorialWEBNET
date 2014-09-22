<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LINQObject.aspx.cs" Inherits="Web.LINQObject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="tbResultado" runat="server" Enabled="False" Font-Bold="True" Font-Names="Consolas" Height="293px" TextMode="MultiLine" Width="703px" Font-Size="Medium"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnEjecutar" runat="server" OnClick="btnEjecutar_Click" Text="Ejecutar" />
            </td>
        </tr>
    </table>
</asp:Content>
