using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Pessoa
    {
        #region Atributos
        private int idPessoa;
        private string nome;
        #endregion

        #region Métodos
        public int IdPessoa
        {
            set { idPessoa = value; }
            get { return idPessoa; }
        }
        
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        #endregion
    }
}
