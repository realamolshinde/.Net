using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Console.WriteLine(m.CalcNetSalary());

            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        string name;
        int empNo;
        protected decimal basic;
        static int newEmp=0;
        public abstract decimal CalcNetSalary();

        public Employee(string name="Amol", int empNo=1, decimal basic=3000)
        {
            this.name = name;
            this.basic = basic;
            this.empNo += newEmp;
        }
        public string Name
        {
            set
            {
                if (value == "")
                    Console.WriteLine("Invalid");
                else
                    value = name;
                
            }
            get
            {
                return name;
            }
        }
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public decimal Basic
        {
            get
            {
                return basic;
            }
        }
    }
    //------------------------------------------------------------------
    public class Manager : Employee
    {
        private string designation;

        public Manager(string designation="Engineer", string name = "Amol", int empNo = 1, decimal basic = 3000) : base(name, empNo, basic)
        {
            this.designation= designation;
        }
        public string Designation
        {
            get
            {
                return designation;
            }
        }
        public override decimal CalcNetSalary()
        {
            basic = basic * (decimal)1.2;
            return basic;
        }
        
    }
    //--------------------------------------------------------------
    public class GeneralManager : Manager
    {
        string perks;

        public GeneralManager(string perks,string designation = "Engineer", string name = "Amol", int empNo = 1, decimal basic = 3000) : base(designation,name, empNo, basic)
        {
            this.Perks = Perks;
        }

        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }
        public override decimal CalcNetSalary()
        {
            return base.CalcNetSalary();
        }
    }

    //---------------------------------------------------------

    public class CEO : Employee
    {
        public CEO(string name = "Amol", int empNo = 1, decimal basic = 3000) : base(name, empNo, basic)
        {

        }
        public override decimal CalcNetSalary()
        {
            basic = basic * (decimal)1.7;
            return basic;
        }
    }
}
