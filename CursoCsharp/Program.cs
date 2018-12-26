using System;

namespace estudar
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string tmp;

            Console.WriteLine("Insira um valor: "); //imprimir
            tmp = Console.ReadLine(); //leitura de string
            num1 = int.Parse(tmp); //conversão para o tipo na variavel que eu atribuir


            Console.WriteLine("Insira mas um valor: "); //imprimir
            tmp = Console.ReadLine(); //leitura de string
            num2 = int.Parse(tmp); //conversão para o tipo na variavel que eu atribuir

            double resultado1;
            resultado1 = num1 + num2; //atribui num1 e num2 a resultado para depois imprimir
            Console.WriteLine("Soma: " + resultado1);

            double resultado2;
            resultado2 = num1 * num2; //atribui num1 e num2 a resultado para depois imprimir
            Console.WriteLine("Multiplicação: " + resultado2);

            double resultado3;
            resultado3 = num1 / num2; //atribui num1 e num2 a resultado para depois imprimir     
            Console.WriteLine("divisão: " + resultado3);

            double resultado4;
            resultado4 = num1 - num2; //atribui num1 e num2 a resultado para depois imprimir
            Console.WriteLine("subtração: " + resultado4);

            Console.ReadLine();
        }
    }
}
