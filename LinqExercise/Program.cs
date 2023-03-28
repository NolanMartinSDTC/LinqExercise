using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            var nums = numbers.ToList();

            //TODO: Print the Sum of numbers

            Console.WriteLine($"Sum of Numbers: {nums.Sum()}\n");

            //TODO: Print the Average of numbers

            Console.WriteLine($"Average of Numbers: {nums.Average()}\n");

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending Order: ");
            nums.OrderBy(num => num).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console

            Console.WriteLine("Descending Order: ");
            nums.OrderByDescending(num => num).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers Greater than 6: ");
            nums.Where(num => num > 6).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("4 Ascending Numbers: ");
            nums.OrderBy(num => num).Take(4).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Index 4 to My Age, Descending Order: ");
            nums[4] = 23;
            nums.OrderByDescending(num => num).ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            Console.WriteLine();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Employee Full Names starting with C, then S:");
            var employeesCS = employees.Where(employee => employee.FirstName[0] == 'C' || employee.FirstName[0] == 'S').OrderBy(employee => employee.FirstName).ToList();
            foreach (var employee in employeesCS)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees over 26: ");
            var employees26 = employees.Where(employee => employee.Age > 26).OrderBy(employee => employee.Age).ThenBy(employee => employee.FirstName).ToList();
            foreach (var employee in employees26)
            {
                Console.WriteLine($"Full Name: {employee.FullName}\nAge: {employee.Age}");
            }
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var employeeExp = employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35).Select(employee => employee.YearsOfExperience).ToList();

            Console.WriteLine($"Sum Years of Experience: {employeeExp.Sum()}\nAverage Years of Experience: {employeeExp.Average()}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()

            var newEmployee = new Employee("Nolan", "Martin", 23, 0);

            Console.WriteLine("List after Addition: ");
            var updatedList = employees.Append(newEmployee).ToList();
            foreach (var person in updatedList)
            {
                Console.WriteLine(person.FirstName);

            }


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
