using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Financeira
{
    public class Contratos
    {
        public Guid idContrato { get; private set; } = Guid.NewGuid();
        public string Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }

        public decimal Prestacao { get { return calcularPrestacao(Valor, Prazo); } }

        public virtual decimal calcularPrestacao(decimal Valor, int Prazo)
        {
            decimal prestacao = Valor/Prazo;
            return prestacao;
        }

        public virtual void exibirInfo()
        {
            Console.WriteLine($"Valor do contrato: R${Valor}");
            Console.WriteLine($"Prazo do contrato: {Prazo}");
            Console.WriteLine($"Valor da prestação: R${Prestacao}");
        }
    }
}
