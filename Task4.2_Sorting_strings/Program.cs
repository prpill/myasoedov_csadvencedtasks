// Дана коллекция строк List.of(«a1», «a4», «a3», «a2», «a1», «a4»).

//     Отсортировать коллекцию строк по алфавиту
//     Добавить "_1" к каждому элементу
//     В коллекции убрать первый символ и вернуть массив чисел (int[])
//     Отсортировать коллекцию строк по алфавиту и убрать дубликаты
namespace Sorting
{
    class Program
    {
        static void Main(string[]args)
        {
            List<string> myList = new List<string>
            {
                "a1", "a4", "a3", "a2", "a1", "a4"
            };

            while (true)
            {
                Console.WriteLine("Main menu\n");

                Console.WriteLine("To display a collection of alphabetically sorted items");
                Console.WriteLine("To display a collection of strings with an added message");
                Console.WriteLine("To display a collection of numbers");
                Console.WriteLine("To display a collection of alphabetically sorted items without duplicates");
                Console.WriteLine("Enter any value to exit the application...");
                Console.Write("\nInput: ");

                Console.Write("Input: ");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1': Console.Clear();
                        SortAlphabetically(myList);
                        break;
                    case '2': Console.Clear();
                        AddToElement(myList);
                        break;
                    case '3': Console.Clear();
                        RemoveFirstChar(myList);
                        break;
                    case '4': Console.Clear();
                        RemoveDuplicate(myList);
                        break;
                    default:
                        return;
                }
            }
            
        }
        static void SortAlphabetically (List<string> userList)
        {
            var changedList = userList;

            changedList.Sort();

            InputList(changedList);
        }
        static void AddToElement(List<string> userList)
        {
            var changedList = new List<string>();

            Console.Write("Enter the message to be added to the items: ");

            string mes = Console.ReadLine();

            foreach (var item in userList)
            {
                changedList.Add(item + mes);
            }
            InputList(changedList);
        }
        static void RemoveFirstChar(List<string> userList)
        {
            var changedList = new List<int>();

            foreach (var item in userList)
            {
                int newItem = int.Parse(item.Remove(0,1));
                changedList.Add(newItem);
            }
            InputList(changedList);
        }
        static void RemoveDuplicate(List<string> userList)
        {
            var changedList = userList.Union(userList).ToList();
            
            changedList.Sort();

            InputList(changedList);
        }
        static void InputList<T>(List<T> changedList)
        {
            foreach (var item in changedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nTo exit to the main menu, enter any value: ");

            Console.ReadKey();

            Console.Clear();
        }
    }
}