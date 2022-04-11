using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.UI.Themeable(false)]
        public virtual string ValidationGroup { get; set; }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] data = new string[13];

            data[0] = ddlCategory.SelectedValue.ToString();

            data[1] = txtExpeseName.Text;

            data[2] = txtDescription.Text;

            data[3] = txtDate.Text;

            data[4] = txtAmount.Text;

            data[5] = DefaultVar.usersession;



            wizService.addexpense(data);

            Response.Redirect("~/Expences/AddExpense.aspx");

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Expences/AddExpense.aspx");
        }
    }
}