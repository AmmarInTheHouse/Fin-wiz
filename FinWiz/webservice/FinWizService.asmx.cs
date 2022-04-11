using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.IO;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using FinWiz.Payroll;

namespace FinWiz
{
    /// <summary>
    /// Summary description for FinWizService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FinWizService : System.Web.Services.WebService
    {
        public object ClientScript { get; private set; }

        public FinWizService()
        {


            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string[] get_user_login(string[] data)
        {
            string[] result = { "", "", "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@username", data[0]);
                param[1] = new SqlParameter("@password", data[1]);

                DataTable dt = Dataacess.GetDataTable("Fiz_sp_get_user_login", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    result[0] = DefaultVar.success;
                    result[1] = data[0];
                    result[2] = dt.Rows[0]["EmpRole"].ToString();
                }
                else
                {
                    result[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                result[0] = DefaultVar.error;
                result[1] = ex.ToString();
            }

            return result;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string pwd_page(string pwd, string email)
        {
            string[] result = { "", "", "" };
            try
            {
                SqlParameter[] pwdparam = new SqlParameter[2];
                pwdparam[0] = new SqlParameter("@pwd", pwd);
                pwdparam[1] = new SqlParameter("@email", email);

                DataTable dt = Dataacess.GetDataTable("pwd_page", CommandType.StoredProcedure, pwdparam);
                if (dt != null && dt.Rows.Count > 0)
                {
                    result[0] = DefaultVar.success;
                    //result[1] = dt.Rows[0]["username"].ToString();
                }
                else
                {
                    result[0] = "nodata";

                }

            }
            catch (Exception ex)
            {
                result[0] = DefaultVar.error;
                result[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(result);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string ChangeExpenseStatus(string expID, string status)
        {
            string[] result = { "", "", "" };
            try
            {
                SqlParameter[] pwdparam = new SqlParameter[2];
                pwdparam[0] = new SqlParameter("@expID", expID);
                pwdparam[1] = new SqlParameter("@status", status);

                DataTable dt = Dataacess.GetDataTable("sp_changeexpensestatus", CommandType.StoredProcedure, pwdparam);
                if (dt != null && dt.Rows.Count > 0)
                {
                    result[0] = DefaultVar.success;
                    //result[1] = dt.Rows[0]["username"].ToString();
                }
                else
                {
                    result[0] = "nodata";

                }

            }
            catch (Exception ex)
            {
                result[0] = DefaultVar.error;
                result[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(result);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string get_forget_account(string EmpEmail)
        {
            string[] res = { "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@email", EmpEmail);

                DataTable dt = Dataacess.GetDataTable("Fiz_sp_get_forget_account", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["EmpEmail"].ToString();
                }
                else
                {
                    res[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(res);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string cmp_register(string[] data)
        {
            string[] result = { "", "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[13];
                param[0] = new SqlParameter("@reg_name", data[0]);
                param[1] = new SqlParameter("@reg_conno", data[1]);
                param[2] = new SqlParameter("@reg_add", data[2]);
                param[3] = new SqlParameter("@reg_email", data[3]);
                param[4] = new SqlParameter("@reg_username", data[4]);
                param[5] = new SqlParameter("@reg_password", data[5]);
                param[6] = new SqlParameter("@cmp_name", data[7]);
                param[7] = new SqlParameter("@cmp_add", data[8]);
                param[8] = new SqlParameter("@cmp_email", data[9]);
                param[9] = new SqlParameter("@cmp_conno", data[10]);
                param[10] = new SqlParameter("@cmp_url", data[11]);
                param[11] = new SqlParameter("@cmp_reg_id", data[12]);



                DataTable dt = Dataacess.GetDataTable("cmp_register", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    result[0] = DefaultVar.success;
                    result[1] = dt.Rows[0]["username"].ToString();
                }
                else
                {
                    result[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                result[0] = DefaultVar.error;
                result[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(result);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string add_user(string[] data)
        {
            string[] result1 = { "", "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("@emp_ID", data[0]);
                param[1] = new SqlParameter("@emp_Name", data[1]);
                param[2] = new SqlParameter("@emp_Email", data[2]);
                param[3] = new SqlParameter("@emp_Add", data[3]);
                param[4] = new SqlParameter("@emp_Phone", data[4]);
                param[5] = new SqlParameter("@emp_EmName", data[5]);
                param[6] = new SqlParameter("@emp_EmNum", data[6]);
                param[7] = new SqlParameter("@emp_SIN", data[7]);
                param[8] = new SqlParameter("@emp_Role", data[8]);
                param[9] = new SqlParameter("@emp_Pay", data[9]);

                DataTable dt = Dataacess.GetDataTable("add_user", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    result1[0] = DefaultVar.success;
                    string str_body;
                    //result1[1] = dt.Rows[0]["username"].ToString();
                    str_body = "<B> This is an auto generated mail</B><br/><br/>";
                    str_body = str_body + "<B>your password is  :</B>" + dt.Rows[0][0].ToString() + "<br/>";
                    string Subject = "your first time password";
                    SmtpClient smtpClient = new SmtpClient();
                    MailMessage message = new MailMessage();
                    MailAddress fromAddress;
                    fromAddress = new MailAddress("Finacialwiz@gmail.com", "OTP");
                    smtpClient.EnableSsl = true;
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    message.To.Add(data[2]);
                    message.From = fromAddress;
                    message.Subject = Subject;
                    message.IsBodyHtml = true;
                    message.Body = str_body;
                    NetworkCredential myCreds = new NetworkCredential("Finacialwiz@gmail.com", "finwiz123", "");
                    smtpClient.Credentials = myCreds;
                    smtpClient.Send(message);
                    //ClientScript.RegisterClientScriptBlock(this.GetType(), "InquirySent", "", true);

                }
                else
                {
                    result1[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                result1[0] = DefaultVar.error;
                result1[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(result1);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string[] get_check_user(string txtSearch)
        {
            string[] res = { "", "", "", "", "", "", "", "", "", "", "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@emp_ID", txtSearch);

                DataTable dt = Dataacess.GetDataTable("sp_check_user", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["EmpName"].ToString();
                    res[2] = dt.Rows[0]["EmpEmail"].ToString();
                    res[3] = dt.Rows[0]["EmpAddress"].ToString();
                    res[4] = dt.Rows[0]["EmpPhone"].ToString();
                    res[5] = dt.Rows[0]["EmpEmergencyContactName"].ToString();
                    res[6] = dt.Rows[0]["EmpEmergencyContactPhone"].ToString();
                    res[7] = dt.Rows[0]["EmpSINno"].ToString();
                    res[8] = dt.Rows[0]["EmpRole"].ToString();
                    res[9] = dt.Rows[0]["EmpPay"].ToString();

                }
                else
                {
                    res[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }

            return res;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string delete_account(string EmpEmail)
        {
            string[] resu = { "", "", "" };
            try
            {
                SqlParameter[] eparam = new SqlParameter[1];
                eparam[0] = new SqlParameter("@email", EmpEmail);

                DataTable dt = Dataacess.GetDataTable("Fiz_sp_delete_account", CommandType.StoredProcedure, eparam);
                if (dt != null && dt.Rows.Count > 0)
                {
                    resu[0] = DefaultVar.success;
                    //result[1] = dt.Rows[0]["username"].ToString();
                }
                else
                {
                    resu[0] = "nodata";

                }

            }
            catch (Exception ex)
            {
                resu[0] = DefaultVar.error;
                resu[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(resu);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string update(string[] data)
        {
            string[] result = { "", "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[13];
                param[0] = new SqlParameter("@emp_id", data[0]);
                param[1] = new SqlParameter("@emp_name", data[1]);
                param[2] = new SqlParameter("@emp_email", data[2]);
                param[3] = new SqlParameter("@emp_address", data[3]);
                param[4] = new SqlParameter("@emp_phone", data[4]);
                param[5] = new SqlParameter("@emp_emg_cont_name", data[5]);
                param[6] = new SqlParameter("@emp_emg_cont_number", data[6]);
                param[7] = new SqlParameter("@emp_sin_number", data[7]);
                param[8] = new SqlParameter("@emp_role", data[8]);



                DataTable dt = Dataacess.GetDataTable("update_emp", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    result[0] = DefaultVar.success;
                    //result[1] = dt.Rows[0]["username"].ToString();
                }
                else
                {
                    result[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                result[0] = DefaultVar.error;
                result[1] = ex.ToString();
            }

            return new JavaScriptSerializer().Serialize(result);
        }
        [WebMethod]

        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]

        public string addexpense(string[] data)

        {

            string[] result = { "", "", "" };

            try

            {

                SqlParameter[] param = new SqlParameter[13];

                param[0] = new SqlParameter("@exp_category", data[0]);

                param[1] = new SqlParameter("@exp_name", data[1]);

                param[2] = new SqlParameter("@exp_desc", data[2]);

                param[3] = new SqlParameter("@exp_date", data[3]);

                param[4] = new SqlParameter("@exp_amt", data[4]);

                param[5] = new SqlParameter("@exp_emp_id", data[5]);

                //param[8] = new SqlParameter("@cmp_email", data[9]);

                DataTable dt = Dataacess.GetDataTable("sp_add_expense", CommandType.StoredProcedure, param);

                if (dt != null && dt.Rows.Count > 0)

                {

                    result[0] = DefaultVar.success;

                    //result[1] = dt.Rows[0]["username"].ToString();

                }

                else

                {

                    result[0] = "nodata";

                }



            }

            catch (Exception ex)

            {

                result[0] = DefaultVar.error;

                result[1] = ex.ToString();

            }



            return new JavaScriptSerializer().Serialize(result);

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataTable get_pending_expenses()
        {
            string[] res = { "", "", "", "", "", "", "", "", "", "", "", "" };
            DataTable dt = null;
            try
            {
                SqlParameter[] param = new SqlParameter[1];

                dt = Dataacess.GetDataTable("sp_get_pending_expenses", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["Exp_ID"].ToString();
                    res[2] = dt.Rows[0]["Exp_name"].ToString();
                    res[3] = dt.Rows[0]["Exp_emp_ID"].ToString();
                    res[4] = dt.Rows[0]["Exp_category"].ToString();
                    res[5] = dt.Rows[0]["Exp_desc"].ToString();
                    res[6] = dt.Rows[0]["Exp_date"].ToString();
                    res[7] = dt.Rows[0]["Exp_amt"].ToString();
                    res[8] = dt.Rows[0]["Exp_status"].ToString();
                    //res[9] = dt.Rows[0]["Empwage"].ToString();
                }
                else
                {
                    res[0] = "nodata";
                }
            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }
            return dt;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataTable Emp_expenses(string[] Data)
        {
            string[] res = { "", "", "", "", "", "", "", "", "", "", "", "" };
            DataTable dt = null;
            try
            {
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@Emp_ID", Data[0]);
                param[1] = new SqlParameter("@Date1", Data[1]);
                param[2] = new SqlParameter("@Date2", Data[2]);

                dt = Dataacess.GetDataTable("Emp_all_expenses", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["exp_ID"].ToString();
                    res[2] = dt.Rows[1]["exp_name"].ToString();
                    res[3] = dt.Rows[2]["exp_emp_ID"].ToString();
                    res[4] = dt.Rows[3]["exp_category"].ToString();
                    res[5] = dt.Rows[4]["exp_desc"].ToString();
                    res[6] = dt.Rows[5]["exp_date"].ToString();
                    res[7] = dt.Rows[6]["exp_amt"].ToString();
                    res[8] = dt.Rows[7]["exp_status"].ToString();
                    //res[9] = dt.Rows[0]["Empwage"].ToString();
                }
                else
                {
                    res[0] = "nodata";
                }
            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }
            return dt;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void enterPayrollInfo(PayrollHandler pi)
        {
            var lastDayOfMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            SqlParameter[] param2 = new SqlParameter[15];
            param2[0] = new SqlParameter("@EmployeeID", pi.EmployeeID);
            param2[1] = new SqlParameter("@EmployeeName", pi.EmployeeName);
            param2[2] = new SqlParameter("@EmployeeSalary", pi.EmployeeSalary);
            param2[3] = new SqlParameter("@GrossEarning", pi.GrossEarning);
            param2[4] = new SqlParameter("@NetEarning", pi.NetEarning);
            param2[5] = new SqlParameter("@PayStubDate", pi.PayStubDate);
            param2[6] = new SqlParameter("@FedTax", pi.FedTax);
            param2[7] = new SqlParameter("@VacationPay", pi.VacationPay);
            param2[8] = new SqlParameter("@CPP", pi.CPP);
            param2[9] = new SqlParameter("@EI", pi.EI);
            param2[10] = new SqlParameter("@TotalDeductions", pi.TotalDeductions);
            param2[11] = new SqlParameter("@PrintedBy", pi.PrintedBY);
            param2[12] = new SqlParameter("@Date1", "01-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
            param2[13] = new SqlParameter("@Date2", lastDayOfMonth + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
            Dataacess.GetDataTable("SP_Generate_Payroll", CommandType.StoredProcedure, param2);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void CheckLastPayroll(string data)
        {

            string[] res = { "", "", "" };
            DateTime date = new DateTime().ToUniversalTime();
            var lastDayOfMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            try
            {
                SqlParameter[] param1 = new SqlParameter[1];
                DataTable dtemployee = Dataacess.GetDataTable("SP_Payroll_Update", CommandType.StoredProcedure, param1);
                List<PayrollHandler> payrollHandlers = new List<PayrollHandler>();
                PayrollHandler pl = new PayrollHandler();
                SqlParameter[] param = new SqlParameter[3];
                DataTable dt;

                for (int i = 0; i < dtemployee.Rows.Count; i++)
                {
                    param[0] = new SqlParameter("@Emp_ID", dtemployee.Rows[i]["EmpID"]);
                    param[1] = new SqlParameter("@Date1", "01/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                    param[2] = new SqlParameter("@endDate", lastDayOfMonth + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                    dt = Dataacess.GetDataTable("SP_Payroll_Expense", CommandType.StoredProcedure, param);
                    payrollHandlers.Add(new PayrollHandler(dtemployee.Rows[i]["EmpID"].ToString(), dtemployee.Rows[i]["EmpName"].ToString()
                        , dtemployee.Rows[i]["EmpPay"].ToString(), dt.Rows[0]["Total"].ToString(), "rink"));
                    pl.CalculatePayrollForEmployee(payrollHandlers[i]);
                    enterPayrollInfo(payrollHandlers[i]);
                }

            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string[] get_Payroll_info(string txt_emp_id)
        {
            string[] res = { "", "", "", "", "", "", "", "", "", "", "", "", "" };

            try
            {
                SqlParameter[] param = new SqlParameter[11];
                param[0] = new SqlParameter("@Emp_ID", txt_emp_id);
                DataTable dt = Dataacess.GetDataTable("Payroll_get_table", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["EmployeeName"].ToString();
                    res[2] = dt.Rows[0]["EmployeeSalary"].ToString();
                    res[3] = dt.Rows[0]["GrossEarning"].ToString();
                    res[4] = dt.Rows[0]["NetEarning"].ToString();
                    res[5] = dt.Rows[0]["PayStubDate"].ToString();
                    res[6] = dt.Rows[0]["FedTax"].ToString();
                    res[7] = dt.Rows[0]["VacationPay"].ToString();
                    res[8] = dt.Rows[0]["CPP"].ToString();
                    res[9] = dt.Rows[0]["EI"].ToString();
                    res[10] = dt.Rows[0]["TotalDeductions"].ToString();

                }
                else
                {
                    res[0] = "nodata";
                }
            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }
            return res;
        }

        public string calculateExpesnseForEmployee(string empID, string date1, string date2)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@Emp_ID", empID);
            param[1] = new SqlParameter("@Date1", date1);
            param[2] = new SqlParameter("@endDate", date2);
            DataTable dt = Dataacess.GetDataTable("SP_Payroll_Expense", CommandType.StoredProcedure, param);
            return dt.Rows[0]["Total"].ToString();
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataTable get_payroll_history(string txt_username)
        {
            string[] res = { "", "", "", "", "", "", "", "", "", "", "", "" };
            DataTable dt = null;
            try
            {
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@txt_username", txt_username);

                dt = Dataacess.GetDataTable("SP_Payroll_History", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["EmployeeSalary"].ToString();
                    res[2] = dt.Rows[0]["GrossEarning"].ToString();
                    res[3] = dt.Rows[0]["NetEarning"].ToString();
                    res[4] = dt.Rows[0]["PayStubDate"].ToString();
                    res[5] = dt.Rows[0]["FedTax"].ToString();
                    res[6] = dt.Rows[0]["VacationPay"].ToString();
                    res[7] = dt.Rows[0]["CPP"].ToString();
                    res[8] = dt.Rows[0]["EI"].ToString();
                    res[9] = dt.Rows[0]["TotalDeductions"].ToString();
                    res[9] = dt.Rows[0]["PrintedBy"].ToString();


                }
                else
                {
                    res[0] = "nodata";
                }
            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }
            return dt;
        }


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string[] get_emp_id(string txt_username)
        {
            string[] res = { "", "" };
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@txt_username", txt_username);

                DataTable dt = Dataacess.GetDataTable("SP_get_emp_id", CommandType.StoredProcedure, param);
                if (dt != null && dt.Rows.Count > 0)
                {
                    res[0] = DefaultVar.success;
                    res[1] = dt.Rows[0]["emp_ID"].ToString();


                }
                else
                {
                    res[0] = "nodata";
                }

            }
            catch (Exception ex)
            {
                res[0] = DefaultVar.error;
                res[1] = ex.ToString();
            }

            return res;
        }




    }
}
