// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class Sudoku
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> niz = new List<int>();
        niz.Add(1);
        niz.Add(2);
        Console.WriteLine(niz);
        foreach (int i in niz)
        {
            Console.WriteLine(i);
        }
    }
}