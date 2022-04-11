using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace FinWiz.login
{
    public partial class forgetPassword : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        static string str_body = "";
        static int n = new Random().Next(1000, 9999);
        static Boolean verified = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SendEmail(string emailBody)
        {

            str_body = "<B> This is an auto generated mail</B><br/><br/>";
            str_body = str_body + "<B>your verification code :</B>" + n + "<br/>";
            string Subject = "your forget password verification code";
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            MailAddress fromAddress;
            fromAddress = new MailAddress("Finacialwiz@gmail.com", "Inquiry");
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            message.To.Add(txt_forget_email.Text.ToString());
            message.From = fromAddress;
            message.Subject = Subject;
            message.IsBodyHtml = true;
            message.Body = str_body;
            NetworkCredential myCreds = new NetworkCredential("Finacialwiz@gmail.com", "finwiz123", "");
            smtpClient.Credentials = myCreds;
            smtpClient.Send(message);
            ClientScript.RegisterClientScriptBlock(this.GetType(), "InquirySent", "", true);

        }

        protected void Unnamed1_FinishButtonClick(object sender, EventArgs e)
        {
            if (verified == false)
            {
                string res = wizService.get_forget_account(txt_forget_email.Text);
                if (res.Contains("success"))
                {
                    // Response.Redirect("../temp.aspx");
                    lbl_msg.Text = "Email is Found and Code is sent to your Email for Reset the Password!!!";
                    //code Generator to reset password

                    //lbl_msg.Text = n.ToString();
                    string sendEmail = ConfigurationManager.AppSettings["SendEmail"];
                    if (sendEmail.ToLower() == "true")
                    {
                        SendEmail(lbl_msg.ToString());
                        Wizard1.MoveTo(this.step2);

                    }

                }
                else
                {
                    //clearform();                    
                    if (txt_forget_email.Text == "")
                    {
                        lbl_msg.Text = "Please Enter You email ID...";
                    }
                    else {
                        lbl_msg.Text = "Invalid Email ID...";
                    }
                    Wizard1.MoveTo(this.Step1);
                }
            }
            if (verified == true)
            {
                Wizard1.MoveTo(this.step3);
            }

        }

        protected void btn_step2_veriCode_Click(object sender, EventArgs e)
        {
            Console.WriteLine(n);
            if (txt_step2_veriCode.Text == n.ToString())
            {
                verified = true;
                Wizard1.MoveTo(this.step3);
                txt_username_retrive.Text = txt_forget_email.Text;
            }
            else
            {
                lbl_step2_veriCode.Text = "Verification code does not match.";
                Wizard1.MoveTo(this.step2);
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, System.Web.UI.WebControls.WizardNavigationEventArgs e)
        {
            if (verified == true)
            {
                if ((txt_password_type.Text == txt_repsw_type.Text) && (txt_password_type.Text != null))
                {
                    tnx.Text = "Password has been reset successfully";
                    string result= wizService.pwd_page(txt_password_type.Text, txt_forget_email.Text);
                    if (result.Contains("success")) {
                        Response.Redirect("~/login/index.aspx");
                    }
                    else
                    {
                        tnx.Text = "Please Enter Valid Password !!!";
                    }
                }
            }
        }
    }
}