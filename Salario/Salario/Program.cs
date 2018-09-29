using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario meuSalario = new Salario();
            meuSalario.Salario_base = 1000; 

            Console.WriteLine("O salario liquido é:" + meuSalario.SalarioLiquido(meuSalario.Salario_base,0.05,0.07));
            Console.ReadKey();
        }
    }
}
