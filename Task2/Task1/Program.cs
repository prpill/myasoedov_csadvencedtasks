// Напишите метод, который на вход получает коллекцию объектов, а возвращает коллекцию уже без дубликатов.

class Program
{

    static void Main(string[] args)
    {
        var myList = new List<string>(){"Egor", "Artem", "Nastya", "Lena", "Nastya","Artem"};

        dynamic noDuplicates = RemovingDuplicates(myList);

        foreach (var item in noDuplicates)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
    static dynamic RemovingDuplicates(dynamic inputList)
    {
        var OutputList = new List<string>();

        foreach (var item in inputList)
        {
            if (CheckedItem(item, OutputList))
            {
                OutputList.Add(item);
            }
        }
        return OutputList;
    }
    static bool CheckedItem(dynamic userItem,dynamic outputList)
    {
        foreach (var item in outputList)
        {
            if (item == userItem)
                return false;
        }
        return true;
    }
}
