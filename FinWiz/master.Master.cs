using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var role = DefaultVar.userrole;

            if (role.Equals("Employee"))
            {
                AddUser.Visible = false;
                EditUser.Visible = false;
                VerifyExpence.Visible = false;
                Payroll.Visible = false;
                GeneratePayroll.Visible = false;
                navbarDropdown.Visible = false;

            }
        }

        protected void AddExpense_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Expences/AddExpense.aspx");
        }

        protected void VerifyExpence_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Expences/VerifyExpense.aspx");
        }

        protected void ExpenceHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Expences/HistoryExpense.aspx");
        }

        protected void Payroll_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Payroll/Payroll.aspx");
        }

        protected void GeneratePatroll_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Payroll/GeneratePayroll.aspx");
        }

        protected void PayrollHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Payroll/PayrollHistory.aspx");
        }

        protected void AddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Users/AddUser.aspx");
        }

        protected void EditUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Users/EditUser.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DefaultVar.usersession = null;
            Response.Redirect("~/login/index.aspx");
        }
    }
}