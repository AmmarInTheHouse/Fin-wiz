using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinWiz
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        FinWizService wizService = new FinWizService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Generatepayroll_Click(object sender, EventArgs e)
        {
            wizService.CheckLastPayroll("EMP20180001");
        }
    }
}