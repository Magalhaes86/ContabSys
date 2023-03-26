using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;

namespace ContabSys
{
    public partial class FichaCliente : Form
    {
        public FichaCliente()
        {
            InitializeComponent();
        }



        MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");


        MySqlCommand command;


        private void FichaCliente_Load(object sender, EventArgs e)
        {

       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListagemClientes frmclientes = new ListagemClientes();
            frmclientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addrecpcaodocumentos frmrececaodocumentos = new addrecpcaodocumentos();

            frmrececaodocumentos.tbidcliente.Text = this.tbId.Text;
            frmrececaodocumentos.tbnomecliente.Text = this.tbNome.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            frmrececaodocumentos.ShowDialog();
        }






        public void RefreshDataGridRecepcaoDocumentos()
        {
            string selectQuery = "SELECT * FROM recepcaodocumentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        public void RefreshDataGridSelecaoEArguivo()
        {
            string selectQuery = "SELECT * FROM selecaoearquivo WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView2.DataSource = table;

        }



        private void button17_Click(object sender, EventArgs e)
        {
            RefreshDataGridRecepcaoDocumentos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addrecpcaodocumentos frmrececaodocumentos = new addrecpcaodocumentos();

            frmrececaodocumentos.tbcodcliente.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmrececaodocumentos.tbidcliente.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmrececaodocumentos.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmrececaodocumentos.tbobs.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmrececaodocumentos.tbnomecliente.Text = this.tbNome.Text;
            frmrececaodocumentos.tbnif.Text = this.tbNif.Text;
            frmrececaodocumentos.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnEditar.Enabled = true;
            btnEditar.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button20_Click(object sender, EventArgs e)
        {
            addseleccaoEarquivo frmraddseleccaoEarquivo = new addseleccaoEarquivo();

            frmraddseleccaoEarquivo.tbidcliente.Text = this.tbId.Text;
            frmraddseleccaoEarquivo.tbnomecliente.Text = this.tbNome.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            frmraddseleccaoEarquivo.ShowDialog();
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridSelecaoEArguivo();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            addseleccaoEarquivo frmraddseleccaoEarquivo = new addseleccaoEarquivo();

            frmraddseleccaoEarquivo.tbcodcliente.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frmraddseleccaoEarquivo.tbidcliente.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            frmraddseleccaoEarquivo.dateTimePicker1.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            frmraddseleccaoEarquivo.tbobs.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            frmraddseleccaoEarquivo.tbnomecliente.Text = this.tbNome.Text;

            frmraddseleccaoEarquivo.tbnif.Text = this.tbNif.Text;
            
            frmraddseleccaoEarquivo.ShowDialog();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            // Atualizar os datagrid
           RefreshDataGridSelecaoEArguivo();
           RefreshDataGridRecepcaoDocumentos();
        }
    }
}
    