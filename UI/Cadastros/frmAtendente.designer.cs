namespace UI
{
    partial class frmAtendente
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
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label label34;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtendente));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbAtualizar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tsbProximo = new System.Windows.Forms.ToolStripButton();
            this.tsbUltimo = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            lblNome = new System.Windows.Forms.Label();
            label34 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.gbMenu.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNome.Location = new System.Drawing.Point(128, 92);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(140, 17);
            lblNome.TabIndex = 219;
            lblNome.Text = "Nome / Razão Social";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label34.Location = new System.Drawing.Point(10, 92);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(52, 17);
            label34.TabIndex = 218;
            label34.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 149);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 17);
            label1.TabIndex = 221;
            label1.Text = "Ativo/Inativo";
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.toolStrip2);
            this.gbMenu.Location = new System.Drawing.Point(5, 4);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(776, 70);
            this.gbMenu.TabIndex = 2;
            this.gbMenu.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPesquisar,
            this.tsbNovo,
            this.tsbAtualizar,
            this.tsbCancelar,
            this.tsbExcluir,
            this.tsbPrimeiro,
            this.tsbAnterior,
            this.tsbProximo,
            this.tsbUltimo,
            this.tsbSair});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(770, 43);
            this.toolStrip2.TabIndex = 183;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbPesquisar
            // 
            this.tsbPesquisar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisar.Image")));
            this.tsbPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisar.Name = "tsbPesquisar";
            this.tsbPesquisar.Size = new System.Drawing.Size(113, 40);
            this.tsbPesquisar.Text = "Pesquisar (F9)";
            this.tsbPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPesquisar.Click += new System.EventHandler(this.tsbPesquisar_Click);
            // 
            // tsbNovo
            // 
            this.tsbNovo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(84, 40);
            this.tsbNovo.Text = "Novo (F4)";
            this.tsbNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbAtualizar
            // 
            this.tsbAtualizar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAtualizar.Image")));
            this.tsbAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAtualizar.Name = "tsbAtualizar";
            this.tsbAtualizar.Size = new System.Drawing.Size(76, 40);
            this.tsbAtualizar.Text = "Atualizar";
            this.tsbAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAtualizar.Click += new System.EventHandler(this.tsbAtualizar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(72, 40);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(59, 40);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tsbPrimeiro
            // 
            this.tsbPrimeiro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrimeiro.Image")));
            this.tsbPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimeiro.Name = "tsbPrimeiro";
            this.tsbPrimeiro.Size = new System.Drawing.Size(73, 40);
            this.tsbPrimeiro.Text = "Primeiro";
            this.tsbPrimeiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPrimeiro.Click += new System.EventHandler(this.tsbPrimeiro_Click);
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnterior.Image")));
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(72, 40);
            this.tsbAnterior.Text = "Anterior";
            this.tsbAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAnterior.Click += new System.EventHandler(this.tsbAnterior_Click);
            // 
            // tsbProximo
            // 
            this.tsbProximo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbProximo.Image = ((System.Drawing.Image)(resources.GetObject("tsbProximo.Image")));
            this.tsbProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProximo.Name = "tsbProximo";
            this.tsbProximo.Size = new System.Drawing.Size(72, 40);
            this.tsbProximo.Text = "Próximo";
            this.tsbProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProximo.Click += new System.EventHandler(this.tsbProximo_Click);
            // 
            // tsbUltimo
            // 
            this.tsbUltimo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbUltimo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUltimo.Image")));
            this.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUltimo.Name = "tsbUltimo";
            this.tsbUltimo.Size = new System.Drawing.Size(61, 40);
            this.tsbUltimo.Text = "Último";
            this.tsbUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUltimo.Click += new System.EventHandler(this.tsbUltimo_Click);
            // 
            // tsbSair
            // 
            this.tsbSair.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(81, 40);
            this.tsbSair.Text = "Sair (F10)";
            this.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(10, 110);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(107, 26);
            this.txtCodigo.TabIndex = 203;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(128, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(653, 26);
            this.txtNome.TabIndex = 204;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(10, 169);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacao.TabIndex = 220;
            // 
            // frmAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 202);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(label34);
            this.Controls.Add(this.gbMenu);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Atendentes";
            this.Load += new System.EventHandler(this.frmAtendentes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAtendentes_KeyDown);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbPesquisar;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton tsbAtualizar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripButton tsbPrimeiro;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton tsbProximo;
        private System.Windows.Forms.ToolStripButton tsbUltimo;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ComboBox cmbSituacao;
    }
}