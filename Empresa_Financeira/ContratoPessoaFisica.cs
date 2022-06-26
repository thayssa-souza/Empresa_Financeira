using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_Financeira
{
    public class ContratoPessoaFisica : Contratos
    {
        public string CPF { get; set; }
        public DateTime dataNascimento { get; set; }

        public override decimal calcularPrestacao (decimal Valor, int Prazo)
        {
            decimal prestacao;
            switch (Idade())
            {
                case <= 30:
                    prestacao = base.calcularPrestacao(Valor, Prazo) + 1;
                    break;

                case <= 40:
                    prestacao = base.calcularPrestacao(Valor, Prazo) + 2;
                    break;

                case <= 50:
                    prestacao = base.calcularPrestacao(Valor, Prazo) + 3;
                    break;

                default:
                    prestacao = base.calcularPrestacao(Valor, Prazo) + 4;
                    break;
            }
            return prestacao;
        }

        public int Idade()
        {
            int idadeCompleta;

            if (dataNascimento.Month > DateTime.Now.Month)
            {
                idadeCompleta = (DateTime.Now.Year - dataNascimento.Year) - 1;
                return idadeCompleta;
            }
            else if (dataNascimento.Month < DateTime.Now.Month)
            {
                idadeCompleta = (DateTime.Now.Year - dataNascimento.Year);
                return idadeCompleta;
            }
            else
            {
                if (dataNascimento.Day > DateTime.Now.Day)
                {
                    idadeCompleta = (DateTime.Now.Year - dataNascimento.Year) - 1;
                    return idadeCompleta;
                }
                else
                {
                    idadeCompleta = (DateTime.Now.Year - dataNascimento.Year);
                    return idadeCompleta;

                }
            }

        }

        public override void exibirInfo()
        {
            base.exibirInfo();
            Console.WriteLine($"Idade do contratante: {Idade()} anos.");

        }
    }
}
