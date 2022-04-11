<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="HistoryExpense.aspx.cs" Inherits="FinWiz.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/Expences.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>History of Expenses</h2>
    <br />
    <br />

    <asp:Label ID="EmployeeID" Font-Bold="true" runat="server" Text="EmployeeID : "></asp:Label>
    <asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox>&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RFVtxtEmpID" runat="server" ErrorMessage="Please Choose Employee ID" ControlToValidate="txtEmpID" InitialValue="" ValidationGroup="HistoryExpenseValidate" ForeColor="red">
    </asp:RequiredFieldValidator>
    <%--<asp:RegularExpressionValidator ID="REVtxtEmpID" runat="server" ControlToValidate="txtEmpID"
        ValidationExpression="EMP[0-9]{8}" ForeColor="red"
        ErrorMessage="Invalid Employee ID."
        ValidationGroup="HistoryExpenseValidate" Display="Dynamic">
    </asp:RegularExpressionValidator>--%>
    <br />
    <br />
    <asp:Label ID="from" Font-Bold="true" runat="server" Text="From : "></asp:Label>
    <asp:TextBox ID="txtSelectDate1" runat="server" TextMode="Date"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="to" Font-Bold="true" runat="server" Text="To : "></asp:Label>
    <asp:TextBox ID="txtSelectDate2" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnHistroy" class="btn btn-outline-success" runat="server" Text="Find History" OnClick="btnHistroy_Click" ValidationGroup="HistoryExpenseValidate" CausesValidation="true"/>
    <br />
    <br />
    <asp:Label ID="Employee" Font-Bold="true" runat="server" Text="Employee Name :"></asp:Label>
    <asp:Label ID="lblEmpName" runat="server"></asp:Label>
    <br />
    <br />
    <div id="exp_history_table" runat="server">
    </div>


</asp:Content>
