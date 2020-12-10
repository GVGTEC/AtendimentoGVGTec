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
    public class MetodosCliente
    {
        public static BancoContexto banco = new BancoContexto();

        public static void Gravar(Cliente cliente)
        {
            ClienteRepositorio x = new ClienteRepositorio();

            if (cliente.Id == 0)
            {
                x.Adicionar(cliente);               
            }
            else
            {
                x.Atualizar(cliente);
            }

            x.SalvarTodos();

            x.Dispose();
        }

        public static Cliente LeituraCliente(int codigocliente)
        {
            //BancoContexto banco = new BancoContexto();

            try
            {
                var arquivo = banco.ClienteCtx.First(p => p.Id == codigocliente);

                return arquivo;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // RETORNA UMA LISTA DE CLIENTES
        public static IEnumerable<Cliente> LeituraTodosClientes()
        {
            //BancoContexto banco = new BancoContexto();

            try
            {
                //ESTE FUNCIONA
                //IEnumerable<Cliente> lista = from c in banco.ClienteCtx select c;

                //ESTE NÃO FUNCIONA
                //var lista = banco.ClienteCtx.Find();

                var lista = from c in banco.ClienteCtx select c;

                return lista.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
