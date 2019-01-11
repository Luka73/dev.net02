using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades; //importando
using Projeto01.Controles; //importando

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Endereco = new Endereco();

            cliente.IdPessoa = 1;
            cliente.Nome = "Eduardo";
            cliente.Email = "eduardo@gmail.com";
            cliente.Cpf = "123.456.789-00";
            cliente.Endereco.IdEndereco = 1;
            cliente.Endereco.Logradouro = "Rua Pedro I, 7";
            cliente.Endereco.Cidade = "Rio de Janeiro";
            cliente.Endereco.Estado = "RJ";
            cliente.Endereco.Cep = "123456-000";

            ClienteControle clienteControle = new ClienteControle();
            clienteControle.ImprimirCliente(cliente);

            Console.ReadKey();
            
        }
    }
}
