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
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("O resolutado da soma entre {0} e {1} é: {2}", n1, n2, soma);
        }

        static void Ex1a3(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("O número inserido é: {0}", n1);
        }
        static void Ex2a1(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{1} {0}", n1, n2);
        }

        static void Ex2a2(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());
            int resultado = n1 * n2 * n3;
            Console.WriteLine("O resultado da multiplicação entre {0}, {1}, e {2} é: {3}", n1, n2, n3, resultado);
        }
        static void Ex2a3(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int add = n1 + n2;
            int sub = n1 - n2;
            int mult = n1 * n2;
            int div = n1 / n2;
            int rest = n1 % n2;
            Console.WriteLine("Adição: {0}\nSubtração: {1}\nMultiplicação: {2}\nDivisão: {3}\nResto: {4}", add, sub, mult, div, rest);
        }
        static void Ex2a4(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            double cubo = Math.Pow(n1, 3);
            Console.WriteLine("{0} elevado ao cubo é: {1}", n1, cubo);
        }
        static void Ex2a5(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            float n3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            float n4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quinta nota: ");
            float n5 = float.Parse(Console.ReadLine());
            float media = (n1 + n2 + n3 + n4 + n5) / 5;
            Console.WriteLine("A média das notas é: {0}", media);
        }
    }
}
