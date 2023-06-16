// Создать 3 различных сотрудника и сделать компараторы на сравнение по зарплате, 
// возрасту и сроку службы.

//     1 Используя метод forEach и lambda-функции, вывести получившихся сотрудников 
//     в консоль.
//     2 Вывести всех сотрудников, у которых зарплата выше 100 000.
//     3 Вывести сотрудника, у которого максимальная зарплата.
//     4 Сгруппировать всех сотрудников по имени.
//     5 Вывести сумму зарплат всех сотрудников.
//     6 Вывести среднюю зарплату сотрудников.

// При работе над данным заданием можно использовать LINQ.

namespace ComparerEmployee
{
    
    class Program
    {
        public delegate void Print(Employee[] employees);
        static void Main(string[]args)
        {
            var vlad = new Employee("Vlad", 20, 35000, 0);

            var leon = new Employee("Leon", 22, 40000, 1);

            var egor = new Employee("Egor", 21, 45000, 2);

            var alina = new Employee("Alina", 24, 75000, 4);

            var vlad2 = new Employee("Vlad", 25, 115000, 6);

            var egor2 = new Employee("Egor", 29, 125000, 7);

            var mark = new Employee("Mark", 32, 190000, 11);
            
            Employee[] employees = {vlad, vlad2, leon, egor, egor2, alina, mark};

            Array.Sort(employees, new WorkExperienceComparer());

            var print1 = (Employee[] employees) =>
            {
                Console.WriteLine("\nAll employees:\n");

                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"Name:{employee.Name}\tAge:{employee.Age}\tSalary: {employee.Salary} rubles\t Work experience: {employee.WorkExperience} years");
                }
            };

            print1(employees);

            
            while(true)
            {
                Console.WriteLine("\nTo display employees with a salary above 100 000 rubles ====== Enter 1");
                Console.WriteLine("To display the employee with the highest salary ============== Enter 2");
                Console.WriteLine("To display a list of employees sorted by name ================ Enter 3");
                Console.WriteLine("To display the sum of all salaries =========================== Enter 4");
                Console.WriteLine("To display the average salary ================================ Enter 5");
                Console.WriteLine("Enter any value to terminate the application...");
                Console.Write("Input: ");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1': Console.Clear();
                        OwnSortingSalary(employees);
                        break;
                    case '2': Console.Clear();
                        MaxSalary(employees);
                        break;
                    case '3': Console.Clear();
                        NameSort(employees);
                        break;
                    case '4': Console.Clear();
                        SumAllSalary(employees);
                        break;
                    case '5': Console.Clear();
                        AverageSalary(employees);
                        break;
                    default:
                        return;
                    
                }
            }
        }
        static void OwnSortingSalary(Employee[] employees)
        {
            Console.WriteLine("\nEmployees with a salary above 100 000 rubles:\n");

            foreach (Employee employee in employees)
            {
                if (employee.Salary >= 100000)
                    Console.WriteLine($"Name: {employee.Name}\tSalary: {employee.Salary} rubles");
            }
            ExitMainMenu();
        }
        static void MaxSalary(Employee[] employees)
        {
            Array.Sort(employees, new SalaryComparer());

            Console.WriteLine($"\nEmployee with the highest salary: {employees[employees.Length - 1].Name}");                

            Console.WriteLine($"\nSalary: {employees[employees.Length - 1].Salary}");

            ExitMainMenu();
        }
        static void NameSort(Employee[] employees)
        {
            Console.WriteLine("\nSort employees by name:\n");

            Array.Sort(employees, new NameComparer());

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name);
            }
            ExitMainMenu();
        }
        static void SumAllSalary(Employee[] employees)
        {
            Console.Write("\nThe sum of all salaries: ");

            int sum = 0;

            foreach (Employee employee in employees)
            {
                sum += employee.Salary;
            }
            Console.WriteLine(sum);

            ExitMainMenu();
        }
        static void AverageSalary(Employee[] employees)
        {
            Console.Write("\nAverage salary: ");

            int sum = 0;

            int divider = 0;

            foreach (Employee employee in employees)
            {
                sum += employee.Salary;

                ++divider;
            }
            sum /= divider;

            Console.WriteLine(sum);

            ExitMainMenu();
        }
        static void ExitMainMenu()
        {
            Console.WriteLine("\nTo exit to the main menu, enter any value: ");

            Console.ReadKey();

            Console.Clear();
        }
    }
}