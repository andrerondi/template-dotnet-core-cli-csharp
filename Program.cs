using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string nome = "André";
            //string sobrenome = "Rondi";
            //string nomeCompleto = nome + " " + sobrenome;
            //Console.WriteLine(nomeCompleto);

            //var valor = 42.50;
            //var taxa = valor * 0.10;
            //var total = valor + taxa;

            //Console.WriteLine($"O valor total é R$ {total:C}.");

            Console.WriteLine("Desafio Catapulta: Receber o número de baterias e duração da bateria e calcular a quantidade de pedras que a catapulta irá solta.");

            var bateriasBase = 5;
            var minutosBase = 15;
            var pedrasBase = 300;

            Console.WriteLine("Digite a quantidade de baterias: ");
            var bateriasInput = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de minutos: ");
            var minutosInput = double.Parse(Console.ReadLine());

            var pedrasInput = (pedrasBase * (bateriasInput * minutosInput)) / (bateriasBase * minutosBase);

            Console.WriteLine($"{bateriasInput} baterias em {minutosInput} minutos lança {pedrasInput:f1} pedras.");
        }
    }
}
