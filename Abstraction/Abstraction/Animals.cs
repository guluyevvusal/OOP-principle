public abstract class Animal
{
    public abstract void MakeSound(); // Abstract method

    public void Sleep() // Concrete method
    {
        Console.WriteLine("Sleeping...");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof!");
    }
}


//Abstraction, yalnız müvafiq məlumatları təqdim etməyə və funksionallığı istifadəçidən gizlətməyə imkan verir. Siniflər və interfeyslər bu prinsipi tətbiq etmək üçün istifadə olunur. Abstraction proqramlaşdırıcının yalnız ehtiyacı olan ətraf mühitlə qarşılıqlı əlaqəyə girməsini təmin edir.

