using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Endereco
    {
        #region Atributos
        private int idEndereco;
        private string logradouro;
        private string cidade;
        private string estado;
        private string cep;
        #endregion

        #region Métodos
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cep { get => cep; set => cep = value; }
        #endregion
    }
}
