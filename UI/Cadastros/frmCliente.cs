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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        //
        //RETORNA DE FrmSolicitante UMA LISTA PARA SER GRAVADO NA TABELA DE SOLICITANTES
        //ESTA GRAVAÇÃO NÃO ESTÁ MAIS NESTA ROTINA. ESTÁ NA PRÓPRIA FrmSolicitante
        //MAS SERVE COMO EXEMPLO DE COMO FAZER ESTÁ TRANSFERÊNCIA DE DADOS
        //
        public List<Solicitante> listasolicitantes = new List<Solicitante>();

        //
        //RETORNA DE FrmFilial UMA LISTA PARA SER GRAVADO NA TABELA DE FILIAIS
        //ESTA GRAVAÇÃO NÃO ESTÁ MAIS NESTA ROTINA. ESTÁ NA PRÓPRIA FrmFilial
        //MAS SERVE COMO EXEMPLO DE COMO FAZER ESTÁ TRANSFERÊNCIA DE DADOS
        //
        public List<Filial> listafiliais = new List<Filial>();

        int codigocliente = 0;
        int codigo1 = 0;
        string nome1 = "";
        string opcao = "";

        public enum opcao1
        {
            inclusao  = 0,
            consulta  = 1,
            alteracao = 2,
            exclusao  = 3
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            DesabilitaOpcoes();

            CarregarComboBox();

            LimparCampos();
        }

        private void CarregarComboBox()
        {
        }

        private void tsbPesquisar_Click(object sender, EventArgs e)
        {
            frmClientePesquisar frm = new frmClientePesquisar();

            frm.ShowDialog();

            //frm.IdCliente retorna o Id Cliente que foi selecionado na pesquisa
            codigocliente = frm.IdCliente;

            if (codigocliente != 0)
            {
                opcao = "alt";

                CarregaDados();

                tsbPesquisar.Enabled = false;
                tsbNovo.Enabled = false;
                tsbAtualizar.Enabled = true;
                tsbExcluir.Enabled = true;
                tsbCancelar.Enabled = true;

                btnPessoas.Enabled = true;

                txtCodigo.Enabled = false;

                //btnEnderecoEntrega.Enabled = true;
            }
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            opcao = "inc";

            cmbPessoa.SelectedIndex = 0;
            cmbUF.SelectedText = "SP";

            codigocliente = 0;

            LimparCampos();

            tsbPesquisar.Enabled = false;
            tsbNovo.Enabled = false;
            tsbCancelar.Enabled = true;
            tsbAtualizar.Enabled = true;

            btnPessoas.Enabled = false;

            //cmbEntSai.Items.Add("TESTE1");  //Adicona em tempo de execução
            //cmbEntSai.Items.Add("TESTE2");

            HabilitaCampos();

            //btnEnderecoEntrega.Enabled = false;

            //cmbEntSai.SelectedIndex = 0;
            //cmbCliFor.SelectedIndex = 0;
            //cmbGerarFaturamento.SelectedIndex = 1;
            //cmbCalculaICMS.SelectedIndex = 1;

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

            //if (codigocliente == 0)
            if (opcao == "inc")
            {
                DialogResult resposta = MessageBox.Show("Confirma Inclusão ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (resposta == DialogResult.No)
                {
                    tsbNovo_Click(sender, e);

                    return;
                }
            }

            //if (codigocliente != 0)
            if (opcao == "alt")
            {
                DialogResult resposta = MessageBox.Show("Confirma Alteração ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
               
                if (resposta == DialogResult.No)
                {
                    tsbNovo_Click(sender, e);

                    DesabilitaOpcoes();
                    DesabilitaCampos();

                    btnPessoas.Enabled = false;

                    tsbPesquisar.Enabled = true;
                    tsbNovo.Enabled = true;
                    tsbSair.Enabled = true;

                    return;
                }
            }

            //ClienteRepositorio banco = new ClienteRepositorio();

            Cliente cliente = new Cliente();

            if (cmbPessoa.SelectedIndex == 0)
            {
                cliente.Pessoa = "F";
                cliente.CPF = mskCPF_CNPJ.Text;
                cliente.RG = txtRG_IE.Text;
            }
            else
            {
                cliente.Pessoa = "J";
                cliente.CGC = mskCPF_CNPJ.Text;
                cliente.IE = txtRG_IE.Text;
            }
           
            cliente.Nome = txtNome.Text;
            cliente.NomeFantasia = txtNomeFantasia.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.CEP = mskCEP.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Email = txtEmail.Text;
            cliente.Estado = cmbUF.Text;
            cliente.NumeroEnd = 0;          
            cliente.Telefone = txtTelefone.Text;

            //cliente.EstadoFat = txt

            cliente.CEP = mskCEP.Text;

            // INCLUSÃO
            //if (codigocliente == 0)
            if (opcao == "inc")
            {
                try
                {
                    //banco.Salvar(produto);

                    //banco.Adicionar(cliente);
                    //banco.SalvarTodos();

                    MetodosCliente.Gravar(cliente);

                    txtCodigo.Text = cliente.Id.ToString();

                    //SAIU DAQUI E COLOQUEI NA NO BOTÃO frmSolicitante
                    //
                    //////////GRAVA OS SOLICITANTES NO BANCO
                    ////////foreach (var item in listasolicitantes)
                    ////////{
                    ////////    Solicitante solicitante = new Solicitante();

                    ////////    solicitante.Nome = item.Nome;
                    ////////    solicitante.AtivoInativo = item.AtivoInativo;
                    ////////    solicitante.ClienteId = cliente.Id;

                    ////////    MetodosSolicitante.Gravar(solicitante);
                    ////////}

                    MessageBox.Show("Inclusão OK", "Código: " + cliente.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //LimparCampos();

                    //tsbNovo_Click(sender, e);

                    codigo1 = cliente.Id;
                    nome1 = txtNome.Text;

                    DialogResult resposta = MessageBox.Show("Deseja Incluir Agora os Solicitantes ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (resposta == DialogResult.Yes)
                    {
                        btnPessoas_Click(sender, e);
                    }

                    //btnEnderecoEntrega.Enabled = true;

                    //frmClientes_Load(sender, e);

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
            //if (codigocliente != 0)
            if (opcao == "alt")
            {
                try
                {
                    cliente.Id = codigocliente;

                    //banco.Alterar(cliente);

                    //banco.Atualizar(cliente);
                    //banco.SalvarTodos();

                    MetodosCliente.Gravar(cliente);

                    //SAIU DAQUI E COLOQUEI NA NO BOTÃO frmSolicitante
                    //
                    //////////GRAVA OS SOLICITANTES NO BANCO
                    //foreach (var item in listasolicitantes)
                    //{
                    //    Solicitante solicitante = new Solicitante();

                    //    solicitante.Nome = item.Nome;
                    //    solicitante.AtivoInativo = item.AtivoInativo;
                    //    solicitante.ClienteId = cliente.Id;

                    //    MetodosSolicitante.Gravar(solicitante);
                    //}

                    MessageBox.Show("Alteração OK", "Código: " + cliente.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //tsbPesquisar.Enabled = true;
                    //tsbNovo.Enabled = true;
                    //tsbSair.Enabled = true;

                    //txtCodigo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na Alteração" + ex + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DesabilitaOpcoes();

                btnPessoas.Enabled = false;

                tsbPesquisar.Enabled = true;
                tsbNovo.Enabled = true;
                tsbSair.Enabled = true;
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

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
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
                if (opcao == "inc")  // ESTÁ FAZENDO UM NOVO CADASTRO E TECLA F10
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

            Cliente cliente = new Cliente();

            //MessageBox.Show(codigo.ToString());  // Mostra o código vindo do DataGridView somente para confirmação

            var arquivo = banco.ClienteCtx.First(c => c.Id == codigocliente);

            //ExibeDados();

            HabilitaCampos();

            if (arquivo.Pessoa == "F")
            {
                cmbPessoa.SelectedIndex = 0;

                txtRG_IE.Text = arquivo.RG;
                mskCPF_CNPJ.Text = arquivo.CPF;
            }
            else
            {
                cmbPessoa.SelectedIndex = 1;

                txtRG_IE.Text = arquivo.IE;
                mskCPF_CNPJ.Text = arquivo.CGC;
            }

            txtCodigo.Text = arquivo.Id.ToString();
            txtNome.Text = arquivo.Nome;
            txtComplemento.Text = arquivo.Complemento;
            txtEmail.Text = arquivo.Email;
            txtEndereco.Text = arquivo.Endereco;
            txtBairro.Text = arquivo.Bairro;
            txtCidade.Text = arquivo.Cidade;
            mskCEP.Text = arquivo.CEP;
            txtComplemento.Text = arquivo.Complemento;
            txtNomeFantasia.Text = arquivo.NomeFantasia;
            txtRG_IE.Text = arquivo.RG;
            txtTelefone.Text = arquivo.Telefone;
            txtRG_IE.Text = arquivo.IE;
            mskCEP.Text = arquivo.CEP;
            cmbUF.Text = arquivo.Estado;

            //codigo1 = Int32.Parse(txtCodigo.Text);
            codigocliente = Int32.Parse(txtCodigo.Text);
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

                if (c is MaskedTextBox)
                    (c as MaskedTextBox).Text = "";

                if (c is ComboBox)
                    (c as ComboBox).Text = "";
            }

            if (opcao == "alt" || opcao == "")
            {
                DesabilitaCampos();
            }

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
            if (opcao == "inc")
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

            if (opcao == "inc")
                txtCodigo.Enabled = false;
            else
                txtCodigo.Enabled = true;

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

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            ValidarDocumento();
        }

        private void ValidarDocumentoX()
        {
            string documento;

            documento = mskCPF_CNPJ.Text;
            documento = documento.Trim();

            if (documento == "")
            {
                return;
            }

            if (documento.Length == 11)
            {
                documento = "CPF";
            }
            else
            {
                if (mskCPF_CNPJ.TextLength == 14)
                {
                    documento = "CNPJ";
                }
                else
                {
                    MessageBox.Show("Documento Inválido","Aviso");

                    mskCPF_CNPJ.Select();

                    return;
                }
            }

            //Inibido temporariamente
            //Não consigo executar o método na pasta MetodosUteis

            if (documento == "CPF")
            {
                //if (METODOS_UTEIS.Validar_CPF_CNPJ.ValidarCPF(mskCPF_CNPJ.Text))
                //{
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("CPF Inválido","Aviso");

                //    mskCPF_CNPJ.Select();

                //    return;
                //}
            }

            //Inibido temporariamente
            //Não consigo executar o método na pasta MetodosUteis

            if (documento == "CNPJ")
            {
                //if (METODOS_UTEIS.Validar_CPF_CNPJ.ValidarCNPJ(mskCPF_CNPJ.Text))
                //{
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("CNPJ Inválido","Aviso");

                //    mskCPF_CNPJ.Select();

                //    return;
                //}
            }
        }

        private void ValidarDocumento()
        {
            string documento;

            documento = mskCPF_CNPJ.Text;
            documento = documento.Trim();

            if (mskCPF_CNPJ.Text.Length != 11 && mskCPF_CNPJ.Text.Length != 14)
            {
                    MessageBox.Show("Documento Inválido", "Aviso");
                    mskCPF_CNPJ.Select();
                    return;
            }

            if (cmbPessoa.SelectedIndex == 0) // PESSOA FISICA
            {
                //Inibido temporariamente
                //Não consigo executar o método na pasta MetodosUteis
                //if (METODOS_UTEIS.Validar_CPF_CNPJ.ValidarCPF(mskCPF_CNPJ.Text))
                //{
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("CPF Inválido", "Aviso");
                //    mskCPF_CNPJ.Select();
                //    return;
                //}
            }

            if (cmbPessoa.SelectedIndex == 1) // PESSOA JURIDICA
            {
                //Inibido temporariamente
                //Não consigo executar o método na pasta MetodosUteis
                //if (METODOS_UTEIS.Validar_CPF_CNPJ.ValidarCNPJ(mskCPF_CNPJ.Text))
                //{
                //    return;
                //}
                //else
                //{
                //    MessageBox.Show("CNPJ Inválido", "Aviso");

                //    mskCPF_CNPJ.Select();

                //    return;
                //}
            }
        }

        private void txtNomeFantasia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                txtNome.Focus();
            }
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
            codigocliente = Int32.Parse(txtCodigo.Text);

            frmSolicitante frm = new frmSolicitante(this, codigocliente, txtNome.Text);

            //frmSolicitante frm = new frmSolicitante(txtNome.Text);

            //frm.frm1 = this;

            frm.ShowDialog();

            //Uso para mostrar os solicitantes deste cliente (TESTE)
            //
            //foreach (var item in listasolicitantes)
            //{
            //    MessageBox.Show(item.Nome);
            //}
        }
    }
}
