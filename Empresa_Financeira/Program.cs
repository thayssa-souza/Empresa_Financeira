using System.Text.RegularExpressions;

namespace Empresa_Financeira
{
    public class Program
    {
        public static void Main(String[] args)
        {
            bool respostaValida = false;
            do
            {
                Console.WriteLine("Deseja cadastrar contrato de pessoa física ou jurídica?");
                string resposta = Console.ReadLine().ToLower();

                var pattern1 = @"^((fisica)|(física)|(pf)|(f)){1}$";
                var pattern2 = @"^((juridica)|(jurídica)|(pj)|(j)){1}$";
                Regex regex1 = new Regex(pattern1);
                Regex regex2 = new Regex(pattern2);

                if (regex1.IsMatch(resposta))
                {
                    var contratoPessoaFisica = new ContratoPessoaFisica();
                    Console.WriteLine("Contratante - Pessoa Física: ");
                    contratoPessoaFisica.Contratante = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("CPF: ");
                    contratoPessoaFisica.CPF = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Data de nascimento (DD/MM/AAAA): ");
                    contratoPessoaFisica.dataNascimento = DateTime.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Valor do contrato: R$");
                    contratoPessoaFisica.Valor = decimal.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Prazo do contrato: ");
                    contratoPessoaFisica.Prazo = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Imprimir Contrato - Pessoa Física");
                    Console.WriteLine($"Código do contrato: {contratoPessoaFisica.idContrato}");
                    Console.WriteLine($"Contratante: {contratoPessoaFisica.Contratante}");
                    Console.WriteLine($"CPF: {contratoPessoaFisica.CPF}");
                    contratoPessoaFisica.exibirInfo();

                    respostaValida = true;
                }
                else if (regex2.IsMatch(resposta))
                {
                    var contratoPessoaJuridica = new ContratoPessoaJuridica();
                    Console.WriteLine("Contratante - Pessoa Jurídica: ");
                    contratoPessoaJuridica.Contratante = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("CNPJ: ");
                    contratoPessoaJuridica.CNPJ = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Inscrição estadual da empresa: ");
                    contratoPessoaJuridica.inscricaoEstadual = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Valor do contrato: ");
                    contratoPessoaJuridica.Valor = decimal.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Prazo do contrato: ");
                    contratoPessoaJuridica.Prazo = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Imprimir Contrato - Pessoa Jurídica");
                    Console.WriteLine($"Código do contrato: {contratoPessoaJuridica.idContrato}");
                    Console.WriteLine($"Contratante: {contratoPessoaJuridica.Contratante}");
                    Console.WriteLine($"CNPJ: {contratoPessoaJuridica.CNPJ}");
                    Console.WriteLine($"Inscrição estadual: {contratoPessoaJuridica.inscricaoEstadual}");
                    contratoPessoaJuridica.exibirInfo();

                    respostaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                    Console.Clear();
                }
            } while (respostaValida == false);

        }
    }
}
