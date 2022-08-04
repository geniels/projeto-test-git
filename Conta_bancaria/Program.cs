using System;
using System.Globalization;
namespace Conta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;


            Console.Write("Entre o número da conta: ");
            int NConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre o titular da conta: ");
            string NTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n)? ");
            string VDeposito = Console.ReadLine();
            if (VDeposito == "s" || VDeposito == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double VIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(NConta, NTitular, VIni);
            }
            else
            {
                conta = new Conta(NConta, NTitular);
            }

            Console.WriteLine();

            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);



        }
    }
}
