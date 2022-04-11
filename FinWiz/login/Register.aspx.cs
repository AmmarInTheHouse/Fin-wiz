using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class Register : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.UI.Themeable(false)]
        public virtual string ValidationGroup { get; set; }

        protected void btn_cmp_reg_Click(object sender, EventArgs e)
        {
            string[] data = new string[13];
            data[0] = txt_reg_name.Text;
            data[1] = txt_reg_conno.Text;
            data[2] = txt_reg_add.Text;
            data[3] = txt_reg_email.Text;
            data[4] = txt_reg_username.Text;
            data[5] = txt_reg_password.Text;
            data[6] = txt_reg_repassword.Text;
            data[7] = txt_cmp_name.Text;
            data[8] = txt_cmp_add.Text;
            data[9] = txt_cmp_email.Text;
            data[10] = txt_cmp_conno.Text;
            data[11] = txt_cmp_url.Text;
            data[12] = txt_cmp_regid.Text;

            wizService.cmp_register(data);
            Response.Redirect("~/login/index.aspx");
        }

        protected void btn_cmp_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}