namespace UI
{
    partial class frmFilialPesquisar
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.AllowUserToAddRows = false;
            this.dgvPesquisar.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(9, 47);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisar.Size = new System.Drawing.Size(945, 622);
            this.dgvPesquisar.TabIndex = 70;
            this.dgvPesquisar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisar_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(878, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 67;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.Location = new System.Drawing.Point(8, 21);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(864, 20);
            this.txtPesquisar.TabIndex = 66;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(5, 5);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(62, 13);
            this.lblPesquisar.TabIndex = 65;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(853, 683);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 23);
            this.btnSair.TabIndex = 69;
            this.btnSair.Text = "Sair (F10)";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(736, 683);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(101, 23);
            this.btnSelecionar.TabIndex = 68;
            this.btnSelecionar.Text = "Selecionar (F5)";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmClientePesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 714);
            this.Controls.Add(this.dgvPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSelecionar);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientePesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Clientes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientePesquisar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSelecionar;
    }
}