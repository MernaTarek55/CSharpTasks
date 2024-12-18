using System;

namespace CsharpStruct
{
    public enum Gender
    {
        Male,
        Female,
        Programmer
    }

    struct Employee
    {
        private int id;
        private int salary;
        private int day, month, year;
        private Gender gender;

        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public void SetDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void GetSalary()
        {
            Console.WriteLine("Employee salary: " + salary);
        }

        public void GetGender()
        {
            Console.WriteLine("Employee gender: " + gender);
        }

        public void GetDate()
        {
            Console.WriteLine("Employee date: " + day + "/" + month + "/" + year);
        }

        public void GetId()
        {
            Console.WriteLine("Employee Id: " + id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees:");
            int numEmployees = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numEmployees];

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");

                Console.Write("Enter ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Salary: ");
                int salary = int.Parse(Console.ReadLine());

                Console.Write("Enter Gender (Male/Female/Programmer): ");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true);

                Console.Write("Enter hire Date (Day): ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("Enter hire Month: ");
                int month = int.Parse(Console.ReadLine());

                Console.Write("Enter hire Year: ");
                int year = int.Parse(Console.ReadLine());

                employees[i].SetId(id);
                employees[i].SetSalary(salary);
                employees[i].SetGender(gender);
                employees[i].SetDate(day, month, year);
            }

            Console.WriteLine("\nEmployee Details:");
            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}:");
                employees[i].GetId();
                employees[i].GetSalary();
                employees[i].GetGender();
                employees[i].GetDate();
            }

            Console.ReadLine();
        }
    }
}
