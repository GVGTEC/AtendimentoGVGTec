using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Contexto;
using DAL.Repositorio;

namespace UI
{
    public partial class frmCobranca : Form
    {
        int codigocliente_w = 0;
        int lancamento_w = 0;

        DateTime datacobranca_w = DateTime.MinValue;

        public class DadosDataGrid
        {
            public bool CobrarServico { get; set; }
            public int Id { get; set; }
            public DateTime DataLancamento { get; set; }
            public string NomeCliente { get; set; }
            public string NomeSolicitante { get; set; }
            public string Solicitacao { get; set; }
            public double ValorServico { get; set; }
            public string NomeControle { get; set; }
            public DateTime DataCobranca { get; set; }
        }

        List<DadosDataGrid> lista = new List<DadosDataGrid>();

        //public class ResultadoDataGrid
        //{
        //    //public int SubCategoriaId { get; set; }
        //    //public string SubCategoriaNome { get; set; }
        //    //public int CategoriaId { get; set; }
        //    //public string CategoriaNome { get; set; }

        //    public int PedidoId { get; set; }
        //    public string Nome { get; set; }
        //    public DateTime DataEmissao { get; set; }
        //    public decimal Total { get; set; }
        //}

        //List<DadosDataGrid> lista = new List<DadosDataGrid>();

        public frmCobranca()
        {
            InitializeComponent();
        }

        private void frmCobranca_Load(object sender, EventArgs e)
        {
            dgvPesquisar.AutoGenerateColumns = false;

            ConfiguraDataGridView();

            //MostraDadosGridView();

            //Salvar();
        }

