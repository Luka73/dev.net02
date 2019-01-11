using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            /*
            double numero = 123.2;
            int numero2 = (int) numero; //Casting só converte elementos da mesma família
            int numero3 = Convert.ToInt16(3.5); //Convert converte tudo
            int numero4 = int.Parse(3.5); //Parse só converte String
            */

            Console.WriteLine("\nCADASTRO DE FUNCIONARIO: \n");

            Console.WriteLine("Código do Funcionário....: ");
            funcionario.IdFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do Funcionário......: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salário do Funcionário...: ");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de Contratação do Funcionário: ");
            Console.WriteLine("\t(1) - Estagiário");
            Console.WriteLine("\t(2) - CLT");
            Console.WriteLine("\t(3) - Terceirizado");
            Console.WriteLine("Informe o código desejado..: ");
            funcionario.TipoContratacao = (TipoContratacao) int.Parse(Console.ReadLine());

            Console.WriteLine("\nDADOS DO FUNCIONÁRIO:\n");
            Console.WriteLine("Código.........: " + funcionario.IdFuncionario);
            Console.WriteLine("Nome...........: " + funcionario.Nome);
            Console.WriteLine("Salário........: " + funcionario.Salario);
            Console.WriteLine("Contratação....: " + funcionario.TipoContratacao);

            Console.ReadKey();
        }
    }
}
