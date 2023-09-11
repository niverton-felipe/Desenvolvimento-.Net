using GestorAcoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcoes.Interfaces
{
    internal interface ICarteiraAcao
    {
        void cadastrarAcao(string codigo, int quantidade);
        void pesquisarAcao(string codigo);
        void visualizarCarteira();
    }
}
