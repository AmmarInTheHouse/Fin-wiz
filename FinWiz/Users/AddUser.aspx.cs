using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz.Users
{
    public partial class AddUser : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();

        protected void Update_Click(object sender, EventArgs e)
        {
           
        }
        protected void btn_add_cancel_Click(object sender, EventArgs e)
        {

        }

        [System.Web.UI.Themeable(false)]
        public virtual string ValidationGroup { get; set; }

        protected void btn_add_adduser_Click(object sender, EventArgs e)
        {
            string[] data = new string[10];
            data[0] = txt_add_empID.Text.ToString();
            data[1] = txt_add_empName.Text.ToString();
            data[2] = txt_add_empEmail.Text.ToString();
            data[3] = txt_add_empAdd.Text.ToString();
            data[4] = txt_add_empPhone.Text.ToString();
            data[5] = txt_add_empEmName.Text.ToString();
            data[6] = txt_add_empEmNum.Text.ToString();
            data[7] = txt_add_empSIN.Text.ToString();
            data[8] = dp_add_empRole.SelectedValue.ToString();
            data[9] = txt_pay_rate.Text.ToString();
            string result = wizService.add_user(data);
            if (result.Contains("success"))
            {
                Response.Redirect("../Users/AddUser.aspx");
            }
        }
    }
}