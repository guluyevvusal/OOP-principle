public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof Woof!");
    }
}


// Inheritance, bir sinifin (subclass) digər sinifin (base class) xüsusiyyətlərini və metodlarını miras almasını təmin edir. Bu, kodun təkrarını azaldır və yeni siniflər yaratmaq üçün mövcud siniflərdən istifadə etməyə imkan verir.