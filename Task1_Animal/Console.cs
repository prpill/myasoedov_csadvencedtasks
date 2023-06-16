class Program
{
    static void Main(string[] args)
    {
        // DataInput();
        MainMenu();
    }
    static void MainMenu(string warning = "")
    {
        Console.WriteLine("Main menu");
        Console.WriteLine("\n1 - Select animal\n2 - Exit\n");
        Console.WriteLine(warning);

        Console.Write("Input: ");
        byte transition = CheckByte();
        
        Console.Clear();
        switch (transition)
        {
            case 1:
                SelectAnimal();
                break;
            case 2:
                break;
            default:
                MainMenu("Input Error!");
                break;
        }
    }
    static void SelectAnimal(string warning = "")
    {
        Console.WriteLine("Animal selection menu");
        Console.WriteLine("\n1 - Cat\n2 - Dog\n3 - Cow\n4 - Parrot\n5 - Exit to main menu\n");
        Console.WriteLine(warning);

        Console.Write("Input: ");
        byte transition = CheckByte();

        Console.Clear();
        switch (transition)
        {
            case 1:
                SelectAction(0);
                break;
            case 2:
                SelectAction(1);
                break;
            case 3:
                SelectAction(2);
                break;
            case 4:
                SelectAction(3);
                break;
            case 5:
                MainMenu();
                break;
            default:
                SelectAnimal("Input Error!");
                break;
        }
    }
    static void SelectAction(byte selectedAnimal, string warning = "")
    {
        Observer observer = new Observer();

        Animal[] animal = { new Cat(), new Dog(), new Cow(), new Parrot()};

        Console.WriteLine("Animal action selection menu");
        Console.WriteLine("\n1 - Make a sound\n2 - Learn the color\n3 - Send to sleep\n");
        Console.WriteLine(warning);

        Console.Write("Input: ");
        byte transition = CheckByte();

        Console.Clear();
        switch (transition)
        {
            case 1:
                observer.MakeNoize(animal[selectedAnimal]);
                break;
            case 2:
                observer.GetColor(animal[selectedAnimal]);
                break;
            case 3:
                observer.Sleep(animal[selectedAnimal]);
                break;
            default:
                SelectAction(selectedAnimal,"Input Error!");
                break;
        }
        Console.Write("\nEnter any value to continue: ");
        Console.ReadKey();
        Console.Clear();
        MainMenu();
    }

    static byte CheckByte()
    {
        try{
            return byte.Parse(Console.ReadLine());
        }catch (FormatException){
            return 0;
        }catch (OverflowException){
            return 0;
        }
    }
}