using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppLearn;

public abstract class Animal
{
    public abstract string Specieces { get; } 
}

public class Dog : Animal
{
    public override string Specieces => "Canis lupus familiaris";
    public string ScareCat() => "I scared the cat";
}

public class Cat : Animal
{
    public override string Specieces => "Felis catus";
    public string CatchMouse() => "I caught a mouse";
}

public class Mouse : Animal
{
    public override string Specieces => "Mus musculus";
    public string BiteDog() => "I bit a dog";
}

public class Nobody : Animal
{
    public override string Specieces => "Unknown";
}

public class IsDemo 
{
    public static void MyMethod() 
    {
        var animals = new Animal[] { new Dog(), new Cat(), new Mouse(), new Nobody() };
        foreach (var animal in animals)
        {
            Console.Write($"{animal.Specieces}: ");
            CheckAnimal5(animal);
        }
    }

    public static void CheckAnimal(Animal animal) 
    {
        var cat = animal as Cat;
        if (cat != null) Console.WriteLine(cat.CatchMouse());
        else
        {
            var dog = animal as Dog;
            if (dog != null) Console.WriteLine(dog.ScareCat());
            else
            {
                var mouse = animal as Mouse;
                if (mouse != null) Console.WriteLine(mouse.BiteDog());
                else Console.WriteLine("Something else");
            }
        }
    }

    public static void CheckAnimal2(Animal animal)
    {
        if (animal is Cat)
        {
            var cat = (Cat)animal;
            Console.WriteLine(cat.CatchMouse());
        }
        else if (animal is Dog)
        {
            var dog = (Dog)animal;
            Console.WriteLine(dog.ScareCat());
        }
        else if (animal is Mouse)
        {
            var mouse = (Mouse)animal;
            Console.WriteLine(mouse.BiteDog());
        }
        else Console.WriteLine("Something else");
    }

    public static void CheckAnimal3(Animal animal)
    {
        if (animal is Cat cat) Console.WriteLine(cat.CatchMouse());
        else if (animal is Dog dog) Console.WriteLine(dog.ScareCat());
        else if (animal is Mouse mouse) Console.WriteLine(mouse.BiteDog());
        else Console.WriteLine("Something else");
    }

    public static void CheckAnimal4(Animal animal) // switch statement
    {
        switch(animal)
        {
            case Cat cat: Console.WriteLine(cat.CatchMouse()); break;
            case Dog dog: Console.WriteLine(dog.ScareCat()); break;
            case Mouse mouse: Console.WriteLine(mouse.BiteDog()); break;
            default: Console.WriteLine("Something else"); break;
        }
    }

    public static void CheckAnimal5 (Animal animal) // switch expression
    {
        var str = animal switch
        {
            Cat cat => cat.CatchMouse(),
            Dog dog => dog.ScareCat(),
            Mouse mouse => mouse.BiteDog(),
            _ => "Something else",
        };
        Console.WriteLine(str);
    }
}