/*9)Escreva um programa que leia o código de um produto e informe a sua categoria:

1 a 10: Alimento não-perecível

11 a 20: Alimento perecível

21 a 30: Vestuário

31 a 40: Eletrônicos

Outros: Código inválido*/

using System;

class Codigo{

    public static void Main (string[] args){

        Console.WriteLine("Leia o código e informe sua categoria");

        Console.WriteLine("Digite um número:");

        int codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo >= 1 && codigo <= 10){
            Console.WriteLine("O alimento é não-perecível");
        }
        else if (codigo >= 11  && codigo <= 20){
            Console.WriteLine("O alimento é perecível");
        }
        else if (codigo >= 21 && codigo <= 30){
            Console.WriteLine("Este produto pertence à seção de vestuário");
        }

         else if (codigo >= 31 && codigo <= 40){
            Console.WriteLine("Este produto pertence à seção de eletrônicos");
        }

        else{
            Console.WriteLine("Erro: Código inválido");
        }
    }
}
