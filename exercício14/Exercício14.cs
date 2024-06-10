//14) Escreva um programa que leia um número e informe se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado.


using System;

class Programa{
    public static void Main(string[] args){
        Console.WriteLine("Digite um número que seja positivo ou negativo:");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero > 0){
            double resultado = Math.Sqrt(numero); // Math.Sqrt é a função que permite calcular a raiz quadrada em C#
            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");
        } else if (numero < 0){
            double resultado = numero * numero;
            Console.WriteLine($"O quadrado de {numero} é {resultado}");
        } else {
            Console.WriteLine("Erro: Número informado é inválido");
        }
    }
}
