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
    public partial class Clientes : Form
    {
               
        public Clientes()
        {
            InitializeComponent();
     
        }

        //  MySqlConnection connection = new MySqlConnection("datasource= " + Properties.Settings.Default.server + ";" + "database=" + Properties.Settings.Default.basedados + ";" + "port=" + Properties.Settings.Default.porta + ";" + "username=" + Properties.Settings.Default.username + ";" + "password=" + Properties.Settings.Default.password);

        MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
   

        MySqlCommand command;

        private void LerDadosClientesDataGrid()
        {

            string selectQuery = "SELECT * FROM clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvClientes.DataSource = table;


        }



  


                private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clientes (Nome,Nif,Morada,Email,Tlm,Tlf,CodOutroSoftware,Obs) VALUES('" +tbNome.Text+ "','" +tbNif.Text+ "','" +tbMorada.Text+ "','" +tbEmail.Text+ "','" +tbTlm.Text+ "','" +tbTlf.Text+ "','" +tbCodOutroSoft.Text+ "','" +tbobs.Text+ "');";
            executeMyQuery(insertQuery);

            LerDadosClientesDataGrid();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE clientes SET Nome='" + tbNome.Text + "',Nif='" + tbNif.Text + "',Morada='" + tbMorada.Text + "',Email='" + tbEmail.Text + "',Tlm='" + tbTlm.Text + "',Tlf='" + tbTlf.Text + "',CodOutroSoftware='" + tbCodOutroSoft.Text + "',Obs='" + tbobs.Text + "' WHERE ID ="+int.Parse(tbId.Text);
            executeMyQuery(updateQuery);
            LerDadosClientesDataGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
         

                }

        private void button1_Click(object sender, EventArgs e)
        {
            LerDadosClientesDataGrid();
        }

        private void dgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
  
            tbId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            tbNif.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            tbMorada.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            tbEmail.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            tbTlm.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            tbTlf.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            tbCodOutroSoft.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
            tbobs.Text = dgvClientes.CurrentRow.Cells[8].Value.ToString();
           
        }

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executada");
                }
                else
                {
                    MessageBox.Show("Query Não Executada");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                closeConnection();
            }
        }


        }
}






