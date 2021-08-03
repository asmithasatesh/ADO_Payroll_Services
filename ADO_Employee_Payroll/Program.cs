using System;

namespace ADO_Employee_Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payroll Services using ADO!");
            //Create oobject for Employee Repository
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Console.WriteLine("Enter 1-To Read all Data from Sql server\nEnter 2-To Update Salary to 3000000\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    employeeRepository.GetSqlData();
                    break;
                case 2:
                    employeeRepository.UpdateSalaryQuery();
                    break;
                case 3:
                    EmployeeDataManager employeeDataManager = new EmployeeDataManager();
                    employeeDataManager.EmployeeName = "Rujula";
                    employeeRepository.RetrieveQuery(employeeDataManager);
                    break;
            }



        }
    }
}
