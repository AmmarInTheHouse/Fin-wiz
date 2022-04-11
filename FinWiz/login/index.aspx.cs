using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class index1 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {
           // wizService.CheckLastPayroll("EMP20180001");
        }

        [System.Web.UI.Themeable(false)]
        public virtual string ValidationGroup { get; set; }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            
            string[] data = new string[3];
            data[0] = txt_username.Text.ToString();
            data[1] = txt_password.Text.ToString();
            string[] result = wizService.get_user_login(data);
            if (result[0].Equals("success"))
            {
                DefaultVar.usersession = result[1];
                //DefaultVar.usersession = txt_username.Text;
                DefaultVar.userrole = result[2];
                Response.Redirect("../main.aspx");
                
            }
            else
            {
                clearform();
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Please Enter Valid credential !!!')</script>");

            }

        }

        private void clearform()
        {
           txt_username.Text = null;
           txt_password.Text = null;
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login/forgetPassword.aspx");
        }
    }
}