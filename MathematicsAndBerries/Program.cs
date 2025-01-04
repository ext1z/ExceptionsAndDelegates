


// 5. https://acm.timus.ru/problem.aspx?space=1&num=2001





class Program
{
    static void Main(string[] args)
    {
        string? input = Console.ReadLine()!;

        string[] splited = input.Split(' ', '\n');

        int a1, b1,
            a2, b2,
            a3, b3;


        a1 = int.Parse(splited[0]);
        b1 = int.Parse(splited[1]);

        a2 = int.Parse(splited[2]);
        b2 = int.Parse(splited[3]);

        a3 = int.Parse(splited[4]);
        b3 = int.Parse(splited[5]);


        int res1, res2;

        PourItOver(from: ref b1,
                   to: ref a1,
                   result: out res1);
        PourItOver(from: ref a2, 
                   to: ref b2, 
                   result:  out res2);


        Console.WriteLine($"{res1} {res2}");

        void PourItOver(ref int from, ref int to, out int result)
        {
            result = from;
            to = from + to;
            from = 0;
        }

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