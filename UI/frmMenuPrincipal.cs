using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI
{
    public partial class frmMenuPrincipal : Form
    {
        string empresa;
        string linha;

        public frmMenuPrincipal()
        {
            InitializeComponent();

            // Abrir no Centro da Tela
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ////this.Text = "SANEL RESTAURANTE - Menu Principal";
            //this.Text = "PANELA VÉIA RESTAURANTE - Menu Principal";

            //ABRE O ARQUIVO EMPRESA.TXT PARA LER E EXIBIR O NOME DA EMPRESA NO CABEÇALHO
            //string arquivo = @"C:\SAT\EMPRESA.TXT";
            string arquivo = @"EMPRESA.TXT";

            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        while ((linha = sr.ReadLine()) != null)
                        {
                            empresa = linha;
                        }

                        empresa = empresa + " - MENU PRINCIPAL";

                        this.Text = empresa;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("O arquivo EMPRESA.TXT Não Existe na Pasta C:\\SAT");
            }
        }

        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                Close();
            }

            //if (e.KeyCode == Keys.F5)
            //{
            //    emissãoToolStripMenuItem_Click(sender, e);
            //}

            if (e.KeyCode == Keys.F5)
            {
                frmAtendimento frm = new frmAtendimento();

                frm.ShowDialog();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();

            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DataHora = DateTime.Now;
            lblDataHora.Text = DataHora.ToLongDateString() + "   " + DataHora.ToLongTimeString();
        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void emissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento frm = new frmAtendimento();

            frm.ShowDialog();
        }

        private void atendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendente frm = new frmAtendente();

            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacaoAtendimentos frm = new frmRelacaoAtendimentos();

            frm.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cobrançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobranca frm = new frmCobranca();

            frm.ShowDialog();
        }
    }
}
