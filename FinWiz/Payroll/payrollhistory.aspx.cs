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
    public partial class WebForm6 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<table class='table table-bordered table-hover'>");
            
            TableRow row;
            var txt_username = DefaultVar.usersession;
            DataTable dt = wizService.get_payroll_history(txt_username);
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                row = new TableRow();
                //row.ID =  i;
                for (int j = 0; j < dt.Columns.Count; j++)

                {

                    TableCell cell = new TableCell();

                    cell.Text = dt.Rows[i][j].ToString();

                    row.Cells.Add(cell);

                }
                payroll_tbl.Rows.Add(row);
            }
            strHTMLBuilder.Append("</table>");

            string Htmltext = strHTMLBuilder.ToString();
        }
    }
}