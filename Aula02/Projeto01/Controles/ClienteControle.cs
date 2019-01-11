using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;

namespace Projeto01.Controles
{
    public class ClienteControle
    {
        public void ImprimirCliente(Cliente cliente)
        {
            Console.WriteLine("\nDADOS DO CLIENTE: \n");
            Console.WriteLine("Cod Pessoa........: " + cliente.IdPessoa);
            Console.WriteLine("Nome..............: " + cliente.Nome);
            Console.WriteLine("CPF...............: " + cliente.Cpf);
            Console.WriteLine("Email.............: " + cliente.Email);
            Console.WriteLine("Cod Endereco......: " + cliente.Endereco.IdEndereco);
            Console.WriteLine("Logradouro........: " + cliente.Endereco.Logradouro);
            Console.WriteLine("Cidade............: " + cliente.Endereco.Cidade);
            Console.WriteLine("Estado............: " + cliente.Endereco.Estado);
            Console.WriteLine("CEP...............: " + cliente.Endereco.Cep);
        }
    }
}
