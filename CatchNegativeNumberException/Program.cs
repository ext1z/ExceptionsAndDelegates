//2. Создайте собственное исключение NegativeNumberException, которое выбрасывается, если пользователь вводит отрицательное число.

//Напишите программу, которая:

//Запрашивает у пользователя положительное число.
//Выбрасывает исключение NegativeNumberException, если число отрицательное.
//Перехватывает исключение и выводит сообщение: "Число не должно быть отрицательным".


// Time 10 minut



class Program
{
    static void Main(string[] args)
    {
		try
		{
				
			int number = int.Parse(Console.ReadLine()!);

			if (number < 0)
			{
				throw new NegativeNumberException("Число не должно быть отрицательным");
			}

		}
		catch (NegativeNumberException ex)
		{
            Console.WriteLine(ex.Message);
		}


    }
}



internal class NegativeNumberException : Exception
{
    public NegativeNumberException(string exception) : base(exception) { }
}