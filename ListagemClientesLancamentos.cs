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
    public partial class ListagemClientesLancamentos : Form
    {
        public ListagemClientesLancamentos()
        {
            InitializeComponent();
        }

        //  MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);


        MySqlCommand command;


        private void ListagemClientesLancamentos_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addLancamentos fc = (addLancamentos)Application.OpenForms["addLancamentos"];
            fc.tbidcliente.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fc.tbnomecliente.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fc.tbnif.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fc.btnUPDATE.Visible = false;

            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[0].DataPropertyName + ", System.String) like '%" + textBox1.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }
    }
}
