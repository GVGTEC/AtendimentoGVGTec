using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading;
using DAL.Contexto;
using DAL.MODEL;
using System.Data.Entity;
using BLL;

//namespace proto.UI
namespace UI
{
    public partial class frmAtendimentoPesquisar : Form
    {
        public frmAtendimentoPesquisar()
        {
            InitializeComponent();
        }

        //Esta propriedade devolve o ID Pedido para o formulario anterior
        public int IdPedido { get; set; }
        public int codigocliente { get; set; }

        public class DadosDataGrid
        {
            public int Id { get; set; }
            public DateTime DataLancamento { get; set; }
            public string NomeCliente { get; set; }
            public string NomeSolicitante { get; set; }
            public string Solicitacao { get; set; }
        }

        List<DadosDataGrid> lista = new List<DadosDataGrid>();

        public class ResultadoDataGrid
        {
            //public int SubCategoriaId { get; set; }
            //public string SubCategoriaNome { get; set; }
            //public int CategoriaId { get; set; }
            //public string CategoriaNome { get; set; }

            public int PedidoId { get; set; }
            public string Nome { get; set; }
            public DateTime DataEmissao { get; set; }
            public decimal Total { get; set; }
        }

        private void frmAtendimentoPesquisar_Load(object sender, EventArgs e)
        {
            //dgvPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvPesquisar.AutoGenerateColumns = false;

            ConfiguraDataGridView();

            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                //MessageBox.Show("Erro na Pesquisa" + ex + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            codigocliente = 0;

            MostraDadosGridView();

            txtCodigoCli.Focus();
        }

        public void ConfiguraDataGridView()
        {
            //dgvPesquisar.Columns.Add("nome", "Nome");
            //dgvPesquisar.Columns.Add("descricao", "Descrição");
            //dgvPesquisar.Columns.Add("data", "Data");

            dgvPesquisar.Columns.Add(".", "Id");
            dgvPesquisar.Columns.Add(".", "Data Atendimento");
            dgvPesquisar.Columns.Add(".", "Cliente");
            dgvPesquisar.Columns.Add(".", "Solicitante");
            dgvPesquisar.Columns.Add(".", "Solicitação");

            //https://www.youtube.com/watch?v=7GlgrnHFnGA
            //dgvPesquisar.ColumnCount = 3;
            //dgvPesquisar.Columns[0].Name = "Cliente";
            //dgvPesquisar.Columns[1].Name = "Descrição";
            //dgvPesquisar.Columns[2].Name = "Data";

            dgvPesquisar.Columns[0].Width = 50;
            dgvPesquisar.Columns[1].Width = 80;
            dgvPesquisar.Columns[2].Width = 300;
            dgvPesquisar.Columns[3].Width = 150;
            dgvPesquisar.Columns[4].Width = 300;

            //dgvPesquisar.RowHeightChanged = 850;

            // INIBE A COLUNA DO ID PARA NÃO APARECER NO GRID
            //dgvPesquisar.Columns[0].Visible = false;

            // BLOQUEIA A EDIÇÃO DO DATAGRID
            dgvPesquisar.ReadOnly = true;
        }

        //http://help.market.com.br/csharp/criando_colunas_e_linhas_em_ru.htm

        public void ConfiguraDGV_OLD()
        {
            //customersDataGridView.Columns["CustomerID"].Visible = false;
            //customersDataGridView.Columns["ContactName"].DisplayIndex = 0;
            //customersDataGridView.Columns["ContactTitle"].DisplayIndex = 1;
            //customersDataGridView.Columns["City"].DisplayIndex = 2;
            //customersDataGridView.Columns["Country"].DisplayIndex = 3;
            //customersDataGridView.Columns["CompanyName"].DisplayIndex = 4;

            // Renoneia o nome da coluna
            //dgvPesquisar.Columns["cfopID"].HeaderText = "Código";
            //dgvPesquisar.Columns["cfop"].HeaderText = "CFOP";

            //////////////////dgvPesquisar.Columns[0].HeaderText = "CFOP";
            //////////////////dgvPesquisar.Columns[1].HeaderText = "Natureza Operação";

            // Redimensiona o a largura da coluna
            //dgvPesquisar.Columns[0].Width = 30;
            //dgvPesquisar.Columns[1].Width = 200;

            //dgvPesquisar.Columns["cfop"].Visible = false;
            //dgvPesquisar.Columns["naturezaoperacao"].Visible = false;
        }

