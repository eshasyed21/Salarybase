using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryBaseSystem
{
       public class Employee
    {
        private int Employee_ID;
        private int Employee_Name;
        private int Employee_Salary;
        private int HoursWork;
        private int UnitProduce;

        public void C()
        {
            throw new System.NotImplementedException();
        }
    }
}



        public void Calculate_Salary()
        {
          if(hoursWorked>Base_Hours)
    {
        basePay = hourlyPayRate * BASE_Hours;
        overtimeHours = hoursWorked - BASE_Hours;
        overtimePay = overtimeHours * hourlyPayRate * OverTIME_RATE;
        unitPay = 3 * unitproduced;
        Grosspay = basePay + overtimePay + unitpay;
    }
        }
    
