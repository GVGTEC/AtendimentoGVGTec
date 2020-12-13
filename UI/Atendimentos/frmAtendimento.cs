using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL.MODEL;
using DAL;
using DAL.Contexto;
using DAL.Repositorio;
using System.IO;
using BLL;
using System.Collections;

namespace UI
{
    public partial class frmAtendimento : Form
    {
        bool bEsc;

        public int IdPedido { get; set; }

        int codigopedido = 0;
        int codigocliente = 0;
        int codigoproduto = 0;
        int codigoatendente = 0;
        int codigosolicitante = 0;
        int FormaPagamento = 0;

        string acao = "";

        //decimal precototal = 0;
        decimal valortotal = 0;

        static string arquivovendasini = @"C:\SAT\VENDA.INI*";
        static string arquivoentrada = @"C:\SAT\ENT.TXT";
        static string linhavendasini;
        static string achou;
        static string OpcaoImpressao;
        static string respostacancela = "";

        //static int codigoproduto;

        static string descricaoproduto;
        static int quantidade;
        static decimal precuonitario;
        static decimal precototal;

        List<Atendente> listaatendentes = new List<Atendente>();
        List<Solicitante> listasolicitantes = new List<Solicitante>();

        public enum opcaoEnum

        {
            inclusao = 1,
            alteracao = 2
        }

        //static string opcao;

        //public enum opcao
        //{
        //    novo = 1,
        //    imprimircupom = 2,
        //    procurarpedido = 3,          
        //}

        //opcao = 01 --> 
        //opcao = 02 --> 
        //opcao = 03 --> Procurar pedidos

        static int opcao = 0;

        public frmAtendimento()
        {
            InitializeComponent();

            Inicializacao();
        }

        private void Inicializacao()
        {
            if (opcao != 3)
            {
                btnCancelar.Enabled = false;
            }

            if (opcao == 3)
            {
                //btnNovo.Enabled = true;
                //btnProcurarPedido.Enabled = true;
                //MessageBox.Show("OPCAO  = 3");
            }

            btnSalvar.Enabled = false;

            //DesabilitaCampos();

            txtCodigoCli.Enabled = false;
            txtNomeCli.Enabled = false;
            cmbSolicitante.Enabled = false;
            cmbDificuldadeAtendimento.Enabled = false;
            cmbDificuldadeAtendimento.Enabled = false;
            txtProcedimentoRealizado.Enabled = false;
            txtObservacao.Enabled = false;
            txtValor.Enabled = false;

            btnPesquisarClientes.Enabled = false;

            txtAtendimento.Enabled = false;
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            //dtpDataAtendimento.Format = DateTimePickerFormat.Custom;

            opcao = 0;

            //Inicializacao();

            DesabilitaControles(this);
            DesabilitaCampos(this);
            LimparCamposTela();
            LimparDadosGrupo1();

            //Utilidades.zeraFormulario();

            //txtCodigoCli.Enabled = false;
            //txtNomeCli.Enabled = false;
            //txtCodigoPrd.Enabled = false;
            //txtDescricaoPrd.Enabled = false;
            //txtPrecoTotal.Enabled = false;
            //txtPrecoUnitario.Enabled = false;
            //txtQuantidadePrd.Enabled = false;

            btnNovo.Enabled = true;
            btnProcurarPedido.Enabled = true;
            btnSair.Enabled = true;

            lblF9ProcuarPedidos.Enabled = false;

            PreencheComboAtendente();
            PreencheComboDificuldadeAtendimento();
        }

        private void frmPedido_KeyDown(object sender, KeyEventArgs e)
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
                btnSair_Click_1(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                btnNovo_Click_1(sender, e);
            }

            if (e.KeyCode == Keys.F9)
            {
                btnProcurarPedido_Click_1(sender, e);
            }

            if (btnSalvar.Enabled == true)
            {
                if (e.KeyCode == Keys.F8)
                {
                    btnSalvar_Click_1(sender, e);
                }
            }

            //if (e.KeyCode == Keys.Escape)
            //{
            //    btnCancelar_Click(sender, e);
            //}
        }

