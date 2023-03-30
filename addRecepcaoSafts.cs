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
using System.Drawing;

namespace ContabSys
{
    public partial class addRecepcaoSafts : Form
    {
        public addRecepcaoSafts()
        {
            InitializeComponent();
        }

        //    MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);


        MySqlCommand command;


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO recepcaosaft (CodCliente,Data,Obs) VALUES('" + tbidcliente.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + tbobs.Text + "');";
            executeMyQuery(insertQuery);
            FichaCliente FichaCliente = (FichaCliente)Application.OpenForms["FichaCliente"];

            FichaCliente.RefreshDataGridaddRecepcaoSafts();

        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ATUALIZAR o registo?", " !! ATUALIZAR REGISTO DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string updateQuery = "UPDATE recepcaosaft SET CodCliente='" + tbidcliente.Text + "',Data='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',Obs='" + tbobs.Text + "' WHERE ID =" + int.Parse(tbcodcliente.Text);
                executeMyQuery(updateQuery);
                FichaCliente FichaCliente = (FichaCliente)Application.OpenForms["FichaCliente"];

                FichaCliente.RefreshDataGridaddRecepcaoSafts();

            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }


          
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
                string udeleteQuery = "DELETE FROM recepcaosaft WHERE ID =" + int.Parse(tbcodcliente.Text);
                executeMyQuery(udeleteQuery);


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }

        }

        private void addRecepcaoSafts_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Registo Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao inserir Registo");
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
                ListClientesRecepcaosaft frmListClientesRecepcaosaft = new ListClientesRecepcaosaft();
                frmListClientesRecepcaosaft.ShowDialog();


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            btnnovo.Visible = false;
            btnGravar.Visible = true;
            tbcodcliente.Text = "";
            tbobs.Text = "";
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

        private void btnUPDATE_MouseHover(object sender, EventArgs e)
        {
            btnUPDATE.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void btnUPDATE_MouseLeave(object sender, EventArgs e)
        {
            btnUPDATE.BackColor = SystemColors.ButtonFace;
        }

        private void btnnovo_MouseHover(object sender, EventArgs e)
        {
            btnnovo.BackColor = SystemColors.ActiveCaption;
        }

        private void btnnovo_MouseLeave(object sender, EventArgs e)
        {
            btnnovo.BackColor = SystemColors.ButtonFace;
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackColor = SystemColors.ButtonFace;
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

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ELIMINAR o registo?", " !! ELIMINAR REGISTO DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string udeleteQuery = "DELETE FROM lancamentos WHERE ID =" + int.Parse(tbcodcliente.Text);
                executeMyQuery(udeleteQuery);


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem a certeza que pretende ELIMINAR o registo?", " !! ELIMINAR REGISTO DA BASE DE DADOS !!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string udeleteQuery = "DELETE FROM recepcaosaft WHERE ID =" + int.Parse(tbcodcliente.Text);
                executeMyQuery(udeleteQuery);


            }

            else if (dialogResult == DialogResult.No)
            {
                //caso pretenda fazer outra coisa qualuqer.
                btncancelar.Focus();
            }
        }
    
private void btnDelete_MouseHover(object sender, EventArgs e)
{
    lbldelete.Visible = true;
}

private void btnDelete_MouseLeave(object sender, EventArgs e)
{
    lbldelete.Visible = false;
}

       
    }
}