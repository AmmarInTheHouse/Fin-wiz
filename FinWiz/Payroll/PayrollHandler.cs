using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinWiz.Payroll
{
    public class PayrollHandler
    {
        public string EmployeeID;
        public string EmployeeName;
        public double EmployeeSalary;
        public string EmployeeExpense;
        public double GrossEarning;
        public double NetEarning;
        public DateTime PayStubDate;
        public double FedTax;
        public double VacationPay;
        public double CPP;
        public double EI;
        public double TotalDeductions;
        public string PrintedBY;

        public PayrollHandler()
        {
        }

        public PayrollHandler(string EmployeeID,string EmployeeName, string EmployeeSalary,string EmployeeExpense,string PrintedBY)
        {
            this.EmployeeID= EmployeeID;
            this.EmployeeName= EmployeeName;
            this.EmployeeSalary= Convert.ToDouble(EmployeeSalary) ;
            this.EmployeeExpense = EmployeeExpense;
            this.PrintedBY= PrintedBY;
            DateTime utcNow = DateTime.UtcNow;
            this.PayStubDate = utcNow.Date;
        }
        public PayrollHandler(string EmployeeID, string EmployeeName, string EmployeeSalary, string EmployeeExpense,DateTime date, string PrintedBY)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = Convert.ToDouble(EmployeeSalary);
            this.EmployeeExpense = EmployeeExpense;
            this.PrintedBY = PrintedBY;
            this.PayStubDate = date;
        }
        public void CalculatePayrollForEmployee(PayrollHandler payrollHandler)
        {
          
            payrollHandler.GrossEarning = payrollHandler.EmployeeSalary * 40*4;
           
            payrollHandler.FedTax = payrollHandler.GrossEarning * 0.022;
            payrollHandler.CPP = payrollHandler.GrossEarning * 0.055;
            payrollHandler.EI = payrollHandler.GrossEarning * 0.0162;
            payrollHandler.VacationPay = payrollHandler.GrossEarning * -0.013;
            payrollHandler.TotalDeductions = payrollHandler.GrossEarning * 0.0932;
            payrollHandler.NetEarning = (payrollHandler.GrossEarning) + (payrollHandler.VacationPay)+(Convert.ToDouble(payrollHandler.EmployeeExpense)) -(payrollHandler.TotalDeductions);
        }

        
    }
}