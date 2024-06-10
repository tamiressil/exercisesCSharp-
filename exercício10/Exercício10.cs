// 10) Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente

using System;

class Operacao
{
    public static void Main(string[] args)

    {

        Console.WriteLine("Digite um número");
        
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro número");

        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escolha uma operação: adição, subtração, multiplicação ou divisão (escreva sem acentuação a operação escolhida)");

        string operacao = Console.ReadLine().ToLower(); // O ToLower transforma letras maiúsculas em minúsculas

        if (operacao == "adicao")
        {
            int resultado = num1 + num2;
            Console.WriteLine("O resultado da conta é: " + resultado);
        }
        else if (operacao == "subtracao")
        {
            int resultado = num1 - num2;
            Console.WriteLine("A conta será: " + resultado);
        }
        else if (operacao == "multiplicacao")
        {
            int resultado = num1 * num2;
            Console.WriteLine("O resultado será de: " + resultado);
        }
        else if (operacao == "divisao")
        {
            if (num2 != 0)
            {
                double resultado = (double)num1 / num2; //ele garante que a divisão retorne com um número real.
                Console.WriteLine("A operação terá o resultado de: " + resultado);
            }
            else
            {
                Console.WriteLine("Divisões por zero não são permitidas.");
            }
        }
        else
        {
            Console.WriteLine("Operação inválida");
        }
    }
}
