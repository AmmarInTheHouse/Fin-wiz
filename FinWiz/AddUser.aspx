<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="temp.aspx.cs" Inherits="FinWiz.index" %>
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
    <h2>Employee Information Form</h2>
    <br />
    <div id="img123">
        <asp:Image ID="Image1" runat="server" src="EmpImg/default.png" />
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" class="btn btn-outline-success" runat="server" onchange="ImagePreview(this);"/>
        <br />
        <br />
    </div>
    <asp:Table ID="Table1" runat="server" CssClass="table">
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label1" runat="server" Text="Employee ID :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label2" runat="server" Text="Employee Name :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label3" runat="server" Text="Employee Email :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label4" runat="server" Text="Employee Address :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label5" runat="server" Text="Employee Phone :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label6" runat="server" Text="Employee Emergency Contact Name :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label7" runat="server" Text="Employee Emergency Contact Number :"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label8" runat="server" Text="Employee SIN Number"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableHeaderCell><asp:Label ID="Label9" runat="server" Text="Emp Role"></asp:Label></asp:TableHeaderCell>
            <asp:TableCell><asp:DropDownList class="btn btn-success" ID="DropDownList1" runat="server">
                                <asp:ListItem>Admin</asp:ListItem>
                                <asp:ListItem>Employee</asp:ListItem>
                           </asp:DropDownList>

            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    <asp:Button ID="Button1" class="btn btn-outline-success" runat="server" Text="Update" />&nbsp;
    <asp:Button ID="Button2" class="btn btn-outline-success" runat="server" Text="Save" />&nbsp;
    <asp:Button ID="Button3" class="btn btn-outline-success" runat="server" Text="Cancle" />
    
</asp:Content>
