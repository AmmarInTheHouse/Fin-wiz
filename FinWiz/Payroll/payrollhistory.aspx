<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="payrollhistory.aspx.cs" Inherits="FinWiz.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="Payroll_table" runat="server">
               <h2> <asp:Label ID="Payroll_History_List" Font-Bold="true" runat="server" Text="Payroll History List"></asp:Label> </h2>
                <br />
                <br />
                
                <asp:Table runat="server" CssClass="table table-bordered"  ID="payroll_tbl">
                    <asp:TableRow>
                        <asp:TableHeaderCell>Employee Salary</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Gross Earning</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Net Earning</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Pay Stub Date</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Fedral Tax</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Vacation Pay</asp:TableHeaderCell>
                        <asp:TableHeaderCell>CPP</asp:TableHeaderCell>
                        <asp:TableHeaderCell>EI</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Total Deductions</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Printed by</asp:TableHeaderCell>
                    </asp:TableRow>
                </asp:Table>
            </div>

</asp:Content>
