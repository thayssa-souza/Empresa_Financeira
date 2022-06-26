using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Financeira
{
    public class ContratoPessoaJuridica : Contratos
    {
        public string CNPJ { get; set; }
        public string inscricaoEstadual { get; set; }

        public override decimal calcularPrestacao(decimal Valor, int Prazo)
        {
            decimal prestacao = base.calcularPrestacao(Valor, Prazo) + 3;
            return prestacao;
        }

        public override void exibirInfo()
        {
            base.exibirInfo();
        }
    }
}
