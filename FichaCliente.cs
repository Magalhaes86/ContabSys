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
    public partial class FichaCliente : Form
    {
        public FichaCliente()
        {
            InitializeComponent();
        }

        private void FichaCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListagemClientes frmclientes = new ListagemClientes();
            frmclientes.ShowDialog();
        }
    }
}
