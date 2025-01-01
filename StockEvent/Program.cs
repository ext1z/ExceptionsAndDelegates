//4.Создайте класс Stock, который имеет:

//Поле Price.
//Событие PriceChanged, которое срабатывает при изменении цены.
//Создайте двух подписчиков:

//Первый выводит текущую цену.
//Второй проверяет, превышает ли цена заданный порог, и выводит предупреждение.
//Продемонстрируйте работу событий с несколькими подписчиками.

// Time 65minut


class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock();
        stock.PriceChangedNotify += FirstSubscriber;
        stock.PriceChangedNotify += SecondSubscriber;


        stock.ShowPrice();
        stock.ChangePrice(50);

        void FirstSubscriber(string message)
        {
            Console.WriteLine($"Подписчик 1 : {message}");
        }

        void SecondSubscriber(string message)
        {
            if (stock.Price < 100)
            {
                Console.WriteLine($"Подписчик 2: Цена изменана, Внимания цена меньше чем {100}");
            }
            else
            {
                Console.WriteLine($"Подписчик 2: {message}");
            }
        }

    }
}

public class Stock
{

    public delegate void PriceChanged(string message);
    public event PriceChanged PriceChangedNotify;

    public int Price { get; set; } = 50;

    public Stock()
    {
        
    }


    public void ShowPrice()
    {
        Console.WriteLine($"Цена : {Price}, метод showprice");
    }

    public void ChangePrice(int price)
    {
        Price = price;
        PriceChangedNotify.Invoke($"Цена изменена {Price}");
    }

}