        //private void CarregaDadosCliente()
        //{
        //    BancoContexto banco = new BancoContexto();

        //    Cliente cliente = new Cliente();

        //    //MessageBox.Show(codigo.ToString());  // Mostra o código vindo do DataGridView somente para confirmação

        //    if (codigocliente == 0)
        //    {
        //        txtCodigoCli.Select();

        //        return;
        //    }

        //    var arquivo = banco.ClienteCtx.First(p => p.Id == codigocliente);

        //    //ExibeDados();

        //    txtCodigoCli.Text = arquivo.Id.ToString();
        //    txtNomeCli.Text = arquivo.Nome;

        //    var retorno = MetodosSolicitante.LeituraSolicitantePorCliente(codigocliente);

        //    cmbSolicitante.DataSource = retorno;
        //}

        private void txtPrecoUnitario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bEsc = true;

                txtProcedimentoRealizado.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (txtValor.Text == "0,00" || string.IsNullOrEmpty(txtValor.Text))
                {
                    txtValor.Select();

                    return;
                }
            }
        }

        private void txtPrecoUnitario_Leave(object sender, EventArgs e)
        {
        }

        private static void GravaArquivoENT()
        {
            using (StreamWriter sw = new StreamWriter(arquivoentrada, true))
            {
                sw.WriteLine(linhavendasini);

                sw.Close();
            }
        }

        public void LimparCamposTela()
        {
            this.LimparCamposTela(this);
        }

        private void LimparCamposTela(Control parent)
        {

            foreach (Control c in parent.Controls)
            {
                if (c is TextBox)
                        (c as TextBox).Text = "";
                if (c is ComboBox)
                        (c as ComboBox).Text = "";
                if (c is MaskedTextBox)
                        (c as MaskedTextBox).Text = "";
                if (c is RadioButton)
                        (c as RadioButton).Checked = false;

            if (c is CheckedListBox)
                {
                    foreach (ListControl item in (c as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }

                if (c is ListView)(c as ListView).Items.Clear();

                // varre os filhos...
                LimparCamposTela(c);
            }

            dtpDataAtendimento.Text = "";
        }

        //Método para limpar caixas de texto
        public void LimparTxt(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
                if (ctl is MaskedTextBox) ctl.Text = "";
            }

            //pbxFotoPes.Image = null;
            //tbxCelularPes.Enabled = true;
        }

        private void txtPedido_Leave(object sender, EventArgs e)
        {
            if (txtAtendimento.Text != string.Empty)
            {
                codigopedido = Int32.Parse(txtAtendimento.Text);

                CarregaDadosPedido();
            }
        }

        private void txtPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                //btnPesquisarPedidos_Click_1(sender, e); RESTAURAR ESTA LINHA COM UM BACKUP



                //frmAtendimentoPesquisar frm = new frmAtendimentoPesquisar();

                //frm.WindowState = System.Windows.Forms.FormWindowState.Normal;

                //frm.ShowDialog();

                //codigopedido = frm.IdPedido;

                //CarregaDadosPedido();
            }
        }

        private void CarregaDadosPedido()
        {
            var atendimento = MetodosAtendimento.LeituraAtendimento(codigopedido);

            txtAtendimento.Text = atendimento.Id.ToString();
            txtCodigoCli.Text = atendimento.ClienteId.ToString();
            txtNomeCli.Text = atendimento.ClienteX.Nome;
            txtSolicitacao.Text = atendimento.SolicitacaoCliente;
            txtProcedimentoRealizado.Text = atendimento.ProcedimentoRealizado;
            cmbSolicitante.Text = atendimento.NomeSolicitante;
            cmbDificuldadeAtendimento.Text = atendimento.NivelDificuldadeAtendimento.ToString();
            cmbAtendidoPor.Text = atendimento.AtendenteX.Nome;
            txtObservacao.Text = atendimento.Observacao;
            txtTempoDeAtendimento.Text = atendimento.TempoDeAtendimento.ToString();
            txtValor.Text = atendimento.ValorServico.ToString();

            dtpDataAtendimento.Text = atendimento.DataAtendimento.ToString();

            HabilitaCampos(this);

            btnSalvar.Enabled = true;
        }

        private void txtCodigoCli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                frmClientePesquisar frm = new frmClientePesquisar();

                frm.WindowState = System.Windows.Forms.FormWindowState.Normal;

                frm.ShowDialog();

                codigocliente = frm.IdCliente;

                LeituraCliente();

                if (codigocliente != 0)
                {
                    btnPesquisarClientes.Enabled = false;
                }
            }
        }

        private void txtCodigoCli_TextChanged(object sender, EventArgs e)
        {
        }

        // Após digitar o codigo do cliente executa este evento
        private void txtCodigoCli_Leave_1(object sender, EventArgs e)
        {
            if (txtCodigoCli.Text != string.Empty)
            {
                codigocliente = Int32.Parse(txtCodigoCli.Text);

                if (codigocliente == 0)
                {
                    txtCodigoCli.Select();

                    return;
                }

                LeituraCliente();

                if (codigocliente == 0)
                {
                    txtCodigoCli.Focus();

                    return;
                }

                //btnCancelar.Enabled = true;

                cmbSolicitante.Focus();
            }
        }

        private void LeituraCliente()
        {
            //BancoContexto banco = new BancoContexto();

            Cliente cliente = new Cliente();

            //MessageBox.Show(codigo.ToString());  // Mostra o código vindo do DataGridView somente para confirmação

            try
            {
                var arquivo = MetodosCliente.LeituraCliente(codigocliente);

                //var arquivo = banco.ClienteCtx.First(p => p.Id == codigocliente);

                txtCodigoCli.Text = arquivo.Id.ToString();
                txtNomeCli.Text = arquivo.Nome;

                //var retorno = MetodosSolicitante.LeituraSolicitantePorCliente(codigocliente);

                listasolicitantes = MetodosSolicitante.LeituraSolicitantePorCliente(codigocliente);

                cmbSolicitante.Items.Clear();

                foreach (var item in listasolicitantes)
                {
                    cmbSolicitante.Items.Add(item.Nome);
                }

                //cmbSolicitante.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente Inexistente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoCli.Text = string.Empty;

                codigocliente = 0;

                //txtCodigoCli.Focus();

                //return;
            }

            //**********************************************************

            //////////if (codigocliente != 0)
            //////////{
            //////////    btnPesquisarClientes.Enabled = false;
            //////////}
        }

        private void PreencheComboAtendente()
        {
            try
            {
                //var todosatendentes = MetodosAtendente.LeituraAtendenteTodos();

                listaatendentes = MetodosAtendente.LeituraAtendenteTodos();

                cmbAtendidoPor.Items.Clear();

                //https://social.msdn.microsoft.com/Forums/pt-BR/4626ffb0-9ed9-4867-969d-d1c14aaf2d4b/combobox-recuperar-id-para-utilizar-no-insert?forum=vscsharppt

                foreach (var item in listaatendentes)
                {
                    cmbAtendidoPor.Items.Add(item.Nome);
                }

                //cmbAtendidoPor.DataSource = retorno.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum Atendente Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PreencheComboDificuldadeAtendimento()
        {
           cmbDificuldadeAtendimento.Items.Clear();

           //cmbDificuldadeAtendimento.Items.Add(EnumNivelDificuldadeAtendimento.Nenhum);
           cmbDificuldadeAtendimento.Items.Add(EnumNivelDificuldadeAtendimento.Baixo);
           cmbDificuldadeAtendimento.Items.Add(EnumNivelDificuldadeAtendimento.Medio);
           cmbDificuldadeAtendimento.Items.Add(EnumNivelDificuldadeAtendimento.Alto);
        }

        public void HabilitaTudo()
        {
            HabilitaCampos(this);
            HabilitaOpcoes(this);
        }

        public void DesabilitaTudo()
        {
            DesabilitaCampos(this);
            DesabilitaControles(this);
        }

        private void HabilitaCampos(Control pai)
        {
            foreach (Control ctl in pai.Controls)
                if (ctl.Controls.Count > 0)
                {
                    HabilitaCampos(ctl);
                }
                else
                {
                    if (ctl is TextBox)
                    {
                        ((TextBox)ctl).Enabled = true;
                    }

                    if (ctl is ComboBox)
                    {
                        ((ComboBox)ctl).Enabled = true;
                    }

                    if (ctl is MaskedTextBox)
                    {
                        ((MaskedTextBox)ctl).Enabled = true;
                    }
                }
        }

        public void HabilitaCamposOLD()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Enabled = true;

                if (c is ComboBox)
                    (c as ComboBox).Enabled = true;

                if (c is MaskedTextBox)
                    (c as MaskedTextBox).Enabled = true;

                if (c is Button)
                    (c as Button).Enabled = true;
            }
        }

        private void DesabilitaCampos(Control pai)
        {
            foreach (Control ctl in pai.Controls)
                if (ctl.Controls.Count > 0)
                {
                    DesabilitaCampos(ctl);
                }
                else
                {
                    if (ctl is TextBox)
                    {
                        ((TextBox)ctl).Enabled = false;
                    }

                    if (ctl is ComboBox)
                    {
                        ((ComboBox)ctl).Enabled = false;
                    }

                    if (ctl is MaskedTextBox)
                    {
                        ((MaskedTextBox)ctl).Enabled = false;
                    }
                }
        }

        public void DesabilitaCamposOLD()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Enabled = false;

                if (c is ComboBox)
                    (c as ComboBox).Enabled = false;

                if (c is MaskedTextBox)
                    (c as MaskedTextBox).Enabled = false;

                //if (c is Button)
                //    (c as Button).Enabled = false;
            }

            //txtCodigoCli.Enabled = true;
            //txtCodigoPrd.Enabled = true;
        }

        private void HabilitaOpcoes(Control pai)
        {
            foreach (Control ctl in pai.Controls)
                if (ctl.Controls.Count > 0)
                {
                    HabilitaOpcoes(ctl);
                }
                else
                {
                    if (ctl is Button)
                    {
                        ((Button)ctl).Enabled = false;
                    }
                }
        }

        public void HabilitaOpcoesOLD()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    (c as Button).Enabled = true;
            }
        }

        private void DesabilitaControles(Control pai)
        {
            foreach (Control ctl in pai.Controls)
                if (ctl.Controls.Count > 0)
                {
                    DesabilitaControles(ctl);
                }
                else
                {
                    if (ctl is Button)
                    {
                        ((Button)ctl).Enabled = false;
                    }
                }

            //btnCancelarCupom.Enabled = true;
        }

        public void DesabilitaControlesOLD()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    (c as Button).Enabled = false;
            }
        }

        // DEVIA LIMPAR EM OUTRO METODO MAS NÃO LIMPA
        public void LimparDadosGrupo1()
        {
            txtCodigoCli.Text = "";
            txtNomeCli.Text = "";
            txtAtendimento.Text = "";
        }

        private void btnProcurarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                //REPETINDO CÓDIGO DO CLICK DO BOTÃO 

                opcao = 3;

                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;
                btnProcurarPedido.Enabled = false;

                txtAtendimento.Enabled = true;

                txtAtendimento.Focus();

                lblF9ProcuarPedidos.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
        }

        //Bloqueia o TextoBox para aceitar somente os caracteres desejados
        //https://social.msdn.microsoft.com/Forums/pt-BR/4d2b4ab2-3d86-4cd2-9d77-4669229c78bc/bloquear-caracteres-especiais-no-textbox?forum=vscsharppt

        private void txtCodigoCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtCodigoPrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar <= '\b'))  // \b = Backspace
                e.Handled = true;
        }

        private void txtQuantidadePrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar <= '\b'))
                e.Handled = true;
        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar <= '\b') && !(e.KeyChar <= ','))
                e.Handled = true;
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcurarPedido_Click_1(object sender, EventArgs e)
        {
            txtAtendimento.Enabled = true;
            btnPesquisarAtendimentos.Enabled = true;

            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;

            txtAtendimento.Focus();
        }

        //private void txtQuantidadePrd_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode==Keys.Escape)
        //    {
        //        txtCodigoPrd.Focus();
        //    }
        //}

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
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposTela();
        }

        private void cmbAtendidoPor_Leave_1(object sender, EventArgs e)
        {
            //PRECISO PEGAR O ID DO ATENDENTE QUE FOI SELECIONADO
            //ESTA ROTINA PEGA O INDICE DO ELEMENTO SELECIONADO NO COMBOBOX
            //E LOCALIZA NA LISTA O OBJETO DESTE INDICE
            //E PEGA O ID DO ATENDENTE QUE ESTÁ NESTE OBJETO

            int posicao = cmbAtendidoPor.SelectedIndex;

            //codigoatendente = int.Parse(listaatendentes[posicao].ToString());
            if (posicao != -1)
            {
                Atendente atendente = listaatendentes[posicao];

                codigoatendente = atendente.Id;
            }
        }

        private void cmbSolicitante_Leave_1(object sender, EventArgs e)
        {
            //PRECISO PEGAR O ID DO SOLICITANTE QUE FOI SELECIONADO
            //ESTA ROTINA PEGA O INDICE DO ELEMENTO SELECIONADO NO COMBOBOX
            //E LOCALIZA NA LISTA O OBJETO DESTE INDICE
            //E PEGA O ID DO SOLICITANTE QUE ESTÁ NESTE OBJETO

            int posicao = cmbSolicitante.SelectedIndex;

            //codigoatendente = int.Parse(listaatendentes[posicao].ToString());

            if (posicao != -1)
            {
                Solicitante solicitante = listasolicitantes[posicao];

                codigosolicitante = solicitante.Id;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            //codigocliente = 1; LeituraCliente();

            opcao = 1;

            LimparCamposTela();

            //radServico.Checked = true;

            txtCodigoCli.Enabled = true;
            txtNomeCli.Enabled = true;
            cmbSolicitante.Enabled = true;
            cmbDificuldadeAtendimento.Enabled = true;
            cmbAtendidoPor.Enabled = true;
            txtSolicitacao.Enabled = true;
            txtProcedimentoRealizado.Enabled = true;
            txtObservacao.Enabled = true;
            txtTempoDeAtendimento.Enabled = true;
            txtValor.Enabled = true;

            cmbDificuldadeAtendimento.SelectedIndex = 0;

            btnPesquisarClientes.Enabled = true;
            btnProcurarPedido.Enabled = false;

            txtCodigoCli.Select();

            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;

            btnLimpar.Enabled = true;

            //PEGA SOMENTE A DATA ATUAL
            //dtpDataAtendimento.Text = DateTime.Today.ToShortDateString();

            //PEGA A DATA E HORA ATUAL 
            dtpDataAtendimento.Text = DateTime.Now.ToString();

            //INICIALIZA A DATA DE CONCLUSÃO EM BRANCO
            //ESTA FORMA EXIGE QUE QUANDO INFORMADA UMA DATA SEJA FEITA UMA MODIFICAÇÃO
            //NO EVENTO (dateTimePicker1_ValueChanged) DO CAMPO
            dtpDataConclusao.Format = DateTimePickerFormat.Custom;
            dtpDataConclusao.CustomFormat = " ";

            //txtValor.Text = "0;
        }

        private void btnProcurarPedido_Click_2(object sender, EventArgs e)
        {
            opcao = 3;

            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            btnProcurarPedido.Enabled = false;
            btnPesquisarAtendimentos.Enabled = true;

            txtAtendimento.Enabled = true;

            txtAtendimento.Focus();

            lblF9ProcuarPedidos.Enabled = true;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (cmbSolicitante.Text == "")
            {
                MessageBox.Show("Informar o Solicitante", "Aviso");

                cmbSolicitante.Focus();

                return;
            }

            if (cmbAtendidoPor.Text == "")
            {
                MessageBox.Show("Informar o Atendente", "Aviso");

                cmbAtendidoPor.Focus();

                return;
            }

            if (radServico.Checked == false && radVenda.Checked == false)
            {
                MessageBox.Show("Informar se é Venda ou Serviço", "Aviso");

                return;
            }

            Atendimento atendimento = new Atendimento();

            //atendimento.Id = Int32.Parse(txtAtendimento.Text);
            atendimento.SolicitacaoCliente = txtSolicitacao.Text;
            atendimento.ProcedimentoRealizado = txtProcedimentoRealizado.Text;
            atendimento.NomeSolicitante = cmbSolicitante.SelectedItem.ToString();

            //RETIRADO MOMENTANEAMENTE ATÉ RESOLVER COMO USAR ESTE CAMPO
            ////////////atendimento.NivelDificuldadeAtendimento = cmbDificuldadeAtendimento;

            //SELECTEDITEM TRAZ A PARTE DE TEXTO
            //atendimento.AtendenteId = int.Parse(cmbAtendidoPor.SelectedItem.ToString());

            //SELECTEDINDEX TRAZ A POSICAO NA LISTA DO COMBO
            //atendimento.AtendenteId = int.Parse(cmbAtendidoPor.SelectedIndex.ToString());

            atendimento.SolicitanteId = codigosolicitante;
            atendimento.AtendenteId = codigoatendente;

            if (radServico.Checked == true)
            {
                atendimento.VendaServico = "S";
            }

            if (radVenda.Checked == true)
            {
                atendimento.VendaServico = "V";
            }

            if (txtValor.Text == "")
            {
                atendimento.ValorServico = 0;
            }
            else
            {
                atendimento.ValorServico = double.Parse(txtValor.Text);
            }

            atendimento.CobrarServico = "S";
            atendimento.ClienteId = int.Parse(txtCodigoCli.Text);
            atendimento.Observacao = txtObservacao.Text;

            if (txtTempoDeAtendimento.Text == "")
            {
                atendimento.TempoDeAtendimento = "";
            }
            else
            {
                atendimento.TempoDeAtendimento = txtTempoDeAtendimento.Text;
            }

            //atendimento.Data = DateTime.Today;

            atendimento.DataAtendimento = DateTime.Parse(dtpDataAtendimento.Text);
            atendimento.DataLancamentoSistema = DateTime.Now;

            //MetodosAtendimento.Gravar(atendimento);

            // INCLUSÃO
            if (codigopedido == 0)
            {
                try
                {
                    MetodosAtendimento.Gravar(atendimento);

                    txtAtendimento.Text = atendimento.Id.ToString();

                    MessageBox.Show("Inclusão OK", "Atendimento: " + atendimento.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //https://www.caelum.com.br/apostila-csharp-orientacao-objetos/excecoes/#16-4-exercicios

                    //MessageBox.Show("Erro na Inclusão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Erro na Inclusão" + ex + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //btnEnderecoEntrega.Enabled = true;

                //LimparCamposTela();

                ////INICIALIZA AS FUNÇÕES DO FORMULÁRIO INCLUSIVE LIMPAR OS CONTROLES
                frmPedido_Load(sender, e);

                //LimparCampos();
            }

            // ALTERAÇÃO
            if (codigopedido != 0)
            {
                try
                {
                    atendimento.Id = codigopedido;

                    MetodosAtendimento.Gravar(atendimento);

                    MessageBox.Show("Alteração OK", "Atendimento: " + atendimento.Id, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCamposTela();

                    DesabilitaCampos(this);

                    txtAtendimento.Enabled = true;
                    txtAtendimento.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na Alteração" + ex + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (opcao == 1)
            {
                if (txtProcedimentoRealizado.Text != "")
                {
                    // Se ACAO = "SALVO" significa que o registro acabou de ser gravado e se o usuario
                    // clicou em CANCELAR ele não quer somente retornar ao inicio.
                    // Portanto não é necessário perguntar se CONFIRMA O CANCELAMENTO

                    if (acao == "SALVO")
                    {
                        respostacancela = "Yes";
                    }
                    else
                    {
                        DialogResult resposta = MessageBox.Show("Cancelar o Atendimento ?", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        respostacancela = resposta.ToString();
                    }

                    acao = "";

                    if (respostacancela == "Yes")
                    {
                        LimparTxt(this);
                        LimparDadosGrupo1();

                        //LimparCamposTela();

                        cmbSolicitante.Enabled = false;
                        cmbDificuldadeAtendimento.Enabled = false;
                        txtSolicitacao.Enabled = false;
                        txtProcedimentoRealizado.Enabled = false;

                        btnCancelar.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnNovo.Enabled = true;
                        btnProcurarPedido.Enabled = true;

                        frmPedido_Load(sender, e);

                        return;
                    }
                }
                else
                {
                    frmPedido_Load(sender, e);
                }
            }
            else
            {
                if (opcao == 3)
                {
                    //btnCancelar.Enabled = false;
                    //btnSalvar.Enabled = false;
                    //btnNovo.Enabled = true;
                    //btnProcurarPedido.Enabled = true;

                    //Inicializacao();

                    frmPedido_Load(sender, e);

                    // Este campo não está sendo desabilitado automaticamente quando executado frmPedido_Load(sender, e);
                    // então estou desabilitando agora
                    txtAtendimento.Enabled = false;

                    return;
                }
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // TESTA SE O DATAGRID ESTÁ VAZIO
            //if (dgvItens.Rows.Count == 0)
            if (txtCodigoCli.Text == string.Empty)
            {
                Close();

                return;
            }

            //if (dgvItens.Rows.Count != 0)

            if (txtCodigoCli.Text != string.Empty)
            {
                if (opcao == 1)
                {
                    DialogResult resposta = MessageBox.Show("Cancelar o Atendimento ?", "Cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resposta == DialogResult.Yes)
                    {
                        LimparTxt(this);

                        btnCancelar.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnNovo.Enabled = true;

                        //return;

                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPesquisarAtendimentos_Click(object sender, EventArgs e)
        {
            frmAtendimentoPesquisar frm = new frmAtendimentoPesquisar();

            frm.ShowDialog();

            codigopedido = frm.IdPedido;

            if (codigopedido != 0)
            {
                var atendimento = MetodosAtendimento.LeituraAtendimento(codigopedido);

                CarregaDadosPedido();
            }
        }

        private void btnPesquisarClientes_Click_1(object sender, EventArgs e)
        {
            frmClientePesquisar frm = new frmClientePesquisar();

            frm.ShowDialog();

            codigocliente = frm.IdCliente;

            LeituraCliente();

            if (codigocliente != 0)
            {
                btnPesquisarClientes.Enabled = false;
            }
            else
            {
                txtCodigoCli.Focus();
            }
        }

        private void dtpDataConclusao_ValueChanged(object sender, EventArgs e)
        {
            //dtpDataConclusao.Format = DateTimePickerFormat.Custom;
            //dtpDataConclusao.CustomFormat = "yyyy-MM-dd";
        }

        private void txtCodigoCli_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnPesquisarClientes_Click_1(sender, e);
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        //    DesabilitaCampos();

        //    //txtCodigo.Enabled = false;

        //    //txtNome.Focus();

        //    //https://www.youtube.com/watch?v=SWKPJ9lix54   aos 7mm:22s
        //    //DateTime hoje = DataTime.Today;// Today - somente a data de hoje, sem horário
        //    //txtDataEmissao.Text = hoje.ToString("dd/MM/yyyy");
        //}

        //public void DesabilitaCampos()
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        if (c is TextBox)
        //            (c as TextBox).Enabled = false;

        //        if (c is ComboBox)
        //            (c as ComboBox).Enabled = false;

        //        if (c is MaskedTextBox)
        //            (c as MaskedTextBox).Enabled = false;
        //    }
        //}

        //public void HabilitaCampos()
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        if (c is TextBox)
        //            (c as TextBox).Enabled = true;

        //        if (c is ComboBox)
        //            (c as ComboBox).Enabled = true;

        //        if (c is MaskedTextBox)
        //            (c as MaskedTextBox).Enabled = true;
        //    }
        //}

        //public void HabilitaOpcoes()
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        if (c is Button)
        //            (c as Button).Enabled = true;
        //    }
        //}

        //public void DesabilitaOpcoes()
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        if (c is Button)
        //            (c as Button).Enabled = false;
        //    }
        //}
    }
}
