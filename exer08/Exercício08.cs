//8) Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3)

using System;

class Nota{

    public static void Main (string[] args){

        Console.WriteLine("Leia a nota de um aluno, e converta-a para um A, B, C, D ou F");

        Console.WriteLine("Digite a sua nota:");

        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 9){
            Console.WriteLine("Se a sua nota foi " + nota);
            Console.WriteLine("Você tirou um A");
        }
        else if (nota >= 7 && nota < 9){
            Console.WriteLine("Se a sua nota foi " + nota);
            Console.WriteLine("Você tirou um B");
        }
        else if (nota >= 5 && nota < 7){
            Console.WriteLine("Se a sua nota foi " + nota);
            Console.WriteLine("Você tirou um C");
        }
        else if (nota >= 3 && nota < 5){
            Console.WriteLine("Se a sua nota foi " + nota);
            Console.WriteLine("Você tirou um D");
        }
        else{
            Console.WriteLine("Se a sua nota foi " + nota);
            Console.WriteLine("Você tirou um F");
        }
    }
}
