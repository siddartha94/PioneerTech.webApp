<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetails.aspx.cs" Inherits="PioneeerTech.WebApp.UI.CompanyDetails1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="CompanyDetails" class="style1">
        <tr>
           <th>CompanyDetails</th>
        </tr>
        
        <tr id="Employer_NameRow">
            <td>
                <asp:Label ID="Employer_NameLabel" runat="server" Text="Employer_Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Employer_NameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="EmployeeIDRow">
            <td>
                <asp:Label ID="EmployeeIDLabel" runat="server" Text="EmployeeID"></asp:Label>   
            </td>
            <td>
                 <asp:DropDownList ID="EmployeeIDDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EmployeeIDDropDownList_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>
        <tr id="Contact_NumberRow">
            <td>
                <asp:Label ID="Contact_NumberLabel" runat="server" Text="ContactNumber"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="Contact_NumberTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="LocationRow">
            <td>
                <asp:Label ID="LocationLabel" runat="server" Text="Location"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="LocationTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="WebsiteRow">
            <td>
                <asp:Label ID="WebsiteLabel" runat="server" Text="Website"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="WebsiteTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="CompanyDetailsSave" runat="server" Text="Save" OnClick="CompanyDetailsSave_Click" />
            </td>
            <td>
                <asp:Button ID="CompanyDetailsEdit" runat="server" Text="Edit" OnClick="CompanyDetailsEdit_Click" />
            </td>
            <td>
                <asp:Button ID="CompanyDetailsClear" runat="server" Text="Clear" OnClick="CompanyDetailsClear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
