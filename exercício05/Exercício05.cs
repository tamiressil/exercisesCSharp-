//5) Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5)./

using System;
class MediaAluno{
    public static void Main(string[] args){
        Console.WriteLine("verificando se o aluno foi aprovado, reprovado ou está de recuperação");
        Console.WriteLine("Informe a o valor da primeira nota: ");
        int nota01 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe  o valor da segunda nota: ");
        int nota02 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o valor da terceira nota: ");
        int nota03 = Convert.ToInt32(Console.ReadLine());

        int media = (nota01 + nota02 + nota03) / 3;

        if (media >= 7)
        {
            Console.WriteLine("A nota é:" + media);
            Console.WriteLine("Aluno aprovado");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("A nota é:" + media);
            Console.WriteLine("Aluno em recuperação");
        }
        else
        {
            Console.WriteLine("A nota é:" + media);
            Console.WriteLine("Aluno reprovado");
        }
    }
}