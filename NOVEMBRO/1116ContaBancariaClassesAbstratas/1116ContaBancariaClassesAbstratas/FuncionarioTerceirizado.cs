using System;
using System.Globalization;

namespace _1116ContaBancariaClassesAbstratas
{
    class FuncionarioTerceirizado : Funcionario
    {
        double Adicional;

        //M�todo Construtor que herda da classe Funcionario
        public FuncionarioTerceirizado(string nome, int horas, double valorHora, double adicional)
            : base (nome, horas, valorHora)
        {
            Adicional = adicional;
        }

        //C�lculo do adicional para funcion�rio terceirizado
        public override double Pagamento()
        {            
            return (Adicional * 1.10) + base.Pagamento();           
        }

    }  
}