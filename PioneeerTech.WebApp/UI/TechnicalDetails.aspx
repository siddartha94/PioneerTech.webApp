<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="TechnicalDetails.aspx.cs" Inherits="PioneeerTech.WebApp.UI.TechnicalDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="TechnicalDetails" class="style1">
        <tr>
           <th>TechnicalDetails</th>
        </tr>
         <tr id="EmployeeIDRow">
            <td>
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="EmployeeID"></asp:Label>   
            </td>
            <td>
                 <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged"></asp:DropDownList>

            </td>
        </tr>
        <tr id="UIRow">
            <td>
                <asp:Label ID="UILabel" runat="server" Text="UI"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="UITextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Programming_LanguagesRow">
            <td>
                <asp:Label ID="Programming_LanguagesLabel" runat="server" Text="Programming_Languages"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Programming_LanguagesTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
       
        <tr id="DatabasesRow">
            <td>
                <asp:Label ID="DatabasesLabel" runat="server" Text="Databases"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="DatabasesTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="TechnicalDetailsSave" runat="server" Text="Save" OnClick="TechnicalDetailsSave_Click" />
            </td>
            <td>
                <asp:Button ID="TechnicalDetailsEdit" runat="server" Text="Edit" OnClick="TechnicalDetailsEdit_Click" />
            </td>
            <td>
                <asp:Button ID="TechnicalDetailsClear" runat="server" Text="Clear" OnClick="TechnicalDetailsClear_Click" />
            </td>
        </tr>
        </table>
</asp:Content>
