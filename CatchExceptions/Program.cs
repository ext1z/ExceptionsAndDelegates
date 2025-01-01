
//1.Напишите программу, которая:

//Запрашивает у пользователя числовое значение.
//Конвертирует введенный текст в число с использованием int.Parse().
//Обрабатывает исключения:
//FormatException, если пользователь вводит нечисловое значение.
//OverflowException, если введенное число выходит за пределы диапазона int.
//Выводит соответствующее сообщение об ошибке.

// Time 20minut



class Porgram
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите число");
            
            int number = int.Parse(Console.ReadLine()!);

            if (number > int.MaxValue)
            {
                throw new OverflowException();
            }

            Console.WriteLine($"Ваше число : {number}");

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Введите только число!!!!!");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Введенное число должно быть меньше {int.MaxValue} !!!!");
        }

    }
}