<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="generatepayroll.aspx.cs" Inherits="FinWiz.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Generate Payroll</h2>
    <br />
    <br />
    <asp:Button ID="Generatepayroll" runat="server" CssClass="btn btn-outline-success" Text="Generate Payroll" OnClick="Generatepayroll_Click"  />
    
</asp:Content>
