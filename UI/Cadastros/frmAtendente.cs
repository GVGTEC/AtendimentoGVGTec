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
    public partial class frmAtendente : Form
    {
        public frmAtendente()
        {
            InitializeComponent();
        }

        //RETORNA DO FrmSOLICITANTE UMA LISTA PARA SER GRAVADO NA TABELA DE SOLICITANTES
        public List<Solicitante> listasolicitantes = new List<Solicitante>();

        int codigoAtendente = 0;
        int codigo1 = 0;
        string nome1 = "";
        int opcao = 0;

        private void frmAtendentes_Load(object sender, EventArgs e)
        {
            DesabilitaOpcoes();

            CarregarComboBox();

            LimparCampos();
        }

        private void CarregarComboBox()
        {
            cmbSituacao.Items.Add("Ativo");
            cmbSituacao.Items.Add("Inativo");
        }

        private void tsbPesquisar_Click(object sender, EventArgs e)
        {
            // TESTAR SE A TABELA ESTÁ VAZIA (A ROTINA ABAIXO NÃO FUNCIONOU)
            //Atendente objeto = new Atendente();

            //if (objeto == null)
            //{
            //    MessageBox.Show("Nenhum Atendente Cadastrado !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    return;
            //}

            frmAtendentePesquisar frm = new frmAtendentePesquisar();

            frm.ShowDialog();

            //frm.IdAtendente retorna o Id Atendente que foi selecionado na pesquisa
            codigoAtendente = frm.IdAtendente;

            if (codigoAtendente != 0)
            {
                opcao = 2;

                CarregaDados();

                tsbPesquisar.Enabled = false;
                tsbNovo.Enabled = false;
                tsbAtualizar.Enabled = true;
                tsbExcluir.Enabled = true;
                tsbCancelar.Enabled = true;

                txtCodigo.Enabled = false;

                //btnEnderecoEntrega.Enabled = true;
            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            opcao = 1;
            codigoAtendente = 0;

            LimparCampos();

            tsbPesquisar.Enabled = false;
            tsbNovo.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbAtualizar.Enabled = true;

            //cmbEntSai.Items.Add("TESTE1");  //Adicona em tempo de execução
            //cmbEntSai.Items.Add("TESTE2");

            HabilitaCampos();

            //btnEnderecoEntrega.Enabled = false;

            //cmbEntSai.SelectedIndex = 0;
            //cmbCliFor.SelectedIndex = 0;
            //cmbGerarFaturamento.SelectedIndex = 1;
            //cmbCalculaICMS.SelectedIndex = 1;

            cmbSituacao.SelectedIndex = 0;

            txtNome.Focus();
        }

        private void tsbAtualizar_Click(object sender, EventArgs e)
        {
            //if (txtCodigo.Text == "")
            //{
            //    MessageBox.Show("Informar o Código Produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    txtCodigo.Focus();
            //}

            if (txtNome.Text == "")
            {
                MessageBox.Show("Informar o Campo Nome/Razão Social", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Focus();

                return;
            }

            if (codigoAtendente == 0)
            {
                DialogResult resposta = MessageBox.Show("Confirma Inclusão ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.No)
                {
                    tsbNovo_Click(sender, e);

                    return;
                }
            }

            if (codigoAtendente != 0)
            {
                DialogResult resposta = MessageBox.Show("Confirma Alteração ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
               
                if (resposta == DialogResult.No)
                {
                    tsbNovo_Click(sender, e);

                    return;
                }
            }

            //AtendenteRepositorio banco = new AtendenteRepositorio();

            Atendente Atendente = new Atendente();

            Atendente.Nome = txtNome.Text;

            // INCLUSÃO
            if (codigoAtendente == 0)
            {
                try
                {
                    //banco.Salvar(produto);

                    //banco.Adicionar(Atendente);
                    //banco.SalvarTodos();

                    MetodosAtendente.Gravar(Atendente);

                    txtCodigo.Text = Atendente.Id.ToString();

                    MessageBox.Show("Inclusão OK", "Código: " + Atendente.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //LimparCampos();

                    //tsbNovo_Click(sender, e);

                    codigo1 = Atendente.Id;
                    nome1 = txtNome.Text;

                    //btnEnderecoEntrega.Enabled = true;

                    //frmAtendentes_Load(sender, e);

                    //////////////DesabilitaCampos();

                    //////////////HabilitaCampos();

                    //////////////tsbNovo.Enabled = true;
                    //////////////tsbSair.Enabled = true;

                    //txtNome.Focus();
                }
                catch (Exception ex)
                {
                    //https://www.caelum.com.br/apostila-csharp-orientacao-objetos/excecoes/#16-4-exercicios

                    //MessageBox.Show("Erro na Inclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Erro na Inclusão" + ex + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //btnEnderecoEntrega.Enabled = true;
            }

            // ALTERAÇÃO
            if (codigoAtendente != 0)
            {
                try
                {
                    Atendente.Id = codigoAtendente;

                    //banco.Alterar(Atendente);

                    //banco.Atualizar(Atendente);
                    //banco.SalvarTodos();

                    MetodosAtendente.Gravar(Atendente);

                    MessageBox.Show("Alteração OK", "Código: " + Atendente.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tsbPesquisar.Enabled = true;
                    tsbNovo.Enabled = true;
                    tsbSair.Enabled = true;

                    txtCodigo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na Alteração" + ex + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimparCampos();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaOpcoes();

            LimparCampos();

            tsbPesquisar.Enabled = true;
            tsbNovo.Enabled = true;
            tsbSair.Enabled = true;
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {

        }

        private void tsbPrimeiro_Click(object sender, EventArgs e)
        {

        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {

        }

        private void tsbProximo_Click(object sender, EventArgs e)
        {

        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAtendentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.F9)
            {
                tsbPesquisar_Click(sender, e);

                //frmCFOPPesquisar frm = new frmCFOPPesquisar();

                //frm.WindowState = System.Windows.Forms.FormWindowState.Normal;

                //frm.ShowDialog();

                //codigo = frm.IdCFOP;

                //if (codigo != 0)
                //{
                //    CarregaDados();

                //    tsbNovo.Enabled = false;
                //    tsbAtualizar.Enabled = true;
                //    tsbExcluir.Enabled = true;
                //    tsbCancelar.Enabled = true;
                //}
            }

            if (e.KeyCode == Keys.F10)
            {
                if (opcao == 1)  // ESTÁ FAZENDO UM NOVO CADASTRO E TECLA F10
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        DialogResult resposta = MessageBox.Show("Confirma Cancelamento ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (resposta == DialogResult.Yes)
                        {
                            Close();

                            return;
                        }
                    }
                }
                else
                {
                    Close();
                }
            }

            //if (keyData == Keys.Escape)
            //{
            //    Close();
            //}

        }

        // SUB-ROTINAS

        private void CarregaDados()
        {
            BancoContexto banco = new BancoContexto();

            Atendente Atendente = new Atendente();

            //MessageBox.Show(codigo.ToString());  // Mostra o código vindo do DataGridView somente para confirmação

            var arquivo = banco.AtendenteCtx.First(c => c.Id == codigoAtendente);

            //ExibeDados();

            HabilitaCampos();

            txtCodigo.Text = arquivo.Id.ToString();
            txtNome.Text = arquivo.Nome;

            codigo1 = Int32.Parse(txtCodigo.Text);
            nome1 = txtNome.Text;
        }

        public void LimparCampos()
        {
            foreach (Control c in this.Controls)
            {
                //if (c.GetType().ToString() == "System.Windows.Form.Textbox")
                //{
                //    c.Text = "";
                //}

                if (c is TextBox)
                    (c as TextBox).Text = "";
            }

            DesabilitaCampos();

            txtCodigo.Enabled = false;

            txtNome.Focus();

            //https://www.youtube.com/watch?v=SWKPJ9lix54   aos 7mm:22s
            //DateTime hoje = DataTime.Today;// Today - somente a data de hoje, sem horário
            //txtDataEmissao.Text = hoje.ToString("dd/MM/yyyy");
        }

        public void ExibeDados()
        {
            //txtCodigo.Text = arquivo.produto;
            //txtDescricao.Text = arquivo.Descricao;
            //txtNaturezaOperacao.Text = arquivo.NaturezaOperacao;
            //txtOperacao.Text = arquivo.Operacao;
            //txtArqMensagens.Text = arquivo.ArquivoMensagens;
            //cmbCalculaICMS.Text = arquivo.CalcularIcms;
            //cmbCliFor.Text = arquivo.CliFor;
            //cmbEntSai.Text = arquivo.EntSai;
            //cmbGerarFaturamento.Text = arquivo.GerarFaturamento;
        }

        public void DesabilitaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Enabled = false;

                if (c is ComboBox)
                    (c as ComboBox).Enabled = false;

                if (c is MaskedTextBox)
                    (c as MaskedTextBox).Enabled = false;
            }

            //btnEnderecoEntrega.Enabled = false;
        }

        public void HabilitaCampos()
        {
            if (opcao == 1)
                txtCodigo.Enabled = false;
            else
                txtCodigo.Enabled = true;

            //if (opcao == 1)
            //    txtCodigo.Enabled = false;
            //else
            //    txtCodigo.Enabled = true;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Enabled = true;

                if (c is ComboBox)
                    (c as ComboBox).Enabled = true;

                if (c is MaskedTextBox)
                    (c as MaskedTextBox).Enabled = true;
            }

            //btnEnderecoEntrega.Enabled = true;
        }

        public void HabilitaOpcoes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    (c as Button).Enabled = true;
            }

            //tsbAnterior.Enabled = true;
            //tsbExcluir.Enabled = true;
            //tsbPrimeiro.Enabled = true;
            //tsbProximo.Enabled = true;
            //tsbUltimo.Enabled = true;
        }

        public void DesabilitaOpcoes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    (c as Button).Enabled = false;
            }

            tsbCancelar.Enabled = false;
            tsbAtualizar.Enabled = false;
            tsbAnterior.Enabled = false;
            tsbExcluir.Enabled = false;
            tsbPrimeiro.Enabled = false;
            tsbProximo.Enabled = false;
            tsbUltimo.Enabled = false;
        }
    }
}
