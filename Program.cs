using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string nome = "André";
            string sobrenome = "Rondi";
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine(nomeCompleto);

            var valor = 42.50;
            var taxa = valor * 0.10;
            var total = valor + taxa;

            Console.WriteLine($"O valor total é R$ {total:C}.");
        }
    }
}
