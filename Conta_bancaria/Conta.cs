using System;
using System.Globalization;
/* ORDEM SUGERIDA
#Atributos privados
#Propriedades autoimplementadas
#Construtores
#Propriedades customizadas
#Outros métodos da classe
*/

namespace Conta_bancaria
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }

        public double Saldo { get; private set; }
        public string NomeTitular { get; set; }
        
        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;

        }

        public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Dados da conta: \r\n"
                + "Conta: " + NumeroConta
                + ", Titular: " + NomeTitular 
                + " Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
} 
