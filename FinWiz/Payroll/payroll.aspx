<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="payroll.aspx.cs" Inherits="FinWiz.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Update PayRoll</h2>

    <asp:Label runat="server" Font-Bold="true" Text="Employee ID : "></asp:Label>
    <asp:TextBox ID="txt_emp_id" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RFVtxt_emp_id" runat="server" ErrorMessage="Please Enter Employee ID to find Particular Employee Payroll" ControlToValidate="txt_emp_id" InitialValue="" ValidationGroup="PayrollValidate" ForeColor="red">
    </asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="REVtxt_emp_id" runat="server" ControlToValidate="txt_emp_id"
        ValidationExpression="EMP[0-9]{8}" ForeColor="red"
        ErrorMessage="Invalid Employee ID."
        ValidationGroup="PayrollValidate" Display="Dynamic">
    </asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Button ID="findpayroll" class="btn btn-outline-success" runat="server" Text="Payroll Info" OnClick="findpayroll_Click" CausesValidation="true" ValidationGroup="PayrollValidate"/>
    <br />
    <div id="tabledata" runat="server">
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableHeaderCell>Employee Name : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label  runat="server" ID="EmpName" Text=""></asp:Label></asp:TableCell> 
            </asp:TableRow>
          
            <asp:TableRow>
                <asp:TableHeaderCell>Employee Salary : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label  runat="server" ID="EmpSal" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Employee Expense : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="EmpExp" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Employee Total : ($)</asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="EmpTotal" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Pay Stub Date : </asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:Label ID="PayDate" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Federal Tax : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="FedTax" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Vacation Pay : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="VacPay" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>CPP : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="Cpp" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>EI : </asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="Ei" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>Total Deductions</asp:TableHeaderCell>
                <asp:TableCell><asp:Label ID="TD" runat="server" Text=""></asp:Label></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Payroll Date"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="btn_generate_payroll" CssClass="btn btn-outline-primary" runat="server" Text="Generate Payroll" OnClick="btn_generate_payroll_Click" />
    </div>
</asp:Content>
