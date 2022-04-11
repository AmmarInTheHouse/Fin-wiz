<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="FinWiz.Users.AddUser" %>

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
    <h2>Add Employee</h2>
    <br />
    <div id="img123">
        <asp:Image ID="Image1" runat="server" src="../../EmpImg/default.png" />
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" class="btn btn-outline-success" runat="server" onchange="ImagePreview(this);" />
        <br />
        <br />
    </div>
    <asp:Table ID="Table1" runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label1" runat="server" Text="Employee UserName :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empID" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empID" runat="server" ErrorMessage="Please Enter Your UserName" ControlToValidate="txt_add_empID" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label2" runat="server" Text="Employee Name :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empName" runat="server" ErrorMessage="Please Enter Your Employee Name" ControlToValidate="txt_add_empName" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label3" runat="server" Text="Employee Email :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empEmail" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empEmail" runat="server" ErrorMessage="Please Enter Email Address" ControlToValidate="txt_add_empEmail" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RegularExpressionValidator ID="REVtxt_add_empEmail" runat="server" ControlToValidate="txt_add_empEmail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="red"
                    ErrorMessage="EmailID is not in correct Formate."
                    ValidationGroup="AddUserValidate"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label4" runat="server" Text="Employee Address :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empAdd" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label5" runat="server" Text="Employee Phone :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empPhone" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empPhone" runat="server" ErrorMessage="Please Enter Your Employee's contact Number" ControlToValidate="txt_add_empPhone" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
             <asp:TableCell>
                <asp:RegularExpressionValidator ID="REVtxt_add_empPhone" runat="server" ControlToValidate="txt_add_empPhone"
                    ValidationExpression="^([0-9]{10})$" ForeColor="red"
                    ErrorMessage="Invalid Contact Number"
                    ValidationGroup="AddUserValidate" Display="Dynamic"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label6" runat="server" Text="Employee Emergency Contact Name :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empEmName" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empEmName" runat="server" ErrorMessage="Please Enter Your Employee's Emergency Contact Name" ControlToValidate="txt_add_empEmName" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label7" runat="server" Text="Employee Emergency Contact Number :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empEmNum" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empEmNum" runat="server" ErrorMessage="Please Enter Employee's Emergency Contact Number" ControlToValidate="txt_add_empEmNum" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RegularExpressionValidator ID="REVtxt_add_empEmNum" runat="server" ControlToValidate="txt_add_empEmNum"
                    ValidationExpression="^([0-9]{10})$"
                    ErrorMessage="Invalid Emergency Contact Number"
                    ValidationGroup="AddUserValidate" Display="Dynamic"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label8" runat="server" Text="Employee SIN Number :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_add_empSIN" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_add_empSIN" runat="server" ErrorMessage="Please Enter Employee's SIN Number" ControlToValidate="txt_add_empSIN" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
                <asp:TableCell>
                    <asp:RegularExpressionValidator ID="REVtxt_add_empSIN" runat="server" ControlToValidate="txt_add_empSIN"
                        ValidationExpression="^([0-9]{9})$" ForeColor="red"
                        ErrorMessage="Invalid SIN Number. Please Enter 9 digit SIN Number"
                        ValidationGroup="AddUserValidate" Display="Dynamic"></asp:RegularExpressionValidator>
                </asp:TableCell>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label9" runat="server" Text="Emp Role :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:DropDownList class="btn btn-success" ID="dp_add_empRole" runat="server">
                    <%--<asp:ListItem Enabled="true" Text="Select Expense" Value="-1"></asp:ListItem>--%>
                    <asp:ListItem>Admin</asp:ListItem>
                    <asp:ListItem>Employee</asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVdp_add_empRole" runat="server" ErrorMessage="Please Choose Role" ControlToValidate="dp_add_empRole" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell>
                <asp:Label ID="Label10" runat="server" Text="Employee pay rate :"></asp:Label>
            </asp:TableHeaderCell>
            <asp:TableCell>
                <asp:TextBox ID="txt_pay_rate" runat="server"></asp:TextBox></asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RFVtxt_pay_rate" runat="server" ErrorMessage="Please Enter Employee's pay rate" ControlToValidate="txt_pay_rate" InitialValue="" ValidationGroup="AddUserValidate" ForeColor="red">
                </asp:RequiredFieldValidator>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RegularExpressionValidator ID="REVtxt_pay_rate" runat="server" ControlToValidate="txt_pay_rate"
                    ValidationExpression="^([0-9]{2})$" ForeColor="red"
                    ErrorMessage="Invalid Pay Rate. (Enter Payrate in 2 digits)"
                    ValidationGroup="AddUserValidate" Display="Dynamic"></asp:RegularExpressionValidator>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>      
    <br />
    <asp:Button ID="btn_add_adduser" class="btn btn-outline-success" runat="server" Text="Add" OnClick="btn_add_adduser_Click" ValidationGroup="AddUserValidate" CausesValidation="true"/>&nbsp;
    <asp:Button ID="btn_add_cancel" class="btn btn-outline-success" runat="server" Text="Cancel" OnClick="btn_add_cancel_Click" />
</asp:Content>
