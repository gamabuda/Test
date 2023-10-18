using Newtonsoft.Json;
using TestCore.Animals;

Cat Cat = new Cat("red");
Tiger Tiger = new Tiger("red");

Tiger Tiger1 = AnimalFactory.CreateTiger("black");

List<Cat> cats = new List<Cat>();

cats.Add(Cat);
cats.Add(Tiger);

    foreach (Cat c in cats)
{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
}


