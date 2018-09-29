using System;
using System.Collections.Generic;
using System.Text;

namespace Salario
{
    /*Faça um algoritmo que receba o salário-base de um funcionário, 
     * calcule e mostre o salário a receber, 
     * sabendo-se que esse funcionário tem gratificação de 5% sobre o salário-base e paga imposto de 7% também sobre o salário-base.
     */
    class Salario
    {
        private double salario_base;
        static readonly double gratificação = 0.05;
        static readonly double imposto = 0.07;

        public Salario(double salario_base)
        {
            Salario_base = this.salario_base;
        }

        public Salario()
        {
        }

        public static double Gratificação => gratificação;

        public static double Imposto => imposto;

        public double Salario_base { get => salario_base; set => salario_base = value; }

        public double SalarioLiquido(double salario_base, double gratificação, double imposto) => (Salario_base + (Salario_base * Gratificação) - (salario_base * Imposto));

    }
}
