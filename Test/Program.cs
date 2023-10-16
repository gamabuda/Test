Cat Cat = new Cat("red");
Cat.color = "gray";
Console.WriteLine(Cat.color);
Cat.Meow();
Cat.Eat();
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