        public void ConfiguraDataGridView()
        {
            //dgvPesquisar.Columns.Add("nome", "Nome");
            //dgvPesquisar.Columns.Add("descricao", "Descrição");
            //dgvPesquisar.Columns.Add("data", "Data");

            //dgvPesquisar.Columns.Add(new DataColumn("Quitar", typeof(bool)));
            ////dgvPesquisar.Columns.Add(".", typeof(bool).ToString());

            //dgvPesquisar.Columns.Add(".", "Cobrar");

            dgvPesquisar.Columns.Add(".", "Id");
            dgvPesquisar.Columns.Add(".", "Data Atendimento");
            dgvPesquisar.Columns.Add(".", "Cliente");
            dgvPesquisar.Columns.Add(".", "Solicitante");
            dgvPesquisar.Columns.Add(".", "Solicitação");
            dgvPesquisar.Columns.Add(".", "Valor Serviço");

            //https://www.youtube.com/watch?v=7GlgrnHFnGA
            //dgvPesquisar.ColumnCount = 3;
            //dgvPesquisar.Columns[0].Name = "Cliente";
            //dgvPesquisar.Columns[1].Name = "Descrição";
            //dgvPesquisar.Columns[2].Name = "Data";

            //dgvPesquisar.Columns[0].Width = 50;
            dgvPesquisar.Columns[0].Width = 50;
            dgvPesquisar.Columns[1].Width = 80;
            dgvPesquisar.Columns[2].Width = 200;
            dgvPesquisar.Columns[3].Width = 150;
            dgvPesquisar.Columns[4].Width = 220;
            dgvPesquisar.Columns[5].Width = 100;

            //dgvPesquisar.RowHeightChanged = 850;

            // INIBE A COLUNA DO ID PARA NÃO APARECER NO GRID
            //dgvPesquisar.Columns[0].Visible = false;

            // BLOQUEIA A EDIÇÃO DO DATAGRID
            //dgvPesquisar.ReadOnly = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void frmCobranca_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnPesquisarClientes_Click_1(object sender, EventArgs e)
        {
            frmClientePesquisar frm = new frmClientePesquisar();

            frm.ShowDialog();

            codigocliente_w = frm.IdCliente;

            var arquivo = MetodosCliente.LeituraCliente(codigocliente_w);

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

        public void MostraDadosGridView()
        {
            //codigocliente_w = 17;

            var atendimento = MetodosAtendimento.LeituraAtendimentoTodos(codigocliente_w);

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

            DadosDataGrid dados = new DadosDataGrid();

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
            //... // set properties as needed here
            //dataGridView1.Columns.Add(col);

            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col.Name = "Cobrar";
            col.HeaderText = "Cobrar";
            col.Name = "Cobrar";
            col.Width = 30;

            //DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            //col.HeaderText = "Id";
            //col.Name = "Id";
            //col.Width = 50;

            //DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            //col.HeaderText = "Data Atendimento";
            //col.Name = "DataAtendimento";
            //col.Width = 80;

            //dgvPesquisar.AutoGenerateColumns = false;
            //dgvPesquisar.ClearSelection();

            //dgvPesquisar.Columns.Add(".", "Id");
            //dgvPesquisar.Columns.Add(".", "Data Atendimento");
            //dgvPesquisar.Columns.Add(".", "Cliente");
            //dgvPesquisar.Columns.Add(".", "Solicitante");
            //dgvPesquisar.Columns.Add(".", "Solicitação");

            //dgvPesquisar.Columns.Insert(0, col1);
            //dgvPesquisar.Columns.Insert(1, col2);
            //dgvPesquisar.Columns.Insert(2, col3);

            dgvPesquisar.Columns.Add(col1);

            foreach (var item in atendimento)
            {
                dados.CobrarServico = false;
                dados.Id = item.Id;
                dados.DataLancamento = item.DataAtendimento;
                dados.NomeCliente = item.ClienteX.Nome;
                dados.NomeSolicitante = item.NomeSolicitante;
                dados.Solicitacao = item.SolicitacaoCliente;
                dados.ValorServico = item.ValorServico;

                lista.Add(dados);

                //dgvPesquisar.Rows.Add(lista);
                //dgvPesquisar.Columns.Add(col);

                //dgvPesquisar.Rows.Add(col, dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao);
                //dgvPesquisar.Rows.Add(dados.CobrarServico, dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao);

                //dgvPesquisar.Rows.Add(dados.Id, dados.DataLancamento);

                dgvPesquisar.Rows.Add(dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao, dados.ValorServico, false);

                //dgvPesquisar.Rows.Add(bool.Parse(col1.ToString()), dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao); dgvPesquisar.Rows.Add(bool.Parse(col1.ToString()), dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao);
                //dgvPesquisar.Rows.Add(bool.Parse(dados.CobrarServico.ToString()), dados.Id, dados.DataLancamento, dados.NomeCliente, dados.NomeSolicitante, dados.Solicitacao);
            }

            //dgvPesquisar.DataSource = lista.ToList();
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void txtCodigoCli_Leave(object sender, EventArgs e)
        //{
        //}

        private void dgvPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodigoCli_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnGerarLoteCobranca_Click(object sender, EventArgs e)
        {
            //frmLoteCobranca new = 
        }

        private void btnGerarLoteCobranca_Click_1(object sender, EventArgs e)
        {

            //Salvar();

            //for (int i = 0; i < dgvPesquisar.Rows.Count; i++)
            //{
            //    bool isCellChecked = (bool)dgvPesquisar.Rows[i].Cells[6].Value;

            //    if (isCellChecked == true)
            //    {
            //        MessageBox.Show("Is Checked");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Is Not Chiked");
            //    }

            //    //for (int x = 0; x < dgvPesquisar.Columns.Count; x++)
            //    // {
            //    //     MessageBox.Show(x  + " --> " +  dgvPesquisar.Rows[i].Cells[x].Value.ToString());
            //    // }
            //}

            bool achou = false;

            // VERIFICA SE TEM ALGUM CHECKBOX MARCADO. SE NÃO HOUVER NENHUM ENTENDE-SE QUE NÃO
            // HÁ ATENDIMENTO PARA SER COBRADO E NÃO EXIBE-SE A TELA PARA INFORMAR A DATA DA COBRANCA
            for (int i = 0; i < dgvPesquisar.Rows.Count; i++)
            {
                bool isCellChecked = (bool)dgvPesquisar.Rows[i].Cells[6].Value;

                if (isCellChecked == true)
                {
                    achou = true;

                    lancamento_w = (int)dgvPesquisar.Rows[i].Cells[0].Value;

                    Atualizar();
                }
            }

            if (achou == false)              
            {
                MessageBox.Show("Nenhum Serviço Selecionado", "Aviso");
            }
        }

        private void Atualizar()
        {
            Atendimentos.frmCobrancaTelaControle frm = new Atendimentos.frmCobrancaTelaControle();

            frm.ShowDialog();

            datacobranca_w = frm.DataCobranca;

            ////////NÃO FUNCIONA UTILIZANDO EM METODOS ATENDIMENTOS
            ////////var arquivo = MetodosAtendimento.LeituraAtendimento(lancamento_w);

            ////////arquivo.DataCobranca = datacobranca_w;

            ////////MetodosAtendimento.Gravar(arquivo);

            AtendimentoRepositorio banco = new AtendimentoRepositorio();

            var arquivo = banco.Find(lancamento_w);

            arquivo.DataCobranca = datacobranca_w;

            banco.Atualizar(arquivo);
            banco.SalvarTodos();
        }

        public void Salvar()
        {
            Atendimentos.frmCobrancaTelaControle frm = new Atendimentos.frmCobrancaTelaControle();

            frm.ShowDialog();

            datacobranca_w = frm.DataCobranca;

            AtendimentoRepositorio banco = new AtendimentoRepositorio();

            //using (BancoContexto contexto = new BancoContexto())
            //{
            //    var arquivo = contexto.AtendimentoCtx.First(x => x.Id == 130);

            //    arquivo.DataCobranca = datacobranca_w;

            //    banco.Adicionar(arquivo);
            //    banco.SalvarTodos();
            //}

            var arquivo = banco.Find(26);

            arquivo.DataCobranca = datacobranca_w;

            banco.Atualizar(arquivo);
            banco.SalvarTodos();


            //var arquivo = MetodosAtendimento.LeituraAtendimento(130);


            //MetodosAtendimento.Gravar(arquivo);]

            //foreach (var item in lista)
            //{
            //    var arquivo = MetodosAtendimento.LeituraAtendimento(item.Id);

            //    arquivo.DataCobranca = datacobranca_w;

            //    MetodosAtendimento.Gravar(arquivo);
            //}
        }

        private void txtCodigoCli_Leave(object sender, EventArgs e)
        {
            if (txtCodigoCli.Text == "")
            {
                txtCodigoCli.Focus();

                return;
            }

            if (txtCodigoCli.Text != "")
            {
                codigocliente_w = Int32.Parse(txtCodigoCli.Text);

                if (codigocliente_w == 0)
                {
                    txtCodigoCli.Focus();

                    return;
                }

                var arquivo = MetodosCliente.LeituraCliente(codigocliente_w);

                if (arquivo == null)
                {
                    MessageBox.Show("Cliente Inexistente", "Aviso");

                    txtCodigoCli.Text = "";

                    txtCodigoCli.Focus();

                    return;
                }

                txtCodigoCli.Text = arquivo.Id.ToString();
                txtNomeCli.Text = arquivo.Nome;

                MetodosAtendimento.LeituraAtendimentoTodos(codigocliente_w);

                MostraDadosGridView();
            }
        }

        private void frmCobranca_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.F9)
            {
                btnPesquisarClientes_Click_1(sender, e);
            }

            if (e.KeyCode == Keys.F10)
            {
                Close();
            }
        }
    }
}
