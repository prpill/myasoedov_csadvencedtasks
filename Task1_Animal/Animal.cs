abstract class Animal
{
    public abstract void MakeNoize();

    public abstract void GetColor();

    public void Sleep()
    {
        Console.WriteLine("This animal is sleeping");
    }
}
class Cat : Animal
{
    public override void GetColor()
    {
        Console.WriteLine("This cat has a tricolor coat color");
    }

    public override void MakeNoize()
    {
        Console.WriteLine("The cat said meow");
    }
}
class Dog : Animal
{
    public override void GetColor()
    {
        Console.WriteLine("This dog is black");
    }

    public override void MakeNoize()
    {
        Console.WriteLine("The dog said woof");
    }
}
class Cow : Animal
{
    public override void GetColor()
    {
        Console.WriteLine("This cow is white with black spots");
    }

    public override void MakeNoize()
    {
        Console.WriteLine("The cow said moo");
    }
}
class Parrot : Animal
{
    public override void GetColor()
    {
        Console.WriteLine("This green parrot");
    }

    public override void MakeNoize()
    {
        Console.WriteLine("The parrot said \"I am beautiful\"");
    }
}
class Observer
{
    public void MakeNoize(Animal animal)
    {
        animal.MakeNoize();
    }

    public void GetColor(Animal animal)
    {
        animal.GetColor();
    }

    public void Sleep(Animal animal)
    {
        animal.Sleep();
    }
}