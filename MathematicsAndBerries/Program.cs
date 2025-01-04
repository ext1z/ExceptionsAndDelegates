


// 5. https://acm.timus.ru/problem.aspx?space=1&num=2001





class Program
{
    static void Main(string[] args)
    {
        string[] oneSpl = Console.ReadLine()!.Split(' ');
        int a1 = int.Parse(oneSpl[0]);
        int b1 = int.Parse(oneSpl[1]);
       
        string[] twoSpl = Console.ReadLine()!.Split(' ');
        int a2 = int.Parse(twoSpl[0]);
        int b2 = int.Parse(twoSpl[1]);
            
        string[] threeSpl = Console.ReadLine()!.Split(' ');
        int a3 = int.Parse(threeSpl[0]);
        int b3 = int.Parse(threeSpl[1]);

        Console.WriteLine($"{a1 - a3} {b1 - b2}");

    }
}



//string? input = Console.ReadLine()!;

//string[] splited = input.Split(' ', '\n');


//int[] arrayOfint = new int[splited.Length];


//for (int i = 0; i < splited.Length; i++)
//{
//    arrayOfint[i] = int.Parse(splited[i]);
//}

//Console.WriteLine($"{arrayOfint[0]} {arrayOfint[3]}");
