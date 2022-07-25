using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byteBank;
using byteBank.Titular;


namespace byteBank
{
    public class ContaCorrente
    {
        public Cliente titular { get; set; }
        private string? conta { get; set; }

        private int _numero_agencia;
        private string _conta;

        //método construtor
        public ContaCorrente(int numero_agencia, string conta)
        {
            NumeroAgencia = numero_agencia;
            Conta = conta;
            totalContasCriadas += 1; //método estático que calcula a quantidade de contas criadas
        }
        public int NumeroAgencia
        {

            get
            {
                return _numero_agencia;
            }

            set
            {
                if (value <= 0)
                {
                    return;
                }
                _numero_agencia = value;
            }

        }
        public string? nomeAgencia { set; get; }
        private double saldo { get; set; }

        public string NomeAgencia // propriedade. Inicia com letra maiuscula e não tem ()
        {
            set
            {
                if (String.IsNullOrEmpty(nomeAgencia))
                {
                    return;
                }
                nomeAgencia = value;
            }
            get { return nomeAgencia; }
        }

        public double Saldo
        {
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
            get { return saldo; }
        }
        public string Conta
        {
            get { return _conta; }
            set
            {
                if (value == null)
                {
                    return;
                }
                _conta = value;
            }
        }
        public static int totalContasCriadas { get; set; }
    }
}
