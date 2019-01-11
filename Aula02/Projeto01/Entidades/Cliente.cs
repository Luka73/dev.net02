using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Cliente : Pessoa
    {
        #region Atributos
        private string cpf;
        private string email;
        private Endereco endereco;
        #endregion

        #region Métodos
        public string Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public Endereco Endereco
        {
            set { endereco = value; }
            get { return endereco; }
        }
        #endregion
    }
}