        public void CarregarGrid()   //http://www.macoratti.net/10/11/c_efcrud.htm
        {
        }

        public void CarregarGrid_OLD()
        {
            try
            {
                DataTable tab = null;

                //tab = fornecedorBll.LocalizarEmTudo(txtPesquisar.Text);
                dgvPesquisar.DataSource = tab;
                dgvPesquisar.ClearSelection();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvPesquisar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // https://pt.stackoverflow.com/questions/49369/chamar-evento-de-dentro-do-c%C3%B3digo

            //dgvPesquisar_CellDoubleClick(sender, e);
        }

        private void dgvPesquisar_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.RowIndex < dgvPesquisar.Rows.Count)
                {
                    int cod = cod = int.Parse(dgvPesquisar.Rows[e.RowIndex].Cells[0].Value.ToString());

                    if (cod != 0)
                    {
                        IdPedido = cod;

                        //fornecedorBll.LocalizarLeave(cod.ToString(), "Id");

                        //txtPesquisar.Text = "";

                        //CarregarCampos();

                        //fornecedorBll.Id = cod;
                        //fornecedorBll.Nome = dgvPesquisar.Rows[e.RowIndex].Cells[1].Value.ToString();

                        //IdFornecedor = fornecedorBll.Id;
                        //Nome = fornecedorBll.Nome;

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtCodigoCli_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCodigoCli_Leave(object sender, EventArgs e)
        {
            if (txtCodigoCli.Text == "0")
            {
                cmbLimpar_Click(sender, e);

                txtCodigoCli.Focus();

                return;
            }

            if (txtCodigoCli.Text == "")
            {
                txtCodigoCli.Focus();

                return;
            }

            if (txtCodigoCli.Text != "")
            {
                codigocliente = Int32.Parse(txtCodigoCli.Text);

                if (codigocliente == 0)
                {
                    txtCodigoCli.Focus();

                    return;
                }

                var arquivo = MetodosCliente.LeituraCliente(codigocliente);

                if (arquivo == null)
                {
                    MessageBox.Show("Cliente Inexistente","Aviso");

                    txtCodigoCli.Text = "";

                    txtCodigoCli.Focus();

                    return;
                }

                txtCodigoCli.Text = arquivo.Id.ToString();
                txtNomeCli.Text = arquivo.Nome;

                MostraDadosGridView();

                //var atendimento = MetodosAtendimento.LeituraAtentimento(codigocliente);

                ////*********************************************************************
                ////https://www.youtube.com/watch?v=7GlgrnHFnGA

                ////var lista = from x in atendimento.ToList()
                ////            select new
                ////            {
                ////                x.ClienteX.Nome,
                ////            };

                ////dgvPesquisar.DataSource = lista.ToList();

                ////*********************************************************************

                //dgvPesquisar.DataSource = atendimento.ToList();

                //dgvPesquisar.Columns["cliente"].DataPropertyName = "Cliente";
                //dgvPesquisar.Columns["descricao"].DataPropertyName = "Descricao";
                //dgvPesquisar.Columns["data"].DataPropertyName = "Data";
            }
        }

        public void MostraDadosGridView_X()
        {
            var atendimento = MetodosAtendimento.LeituraAtendimentoTodos(codigocliente);

            //*********************************************************************
            //https://www.youtube.com/watch?v=7GlgrnHFnGA

            //var lista = from x in atendimento.ToList()
            //            select new
            //            {
            //                x.ClienteX.Nome,
            //            };

            //dgvPesquisar.DataSource = lista.ToList();

            //*********************************************************************

            //ESTA LINHA CARREGA O DATAGRID COM TODOS OS CAMPOS DA TABELA
            //dgvPesquisar.DataSource = atendimento.ToList();



            //foreach (var item in atendimento)
            //{
            //dgvPesquisar.Rows.Add(item.Id);                
            //}

            DadosDataGrid dados = new DadosDataGrid();

            foreach (var item in atendimento)
            {
                dados.Id = item.Id;
                dados.DataLancamento = item.DataAtendimento;
                dados.NomeCliente = item.ClienteX.Nome;
                dados.NomeSolicitante = item.SolicitanteId.ToString();
                dados.Solicitacao = item.SolicitacaoCliente;

                lista.Add(dados);

                dgvPesquisar.Rows.Add(lista);
            }

            //dgvPesquisar.Rows.Add(lista)

            //dgvPesquisar.Rows.Add(atendimento. txtCodigoPrd.Text, txtDescricaoPrd.Text, txtQuantidadePrd.Text, txtPrecoUnitario.Text, txtPrecoTotal.Text);

            //dgvPesquisar.Columns["nome"].DataPropertyName = "Nome";
            //dgvPesquisar.Columns["descricao"].DataPropertyName = "Descricao";
            //dgvPesquisar.Columns["data"].DataPropertyName = "Data";
        }

        public void MostraDadosGridView()
        {
            var atendimento = MetodosAtendimento.LeituraAtendimentoTodos(codigocliente);

            //*********************************************************************
            //https://www.youtube.com/watch?v=7GlgrnHFnGA

            //var lista = from x in atendimento.ToList()
            //            select new
            //            {
            //                x.ClienteX.Nome,
            //            };

            //dgvPesquisar.DataSource = lista.ToList();

            //*********************************************************************

            //ESTA LINHA CARREGA O DATAGRID COM TODOS OS CAMPOS DA TABELA
            //dgvPesquisar.DataSource = atendimento.ToList();



            //foreach (var item in atendimento)
            //{
            //    dgvPesquisar.Rows.Add(item.Id);
            //}

            LimpaDataGridView();

            //dgvPesquisar.Columns.Clear();
            //dgvPesquisar.Rows.Clear();
            //dgvPesquisar.Refresh();

            //lista.Clear();

            //ConfiguraDataGridView();

            DadosDataGrid dados = new DadosDataGrid();

            foreach (var item in atendimento)
            {
                dados.Id = item.Id;
                dados.DataLancamento = item.DataAtendimento;
                dados.NomeCliente = item.ClienteX.Nome;
                dados.NomeSolicitante = item.NomeSolicitante;
                dados.Solicitacao = item.SolicitacaoCliente;

                lista.Add(dados);

                //dgvPesquisar.Rows.Add(lista);

                dgvPesquisar.Rows.Add(dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao);
            }

            //dgvPesquisar.DataSource = lista.ToList();
        }

        private void LimpaDataGridView()
        {
            dgvPesquisar.Columns.Clear();
            dgvPesquisar.Rows.Clear();
            dgvPesquisar.Refresh();

            lista.Clear();

            ConfiguraDataGridView();
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            frmClientePesquisar frm = new frmClientePesquisar();

            frm.ShowDialog();

            codigocliente = frm.IdCliente;

            var arquivo = MetodosCliente.LeituraCliente(codigocliente);

            if (arquivo == null)
            {
                MessageBox.Show("Cliente Inexistente", "Aviso");

                txtCodigoCli.Text = "";

                txtCodigoCli.Focus();

                return;
            }

            txtCodigoCli.Text = arquivo.Id.ToString();
            txtNomeCli.Text = arquivo.Nome;

            //MetodosAtendimento.LeituraAtendimentoTodos(codigocliente);

            MostraDadosGridView();
        }

        private void frmAtendimentoPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.F9)
            {
                btnPesquisarClientes_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigoCli.Text = "";
            txtNomeCli.Text = "";

            dgvPesquisar.DataSource = null;

            txtCodigoCli.Focus();
        }

        private void cmbLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoCli.Text = "";
            txtNomeCli.Text = "";

            codigocliente = 0;

            //LimpaDataGridView();

            MostraDadosGridView();

            //ZERAR DATAGRIDVIEW (OS COMANDOS ABAIXO NAO FUNCIONAM)
            //dgvPesquisar.Rows.Clear();

            //dgvPesquisar.DataSource = null;

            txtCodigoCli.Focus();

            txtCodigoCli.Select();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MostraDadosGridView();
        }
    }
}
