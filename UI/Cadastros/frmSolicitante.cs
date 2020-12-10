using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
//using System.Data.SqlClient;
using System.Reflection;
using DAL.MODEL;
using DAL;
using DAL.Contexto;
using DAL.Repositorio;
using BLL;

namespace UI
{
    public partial class frmSolicitante : Form
    {
        private frmCliente frmCliente;

        public int codigocliente_w;
        public int codigosolicitante;

        public frmSolicitante(frmCliente frmCliente, int codigocliente, string nome)
        {
            InitializeComponent();

            this.frmCliente = frmCliente;

            lblCliente.Text = codigocliente + "-" + nome;

            codigocliente_w = codigocliente;
        }

        private void frmSolicitante_Load(object sender, EventArgs e)
        {
            ConfiguraDataGridView();

            MostraDadosGridView();

            CarregarComboBox();

            txtNome.Focus();

            txtNome.Select();

            btnSalvar.Enabled = false;
        }

        private void CarregarComboBox()
        {
            cmbSituacao.Items.Add("Ativo");
            cmbSituacao.Items.Add("Inativo");

            cmbSituacao.SelectedIndex = 0;
        }

        public void ConfiguraDataGridView()
        {
            // Desabilita a criação automatica de colunas
            //dgvItens.AutoGenerateColumns = false;

            dgvSolicitante.Columns.Add(".", "Nome");
            dgvSolicitante.Columns.Add(".", "Situacao");

            dgvSolicitante.Columns[0].Width = 600;
            dgvSolicitante.Columns[1].Width = 100;

            // INIBE A COLUNA DO ID PARA NÃO APARECER NO GRID
            //dgvPesquisar.Columns[0].Visible = false;

            //BLOQUEIA A EDIÇÃO DO DATAGRID
            dgvSolicitante.ReadOnly = true;
        }

        private void MostraDadosGridView()
        {
            var retorno = MetodosSolicitante.LeituraSolicitantePorCliente(codigocliente_w);

            frmCliente.listasolicitantes.Clear();

            foreach (var item in retorno)
            {
                //Carrega todos os Solicitantes no DataGridView
                dgvSolicitante.Rows.Add(item.Nome, item.AtivoInativo);
                //dgvSolicitante.Rows.Add(item.AtivoInativo);

                //Carrega todos os Solicitantes na lista
                frmCliente.listasolicitantes.Add(item);

                //MessageBox.Show("pausa");
            }

            //MessageBox.Show("Passou");

            //dgvSolicitante.DataSource = retorno;
        }

        private void AdicionarItem()
        {
            if (txtNome.Text == "")
            {
                return;
            }

            dgvSolicitante.Rows.Add(txtNome.Text, cmbSituacao.Text);
            
            Solicitante dados = new Solicitante();

            dados.Id = codigosolicitante;
            dados.Id = 0;

            dados.Nome = txtNome.Text;
            dados.AtivoInativo = cmbSituacao.Text;

            frmCliente.listasolicitantes.Add(dados);

            txtNome.Text = "";
            //cmbSituacao.Text = "";

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNome.Focus();
            txtNome.Select();

            btnSalvar.Enabled = true;
        }

        private void frmSolicitante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            //if (e.KeyCode == Keys.F9)
            //{
            //    btnPesquisar_Click(sender, e);
            //}

            if (e.KeyCode == Keys.F10)
            {
                btnSair_Click(sender, e);
            }

            if (btnSalvar.Enabled == true)
            {
                if (e.KeyCode == Keys.F8)
                {
                    btnSalvar_Click(sender, e);
                }
            }

            //if (e.KeyCode == Keys.Escape)
            //{
            //    btnCancelar_Click(sender, e);
            //}
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            BancoContexto contexto = new BancoContexto();

            //GRAVA OS SOLICITANTES NO BANCO
            //foreach (var item in frmCliente.listasolicitantes)
            //{
            //    Solicitante solicitante = new Solicitante();

            //    solicitante.Nome = item.Nome;
            //    solicitante.AtivoInativo = item.AtivoInativo;
            //    solicitante.ClienteId = codigocliente_w;

            //    MetodosSolicitante.Gravar(solicitante);
            //}

            int ix = 0;

            foreach (var item in frmCliente.listasolicitantes)
            {
                if (item.Id == 0)
                {
                    Solicitante solicitante = new Solicitante();

                    solicitante.Nome = item.Nome;
                    solicitante.AtivoInativo = item.AtivoInativo;
                    solicitante.ClienteId = codigocliente_w;
                    solicitante.FilialId = 1;

                    MetodosSolicitante.Gravar(solicitante);

                    ix++;
                }
            }

            MessageBox.Show(ix + " Solicitantes Gravados","Aviso");

            dgvSolicitante.Rows.Clear();

            MostraDadosGridView();

            btnSalvar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            dgvSolicitante.Rows.Remove(this.dgvSolicitante.CurrentRow);
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (this.ActiveControl == txtValorTotal)
                //{
                //    AdicionarItem();

                //    txtCodigoPrd.Focus();
                //}

                AdicionarItem();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }

        private void dgvSolicitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.RowIndex < dgvSolicitante.Rows.Count)
                {
                    int cod = cod = int.Parse(dgvSolicitante.Rows[e.RowIndex].Cells[0].Value.ToString());

                    if (cod != 0)
                    {
                        //IdProduto = cod;

                        //txtCodigoPrd.Text = dgvSolicitante.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //txtDescricaoPrd.Text = dgvSolicitante.Rows[e.RowIndex].Cells[0].Value.ToString();

                        txtNome.Text = dgvSolicitante.Rows[e.RowIndex].Cells[1].Value.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                if (cmbSituacao.Text == "")
                {
                    cmbSituacao.SelectedIndex = 0;
                }
            }
        }
    }
}
