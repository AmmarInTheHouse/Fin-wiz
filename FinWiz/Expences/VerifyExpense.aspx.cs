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
    public partial class WebForm3 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder strHTMLBuilder = new StringBuilder();
            strHTMLBuilder.Append("<table class='table table-bordered table-hover'>");
            exp_details.Visible = false;
            TableRow row;
            DataTable dt = wizService.get_pending_expenses();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               

                    row = new TableRow();
                //row.ID =  i;
               
                TableCell cell1 = new TableCell();
                var Button = new Button
                {
                    //ID = "btnViewtable",
                    Text = "Accept",
                    CssClass = "btn btn-outline-success",
                    ToolTip = "Approve Expense by clicking on Accept...",
                    CommandArgument = i.ToString()

                };
                Button.Attributes.Add("Class", "btn btn-outline-success");
                //Button.ApplyStyle(new Style());
                Button.Click += rowclick;
                cell1.Controls.Add(Button);

                var Button1 = new Button
                {
                    //ID = "btnViewtable",
                    Text = "Reject",
                    CssClass = "btn btn-outline-danger",
                    ToolTip = "Reject Expense by clicking on Reject...",
                    CommandArgument = i.ToString()

                };
                Button1.Attributes.Add("Class", "btn btn-outline-danger");
                Button1.Click += rowclick1;
                cell1.Controls.Add(Button1);

                row.Cells.Add(cell1);
                for (int j = 0; j < dt.Columns.Count; j++)

                    {

                        TableCell cell = new TableCell();
                        
                        cell.Text = dt.Rows[i][j].ToString();

                        row.Cells.Add(cell);

                    }
                exp_tbl.Rows.Add(row);
            }
            strHTMLBuilder.Append("</table>");

            string Htmltext = strHTMLBuilder.ToString();
           

        }
        public void rowclick(object sender,EventArgs e)
        {
            int rowIndex = int.Parse( ((Button)sender).CommandArgument );
            wizService.ChangeExpenseStatus(exp_tbl.Rows[rowIndex + 1].Cells[1].Text,"Accepted");
            Response.Redirect("~/Expences/VerifyExpense.aspx");
        }
        public void rowclick1(object sender, EventArgs e)
        {
            int rowIndex = int.Parse(((Button)sender).CommandArgument);
            wizService.ChangeExpenseStatus(exp_tbl.Rows[rowIndex + 1].Cells[1].Text, "Rejected");
            Response.Redirect("~/Expences/VerifyExpense.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            exp_table.Visible = true;
        }
    }
}