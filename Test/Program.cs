Cat Cat = new Cat("red");
Cat.color = "gray";
Console.WriteLine(Cat.color);
Cat.Meow();
Cat.Eat();

Tiger Tiger = new Tiger("red");
Tiger.Meow();
Tiger.Eat();
Tiger.Hunting();
class Cat
{
    public string color;

    public Cat(string color)
    {
        this.color = color;
        Console.WriteLine("Cat created!");
    }

    public void Meow()
    {
        Console.WriteLine("meow!");
    }

    public void Eat()
    {
        Console.WriteLine("eat!");
    }
}

class Tiger : Cat {
    public Tiger(string color) : base(color)
    {
        Console.WriteLine("Tiger created!");
    }

    public void Hunting()
    {
        Console.WriteLine("Start hunting!");
    }
}