public interface IService
{
    void Serve();
}

public class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service is serving");
    }
}

public class Consumer
{
    private readonly IService _service;

    public Consumer(IService service)
    {
        _service = service;
    }

    public void UseService()
    {
        _service.Serve();
    }
}

// Program.cs   =>

//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<IService, Service>();
//builder.Services.AddTransient<Consumer>();

//var app = builder.Build();
//var consumer = app.Services.GetRequiredService<Consumer>();
//consumer.UseService();
//app.Run();





// Dependency Injection (DI) OOP prinsipi deyil, amma OOP-nin yaxşı təcrübələrindən biridir. Bu, obyektlərin asılılıqlarını xaricdən təmin etməyə imkan verir və kodun daha yaxşı test edilə bilən və daha az bağlı olmasını təmin edir. .NET-də DI dəstəyi daxili olaraq təqdim edilir.