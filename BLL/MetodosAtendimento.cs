using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.MODEL;
using DAL.Contexto;
using DAL.Repositorio;

namespace BLL
{
    public class MetodosAtendimento
    {
        //public static BancoContexto banco = new BancoContexto();

        public static void Gravar(Atendimento atendimento)
        {
            AtendimentoRepositorio x = new AtendimentoRepositorio();

            if (atendimento.Id == 0)
            {
                x.Adicionar(atendimento);
            }
            else
            {
                x.Atualizar(atendimento);
            }

            x.SalvarTodos();
        }

        public static List<Atendimento> LeituraAtendimentoTodos(int codigocliente)
        {
            BancoContexto banco = new BancoContexto();

            List<Atendimento> lista = new List<Atendimento>();

            if (codigocliente == 0)
            {
                //var arquivo = from c in banco.AtendimentoCtx select c;

                var arquivo = from c in banco.AtendimentoCtx
                              where (codigocliente == 0 || c.ClienteId == codigocliente)
                              orderby c.Id ascending
                              orderby c.DataAtendimento descending
                              select c;

                foreach (var item in arquivo)
                {
                    lista.Add(item);
                }

                return lista;
            }
            else
            {
                //var arquivo = banco.AtendimentoCtx.Where(p => p.ClienteId == codigocliente);

                var arquivo = from c in banco.AtendimentoCtx
                              where (codigocliente == 0 || c.ClienteId == codigocliente)
                              orderby c.Id ascending
                              orderby c.DataAtendimento descending
                              select c;

                foreach (var item in arquivo)
                {
                    lista.Add(item);
                }

                return lista;
            }
        }

        public static Atendimento LeituraAtendimento(int codigoatendimento)
        {
            BancoContexto banco = new BancoContexto();

            var arquivo = banco.AtendimentoCtx.First(p => p.Id == codigoatendimento);

            return arquivo;
        }
    }
}
