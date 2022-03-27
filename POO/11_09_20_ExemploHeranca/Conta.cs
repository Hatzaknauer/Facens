using System;

namespace ExemploHeranca
{
    class Conta
    {
        //Declarações das variáveis e uso do encapsulamento
        public int Numero;
        public string Titular;
        public double Saldo;

        //Metodo construtor da conta
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero; Titular = titular; Saldo = saldo;
        }
        //Método de Saque
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //Método de Deposito
        public void Deposito(double saldoTotal)
        {
            Saldo += saldoTotal;
        }
    }
}