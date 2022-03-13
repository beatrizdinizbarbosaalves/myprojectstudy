using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;

            Console.Write("Digite o seu peso:");

            peso = float.Parse(Console.ReadLine());

            Console.Write("Digite o seu altura:");
            altura = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            if (imc < 18.5)
            {
                Console.WriteLine("Magreza");
            }
            if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("PESO NORMAL");
            }
            if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("SOBREPESO I");
            }
            if (imc >= 30 && imc <= 39.9)
            {
                Console.WriteLine("OBESIDADE II");
            }
            if (imc >= 40)
            {
                Console.WriteLine("OBESIDADE II");
            }
            Console.ReadLine();
        }
    }
}
