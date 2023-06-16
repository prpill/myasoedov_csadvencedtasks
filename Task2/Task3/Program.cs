//  Напишите метод, который будет подсчитывать количество цифр «2», используемых в десятичной записи целых чисел от 0 до n (включительно)

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("This program counts the digits \"2\" in the given number");

        ulong inputValue = (ulong)CheckInt();

        Console.Write("\nResult: ");

        int result = CountingNumber(inputValue);

        Console.WriteLine(result);
    }
    static int CountingNumber(ulong userValue)
    {
        string searchValue = $"{userValue}";

        int count = 0;

        foreach (var symbol in searchValue)
        {
            if (symbol == '2')
            {
                count++;
            }
        }
        return count;
    }
    static ulong? CheckInt()
    {
        try
        {
            Console.Write("\nInput: ");
            return ulong.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("\nInput error.");
            return null;
        }
    }
}