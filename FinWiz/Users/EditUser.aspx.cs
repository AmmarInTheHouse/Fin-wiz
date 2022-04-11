using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz.Users
{
    public partial class EditUser : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {
            userform.Visible = false;
            formbtn.Visible = false;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string[] res = wizService.get_check_user(txtSearch.Text);
            if (res[0].Contains("success"))
            {
                userform.Visible = true;
                lblEmpID.Text = txtSearch.Text;
                txtEmployeeName.Text = res[1];
                txtEmployeeEmail.Text = res[2];
                txtEmpAddress.Text = res[3];
                txtempPhone.Text = res[4];
                txtEmpEmgContName.Text = res[5];
                txtEmpEmgContNumber.Text = res[6];
                txtEmpSINnumber.Text = res[7];
                if (res[8].Contains("Admin"))
                {
                    DropDownList1.SelectedIndex = 0;
                }
                else
                {
                    DropDownList1.SelectedIndex = 1;
                }
                formbtn.Visible = true;
                txt_delete_msg.Text = "";
            }
            else
            {
                txt_delete_msg.Text = "Employee Not Found!!!";
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string resu = wizService.delete_account(txtEmployeeEmail.Text);
            if (resu.Contains("nodata"))
            {
                txt_delete_msg.Text = "employee information deleted";
                userform.Visible = false;
                formbtn.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] data = new string[13];
            data[0] = txtSearch.Text;
            data[1] = txtEmployeeName.Text;
            data[2] = txtEmployeeEmail.Text;
            data[3] = txtEmpAddress.Text;
            data[4] = txtempPhone.Text;
            data[5] = txtEmpEmgContName.Text;
            data[6] = txtEmpEmgContNumber.Text;
            data[7] = txtEmpSINnumber.Text;
            data[8] = DropDownList1.SelectedValue;


            wizService.update(data);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}