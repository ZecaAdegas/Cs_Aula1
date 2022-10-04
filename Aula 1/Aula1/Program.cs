using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \nHenrique Paulo!");
            Ex1a2(args);
            Ex1a3(args);
            Ex2a1(args);
            Ex2a2(args);
            Ex2a3(args);
            Ex2a4(args);
            Ex2a5(args);
        }


        static void Ex1a2(string[] args)
        {
            int n1, n2, soma;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("O resolutado da soma entre {0} e {1} é: {2}",n1,n2,soma);
        }
            
        static void Ex1a3(string[] args)
        {
            int n1;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O número inserido é: {0}", n1);
        }
        static void Ex2a1(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{1} {0}",n1,n2);
        }

        static void Ex2a2(string[] args)
        {
            int n1, n2, n3, resultado;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());
            resultado = n1 * n2 * n3;
            Console.WriteLine("O resultado da multiplicação entre {0}, {1}, e {2} é: {3}", n1, n2,n3,resultado);
        }
        static void Ex2a3(string[] args)
        {
            int n1, n2, add, sub, mult, div, rest;
            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            add = n1 + n2;
            sub = n1 - n2;
            mult = n1 * n2;
            div = n1 / n2;
            rest = n1 % n2;
            Console.WriteLine("Adição: {0}\nSubtração: {1}\nMultiplicação: {2}\nDivisão: {3}\nResto: {4}", add, sub, mult, div, rest);
        }
        static void Ex2a4(string[] args)
        {
            int n1; 
            double cubo;
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            cubo = Math.Pow(n1, 3);
            Console.WriteLine("{0} elevado ao cubo é: {1}", n1, cubo);
        }
        static void Ex2a5(string[] args)
        {
            float n1, n2, n3, n4, n5, media;
            Console.WriteLine("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quinta nota: ");
            n5 = float.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("A média das notas é: {0}", media);
        }
    }
}
