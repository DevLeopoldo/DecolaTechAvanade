﻿using System;

class SequenciaS
{

    static void Main(string[] args)
    {

        double c, S = 0;
        for (double n = 1; n <= 100; n++)
        {
            c = 1 / n;  //coloque a sua lógica nos espaços em branco
            S = S + c;
        }
        var x = Math.Round(S, 2);
        Console.WriteLine(x);

    }

}