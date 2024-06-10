//11) Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive).

using System;

class Intervalo{
    public static void Main(string[] args) {
        Console.WriteLine("Checando se um número está dentro do intervalo de  10 e 20!");
        Console.WriteLine("Digite um número:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 10 && numero <= 20)
        { 
            Console.WriteLine($"{numero} Este número está dentro do intervalo de 10 a 20!");
        }
        else
        {
            Console.WriteLine($"{numero} Este número não está dentro do intervalo de 10 a 20!");
        }
    }
}