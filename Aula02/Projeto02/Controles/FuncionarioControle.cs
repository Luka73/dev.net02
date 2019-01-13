using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using System.IO;

namespace Projeto02.Controles
{
    public class FuncionarioControle
    {
        public void ExportarParaTxt(Funcionario funcionario)
        {
            //abrindo o arquivo txt
            StreamWriter sw = new StreamWriter("c:\\temp\\funcionarios.txt", true);

            //escrevendo o conteúdo do arquivo
            sw.WriteLine("Código..........: " + funcionario.IdFuncionario);
            sw.WriteLine("Nome............: " + funcionario.Nome);
            sw.WriteLine("Salário.........: " + funcionario.Salario);
            sw.WriteLine("Contratação.....: " + funcionario.TipoContratacao);
            sw.WriteLine("--------------------------------------");

            //fechando o arquivo txt
            sw.Close();
        }

        public void ExportarParaCsv(Funcionario funcionario)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\funcionarios.csv", true);

            string dados = $"{funcionario.IdFuncionario};{funcionario.Nome};" +
                           $"{funcionario.Salario};{funcionario.TipoContratacao}";

            sw.WriteLine(dados);
       
            sw.Close();
        }

        public void ExportarParaXml(Funcionario funcionario)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\funcionarios.xml", true);

            sw.WriteLine("<?xml version='1.0' encoding='ISO-8859-1'?>");
            sw.WriteLine("<FUNCIONARIO>");
            sw.WriteLine($"<CODIGO>{funcionario.IdFuncionario}</CODIGO>");
            sw.WriteLine($"<NOME>{funcionario.Nome}</NOME>");
            sw.WriteLine($"<SALARIO>{funcionario.Salario}</SALARIO>");
            sw.WriteLine($"<TIPO>{funcionario.TipoContratacao}</TIPO>");
            sw.WriteLine("</FUNCIONARIO>");

            sw.Close();
        }
    }
}
