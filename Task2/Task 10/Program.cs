class Program
{
    static void Main(string[] args)
    {
        Console.Write("Specify the number of array elements: ");

        uint lengthArray = uint.Parse(Console.ReadLine()); 

        Console.WriteLine();

        int[] myArray = InputParameters(lengthArray);

        Console.WriteLine();

        SearchPair(myArray);

        Console.WriteLine();
    }
    static int[] InputParameters(uint arrayLenght)
    {
        int[] userArray = new int[arrayLenght];

        for (int i = 0; i < userArray.Length; i++)
        {
            Console.Write($"Enter a value for array element #{i + 1}: ");
            userArray[i] = int.Parse(Console.ReadLine());
        }

        return userArray;
    }
    static void SearchPair(int[] array)
    {
        Console.Write("Output of identical pairs: ");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i >= j) {continue;}

                if (array[i] == array [j])
                {
                    Console.Write($"({i},{j}) ");
                }
            }
        }
    }
}