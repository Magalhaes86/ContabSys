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
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Drawing;

namespace ContabSys
{
    public partial class CriarUtilizadorAdmin : Form
    {
        public CriarUtilizadorAdmin()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);
        MySqlCommand command;



        private void CriarUtilizadorAdmin_Load(object sender, EventArgs e)
        {
            LerDadosClientesDataGrid();
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

        public void executeMyQueryDelete(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Utilizador Eliminado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro");
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


        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Utilizador Guardado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro");
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

        public void executeMyQueryUpdate(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Utilizador Atualizado com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro");
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

        private void btngravar_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO logintable (username,password) VALUES('" + tbuser.Text + "','" + tbpassword.Text + "');";
            executeMyQuery(insertQuery);

            LerDadosClientesDataGrid();
            btnnovo.Enabled = true;
            btngravar.Visible = true;
            btngravar.Enabled = false;
            //  LerDadosClientesDataGrid();
            tbid.Text = "";
            tbpassword.Text = "";
            tbuser.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ATUALIZAR os dados do Utilizador?", " !! ATUALIZAR CLIENTE !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string updateQuery = "UPDATE logintable SET username='" + tbuser.Text + "',password='" + tbpassword.Text + "' WHERE Id =" + int.Parse(tbid.Text);
                executeMyQueryUpdate(updateQuery);
                //    LerDadosClientesDataGrid();
                 Atualizar.Visible = false;                  
                 btngravar.Enabled = false;
                btngravar.Visible = true;
                btneditar.Enabled = false;
                tbid.Text = "";
                tbpassword.Text = "";
                tbuser.Text = "";
                LerDadosClientesDataGrid();
            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                tbuser.Focus();
                Atualizar.Visible = false;
                btngravar.Enabled = false;
                btngravar.Visible = true;
                btneditar.Enabled = false;
                tbid.Text = "";
                tbpassword.Text = "";
                tbuser.Text = "";
            }


        }


        private void LerDadosClientesDataGrid()
        {

            string selectQuery = "SELECT * FROM logintable";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;


            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 50;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 190;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.Width = 190;
          


        }



        private void btndelete_Click(object sender, EventArgs e)
        {

          
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Pretende Editar o Utilizador Selecionado?", " !! Editar Utilizador !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                tbid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tbuser.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tbpassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
              

               Atualizar.Visible = true;
               btngravar.Visible = false;
            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btneditar.Enabled = false;
                tbuser.Focus();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            btnnovo.Enabled = false;
            btngravar.Enabled = true;
            btngravar.Visible = true;
            tbuser.Text = "";
            tbpassword.Text = "";
            tbid.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbid.Text))
            {
                MessageBox.Show("Escolha o Cliente que pretende Anular");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ELIMINAR o Utilizador?", " !! ELIMINAR UTILIZADOR DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string udeleteQuery = "DELETE FROM logintable WHERE ID =" + int.Parse(tbid.Text);
                executeMyQueryDelete(udeleteQuery);
                //   LerDadosClientesDataGrid();
                LerDadosClientesDataGrid();
                tbid.Text = "";
                tbpassword.Text = "";
                tbuser.Text = "";
                Atualizar.Visible = false;
                btngravar.Enabled = false;
                btngravar.Visible = true;
                btneditar.Enabled = false;

            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                tbuser.Focus();
                Atualizar.Visible = false;
                btngravar.Enabled = false;
                btngravar.Visible = true;
                btneditar.Enabled = false;
                tbid.Text = "";
                tbpassword.Text = "";
                tbuser.Text = "";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lbldelete.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lbldelete.Visible = false;
        }

        private void btnnovo_MouseHover(object sender, EventArgs e)
        {
            btnnovo.BackColor = SystemColors.ActiveCaption;
        }

        private void btnnovo_MouseLeave(object sender, EventArgs e)
        {
            btnnovo.BackColor = SystemColors.ButtonFace;
        }

        private void Atualizar_MouseHover(object sender, EventArgs e)
        {
            Atualizar.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void Atualizar_MouseLeave(object sender, EventArgs e)
        {
            Atualizar.BackColor = SystemColors.ButtonFace;
        }

        private void btngravar_MouseHover(object sender, EventArgs e)
        {
            btngravar.BackColor = System.Drawing.Color.Green;
            btngravar.ForeColor = SystemColors.HighlightText;
        }

        private void btngravar_MouseLeave(object sender, EventArgs e)
        {
            btngravar.BackColor = SystemColors.ButtonFace;
            btngravar.ForeColor = System.Drawing.Color.Black;
        }

        private void btneditar_MouseHover(object sender, EventArgs e)
        {
            btneditar.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void btneditar_MouseLeave(object sender, EventArgs e)
        {
            btneditar.BackColor = SystemColors.ButtonFace;
        }

        private void btncancelar_MouseHover(object sender, EventArgs e)
        {
            btncancelar.BackColor = System.Drawing.Color.RosyBrown;
            btncancelar.ForeColor = SystemColors.HighlightText;
        }

        private void btncancelar_MouseLeave(object sender, EventArgs e)
        {
            btncancelar.BackColor = SystemColors.ButtonFace;
            btncancelar.ForeColor = System.Drawing.Color.Black;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende Fechar formulário sem fazer alterações?", " !! FERCHAR SEM ALTERAÇÕES  !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();



            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btneditar.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btneditar.Enabled = true;
        }
    }
}
