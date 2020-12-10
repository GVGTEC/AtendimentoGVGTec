namespace UI
{
    partial class frmAtendimentoPesquisar
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
            this.dgvPesquisar = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnPesquisarClientes = new System.Windows.Forms.Button();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.AllowUserToAddRows = false;
            this.dgvPesquisar.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(8, 47);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisar.Size = new System.Drawing.Size(945, 623);
            this.dgvPesquisar.TabIndex = 60;
            this.dgvPesquisar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisar_CellDoubleClick_1);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(853, 683);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair (F10)";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(639, 683);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(101, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar (F5)";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarClientes
            // 
            this.btnPesquisarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarClientes.Location = new System.Drawing.Point(105, 19);
            this.btnPesquisarClientes.Name = "btnPesquisarClientes";
            this.btnPesquisarClientes.Size = new System.Drawing.Size(32, 25);
            this.btnPesquisarClientes.TabIndex = 100014;
            this.btnPesquisarClientes.TabStop = false;
            this.btnPesquisarClientes.Text = "F9";
            this.btnPesquisarClientes.UseVisualStyleBackColor = true;
            this.btnPesquisarClientes.Click += new System.EventHandler(this.btnPesquisarClientes_Click);
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCli.Location = new System.Drawing.Point(8, 18);
            this.txtCodigoCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(90, 26);
            this.txtCodigoCli.TabIndex = 0;
            this.txtCodigoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoCli_KeyDown);
            this.txtCodigoCli.Leave += new System.EventHandler(this.txtCodigoCli_Leave);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(144, 18);
            this.txtNomeCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(703, 26);
            this.txtNomeCli.TabIndex = 1;
            this.txtNomeCli.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 100015;
            this.label2.Text = "Código do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 100016;
            this.label1.Text = "Nome do Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(746, 683);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 100017;
            this.btnCancelar.Text = "Cancelar (Esc)";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(852, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 25);
            this.btnPesquisar.TabIndex = 100018;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbLimpar
            // 
            this.cmbLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmbLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLimpar.Location = new System.Drawing.Point(8, 683);
            this.cmbLimpar.Name = "cmbLimpar";
            this.cmbLimpar.Size = new System.Drawing.Size(101, 23);
            this.cmbLimpar.TabIndex = 100019;
            this.cmbLimpar.Text = "Limpar (F8)";
            this.cmbLimpar.UseVisualStyleBackColor = true;
            this.cmbLimpar.Click += new System.EventHandler(this.cmbLimpar_Click);
            // 
            // frmAtendimentoPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 715);
            this.Controls.Add(this.cmbLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisarClientes);
            this.Controls.Add(this.txtCodigoCli);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.dgvPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSelecionar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtendimentoPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Atendimentos";
            this.Load += new System.EventHandler(this.frmAtendimentoPesquisar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAtendimentoPesquisar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnPesquisarClientes;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button cmbLimpar;
    }
}