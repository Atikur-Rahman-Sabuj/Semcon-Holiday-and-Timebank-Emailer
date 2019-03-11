using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semcon_Holiday_and_Timebank_Emailer.Models;

namespace Semcon_Holiday_and_Timebank_Emailer.DataAccess
{
    public class EmployeeDataAccess
    {
        public List<Employee> BindFileDataToModelForHoliday(String filePath)
        {
            String[] lines = System.IO.File.ReadAllLines(filePath);
            List<Employee> employees = new List<Employee>();
            if (lines.Length > 0)
            {
                for(int i = 1; i<lines.Length; i++)
                {
                    string[] dataRow = lines[i].Split(',');
                    int index = 0;
                    Employee employee = new Employee()
                    {
                        Name = dataRow[index++],
                        FirstName = dataRow[index++],
                        SurName = dataRow[index++],
                        Email = dataRow[index++],
                        HolidayTakenYTD = dataRow[index++],
                        RemainingHours = dataRow[index]
                    };
                    if(employee.Email!="")
                        employees.Add(employee);
                }
            }
            return employees;
        }
        public List<Employee> BindFileDataToModelForTimebank(String filePath)
        {
            String[] lines = System.IO.File.ReadAllLines(filePath);
            List<Employee> employees = new List<Employee>();
            if (lines.Length > 0)
            {
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataRow = lines[i].Split(',');
                    int index = 0;
                    Employee employee = new Employee()
                    {
                        Name = dataRow[index++],
                        FirstName = dataRow[index++],
                        SurName = dataRow[index++],
                        Email = dataRow[index++],
                        TotalTimebank = dataRow[index++],
                    };
                    if (employee.Email != "")
                        employees.Add(employee);
                }
            }
            return employees;
        }
    }
}
