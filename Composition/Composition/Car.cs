public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

public class Car
{
    private Engine engine;

    public Car()
    {
        engine = new Engine();
    }

    public void Start()
    {
        engine.Start();
        Console.WriteLine("Car started");
    }
}


// Kompozisiya, siniflər arasında "has-a" əlaqəsi yaratmaq üçün istifadə olunur. Bu, bir sinifin digər siniflərin instansiyalarını özündə saxlamasıdır. Kompozisiya siniflər arasında əlaqələri daha çevik şəkildə qurmağa imkan verir.