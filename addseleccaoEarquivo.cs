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
    public partial class addseleccaoEarquivo : Form
    {
        public addseleccaoEarquivo()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");


        MySqlCommand command;



        private void addseleccaoEarquivo_Load(object sender, EventArgs e)
        {

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                closeConnection();
            }
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
           

            DialogResult dialogResult = MessageBox.Show("Pretende fazer um lançamento para um novo Cliente ?", "Novo Lançamento", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tbcodcliente.Text = "";
                tbidcliente.Text = "";
                tbnomecliente.Text = "";
                tbnif.Text = "";
                tbobs.Text = "";
                listagemClientesSeleccaoEArguivos frmclienteslistcli = new listagemClientesSeleccaoEArguivos();
                frmclienteslistcli.ShowDialog();


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO selecaoearquivo (CodCliente,Data,Obs) VALUES('" + tbidcliente.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + tbobs.Text + "');";
            executeMyQuery(insertQuery);
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE selecaoearquivo SET CodCliente='" + tbidcliente.Text + "',Data='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',Obs='" + tbobs.Text + "' WHERE ID =" + int.Parse(tbcodcliente.Text);
            executeMyQuery(updateQuery);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ELIMINAR o registo?", " !! ELIMINAR REGISTO DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string udeleteQuery = "DELETE FROM selecaoearquivo WHERE ID =" + int.Parse(tbcodcliente.Text);
                executeMyQuery(udeleteQuery);


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }

        }
    }
}
