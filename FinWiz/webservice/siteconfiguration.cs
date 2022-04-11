using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for siteconfiguration
/// </summary>
public static class siteconfiguration
{

    private readonly static string dbconnectionstring;
    private readonly static string dbprovidername;
	static siteconfiguration()
	{
		//
		// TODO: Add constructor logic here
		//
        dbconnectionstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        dbprovidername = ConfigurationManager.ConnectionStrings["connection"].ProviderName;
	}
    public static string DbConnectionstring()
    {
        return dbconnectionstring;
    }
}
