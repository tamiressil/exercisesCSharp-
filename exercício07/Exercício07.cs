//7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais).

using System;

class Idade{

    public static void Main (string[] args){

        Console.WriteLine("Informe sua idade, e saiba se a pessoa é uma criança, adolescente, adulto ou um idoso");

        Console.WriteLine("Digite sua idade:");

        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 12){
            Console.WriteLine("Você é uma criança");
        }
        else if (idade <= 17){
            Console.WriteLine("Você é um adolescente");
        }
        else if (idade <= 59){
            Console.WriteLine("Você é um adulto");
        }
        else{
            Console.WriteLine("Você é um idoso");
        }
    }
}
