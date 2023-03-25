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
    public partial class addrecpcaodocumentos : Form
    {
        public addrecpcaodocumentos()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");


        MySqlCommand command;



        private void addrecpcaodocumentos_Load(object sender, EventArgs e)
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


        private void btnNovo_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clientes (CodCliente,Data,Obs) VALUES('" + tbidcliente.Text + "','" + dateTimePicker1.Text + "','" + tbobs.Text + "');";
            executeMyQuery(insertQuery);
        }
    }
}
