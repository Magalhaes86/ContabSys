using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabSys
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void brnAbirFichaCliente_Click(object sender, EventArgs e)
        {
            FichaCliente frmFichaCliente = new FichaCliente();
            frmFichaCliente.ShowDialog();
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            Clientes frmclientes = new Clientes();
            frmclientes.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
             Config frmConfig = new Config();
            frmConfig.ShowDialog();
        }
    }
}
