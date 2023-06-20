//  Провалидировать строку на закрывающиеся скобки.
// "{[[]{}]}()()"
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            MainMethod();
            
            Console.WriteLine("\nWould you like to re-check? 1 - Yes, Other - No");
            char select = Console.ReadKey().KeyChar;
            if (select != '1')
                break;
        }
    }
    static void MainMethod()
    {
        Console.Write("\nEnter the string to be failed: ");

        string userInput = Console.ReadLine();
        
        Console.Write("\nOutput: ");

        string brackets = GetBrackets(userInput);

        bool validationValue = ValidateString(brackets);

        if (validationValue)
            Console.WriteLine("Parentheses are set correctly");
        else
            Console.WriteLine("Parentheses are not set correctly");
    }
    static string GetBrackets(string userInput)
    {
        string brackets = "";

        foreach (var symbol in userInput)
        {
            if (symbol == '(' || symbol == ')' || symbol == '{' || symbol == '}' || symbol == '[' || symbol == ']')
            brackets += symbol;
        }
        return brackets;
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