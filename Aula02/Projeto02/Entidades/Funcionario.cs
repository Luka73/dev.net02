using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entidades
{
    public class Funcionario
    {
        #region Atributos    
        private int idFuncionario;
        private string nome;
        private decimal salario;
        private TipoContratacao tipoContratacao;
        #endregion

        #region Métodos
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Salario { get => salario; set => salario = value; }
        public TipoContratacao TipoContratacao { get => tipoContratacao; set => tipoContratacao = value; }
        #endregion
    }
}
