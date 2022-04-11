using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee.Visible = false;
            var role = DefaultVar.userrole;
            if (role.Equals("Employee"))
            {
                txtEmpID.Enabled = false;
                var txt_username = DefaultVar.usersession;
                string[] res = wizService.get_emp_id(txt_username);
                if (res[0].Contains("success"))
                {
                    txtEmpID.Text = res[1];
                }

         
            }

        }

        protected void btnHistroy_Click(object sender, EventArgs e)
        {
          
            string[] Data = new string[3];
            Data[0] = txtEmpID.Text;
            Data[1] = txtSelectDate1.Text;
            Data[2] = txtSelectDate2.Text;
           

                StringBuilder strHTMLBuilder = new StringBuilder();
                strHTMLBuilder.Append("<table class='table table-bordered table-hover' Id='table1'>");
                DataTable dt = wizService.Emp_expenses(Data);
                foreach (DataColumn myColumn in dt.Columns)
                {
                    strHTMLBuilder.Append("<td >");
                    strHTMLBuilder.Append(myColumn.ColumnName);
                    strHTMLBuilder.Append("</td>");

                }

                foreach (DataRow myRow in dt.Rows)
                {

                    strHTMLBuilder.Append("<tr >");
                    foreach (DataColumn myColumn in dt.Columns)
                    {
                        strHTMLBuilder.Append("<td >");
                        strHTMLBuilder.Append(myRow[myColumn.ColumnName].ToString());
                        strHTMLBuilder.Append("</td>");

                    }
                    strHTMLBuilder.Append("</tr>");
                }
                //Close tags.  
                strHTMLBuilder.Append("</table>");

                string Htmltext = strHTMLBuilder.ToString();
                exp_history_table.InnerHtml = Htmltext;
            
        }
    }
}