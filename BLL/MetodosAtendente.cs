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
    public class MetodosAtendente
    {
        public static void Gravar(Atendente atendente)
        {
            AtendenteRepositorio banco = new AtendenteRepositorio();

            if (atendente.Id == 0)
            {
                banco.Adicionar(atendente);
            }
            else
            {
                banco.Atualizar(atendente);
            }

            banco.SalvarTodos();
        }

        public static Atendente LeituraAtendente(int codigoatendente)
        {
            BancoContexto banco = new BancoContexto();

            try
            {
                var arquivo = banco.AtendenteCtx.First(p => p.Id == codigoatendente);

                return arquivo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Atendente> LeituraAtendenteTodos()
        {
            BancoContexto banco = new BancoContexto();

            List<Atendente> lista = new List<Atendente>();

            var arquivo = from c in banco.AtendenteCtx select c;

            foreach (var item in arquivo)
            {
                lista.Add(item);
            }

            return lista;
        }
    }
}
