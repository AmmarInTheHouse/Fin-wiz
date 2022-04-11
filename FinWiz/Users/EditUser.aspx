<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="FinWiz.Users.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://code.jquery.com/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function ImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image1.ClientID%>').prop('src', e.target.result)
                        .width(100)
                        .height(100);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Edit Employee</h2>
    <br />
    <div id="img123">
        <asp:Image ID="Image1" runat="server" src="../../EmpImg/default.png" />
        <br />
        <br />
        <asp:Label ID="Search_Emp" Font-Bold="true" runat="server" Text="Search Employee by ID : "></asp:Label>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>&nbsp;&nbsp;         
        <asp:RegularExpressionValidator ID="REVtxtSearch" runat="server" ControlToValidate="txtSearch"
            ValidationExpression="EMP[0-9]{8}" ForeColor="red"
            ErrorMessage="Invalid Employee ID."
            ValidationGroup="EditUserValidate" Display="Dynamic"></asp:RegularExpressionValidator>&nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" class="btn btn-outline-success" Text="Search" OnClick="btnSearch_Click" CausesValidation="true" ValidationGroup="EditUserValidate" />
        <br />
        <br />
    </div>
    <div id="userform" runat="server">
        <asp:Table ID="Table1" runat="server" CssClass="table">
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label1" runat="server" Text="Employee ID :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:Label ID="lblEmpID" runat="server" Text="Employee ID :"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label2" runat="server" Text="Employee Name :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label3" runat="server" Text="Employee Email :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmployeeEmail" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label4" runat="server" Text="Employee Address :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmpAddress" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label5" runat="server" Text="Employee Phone :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtempPhone" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label6" runat="server" Text="Employee Emergency Contact Name :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmpEmgContName" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label7" runat="server" Text="Employee Emergency Contact Number :"></asp:Label></asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmpEmgContNumber" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label8" runat="server" Text="Employee SIN Number"></asp:Label>
                </asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:TextBox ID="txtEmpSINnumber" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="Label9" runat="server" Text="Emp Role"></asp:Label>
                </asp:TableHeaderCell>
                <asp:TableCell>
                    <asp:DropDownList class="btn btn-success" ID="DropDownList1" runat="server">
                        <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Employee</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <br />
    <div id="formbtn" runat="server">
        <asp:Button ID="Button1" class="btn btn-outline-success" runat="server" Text="Update" OnClick="Button1_Click" />&nbsp;
    <asp:Button ID="btn_edit_delete" class="btn btn-outline-success" runat="server" Text="Delete" OnClick="Button2_Click" ToolTip="Enter Employee ID" />&nbsp;
    <asp:Button ID="Button3" class="btn btn-outline-success" runat="server" Text="Cancel" OnClick="Button3_Click"/>
    </div>
    <div>
        <span>
            <asp:Label ID="txt_delete_msg" runat="server"></asp:Label></span>
    </div>
</asp:Content>
