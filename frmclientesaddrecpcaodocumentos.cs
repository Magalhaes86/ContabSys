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
    public partial class frmclientesaddrecpcaodocumentos : Form
    {
        public frmclientesaddrecpcaodocumentos()
        {
            InitializeComponent();
        }


        // MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);


        MySqlCommand command;



        private void frmclientesaddrecpcaodocumentos_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                addrecpcaodocumentos fc = (addrecpcaodocumentos)Application.OpenForms["addrecpcaodocumentos"];
                fc.tbidcliente.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                fc.tbnomecliente.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                fc.tbnif.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Close();
            }
        }
    }

}

