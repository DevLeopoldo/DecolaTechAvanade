using System;

class Xenlongao
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            int qntEsferas = int.Parse(Console.ReadLine());
            int qntDivisoes = 0;
            int ignorarEsferas = 1;
            for (int j = 2; j <= qntEsferas; j++)
            {
                qntDivisoes = 0;
                for (int k = 1; k <= j; k++)
                {
                    if (j % k == 0)
                    {
                        qntDivisoes++;
                    }
                }
                if (qntDivisoes % 2 != 0)
                {
                    ignorarEsferas++;
                }
            }
            Console.WriteLine(qntEsferas - ignorarEsferas);
        }

    }
}