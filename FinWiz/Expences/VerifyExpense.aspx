<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="VerifyExpense.aspx.cs" Inherits="FinWiz.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Expences.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <h2>Verify Expenses</h2>
            <br />
            <br />
            <div id="exp_table" runat="server">
                <asp:Label ID="Employee_Expense_List" Font-Bold="true" runat="server" Text="Employee's Expense List"></asp:Label>
                <br />
                <br />
                
                <asp:Table runat="server" CssClass="table table-bordered" ID="exp_tbl">
                    <asp:TableRow>
                         <asp:TableHeaderCell>View </asp:TableHeaderCell>
                        <asp:TableHeaderCell>Expense ID</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Expense Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Employee ID</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Category</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Description</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Expense Date</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Amount</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Status</asp:TableHeaderCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
            <br />
            <div id="exp_details" runat="server">
                <asp:Label ID="Employee_Expense_Details"  Font-Bold="true" runat="server" Text="Employee's Expense Details"></asp:Label>
                <br />
                <br />
                <asp:Table runat="server">
                    <asp:TableRow>
                        <asp:TableHeaderCell>Category :</asp:TableHeaderCell>
                        <asp:TableCell><asp:Label ID="lblCategory" runat="server"></asp:Label></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>Expense Name :</asp:TableHeaderCell>
                        <asp:TableCell><asp:Label ID="lblExpenseName" runat="server"></asp:Label></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>Description :</asp:TableHeaderCell>
                        <asp:TableCell><asp:Label ID="lblDescription" runat="server"></asp:Label></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>Date :</asp:TableHeaderCell>
                        <asp:TableCell><asp:Label ID="lblDate" runat="server" ></asp:Label></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell>Amount :</asp:TableHeaderCell>
                        <asp:TableCell><asp:Label ID="lblAmount" runat="server"></asp:Label></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell><asp:Label ID="lblReceipt" runat="server" Text="Receipt"></asp:Label></asp:TableHeaderCell>
                        <asp:TableCell><asp:Image ID="imgReceipt" runat="server" Height="334px" Width="455px" /></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableHeaderCell><asp:Label ID="lblReason" runat="server" Text="Reason"></asp:Label></asp:TableHeaderCell>
                        <asp:TableCell><textarea id="TextArea1" class="form-control" cols="20" name="S1" rows="3"></textarea></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
               <br />
                
            </div>
            <br />
            <br />

</asp:Content>
