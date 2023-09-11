using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcoes.Model
{
    internal class Acao
    {
        private string codigo;
        private int quantidade;

        
        public Acao(string codigo, int quantidade)
        {
            this.codigo = codigo;
            this.quantidade = quantidade;
        }

        public string getCodigo() => this.codigo;
        public int getQuantidade() => this.quantidade;

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
    }
}
