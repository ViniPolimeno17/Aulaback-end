using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente
    {
        public int numeroConta;
        public string Titular;
        public float Saldo = 0f;

        public void Depositar(float valor)
        {
            Saldo = Saldo + valor;
        }
        public void Sacar(float valor)
        {
            Saldo = Saldo - valor;
        }
        
    }
}