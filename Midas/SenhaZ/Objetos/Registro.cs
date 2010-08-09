using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SenhaZ.Objetos
{

    /// <summary>
    /// Classe que representa o cadastro de uma senha.
    /// </summary>
    public class Registro:ObjetoNegocio
    {
        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private Categoria categoria;
        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}