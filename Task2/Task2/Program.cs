// Написать итератор по массиву
class Program
{
    static void Main(string[] args)
    {
        int[] myArray = {12, 7, 65, -3, 4, -47 };

        ArrayIterator(ref myArray);

        Console.WriteLine();
    }
    static void ArrayIterator<T>(ref T[] userArray)
    {
        foreach (var item in userArray)
        {
            Console.Write(item + "\t");
        }
    }
}
