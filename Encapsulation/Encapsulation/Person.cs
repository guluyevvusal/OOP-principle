public class Person
{
    // Private field
    private string name;

    // Public property
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }
    }

    // Public method
    public void PrintName()
    {
        Console.WriteLine($"Name: {name}");
    }


    // Encapsulation, məlumatların (xüsusiyyətlərin) və funksiyaların (metodların) bir sinifdə birləşdirilməsini və bu məlumatların xarici müdaxilədən qorunmasını təmin edir. Bu, məlumatların təhlükəsizliyini və siniflərin daxili iş prinsiplərinin gizlədilməsini təmin edir.
}
