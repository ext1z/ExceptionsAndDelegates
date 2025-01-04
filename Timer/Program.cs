//3.Создайте класс Clock, который:

//Содержит событие Tick, возникающее каждую секунду.
//Использует Timer для генерации событий.
//Создайте подписчика, который выводит сообщение: "Секунда прошла!" при каждом вызове события.


// Time 45 minut

using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Clock clock = new Clock();

        clock.TickNotify += Clock_TickNotify;

        clock.Start();

        Console.ReadKey();

        clock.Stop();

    }

    private static void Clock_TickNotify(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Секунда прошла!!");
        Console.WriteLine($"{e.SignalTime}");
    }
}

public class Clock
{
    private System.Timers.Timer _timer;
    public delegate void TickHandler(object sender, ElapsedEventArgs e);
    public event TickHandler TickNotify;

    public Clock()
    {
        _timer = new System.Timers.Timer(1000);
        _timer.Elapsed += TimerElapsed;
    }

    public void Start() => _timer.Start();


    public void Stop() => _timer.Stop();

    private void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        TickNotify?.Invoke(this, e);
    }

}

