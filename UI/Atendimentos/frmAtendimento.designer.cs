namespace UI
{
    partial class frmAtendimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProcurarPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDificuldadeAtendimento = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSolicitacao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radVenda = new System.Windows.Forms.RadioButton();
            this.txtTempoDeAtendimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radServico = new System.Windows.Forms.RadioButton();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcedimentoRealizado = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataAtendimento = new System.Windows.Forms.DateTimePicker();
            this.cmbAtendidoPor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisarAtendimentos = new System.Windows.Forms.Button();
            this.lblF9ProcuarPedidos = new System.Windows.Forms.Label();
            this.btnPesquisarClientes = new System.Windows.Forms.Button();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.txtAtendimento = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpDataConclusao = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtFalhaNossa = new System.Windows.Forms.Label();
            this.txtFalhaCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.btnProcurarPedido);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(913, 431);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 25);
            this.btnLimpar.TabIndex = 100011;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnProcurarPedido
            // 
            this.btnProcurarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarPedido.Location = new System.Drawing.Point(626, 431);
            this.btnProcurarPedido.Name = "btnProcurarPedido";
            this.btnProcurarPedido.Size = new System.Drawing.Size(232, 25);
            this.btnProcurarPedido.TabIndex = 100009;
            this.btnProcurarPedido.Text = "Pesquisar Atendimentos (F9)";
            this.btnProcurarPedido.UseVisualStyleBackColor = true;
            this.btnProcurarPedido.Click += new System.EventHandler(this.btnProcurarPedido_Click_2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(355, 431);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 25);
            this.btnCancelar.TabIndex = 100007;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(5, 431);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(188, 25);
            this.btnNovo.TabIndex = 100004;
            this.btnNovo.Text = "Novo Atendimento (F4)";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(517, 431);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 25);
            this.btnSair.TabIndex = 100008;
            this.btnSair.Text = "Sair (F10)";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(202, 431);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(144, 25);
            this.btnSalvar.TabIndex = 100006;
            this.btnSalvar.Text = "Salvar (F8)";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDificuldadeAtendimento);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSolicitacao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.radVenda);
            this.groupBox2.Controls.Add(this.txtTempoDeAtendimento);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radServico);
            this.groupBox2.Controls.Add(this.txtObservacao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProcedimentoRealizado);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1097, 293);
            this.groupBox2.TabIndex = 100005;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motivo Atendimento";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // cmbDificuldadeAtendimento
            // 
            this.cmbDificuldadeAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDificuldadeAtendimento.FormattingEnabled = true;
            this.cmbDificuldadeAtendimento.Location = new System.Drawing.Point(443, 29);
            this.cmbDificuldadeAtendimento.Name = "cmbDificuldadeAtendimento";
            this.cmbDificuldadeAtendimento.Size = new System.Drawing.Size(180, 24);
            this.cmbDificuldadeAtendimento.TabIndex = 100025;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(442, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 17);
            this.label14.TabIndex = 100024;
            this.label14.Text = "Dificuldade do Atendimento";
            // 
            // txtSolicitacao
            // 
            this.txtSolicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSolicitacao.Location = new System.Drawing.Point(11, 58);
            this.txtSolicitacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtSolicitacao.Name = "txtSolicitacao";
            this.txtSolicitacao.Size = new System.Drawing.Size(1077, 26);
            this.txtSolicitacao.TabIndex = 100019;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 100020;
            this.label11.Text = "Solicitação do Cliente";
            // 
            // radVenda
            // 
            this.radVenda.AutoSize = true;
            this.radVenda.Location = new System.Drawing.Point(247, 23);
            this.radVenda.Name = "radVenda";
            this.radVenda.Size = new System.Drawing.Size(67, 21);
            this.radVenda.TabIndex = 100004;
            this.radVenda.TabStop = true;
            this.radVenda.Text = "Venda";
            this.radVenda.UseVisualStyleBackColor = true;
            // 
            // txtTempoDeAtendimento
            // 
            this.txtTempoDeAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoDeAtendimento.Location = new System.Drawing.Point(635, 28);
            this.txtTempoDeAtendimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempoDeAtendimento.Name = "txtTempoDeAtendimento";
            this.txtTempoDeAtendimento.Size = new System.Drawing.Size(203, 26);
            this.txtTempoDeAtendimento.TabIndex = 2;
            this.txtTempoDeAtendimento.TabStop = false;
            this.txtTempoDeAtendimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 100016;
            this.label4.Text = "Tempo de Atendimento";
            // 
            // radServico
            // 
            this.radServico.AutoSize = true;
            this.radServico.Location = new System.Drawing.Point(331, 23);
            this.radServico.Name = "radServico";
            this.radServico.Size = new System.Drawing.Size(73, 21);
            this.radServico.TabIndex = 100005;
            this.radServico.TabStop = true;
            this.radServico.Text = "Serviço";
            this.radServico.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(12, 258);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1077, 26);
            this.txtObservacao.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 100018;
            this.label6.Text = "Observação";
            // 
            // txtProcedimentoRealizado
            // 
            this.txtProcedimentoRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedimentoRealizado.Location = new System.Drawing.Point(11, 112);
            this.txtProcedimentoRealizado.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcedimentoRealizado.Multiline = true;
            this.txtProcedimentoRealizado.Name = "txtProcedimentoRealizado";
            this.txtProcedimentoRealizado.Size = new System.Drawing.Size(1078, 120);
            this.txtProcedimentoRealizado.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(846, 28);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 26);
            this.txtValor.TabIndex = 3;
            this.txtValor.TabStop = false;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(873, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 100010;
            this.label9.Text = "$ Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 103;
            this.label1.Text = "Procedimento Realizado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataAtendimento);
            this.groupBox1.Controls.Add(this.cmbAtendidoPor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbSolicitante);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPesquisarAtendimentos);
            this.groupBox1.Controls.Add(this.lblF9ProcuarPedidos);
            this.groupBox1.Controls.Add(this.btnPesquisarClientes);
            this.groupBox1.Controls.Add(this.txtCodigoCli);
            this.groupBox1.Controls.Add(this.txtAtendimento);
            this.groupBox1.Controls.Add(this.txtNomeCli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1097, 125);
            this.groupBox1.TabIndex = 100010;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // dtpDataAtendimento
            // 
            this.dtpDataAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataAtendimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAtendimento.Location = new System.Drawing.Point(949, 89);
            this.dtpDataAtendimento.Name = "dtpDataAtendimento";
            this.dtpDataAtendimento.Size = new System.Drawing.Size(140, 29);
            this.dtpDataAtendimento.TabIndex = 100021;
            // 
            // cmbAtendidoPor
            // 
            this.cmbAtendidoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtendidoPor.FormattingEnabled = true;
            this.cmbAtendidoPor.Location = new System.Drawing.Point(352, 92);
            this.cmbAtendidoPor.Name = "cmbAtendidoPor";
            this.cmbAtendidoPor.Size = new System.Drawing.Size(293, 24);
            this.cmbAtendidoPor.TabIndex = 100020;
            this.cmbAtendidoPor.Leave += new System.EventHandler(this.cmbAtendidoPor_Leave_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 100019;
            this.label10.Text = "Atendido Por";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(900, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 100018;
            this.label7.Text = "Data: ";
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(11, 92);
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.Size = new System.Drawing.Size(329, 24);
            this.cmbSolicitante.TabIndex = 100017;
            this.cmbSolicitante.Leave += new System.EventHandler(this.cmbSolicitante_Leave_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 100014;
            this.label5.Text = "Nome Solicitante";
            // 
            // btnPesquisarAtendimentos
            // 
            this.btnPesquisarAtendimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAtendimentos.Location = new System.Drawing.Point(1058, 23);
            this.btnPesquisarAtendimentos.Name = "btnPesquisarAtendimentos";
            this.btnPesquisarAtendimentos.Size = new System.Drawing.Size(32, 25);
            this.btnPesquisarAtendimentos.TabIndex = 100012;
            this.btnPesquisarAtendimentos.TabStop = false;
            this.btnPesquisarAtendimentos.Text = "F9";
            this.btnPesquisarAtendimentos.UseVisualStyleBackColor = true;
            this.btnPesquisarAtendimentos.Click += new System.EventHandler(this.btnPesquisarAtendimentos_Click);
            // 
            // lblF9ProcuarPedidos
            // 
            this.lblF9ProcuarPedidos.AutoSize = true;
            this.lblF9ProcuarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF9ProcuarPedidos.ForeColor = System.Drawing.Color.Blue;
            this.lblF9ProcuarPedidos.Location = new System.Drawing.Point(823, 60);
            this.lblF9ProcuarPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblF9ProcuarPedidos.Name = "lblF9ProcuarPedidos";
            this.lblF9ProcuarPedidos.Size = new System.Drawing.Size(271, 16);
            this.lblF9ProcuarPedidos.TabIndex = 100011;
            this.lblF9ProcuarPedidos.Text = "Teclar F9 para Procurar Atendimentos";
            // 
            // btnPesquisarClientes
            // 
            this.btnPesquisarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarClientes.Location = new System.Drawing.Point(87, 44);
            this.btnPesquisarClientes.Name = "btnPesquisarClientes";
            this.btnPesquisarClientes.Size = new System.Drawing.Size(32, 25);
            this.btnPesquisarClientes.TabIndex = 100011;
            this.btnPesquisarClientes.TabStop = false;
            this.btnPesquisarClientes.Text = "F9";
            this.btnPesquisarClientes.UseVisualStyleBackColor = true;
            this.btnPesquisarClientes.Click += new System.EventHandler(this.btnPesquisarClientes_Click_1);
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCli.Location = new System.Drawing.Point(11, 44);
            this.txtCodigoCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(68, 26);
            this.txtCodigoCli.TabIndex = 0;
            this.txtCodigoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCli_KeyDown_1);
            this.txtCodigoCli.Leave += new System.EventHandler(this.txtCodigoCli_Leave_1);
            // 
            // txtAtendimento
            // 
            this.txtAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtendimento.Location = new System.Drawing.Point(949, 13);
            this.txtAtendimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAtendimento.Name = "txtAtendimento";
            this.txtAtendimento.Size = new System.Drawing.Size(102, 35);
            this.txtAtendimento.TabIndex = 2;
            this.txtAtendimento.TabStop = false;
            this.txtAtendimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(128, 43);
            this.txtNomeCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(662, 26);
            this.txtNomeCli.TabIndex = 1;
            this.txtNomeCli.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Nome/Razão Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(859, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 105;
            this.label8.Text = "Chamado Nº";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpDataConclusao);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.txtFalhaNossa);
            this.tabPage2.Controls.Add(this.txtFalhaCliente);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outros Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpDataConclusao
            // 
            this.dtpDataConclusao.CustomFormat = " ";
            this.dtpDataConclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConclusao.Location = new System.Drawing.Point(62, 154);
            this.dtpDataConclusao.Name = "dtpDataConclusao";
            this.dtpDataConclusao.Size = new System.Drawing.Size(140, 29);
            this.dtpDataConclusao.TabIndex = 100026;
            this.dtpDataConclusao.ValueChanged += new System.EventHandler(this.dtpDataConclusao_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 160);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 100025;
            this.label13.Text = "Data: ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(16, 101);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1077, 26);
            this.textBox3.TabIndex = 100023;
            // 
            // txtFalhaNossa
            // 
            this.txtFalhaNossa.AutoSize = true;
            this.txtFalhaNossa.Location = new System.Drawing.Point(13, 80);
            this.txtFalhaNossa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFalhaNossa.Name = "txtFalhaNossa";
            this.txtFalhaNossa.Size = new System.Drawing.Size(101, 13);
            this.txtFalhaNossa.TabIndex = 100024;
            this.txtFalhaNossa.Text = "Houve Falha Nossa";
            // 
            // txtFalhaCliente
            // 
            this.txtFalhaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFalhaCliente.Location = new System.Drawing.Point(16, 42);
            this.txtFalhaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtFalhaCliente.Name = "txtFalhaCliente";
            this.txtFalhaCliente.Size = new System.Drawing.Size(1077, 26);
            this.txtFalhaCliente.TabIndex = 100021;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 100022;
            this.label12.Text = "Houve Falha do CLiente";
            // 
            // frmAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 517);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "frmAtendimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimentos";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPedido_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProcurarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSolicitacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radVenda;
        private System.Windows.Forms.RadioButton radServico;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcedimentoRealizado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataAtendimento;
        private System.Windows.Forms.ComboBox cmbAtendidoPor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.TextBox txtTempoDeAtendimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisarAtendimentos;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblF9ProcuarPedidos;
        private System.Windows.Forms.Button btnPesquisarClientes;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.TextBox txtAtendimento;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataConclusao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtFalhaNossa;
        private System.Windows.Forms.TextBox txtFalhaCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDificuldadeAtendimento;
        private System.Windows.Forms.Label label14;
    }
}