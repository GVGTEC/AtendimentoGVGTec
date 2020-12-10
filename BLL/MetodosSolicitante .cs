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
    public class MetodosSolicitante
    {
        public static BancoContexto banco = new BancoContexto();

        public static void Gravar(Solicitante solicitante)
        {
            SolicitanteRepositorio banco = new SolicitanteRepositorio();

            if (solicitante.Id == 0)
            {
                banco.Adicionar(solicitante);               
            }
            else
            {
                banco.Atualizar(solicitante);
            }

            banco.SalvarTodos();
        }

        public static Solicitante LeituraSolicitante(int codigosolicitante)
        {
            //BancoContexto banco = new BancoContexto();

            try
            {
                var arquivo = banco.SolicitanteCtx.First(p => p.Id == codigosolicitante);

                return arquivo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Solicitante> LeituraSolicitantePorCliente(int codigocliente)
        {
            //BancoContexto banco = new BancoContexto();

            List<Solicitante> lista = new List<Solicitante>();

            try
            {
                var arquivo = banco.SolicitanteCtx.Where(p => p.ClienteId == codigocliente);

                //var arquivo = from p in banco.SolicitanteCtx where p.FilialX.Id == codigocliente select p;

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
