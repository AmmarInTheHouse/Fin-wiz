<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetPassword.aspx.cs" Inherits="FinWiz.login.forgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="shortcut icon" href="../Logo/FinWiz.ico"/> 
    <title>FinWiz</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <link href="../CSS/forgetpassword.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="284px">
                <br />
                <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" onactivestepchanged="Unnamed1_FinishButtonClick" OnFinishButtonClick="Wizard1_FinishButtonClick" >
                    <HeaderStyle  HorizontalAlign="Center" />
                    <NavigationButtonStyle CssClass="btn btn-outline-success" />
                    <SideBarButtonStyle CssClass="steplink"  />
                    <SideBarStyle Width="100px" CssClass="sidebar" VerticalAlign="Top" />
                    <StepStyle CssClass="stepstyle" />
                    <WizardSteps>
                        <asp:WizardStep ID="Step1" Title="Step 1" runat="server">
                             <asp:Label ID="lbl_forget_email" runat="server" Text="Enter your Email Address:"></asp:Label>
                            <br />
                            <asp:TextBox ID="txt_forget_email" class="form-control" runat="server"></asp:TextBox>
                            <br />
                            <asp:Label ID="lbl_msg" runat="server" ></asp:Label>
                        </asp:WizardStep>
                        <asp:WizardStep ID="step2" Title="Step 2" runat="server">                            
                            <asp:TextBox ID="txt_step2_veriCode" runat="server"></asp:TextBox>
                            <asp:Button ID="btn_step2_veriCode" runat="server" Text="Verify" OnClick="btn_step2_veriCode_Click" /><br />
                            <asp:Label ID="lbl_step2_veriCode" runat="server" Text="" ForeColor="Green"></asp:Label>
                        </asp:WizardStep>
                        <asp:WizardStep ID="step3" Title="Step 3" runat="server">
                            <asp:Label ID="lbl_un" runat="server" Text="Username"></asp:Label>
                            <br />
                            <asp:TextBox ID="txt_username_retrive" class="form-control" runat="server" Enabled="false"></asp:TextBox>
                            <br /><br />
                            <asp:Label ID="lbl_psw" runat="server" Text="password"></asp:Label>
                            <br />
                            <asp:TextBox ID="txt_password_type" class="form-control" TextMode="Password" runat="server" ></asp:TextBox>
                            <br />
                            <asp:Label ID="lbl_repsw" runat="server" Text="re-password"></asp:Label>
                            <asp:TextBox ID="txt_repsw_type" TextMode="Password" class="form-control" runat="server"></asp:TextBox>
                            <br />
                            <asp:Label ID="tnx" runat="server"></asp:Label>
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
