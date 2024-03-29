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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection(@"server="+Properties.Settings.Default.server + ";database="+Properties.Settings.Default.basedados+";port="+Properties.Settings.Default.porta+";userid="+Properties.Settings.Default.username+";password="+Properties.Settings.Default.password);

      //  MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");

        MySqlCommand command;



        private void brnAbirFichaCliente_Click(object sender, EventArgs e)
        {
            
        }

      

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            password password = new password();
            password.ShowDialog();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            //  LerDadosClientesDataGrid();
            LerDadosParaDataGrid();
        }

      


        public void RefreshDataGridRecepcaoDocumentos()
        {
         //   string selectQuery = "SELECT * FROM recepcaodocumentos WHERE CodCliente =" + int.Parse(tbId.Text);

    //        string selectQuery = "SELECT * FROM recepcaodocumentos WHERE CodCliente =" + int.Parse(tbId.Text);

   //         DataTable table = new DataTable();
     //       MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
      //      adapter.Fill(table);
      //      dataGridView1.DataSource = table;

        }

        private void LerDadosClientesDataGrid()
        {

            string selectQuery = "SELECT * FROM clientes";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;


        }

        private void LerDadosParaDataGrid()
        {
        //    string selectQuery = "select clientes.ID as 'Cod. Cliente', clientes.CodOutroSoftware as 'Cod.Outro Software',clientes.nome as 'Nome Cliente',clientes.Nif as 'Nif',clientes.Email, clientes.Tlm, Clientes.Tlf,MAX(recepcaodocumentos.Data) as 'Recepção Documentos',MAX(recepcaosaft.Data) as 'Recepçãoão Saft',MAX(selecaoearquivo.Data) as 'Selecção e Arquivo', MAX(lancamentos.Data) as 'Lançamento', MAX(recebimentos.Data) as 'Recebimento', recebimentos.Valor as 'valor recebimento' from clientes left Join lancamentos on lancamentos.CodCliente = clientes.ID left join recebimentos on recebimentos.CodCliente = clientes.ID AND recebimentos.data = (select MAX(recebimentos.Data) from recebimentos where CodCliente = clientes.ID) left Join recepcaodocumentos on recepcaodocumentos.CodCliente = clientes.ID left Join recepcaosaft on recepcaosaft.CodCliente = clientes.ID left Join selecaoearquivo on selecaoearquivo.CodCliente = clientes.ID Group by clientes.ID";

            string selectQuery = "select clientes.ID, clientes.CodOutroSoftware,clientes.nome,clientes.Nif,clientes.NISS,clientes.Email,clientes.Tlm,Clientes.Tlf,MAX(recepcaodocumentos.Data),MAX(recepcaosaft.Data),MAX(selecaoearquivo.Data), MAX(lancamentos.Data), MAX(recebimentos.Data), recebimentos.Valor from clientes left Join lancamentos on lancamentos.CodCliente = clientes.ID left join recebimentos on recebimentos.CodCliente = clientes.ID AND recebimentos.data = (select MAX(recebimentos.Data) from recebimentos where CodCliente = clientes.ID) left Join recepcaodocumentos on recepcaodocumentos.CodCliente = clientes.ID left Join recepcaosaft on recepcaosaft.CodCliente = clientes.ID left Join selecaoearquivo on selecaoearquivo.CodCliente = clientes.ID Group by clientes.ID";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].HeaderText = "Cod Cliente";
            dataGridView1.Columns[1].HeaderText = "Cod. O/Soft.";
            dataGridView1.Columns[2].HeaderText = "Nome";
            dataGridView1.Columns[3].HeaderText = "Nif";
            dataGridView1.Columns[4].HeaderText = "NISS";
            dataGridView1.Columns[5].HeaderText = "Email";

            dataGridView1.Columns[6].HeaderText = "Tlm";
            dataGridView1.Columns[7].HeaderText = "Tlf";
            dataGridView1.Columns[8].HeaderText = "Recepção Documentos";
            dataGridView1.Columns[9].HeaderText = "Recepção Saft";
            dataGridView1.Columns[10].HeaderText = "Seleção e Arquivo";
            
            dataGridView1.Columns[11].HeaderText = "Lançamentos";
            dataGridView1.Columns[12].HeaderText = "Recebimentos";

            dataGridView1.Columns[13].HeaderText = "Valor";


            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 90;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 92;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 190;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.Width = 80;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.Width = 95;
            DataGridViewColumn column5 = dataGridView1.Columns[5];
            column5.Width = 180;
            DataGridViewColumn column6 = dataGridView1.Columns[6];
            column6.Width = 80;
            DataGridViewColumn column7 = dataGridView1.Columns[7];
            column7.Width = 80;
            DataGridViewColumn column8 = dataGridView1.Columns[8];
            column8.Width = 145;
            DataGridViewColumn column9 = dataGridView1.Columns[9];
            column9.Width = 145;

            DataGridViewColumn column10 = dataGridView1.Columns[10];
            column10.Width = 140;
            DataGridViewColumn column12 = dataGridView1.Columns[13];
            column12.Width = 80;


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

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes frmclientes = new Clientes();
            frmclientes.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }



      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
                FichaCliente FichaCliente = new FichaCliente();
                FichaCliente.tbId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FichaCliente.tbCodOutroSoft.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FichaCliente.tbNome.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FichaCliente.tbNif.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FichaCliente.tbniss.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                FichaCliente.tbEmail.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                FichaCliente.tbTlm.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                FichaCliente.tbTlf.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                FichaCliente.RefreshALLDataGrid();
                FichaCliente.ShowDialog();

            }    
        }

        private void tbcod_TextChanged(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[0].DataPropertyName + ", System.String) like '%" + tbcod.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;

        }

        private void tbcodoutrosoft_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[1].DataPropertyName + ", System.String) like '%" + tbcodoutrosoft.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void tbnif_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[3].DataPropertyName + ", System.String) like '%" + tbnif.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void tbnome_TextChanged(object sender, EventArgs e)
        {
         
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[2].DataPropertyName + ", System.String) like '%" + tbnome.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[12].DataPropertyName + ", System.String) like '%" + textBox1.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label16.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label16.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbcod.Text = "";
            tbcodoutrosoft.Text = "";
            tbnome.Text = "";
            tbnif.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox1.Text = "";
            LerDadosParaDataGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Encerrar a Aplicação?", " !! ENCERRAR APLICAÇÃO !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Application.Exit();

            }

            else if (dialogResult == DialogResult.No)
            {
       
                tbcod.Focus();
            }
        }

        private void btnConfig_MouseHover(object sender, EventArgs e)
        {
            labeladmin.Visible = true;
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            labeladmin.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            LerDadosParaDataGrid();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.ActiveCaption;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Window;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[4].DataPropertyName + ", System.String) like '%" + textBox5.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[5].DataPropertyName + ", System.String) like '%" + textBox2.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[6].DataPropertyName + ", System.String) like '%" + textBox3.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[7].DataPropertyName + ", System.String) like '%" + textBox4.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[13].DataPropertyName + ", System.String) like '%" + textBox1.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }
    }
    }

