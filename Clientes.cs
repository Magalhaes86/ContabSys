﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;
using System.Drawing;

namespace ContabSys
{
    public partial class Clientes : Form
    {
               
        public Clientes()
        {
            InitializeComponent();
     
        }

        //   MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);


        MySqlCommand command;

        private void LerDadosClientesDataGrid()
        {

            string selectQuery = "SELECT * FROM clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dgvClientes.DataSource = table;


        }

        public void limparPesquisa()
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
        }

        public void limpartudo()
        {
            tbId.Text = "";
tbCodOutroSoft.Text = "";
            tbNome.Text = "";
            tbNif.Text = "";
            tbEmail.Text = "";
            tbTlm.Text = "";
            tbTlf.Text = "";
            tbMorada.Text = "";
            tbobs.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox12.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
        }

                private void Clientes_Load(object sender, EventArgs e)
        {
            LerDadosClientesDataGrid();
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


        public void PesquisarporID()
        {
            //MySqlDataReader mdr;
            //string selectID = "SELECT * FROM clientes WHERE ID =" + tbsearchid.Text;

            //command = new MySqlCommand(selectID, connection);
            //openConnection();
            //mdr = command.ExecuteReader();

            //if (mdr.Read())
            //{
            //    tbNome.Text = mdr.GetString("Nome");
            //    tbNif.Text = mdr.GetString("Nif");
            //    tbMorada.Text = mdr.GetString("Morada");
            //    tbEmail.Text = mdr.GetString("Email");
            //    tbTlm.Text = mdr.GetString("Tlm");

            //    tbTlf.Text = mdr.GetString("Tlf");
            //    tbCodOutroSoft.Text = mdr.GetString("CodOutroSoftware");
            //    tbobs.Text = mdr.GetString("Obs");

            //}
            //else
            //{
            //    MessageBox.Show("Utilizador Não Encontrado");
            //}
            //closeConnection();

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

        private void button2_Click(object sender, EventArgs e)
        {

          
            //if (tbsearchid.Text == "")
            //{
            //    MessageBox.Show("Inserir Codigo do Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbsearchid.Focus();
            //    return;

            //}
            //try
            //{
            //    PesquisarporID();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro : " + ex.Message);
            //}


        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_MouseHover(object sender, EventArgs e)
        {
            btnNovo.BackColor = SystemColors.ActiveCaption;
        }

        private void btnNovo_MouseLeave(object sender, EventArgs e)
        {
            btnNovo.BackColor = SystemColors.ButtonFace;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            lbldelete.Visible = true;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            lbldelete.Visible = false;
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = SystemColors.ButtonFace;
        }

        private void btnGravar_MouseHover(object sender, EventArgs e)
        {
            btnGravar.BackColor = System.Drawing.Color.Green;
            btnGravar.ForeColor = SystemColors.HighlightText;
        }

        private void btnGravar_MouseLeave(object sender, EventArgs e)
        {
            btnGravar.BackColor = SystemColors.ButtonFace;
            btnGravar.ForeColor = System.Drawing.Color.Black;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ELIMINAR o registo?", " !! ELIMINAR REGISTO DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string udeleteQuery = "DELETE FROM clientes WHERE ID =" + int.Parse(tbId.Text);
                executeMyQuery(udeleteQuery);
                LerDadosClientesDataGrid();


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                textBox10.Focus();
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            limpartudo();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            limparPesquisa();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ELIMINAR o registo?", " !! ELIMINAR REGISTO DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string udeleteQuery = "DELETE FROM clientes WHERE ID =" + int.Parse(tbId.Text);
                executeMyQuery(udeleteQuery);
                LerDadosClientesDataGrid();


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                textBox10.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO clientes (Nome,Nif,Morada,Email,Tlm,Tlf,CodOutroSoftware,Obs) VALUES('" + tbNome.Text + "','" + tbNif.Text + "','" + tbMorada.Text + "','" + tbEmail.Text + "','" + tbTlm.Text + "','" + tbTlf.Text + "','" + tbCodOutroSoft.Text + "','" + tbobs.Text + "');";
            executeMyQuery(insertQuery);

            LerDadosClientesDataGrid();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ATUALIZAR os dados do Cliente?", " !! ATUALIZAR CLIENTE !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string updateQuery = "UPDATE clientes SET Nome='" + tbNome.Text + "',Nif='" + tbNif.Text + "',Morada='" + tbMorada.Text + "',Email='" + tbEmail.Text + "',Tlm='" + tbTlm.Text + "',Tlf='" + tbTlf.Text + "',CodOutroSoftware='" + tbCodOutroSoft.Text + "',Obs='" + tbobs.Text + "' WHERE ID =" + int.Parse(tbId.Text);
                executeMyQuery(updateQuery);
                LerDadosClientesDataGrid();

            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                textBox10.Focus();
            }


          
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Pretende sair sem fazer alterações?", " !! Sair sem Alterações !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Close();

            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                textBox10.Focus();
            }
        }
    }
}






