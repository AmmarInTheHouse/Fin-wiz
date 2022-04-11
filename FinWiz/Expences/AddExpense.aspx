<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddExpense.aspx.cs" Inherits="FinWiz.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Expences.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Add Expenses</h2>
    <br />

    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="lblCategory" runat="server" Text="Category"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:DropDownList ID="ddlCategory" class="btn btn-success" runat="server">
                    <asp:ListItem Enabled="true" Text="Select Expense" Value="-1"></asp:ListItem>
                    <asp:ListItem Text="Travel" Value="Travel"></asp:ListItem>
                    <asp:ListItem Text="Stationary" Value="Stationary"></asp:ListItem>
                    <asp:ListItem Text="Misc" Value="Misc"></asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVddlCategory" runat="server" ErrorMessage="Please choose Category" ControlToValidate="ddlCategory" InitialValue="-1" ValidationGroup="AddExpenseValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="lblExpenseName" runat="server" Text="Expense Name :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txtExpeseName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxtExpeseName" runat="server" ErrorMessage="Please Enter Expense Name" ControlToValidate="txtExpeseName" InitialValue="" ValidationGroup="AddExpenseValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="lblDescription" runat="server" Text="Description :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="lblDate" runat="server" Text="Date :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txtDate" TextMode="Date" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxtDate" runat="server" ErrorMessage="Please choose Expense Date" ControlToValidate="txtDate" InitialValue="" ValidationGroup="AddExpenseValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="lblAmount" runat="server" Text="Amount :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxtAmount" runat="server" ErrorMessage="Please choose Your Expense Amount" ControlToValidate="txtAmount" InitialValue="" ValidationGroup="AddExpenseValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>           
        </asp:TableRow>
    </asp:Table>

    <br />
    <asp:Button ID="btnSubmit" class="btn btn-outline-success" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="AddExpenseValidate" CausesValidation="true"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClear" class="btn btn-outline-success" runat="server" Text="Clear" OnClick="btnClear_Click" />
    <br />

</asp:Content>
