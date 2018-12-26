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

            double resultado;
            resultado = num1 + num2; //atribui num1 e num2 a resultado para depois imprimir

            Console.WriteLine("Resultado final: " + resultado);

            Console.ReadLine();
        }
    }
}
