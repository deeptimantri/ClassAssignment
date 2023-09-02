using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
     class Employee
    {
        int EmpId, BasicSalary;
        string EmpName;
        double HRA, TA, PF,GrossSal;
        static int EmpCount = 0;
        const int PT = 200;

        public Employee(int _EmpId,string _EmpName,int _BasicSalary)
        {
            EmpId = _EmpId;
            EmpName = _EmpName;
            BasicSalary = _BasicSalary;
            EmpCount++;
        }
        public double CalcuateSalary()
        {
            HRA = BasicSalary * 0.40;
            TA = BasicSalary * 0.20;
            PF = BasicSalary * 0.12;
            GrossSal= BasicSalary+HRA+TA+PF;
            GrossSal -= PT;//deducting professional tax 200 rs
            return GrossSal;
        }
        public override string ToString()
        {
            return "Employee Id = " + EmpId + "\nEmployee Name = " + EmpName + "\nBasic Salary =" + BasicSalary+"\nGross Salary ="+ GrossSal;
        }
        public static void DisplayCount()
        {
            Console.WriteLine("Total numbers of employees are = "+ EmpCount);
        }
    }
}
