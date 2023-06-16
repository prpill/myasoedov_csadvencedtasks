//  Реализуйте метод сжатия строки на основе счетчика повторяющихся символов. 
//  Например, строка aabcccccaaa должна превратиться в а2b1с5аЗ. 
//  Если «сжатая» строка оказывается длиннее исходной, метод должен вернуть исходную строку.

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Enter the text oyu want to compress");

        Console.Write("\nInput: ");

        string userStr = Console.ReadLine();

        Console.Write("\nOutput: ");

        StringCompression(userStr);

        Console.WriteLine();
    }
    static void StringCompression(string userStr)
    {
        int count = -1;

        for (int i = 0; i <+ userStr.Length; i++)
        {
            count++;

            if(i == 0)
            {
                continue;
            }
            if (userStr[i] != userStr[i - 1])
            {
                Console.Write($"{userStr[i - 1]}{count}");
                count = 0;
            }
            if(i == (userStr.Length - 1))
            {
                Console.Write($"{userStr[i]}{count + 1}");
            }
        }
    }
}