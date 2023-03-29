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
    public partial class ListagemClientes : Form
    {
        public ListagemClientes()
        {
            InitializeComponent();
        }


        //  MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);


        MySqlCommand command;


        private void ListagemClientes_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (String.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("Escolha na listagem os dados a Exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //dataGridView1.Rows.Clear();
            //}
            //else
            //{

            FichaCliente fc = (FichaCliente)Application.OpenForms["FichaCliente"];
            fc.tbId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fc.tbNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fc.tbNif.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();


            fc.tbEmail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fc.tbTlm.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fc.tbTlf.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

            fc.tbCodOutroSoft.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

            //  fc.add2.Enabled = true;

            //  fc.btnUpdate.Enabled = true;
            //    fr.textcodsage.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //  fr.textNomeCliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //  fc.ObterDadosCabecalho();
            //  fc.ObterDadosLinhas();
            FichaCliente FichaCliente = (FichaCliente)Application.OpenForms["FichaCliente"];

            FichaCliente.RefreshALLDataGrid();


            Close();
            }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (String.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("Escolha na listagem os dados a Exportar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //dataGridView1.Rows.Clear();
            //}
            //else
            //{

            FichaCliente fc = (FichaCliente)Application.OpenForms["FichaCliente"];
            fc.tbId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fc.tbNome.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fc.tbNif.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();


            fc.tbEmail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            fc.tbTlm.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fc.tbTlf.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

            fc.tbCodOutroSoft.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            FichaCliente FichaCliente = (FichaCliente)Application.OpenForms["FichaCliente"];

            FichaCliente.RefreshALLDataGrid();
            //  fc.add2.Enabled = true;

            //  fc.btnUpdate.Enabled = true;
            //    fr.textcodsage.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //  fr.textNomeCliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //  fc.ObterDadosCabecalho();
            //  fc.ObterDadosLinhas();



            Close();
        }
    }
    }

