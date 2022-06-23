// See https://aka.ms/new-console-template for more information
using System;
namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lievelingskleur?");
            string kleur = Console.ReadLine();
            Console.WriteLine("Lievelingsboek?");
            string boek = Console.ReadLine();
            Console.WriteLine("Lievelingseten?");
            string eten = Console.ReadLine();
            Console.WriteLine("Lievelingsauto?");
            string auto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Je");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" favoriete");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" kleur");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" is ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(eten);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" etc");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(auto);
            Console.ForegroundColor = ConsoleColor.Cyan ;
            Console.Write(boek);
        }
    }
}