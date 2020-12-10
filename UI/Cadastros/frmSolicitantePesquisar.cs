using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DAL.Contexto;
using DAL.MODEL;

namespace UI
{
    public partial class frmSolicitantePesquisar : Form
    {
        public frmSolicitantePesquisar()
        {
            InitializeComponent();
        }

        //Esta propriedade devolve o ID Solicitante para o formulario anterior
        public int IdCliente { get; set; }

        private void frmSolicitantePesquisar_Load(object sender, EventArgs e)
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
        }

        public void ConfiguraDataGridView()
        {
            dgvPesquisar.Columns.Add("codigo", "Código");
            //dgvPesquisar.Columns.Add("descricao", "Descrição");
            dgvPesquisar.Columns.Add("nome", "Nome");

            dgvPesquisar.Columns[0].Width = 60;
            dgvPesquisar.Columns[1].Width = 850;

            //dgvPesquisar.RowHeightChanged = 850;

            // INIBE A COLUNA DO ID PARA NÃO APARECER NO GRID
            //dgvPesquisar.Columns[0].Visible = false;

            // BLOQUEIA A EDIÇÃO DO DATAGRID
            dgvPesquisar.ReadOnly = true;
        }

        public void CarregarGrid()   //http://www.macoratti.net/10/11/c_efcrud.htm
        {
            try
            {
                BancoContexto contexto = new BancoContexto();

                //                No entanto, para exibir algumas propriedades com Lambda Expressions, use:
                //                var dados = ef.Produto.Select(p => new { p.NomeProduto, p.Preco });
                //                gvProdutos.DataSource = dados;
                //                gvProdutos.DataBind();

                //                Caso queira usar o linq, use
                //                var dados = from p in ef.Produto
                //                            select new { p.NomeProduto, p.Preco };
                //                gvProdutos.DataSource = dados;
                //                gvProdutos.DataBind();

                //var lista = from p in contexto.Cfops select p.cfop;
                //IEnumerable<Cfop> lista = from p in contexto.Cfops select new { p.cfop };

                IEnumerable<Solicitante> lista = from c in contexto.SolicitanteCtx select c;

                dgvPesquisar.DataSource = lista.ToList();

                //dgvPesquisar.Columns["codigo"].DataPropertyName = "ClienteId";
                //dgvPesquisar.Columns["descricao"].DataPropertyName = "Nome";

                dgvPesquisar.Columns["codigo"].DataPropertyName = "Id";
                dgvPesquisar.Columns["nome"].DataPropertyName = "Nome";
            }

            catch (Exception)
            {
                throw;
            }
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

        private void frmClientePesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.F10)
            {
                Close();
            }

        }

        private void dgvPesquisar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.RowIndex < dgvPesquisar.Rows.Count)
                {
                    int cod = cod = int.Parse(dgvPesquisar.Rows[e.RowIndex].Cells[0].Value.ToString());

                    if (cod != 0)
                    {
                        IdCliente = cod;

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void SelecionaLinha()
        {
            throw new NotImplementedException();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmSolicitantePesquisar_Load(sender, e);
        }

        //http://help.market.com.br/csharp/criando_colunas_e_linhas_em_ru.htm
    }
}
