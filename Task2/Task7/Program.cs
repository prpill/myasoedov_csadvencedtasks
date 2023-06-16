//  Провалидировать строку на закрывающиеся скобки.

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("\nInput:  ");

        // string userInput = Console.ReadLine();

        string userInput = "{[[]{}]}()()";

        Console.Write("Output: ");

        bool a = ValidateString(userInput);

        Console.WriteLine(a);
    }
    static bool ValidateString(string userInput)
    {
        Stack <char> stackString = new Stack<char>();


        foreach (var symbol in userInput)
        {
            if(IsClosedBracket(symbol))
            {
                if (ClosedTrue(symbol) != stackString.Pop())
                    return false;
            }
            else
            {
                stackString.Push(symbol);
            }
        }
        return stackString.Count == 0;
    }
    static bool IsClosedBracket (char symbol)
    {
        if (symbol == ')' || symbol == ']' || symbol == '}')
        {
            return true;
        }
        return false;
        
    }
    static char ClosedTrue(char symbol)
    {
        var brackets = new Dictionary <char,char>(){
            {')','('},
            {']','['},
            {'}','{'}
        };

        foreach (var bracketSym in brackets)
        {
            if (bracketSym.Key == symbol)
                return bracketSym.Value;
        }
        return ' ';
    }
}