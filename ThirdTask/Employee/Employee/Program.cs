using System;

namespace Employee
{
    class Employee
    {
        public string name;
        public string secondName;
        public static string recruitmentDate;
        public OperateCost operationCost;


        public Employee(string name, string surname, string recruitmentDate, OperateCost opCost)
        {
            this.name = name;
            this.secondName = surname;
            Employee.recruitmentDate = recruitmentDate;
            this.operationCost = opCost;

        }
        public static double DiscoverGrade(string recruitmentDate)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(recruitmentDate)).TotalDays;
            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.1;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.5;
        }
    }
    class Developer : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (100000 + 3 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.22;
        }
    }

    class JuniorDeveloper : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (10000 + 1 * bonus) * grade;
        }

        public override void ApplyTax()
        {
            tax = salary * 0.22;
        }
    }
    abstract class OperateCost
    {
        public double salary;
        public double tax;

        public abstract void ApplyBonus(double bonus, double grade);
        public abstract void ApplyTax();
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperateCost oc = new JuniorDeveloper();
            Employee emp = new Employee("Олег", "Боренко", "11.06.2021", oc);
            double grade = Employee.DiscoverGrade("11.06.2021 ");
            Console.WriteLine("Имя: " + emp.name + ", Фамилия: " + emp.secondName + ", Должность: " + emp.operationCost);
            oc.ApplyBonus(25000, grade);
            oc.ApplyTax();
            Console.WriteLine("Зарплата: " + emp.operationCost.salary + ", Налог: " + emp.operationCost.tax);
            Console.ReadKey();
        }
    }
}
