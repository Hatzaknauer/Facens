using System;

namespace _1116FolhaDePagamento
{
    class Conta
    {
        //Declara��es das vari�veis e uso do encapsulamento
        public int Numero;
        public string Titular;
        public double Saldo;

        //Metodo construtor da conta
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; Titular = titular; Saldo = saldo;
        }
        //M�todo de Saque
        public virtual void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //M�todo de Deposito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}