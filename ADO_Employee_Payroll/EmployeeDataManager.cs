using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_Employee_Payroll
{
    public class EmployeeDataManager
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double BasicPay { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }
        public Int64 EmployeePhoneNumber { get; set; }
        public string EmployeeDepartment { get; set; }
        public string Address { get; set; }
        public double Deduction { get; set; }
        public double IncomeTax { get; set; }
        public double TaxablePay { get; set; }
        public double NetPay { get; set; }

        //ER Diagram Elements
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        //Transaction
        public int IsActive { get; set; }


    }
}
