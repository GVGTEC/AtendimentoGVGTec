namespace UI
{
    partial class frmCobranca
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisarClientes = new System.Windows.Forms.Button();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerarLoteCobranca = new System.Windows.Forms.Button();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(851, 92);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 25);
            this.btnPesquisar.TabIndex = 100024;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 100023;
            this.label1.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 100022;
            this.label2.Text = "Código do Cliente";
            // 
            // btnPesquisarClientes
            // 
            this.btnPesquisarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarClientes.Location = new System.Drawing.Point(104, 92);
            this.btnPesquisarClientes.Name = "btnPesquisarClientes";
            this.btnPesquisarClientes.Size = new System.Drawing.Size(32, 25);
            this.btnPesquisarClientes.TabIndex = 100021;
            this.btnPesquisarClientes.TabStop = false;
            this.btnPesquisarClientes.Text = "F9";
            this.btnPesquisarClientes.UseVisualStyleBackColor = true;
            this.btnPesquisarClientes.Click += new System.EventHandler(this.btnPesquisarClientes_Click_1);
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCli.Location = new System.Drawing.Point(7, 91);
            this.txtCodigoCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(90, 26);
            this.txtCodigoCli.TabIndex = 2;
            this.txtCodigoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoCli.Leave += new System.EventHandler(this.txtCodigoCli_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 100029;
            this.label3.Text = "Data Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 100028;
            this.label4.Text = "Data Inicial";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(258, 525);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair (F10)";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnGerarLoteCobranca
            // 
            this.btnGerarLoteCobranca.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGerarLoteCobranca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarLoteCobranca.Location = new System.Drawing.Point(10, 525);
            this.btnGerarLoteCobranca.Name = "btnGerarLoteCobranca";
            this.btnGerarLoteCobranca.Size = new System.Drawing.Size(126, 23);
            this.btnGerarLoteCobranca.TabIndex = 4;
            this.btnGerarLoteCobranca.Text = "Gerar Cobrança";
            this.btnGerarLoteCobranca.UseVisualStyleBackColor = true;
            this.btnGerarLoteCobranca.Click += new System.EventHandler(this.btnGerarLoteCobranca_Click_1);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(143, 91);
            this.txtNomeCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(703, 26);
            this.txtNomeCli.TabIndex = 3;
            this.txtNomeCli.TabStop = false;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(9, 29);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(141, 29);
            this.dtpDataInicial.TabIndex = 100030;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(162, 29);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(141, 29);
            this.dtpDataFinal.TabIndex = 100031;
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.AllowUserToAddRows = false;
            this.dgvPesquisar.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(11, 124);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisar.Size = new System.Drawing.Size(945, 383);
            this.dgvPesquisar.TabIndex = 100032;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(146, 525);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 100033;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 558);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPesquisar);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.btnGerarLoteCobranca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisarClientes);
            this.Controls.Add(this.txtCodigoCli);
            this.Controls.Add(this.txtNomeCli);
            this.KeyPreview = true;
            this.Name = "frmCobranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobranças";
            this.Load += new System.EventHandler(this.frmCobranca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCobranca_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisarClientes;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerarLoteCobranca;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.Button btnCancelar;
    }
}