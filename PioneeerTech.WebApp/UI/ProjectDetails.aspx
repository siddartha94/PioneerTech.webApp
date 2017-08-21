<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetails.aspx.cs" Inherits="PioneeerTech.WebApp.UI.ProjectDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table id="ProjectDetails">
        <tr>
           <th>ProjectDetails</th>
        </tr>
        <tr id="EmployeeIDRow">
            <td>
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="EmployeeID"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexchanged"></asp:DropDownList>   
            </td>
        </tr>
        <tr id="Project_NameRow">
            <td>
                Project_ID</td>
            <td>
                <asp:TextBox ID="Project_NameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Client_NameRow">
            <td>
                Client</td>
            <td>
                <asp:TextBox ID="Client_NameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="Client_NameRequiredFieldValidator" runat="server" ErrorMessage="Please enter client name" ControlToValidate="Client_NameTextBox" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="LocationRow">
            <td>
                Location_tx</td>
            <td>
                <asp:TextBox ID="LocationTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="RolesRow">
            <td>
                Roles_SW</td>
            <td>
                <asp:TextBox ID="RolesTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="ProjectDetailsSave" runat="server" Text="Save" OnClick="ProjectDetailsSave_Click" />
            </td>
            <td>
                <asp:Button ID="ProjectDetailsEdit" runat="server" Text="Edit" OnClick="ProjectDetailsEdit_Click" />
            </td>
            <td>
                <asp:Button ID="ProjectDetailsClear" runat="server" Text="Clear" OnClick="ProjectDetailsClear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
