using System;

namespace _1021VetoresHotel
{
    public class Hotel
    {
        int _quarto;
        string _nome, _email;

        //Construtor do hotel
        public Hotel(int quarto, string nome, string email)
        {
            _quarto = quarto;
            _nome = nome;
            _email = email;
        }

        //Get Nome
        public string GetNome()
        {
            return _nome;
        }

        //Exibe informações
        public override string ToString()
        {
            return ("\nQUARTO "
                    + _quarto
                    + "\n NOME: "
                    + _nome
                    + "\n EMAIL: "
                    + _email);
        }
    }
}
