public interface IDriveable
{
    void Drive();
}

public class Car : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}


// İnterfeyslər, siniflərin tətbiq etməli olduğu metodları və xüsusiyyətləri müəyyən edir. İnterfeyslər siniflər arasında müqavilələr yaradır və çoxsaylı siniflərin eyni metod adlarını istifadə etməsinə imkan verir.