using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class frmRelacaoAtendimentos : Form
    {
        int codigocliente = 0;

        public frmRelacaoAtendimentos()
        {
            InitializeComponent();
        }

        private void relRelacaoAtendimentos_Load(object sender, EventArgs e)
        {
            //mskDataInicial.Mask = "00/00/0000";
            //mskDataFinal.Mask = "00/00/0000";

            //mskDataInicial.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //mskDataFinal.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void frmRelacaoAtendimentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.F10)
            {
                Close();
            }
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            frmClientePesquisar frm = new frmClientePesquisar();

            frm.ShowDialog();

            codigocliente = frm.IdCliente;

            var arquivo = MetodosCliente.LeituraCliente(codigocliente);

            if (arquivo == null)
            {
                MessageBox.Show("Cliente Inexistente", "Aviso");

                txtCodigoCli.Text = "";

                txtCodigoCli.Focus();

                return;
            }

            txtCodigoCli.Text = arquivo.Id.ToString();
            txtNomeCli.Text = arquivo.Nome;

            //MetodosAtendimento.LeituraAtendimentoTodos(codigocliente);
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoCli_Leave(object sender, EventArgs e)
        {
            if (txtCodigoCli.Text == "")
            {
                txtCodigoCli.Focus();

                return;
            }

            if (txtCodigoCli.Text != "")
            {
                codigocliente = Int32.Parse(txtCodigoCli.Text);

                if (codigocliente == 0)
                {
                    txtCodigoCli.Focus();

                    return;
                }

                var arquivo = MetodosCliente.LeituraCliente(codigocliente);

                if (arquivo == null)
                {
                    MessageBox.Show("Cliente Inexistente", "Aviso");

                    txtCodigoCli.Text = "";

                    txtCodigoCli.Focus();

                    return;
                }

                txtCodigoCli.Text = arquivo.Id.ToString();
                txtNomeCli.Text = arquivo.Nome;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmCarregaRelacaoAtendimentos frm = new frmCarregaRelacaoAtendimentos();

            frm.ShowDialog();
        }
    }
}
