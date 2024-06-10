//4) Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado./

using System;

class Triangulo {
    public static void Main (string[] args) {
        Console.WriteLine ("Lendo os lados de um triângulo e verificando se são válidos ");
        Console.WriteLine ("Informe o valor do primeiro lado:");
        int valor01 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor do segundo lado:");
        int valor02 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor do terceiro lado:");
        int valor03 = Convert.ToInt32(Console.ReadLine());
        if (valor01 + valor02 > valor03 && valor01 + valor03 > valor02 && valor02 + valor03 > valor01) {
            Console.WriteLine("Os valores informados formam um triângulo");
        } else {
            Console.WriteLine("Os valores informados NÃO formam um triângulo");
        }
    }
}
