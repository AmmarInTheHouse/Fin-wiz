using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Net;
using System.Linq;

/// <summary>
/// Summary description for Dataacess
/// </summary>
public class Dataacess
{


   
    public Dataacess()
    {

        //
        // TODO: Add constructor logic here
        //
    }
    
    public static DataTable GetDataTable(String cmdText, CommandType cmdType, SqlParameter[] parameters)
    {
        try
        {
            string conString = siteconfiguration.DbConnectionstring();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    if (cmdType == null) cmd.CommandType = CommandType.StoredProcedure; else cmd.CommandType = cmdType;
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            if (null != parameter) cmd.Parameters.Add(parameter);
                        }
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();
                        con.Dispose();
                        return dt;
                    }
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    
    
}
