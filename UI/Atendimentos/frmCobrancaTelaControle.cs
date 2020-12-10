using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Atendimentos
{
    public partial class frmCobrancaTelaControle : Form
    {
        //RETORNA O NOME DO CONTROLE PARA O FORMULARIO PAI
        public string NomeControle { get; set; }
        public DateTime DataCobranca { get; set; }

        public frmCobrancaTelaControle()
        {
            InitializeComponent();
        }

        private void frmCobrancaTelaLote_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmCobrancaTelaControle_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //NomeControle = txtControle.Text;

            DataCobranca = DateTime.Parse(dtpDataCobranca.Text);

            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
