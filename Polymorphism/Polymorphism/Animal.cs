public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound...");
    }
}

public class Dog : Animal
{
    public override void MakeSound() // Method overriding
    {
        Console.WriteLine("Woof Woof!");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myDog = new Dog();
        myDog.MakeSound(); // Output: Woof Woof!
    }
}


// Polymorphism, bir metodun bir neçə müxtəlif şəkildə istifadə olunmasını təmin edir. Bu, metodların müxtəlif siniflərdə eyni adla fərqli şəkildə işləməsini təmin edir. Polimorfizm iki əsas növü var: compile-time (overloading) və runtime (overriding).