using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaconta = new Conta(TipoConta.PessoaFisica, 0, 0, "Filipe");

            Console.WriteLine(minhaconta.ToString());
        }
    }
}
