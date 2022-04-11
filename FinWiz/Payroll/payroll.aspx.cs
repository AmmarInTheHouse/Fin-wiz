using FinWiz.Payroll;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {

            }
            else
            {
                tabledata.Visible = false;
            }

        }

        protected void findpayroll_Click(object sender, EventArgs e)
        {

            string[] res = wizService.get_Payroll_info(txt_emp_id.Text);
            if (res[0].Contains("success"))
            {
                tabledata.Visible = true;
                EmpName.Text = res[1];
                EmpSal.Text = res[2];
                EmpExp.Text = res[3];
                EmpTotal.Text = res[4];
                PayDate.Text = res[5];
                FedTax.Text = res[6];
                VacPay.Text = res[7];
                Cpp.Text = res[8];
                Ei.Text = res[9];
                TD.Text = res[10];

            }
            else
            {

            }

        }

        protected void btn_generate_payroll_Click(object sender, EventArgs e)
        {
            tabledata.Visible = true;
            DateTime payrolldate = Calendar1.SelectedDate;
            var lastDayOfMonth = DateTime.DaysInMonth(payrolldate.Year, payrolldate.Month);
            string newexp = wizService.calculateExpesnseForEmployee(txt_emp_id.Text, "01/" + payrolldate.Month + "/" + payrolldate.Year, lastDayOfMonth + "/" + payrolldate.Month + "/" + payrolldate.Year);
            PayrollHandler payrollHandler = new PayrollHandler(txt_emp_id.Text, EmpName.Text, EmpSal.Text, newexp, payrolldate, "rink");
            payrollHandler.CalculatePayrollForEmployee(payrollHandler);
            if (payrollHandler.GrossEarning.Equals(EmpExp.Text))
            {

            }
            else
            {

                wizService.enterPayrollInfo(payrollHandler);
            }
        }
    }
}