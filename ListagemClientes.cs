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

            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 260;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 260;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 260;
            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.Width = 170;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
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

           
            }

      
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[0].DataPropertyName + ", System.String) like '%" + textBox10.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[7].DataPropertyName + ", System.String) like '%" + textBox11.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[1].DataPropertyName + ", System.String) like '%" + textBox18.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[2].DataPropertyName + ", System.String) like '%" + textBox17.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[4].DataPropertyName + ", System.String) like '%" + textBox16.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[5].DataPropertyName + ", System.String) like '%" + textBox15.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[6].DataPropertyName + ", System.String) like '%" + textBox12.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[3].DataPropertyName + ", System.String) like '%" + textBox14.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[8].DataPropertyName + ", System.String) like '%" + textBox13.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox12.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox5.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[9].DataPropertyName + ", System.String) like '%" + textBox5.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }
    }
}

