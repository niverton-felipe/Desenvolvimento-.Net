using GestorAcoes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcoes.Model
{
    internal class CarteiraAcao : ICarteiraAcao
    {
        private List<string> acoesDisponiveis = new List<string>();
        private List<Acao> acoes = new List<Acao>();

   
        private void adicionarAcoesDisponiveis()
        {
            List<string> acoesAdicionadas = new List<string> 
            {
                "MGLU3",
                "PETR4",
                "VALE3",
                "BBDC4",
                "GOAL4",
                "VVAR3",
                "USIM5"
            };
            acoesDisponiveis.AddRange(acoesAdicionadas);
        }



        public CarteiraAcao() 
        {
            adicionarAcoesDisponiveis();
        }

        public void visualizarAcoesDisponiveis()
        {
            Console.WriteLine("Lista de ações disponíveis:");
            Console.WriteLine("------------------------------");
            foreach (var acao in acoesDisponiveis) 
            {
                Console.WriteLine($"CÓDIGO: {acao.ToString()}");
            }
            Console.WriteLine("------------------------------\n");
        }

        public void cadastrarAcao(string codigo, int quantidade)
        {
            if (acoesDisponiveis.Contains(codigo))
            {
                cadastrarAcaoValida(codigo, quantidade);
            }
            else
            {
                Console.WriteLine("Código de ação inválida, por favor digite um código válido");
            }

        }

        public void pesquisarAcao(string codigo)
        {
            Acao acao = acoes.Find(a => a.getCodigo() == codigo);

            if (acao != null)
            {
                Console.WriteLine($"Código: {acao.getCodigo()}, Quantidade: {acao.getQuantidade()}\n");
            }
            else
            {
                Console.WriteLine("Ação não disponível ou não encontrada na sua carteira");
            }
        }

        public void visualizarCarteira()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Carteira de ações cadastradas");
            Console.WriteLine("------------------------------\n");
            if (acoes.Count > 0)
            {
                foreach (var acao in acoes)
                {
                    Console.WriteLine($"Código: {acao.getCodigo()}, Quantidade: {acao.getQuantidade()}");

                }
            }
            else
            {
                Console.WriteLine("Ainda não há ações cadastradas na sua carteira");
            }
            Console.WriteLine("------------------------------\n");


        }

        private void cadastrarAcaoValida(string codigo, int quantidade)
        {
            bool acaoCadastrada = acoes.Exists(acao => acao.getCodigo() == codigo);

            if (acaoCadastrada)
            {
                foreach(var acao in acoes)
                {
                    if (acao.getCodigo() == codigo) 
                    {
                        acao.setQuantidade(acao.getQuantidade() + quantidade);
                        Console.WriteLine($"Quantidade {quantidade} adicionada com êxito à ação {codigo}\n");
                    } 
                }
            }
            else
            {
                Acao acao = new Acao(codigo, quantidade);
                acoes.Add(acao);
                Console.WriteLine($"Ação {codigo} adicionada com sucesso a sua carteira. \nDigite a opção número 2 para visualizar sua carteira atualizada\n");
            }
        }
    }
}
