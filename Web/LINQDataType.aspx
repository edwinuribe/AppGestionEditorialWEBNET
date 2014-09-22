<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LINQDataType.aspx.cs" Inherits="Web.LINQDataType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
            <table>
                <tr>
                    <td>

                        &nbsp;</td>
                    <td>

                    </td>
                </tr>
                 <tr>
                     <td ><asp:TextBox ID="tbResultado" runat="server" Enabled="False" Font-Bold="True" Font-Names="Consolas" Height="159px" TextMode="MultiLine" Width="650px" Font-Size="Medium"></asp:TextBox></td>
                 <td><asp:Button ID="btnEjecutar" runat="server" OnClick="btnEjecutar_Click" Text="Ejecutar" /></td>   
                 </tr>

            </table>
           
            
            
    <br />
    <br />
           
            
            
    <br />
</asp:Content>
