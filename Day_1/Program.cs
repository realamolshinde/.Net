using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();


            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o4.EMPNO);

            Console.ReadLine();
        }
    }
    class Employee
    {
        private string Name;
        private int EmpNo;
        private decimal Basic;
        private short DeptNo;
        private double Salary;
        private static int E;

        public Employee()
        {
            E++;
            EmpNo = E;
        }
        public Employee(string Name)
        {
            E++;
            EmpNo = E;
            this.Name = Name;
        }
        public Employee(string Name, decimal Basic)
        {
            E++;
            EmpNo = E;
            this.Name = Name;
            this.Basic = Basic;
        }
        
        public Employee(string Name, decimal Basic,short DeptNo)
        {
            E++;
            EmpNo = E;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public string NAME
        {
            set
            {
                if(value=="")
                    Console.WriteLine("Invalid");
                else
                    Name=value;
            }
            get
            {
                return Name;
            }
        }
        public int EMPNO
        {
            get
            {
                return EmpNo;
            }
        }
        public decimal BASIC
        {
            get
            {
                return Basic;
            }
        }
        public short DEPTNO
        {
            get
            {
                return DeptNo;
            }
        }
        public double SALARY
        {
            set
            {
                if (Basic > 10000)
                    Salary = (double)Basic + 5000;
                else
                    Salary = (double)Basic + 3000;
            }
        }
    }
}
