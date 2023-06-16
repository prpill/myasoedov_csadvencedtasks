// Дана коллекция класс Students 
// (с полями name — имя, age — возраст, sex — пол), вида List.of( new Students(«Вася», 16, Sex.MAN), 
// new Students(«Петя», 23, Sex.MAN), new Students(«Елена», 42, Sex.WOMAN), new Students(«Иван Иванович», 69, Sex.MAN)).

//     Выбрать кому придет повестка (от 18 до 27 лет).
//     Найти кол-во потенциальных работяг (т. е. от 18 лет и учитывая что женщины выходят в 55 лет, а мужчины в 60).


namespace SortingCollection
{
    class Program
    {
        static void Main(string[]args)
        {
            List <Student> students = new List<Student>()
            {
                new Student("Вася",16,Gender.Male),

                new Student("Женя",17,Gender.Female),

                new Student("Света",21,Gender.Female),

                new Student("Петя",23,Gender.Male),
                
                new Student("Елена",42,Gender.Female),

                new Student("Валерия Евгеньевна",57,Gender.Female),

                new Student("Иван Иванович",69,Gender.Male)
            };
            while(true)
            {
                Console.WriteLine("To display people who will receive a notofication ====== Enter 1");
                Console.WriteLine("To displey potential employee ========================== Enter 2");   
                Console.WriteLine("Enter any value to exit the application...");
                Console.Write("\nInput: ");
                switch(Console.ReadKey().KeyChar)
                {
                    case '1': Console.Clear();
                    PeopleWithNocide(students);
                        break;
                    case '2': Console.Clear();
                    PotentialEmployee(students);
                        break;
                    default:
                        return;
                }
            }
        }
        static void PeopleWithNocide(List<Student> students)
        {
            Console.WriteLine("\nPeople who will receive a notice:\n");

            var studentsWithNotice = from p in students
                                    where p.Age > 18 && p.Age < 27
                                    select p;
            foreach (Student student in studentsWithNotice)
            {
                Console.WriteLine($"Name: {student.Name} \tAge: {student.Age} \tGender: {student.Gender}");
            }
            ExitMainMenu();
        }
        static void PotentialEmployee(List<Student> students)
        {
            Console.WriteLine("\nList of potential employees: \n");

            var potentialEmployee = from p in students
                                    where p.Age > 18 && p.Gender == Gender.Male ? p.Age < 60 : p.Age < 55
                                    select p;
            foreach (Student student in potentialEmployee)
            {
                Console.WriteLine($"Name: {student.Name} \tAge: {student.Age} \tGender: {student.Gender}");
            }
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