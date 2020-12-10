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
    public class MetodosFilial
    {
        public static void Gravar(Filial filial)
        {
            FilialRepositorio banco = new FilialRepositorio();

            if (filial.Id == 0)
            {
                banco.Adicionar(filial);               
            }
            else
            {
                banco.Atualizar(filial);
            }

            banco.SalvarTodos();
        }

        public static Filial LeituraFilial(int codigofilial)
        {
            BancoContexto banco = new BancoContexto();

            try
            {
                var arquivo = banco.FilialCtx.First(p => p.Id == codigofilial);

                return arquivo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Filial> LeituraFilialPorCliente(int codigocliente)
        {
            BancoContexto banco = new BancoContexto();

            List<Filial> lista = new List<Filial>();

            try
            {
                //var arquivo = banco.FilialCtx.Where(p => p.ClienteId == codigocliente);

                var arquivo = from p in banco.FilialCtx where p.ClienteX.Id == codigocliente select p;

                foreach (var item in arquivo)
                {
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
