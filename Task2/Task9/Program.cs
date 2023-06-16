//  Дана строка, требуется преобразовать все идущие подряд пробелы в один.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program removes extra spaces");

        Console.Write("\nInput: ");

        string input = Console.ReadLine();

        Console.Write("\nOutput: ");

        string output = SpaceExclusion(input);

        Console.Write(output + "\n");
    }
    static string SpaceExclusion(string userInput)
    {
        while (true)
        {
            for (int i = 1; i < userInput.Length; i++)
            {
                if (userInput[i] == ' ' && userInput[i - 1] == ' ')
                {
                    userInput = userInput.Remove(i, 1);
                    break;
                }
                if (i == userInput.Length - 1)
                {
                    return userInput;
                }
            }
        }
    }
}