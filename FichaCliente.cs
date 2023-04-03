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
    public partial class FichaCliente : Form
    {
        public FichaCliente()
        {
            InitializeComponent();
        }



        //MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");
        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);


        MySqlCommand command;


        private void FichaCliente_Load(object sender, EventArgs e)
        {

            RefreshALLDataGrid();

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            addrecpcaodocumentos frmrececaodocumentos = new addrecpcaodocumentos();

            frmrececaodocumentos.tbidcliente.Text = this.tbId.Text;
            frmrececaodocumentos.tbnomecliente.Text = this.tbNome.Text;
            frmrececaodocumentos.tbnif.Text = this.tbNif.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmrececaodocumentos.btnUPDATE.Visible = false;
            frmrececaodocumentos.btnnovo.Visible = false;
            frmrececaodocumentos.ShowDialog();
        }


        public void RefreshALLDataGrid()
        {
            RefreshDataGridSelecaoEArguivo();
            RefreshDataGridRecepcaoDocumentos();
            RefreshDataGridaddLancamentos();
            RefreshDataGridaddRecepcaoSafts();
            RefreshDataGridRecebimentos();
        }
        


        public void RefreshDataGridaddRecepcaoSafts()
        {
            string selectQuery = "SELECT * FROM recepcaosaft WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView4.DataSource = table;


            DataGridViewColumn column = dataGridView4.Columns[3];
            column.Width = 400;
        }

        public void RefreshDataGridaddLancamentos()
        {
            string selectQuery = "SELECT * FROM lancamentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView3.DataSource = table;


            DataGridViewColumn column = dataGridView3.Columns[3];
            column.Width = 400;

        }

        public void RefreshDataGridRecepcaoDocumentos()
        {
            string selectQuery = "SELECT * FROM recepcaodocumentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            DataGridViewColumn column = dataGridView1.Columns[3];
            column.Width = 400;

        }

        public void RefreshDataGridRecebimentos()
        {
            string selectQuery = "SELECT * FROM recebimentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView5.DataSource = table;


            DataGridViewColumn column = dataGridView5.Columns[4];
            column.Width = 300;
        }


        public void RefreshDataGridSelecaoEArguivo()
        {
            string selectQuery = "SELECT * FROM selecaoearquivo WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView2.DataSource = table;


            DataGridViewColumn column = dataGridView2.Columns[3];
            column.Width = 400;

        }



        private void button17_Click(object sender, EventArgs e)
        {
            RefreshDataGridRecepcaoDocumentos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addrecpcaodocumentos frmrececaodocumentos = new addrecpcaodocumentos();

            frmrececaodocumentos.tbcodcliente.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmrececaodocumentos.tbidcliente.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmrececaodocumentos.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmrececaodocumentos.tbobs.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frmrececaodocumentos.tbnomecliente.Text = this.tbNome.Text;
            frmrececaodocumentos.tbnif.Text = this.tbNif.Text;

            frmrececaodocumentos.btnGravar.Visible = false;
            frmrececaodocumentos.btnnovo.Visible = false;


            frmrececaodocumentos.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnEditar.Enabled = true;
            btnEditar.Focus();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button20_Click(object sender, EventArgs e)
        {
            addseleccaoEarquivo frmraddseleccaoEarquivo = new addseleccaoEarquivo();

            frmraddseleccaoEarquivo.tbidcliente.Text = this.tbId.Text;
            frmraddseleccaoEarquivo.tbnomecliente.Text = this.tbNome.Text;
            frmraddseleccaoEarquivo.tbnif.Text = this.tbNif.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            frmraddseleccaoEarquivo.btnUPDATE.Visible = false;
            frmraddseleccaoEarquivo.btnnovo.Visible = false;

            frmraddseleccaoEarquivo.ShowDialog();
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridSelecaoEArguivo();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            addseleccaoEarquivo frmraddseleccaoEarquivo = new addseleccaoEarquivo();

            frmraddseleccaoEarquivo.tbcodcliente.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            frmraddseleccaoEarquivo.tbidcliente.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            frmraddseleccaoEarquivo.dateTimePicker1.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            frmraddseleccaoEarquivo.tbobs.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            frmraddseleccaoEarquivo.tbnomecliente.Text = this.tbNome.Text;

            frmraddseleccaoEarquivo.tbnif.Text = this.tbNif.Text;

            frmraddseleccaoEarquivo.btnGravar.Visible = false;
            frmraddseleccaoEarquivo.btnnovo.Visible = false;


            frmraddseleccaoEarquivo.ShowDialog();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

       

        private void button10_Click(object sender, EventArgs e)
        {
           

                  addLancamentos frmraddaddLancamentos = new addLancamentos();

            frmraddaddLancamentos.tbidcliente.Text = this.tbId.Text;
            frmraddaddLancamentos.tbnomecliente.Text = this.tbNome.Text;
            frmraddaddLancamentos.tbnif.Text = this.tbNif.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmraddaddLancamentos.btnUPDATE.Visible = false;
            frmraddaddLancamentos.btnnovo.Visible = false;
            frmraddaddLancamentos.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            addLancamentos frmraddaddLancamentos = new addLancamentos();
            frmraddaddLancamentos.tbcodcliente.Text = this.dataGridView3.CurrentRow.Cells[0].Value.ToString();
            frmraddaddLancamentos.tbidcliente.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            frmraddaddLancamentos.dateTimePicker1.Text = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
            frmraddaddLancamentos.tbobs.Text = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
            frmraddaddLancamentos.tbnomecliente.Text = this.tbNome.Text;
            frmraddaddLancamentos.tbnif.Text = this.tbNif.Text;
            frmraddaddLancamentos.btnGravar.Visible = false;
            frmraddaddLancamentos.btnnovo.Visible = false;
            frmraddaddLancamentos.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {


            addRecepcaoSafts frmraddRecepcaoSafts = new addRecepcaoSafts();

            frmraddRecepcaoSafts.tbidcliente.Text = this.tbId.Text;
            frmraddRecepcaoSafts.tbnomecliente.Text = this.tbNome.Text;
            frmraddRecepcaoSafts.tbnif.Text = this.tbNif.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmraddRecepcaoSafts.btnUPDATE.Visible = false;
            frmraddRecepcaoSafts.btnnovo.Visible = false;
            frmraddRecepcaoSafts.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addRecepcaoSafts frmraddRecepcaoSafts = new addRecepcaoSafts();
            frmraddRecepcaoSafts.tbcodcliente.Text = this.dataGridView4.CurrentRow.Cells[0].Value.ToString();
            frmraddRecepcaoSafts.tbidcliente.Text = this.dataGridView4.CurrentRow.Cells[1].Value.ToString();
            frmraddRecepcaoSafts.dateTimePicker1.Text = this.dataGridView4.CurrentRow.Cells[2].Value.ToString();
            frmraddRecepcaoSafts.tbobs.Text = this.dataGridView4.CurrentRow.Cells[3].Value.ToString();
            frmraddRecepcaoSafts.tbnomecliente.Text = this.tbNome.Text;
            frmraddRecepcaoSafts.tbnif.Text = this.tbNif.Text;

            frmraddRecepcaoSafts.btnGravar.Visible = false;
            frmraddRecepcaoSafts.btnnovo.Visible = false;

            frmraddRecepcaoSafts.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addRecebimentos frmaddRecebimentos = new addRecebimentos();

            frmaddRecebimentos.tbidcliente.Text = this.tbId.Text;
            frmaddRecebimentos.tbnomecliente.Text = this.tbNome.Text;
            frmaddRecebimentos.tbnif.Text = this.tbNif.Text;
            //      frmrececaodocumentos.tbobscliente.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmaddRecebimentos.btnUPDATE.Visible = false;
            frmaddRecebimentos.btnnovo.Visible = false;

            frmaddRecebimentos.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addRecebimentos frmaddRecebimentos = new addRecebimentos();
            frmaddRecebimentos.tbcodcliente.Text = this.dataGridView5.CurrentRow.Cells[0].Value.ToString();
            frmaddRecebimentos.tbidcliente.Text = this.dataGridView5.CurrentRow.Cells[1].Value.ToString();
            frmaddRecebimentos.dateTimePicker1.Text = this.dataGridView5.CurrentRow.Cells[2].Value.ToString();
            frmaddRecebimentos.tbvalor.Text = this.dataGridView5.CurrentRow.Cells[3].Value.ToString();
            frmaddRecebimentos.tbobs.Text = this.dataGridView5.CurrentRow.Cells[4].Value.ToString();
            frmaddRecebimentos.tbnomecliente.Text = this.tbNome.Text;
            frmaddRecebimentos.tbnif.Text = this.tbNif.Text;

            frmaddRecebimentos.btnGravar.Visible = false;
            frmaddRecebimentos.btnnovo.Visible = false;

            frmaddRecebimentos.ShowDialog();
        }

        private void button22_MouseHover(object sender, EventArgs e)
        {
            label20.Visible = true;
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            label20.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ListagemClientes frmclientes = new ListagemClientes();
            frmclientes.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            frmTesteEmail frmTesteEmail = new frmTesteEmail();
            string a = "Caro ";
            string b = tbNome.Text + ",";
            string c = "Vimos por este meio informar que está em falta a entrega da documentação";
            string f = "Solicitamos a entrega dos mesmos com maior brevidade possível";
            string d = a + b + "\r\n" + c + "\r\n" + f;
            frmTesteEmail.txtAssuntoTitulo.Text = "Documentos em Falta";
            frmTesteEmail.txtEnviarPara.Text = tbEmail.Text;
            frmTesteEmail.txtMensagem.Text = d;
            frmTesteEmail.ShowDialog();
        
            
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            frmTesteEmail frmTesteEmail = new frmTesteEmail();
            string a = "Caro ";
            string b = tbNome.Text + ",";
            string c = "Vimos por este meio informar que está em falta o envio do Ficheiro Saft";
            string f = "Solicitamos o envio com maior brevidade possível";
            string d = a + b + "\r\n" + c + "\r\n" + f;
            frmTesteEmail.txtAssuntoTitulo.Text = "Ficheiro Saft em Falta";
            frmTesteEmail.txtEnviarPara.Text = tbEmail.Text;
            frmTesteEmail.txtMensagem.Text = d;
            frmTesteEmail.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            frmTesteEmail frmTesteEmail = new frmTesteEmail();
            string a = "Caro ";
            string b = tbNome.Text + ",";
            string c = "Vimos por este meio informar que se encontram valores por liquidar";
            string f = "Solicitamos a regularização com maior brevidade possível";
            string d = a + b + "\r\n" + c + "\r\n" + f;
            frmTesteEmail.txtAssuntoTitulo.Text = "Valores Por liquidar";
            frmTesteEmail.txtEnviarPara.Text = tbEmail.Text;
            frmTesteEmail.txtMensagem.Text = d;
            frmTesteEmail.ShowDialog();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.ActiveCaption;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.ButtonFace;
        }

        private void btnEditar_MouseHover(object sender, EventArgs e)
        {
            btnEditar.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            btnEditar.BackColor = SystemColors.ButtonFace;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ActiveCaption;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ButtonFace;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridRecepcaoDocumentos();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridSelecaoEArguivo();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            RefreshDataGridaddLancamentos();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            RefreshDataGridaddRecepcaoSafts();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            RefreshDataGridRecebimentos();

        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            button16.BackColor = SystemColors.ActiveCaption;
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = SystemColors.ButtonFace;
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            button15.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = SystemColors.ButtonFace;
        }

 

        private void button20_MouseHover(object sender, EventArgs e)
        {
            button20.BackColor = SystemColors.ActiveCaption;
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = SystemColors.ButtonFace;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = SystemColors.ActiveCaption;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = SystemColors.ButtonFace;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.BackColor = SystemColors.ActiveCaption;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.BackColor = SystemColors.ButtonFace;
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            button19.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = System.Drawing.Color.Cornsilk;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = SystemColors.ButtonFace;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = SystemColors.ButtonFace;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = SystemColors.ButtonFace;
        }

     

        private void button25_MouseHover(object sender, EventArgs e)
        {
            button25.BackColor = SystemColors.ActiveCaption;
        }

        private void button26_MouseHover(object sender, EventArgs e)
        {
            button26.BackColor = SystemColors.ActiveCaption;
        }

  

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            button25.BackColor = SystemColors.ButtonFace;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackColor = SystemColors.ButtonFace;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[2].DataPropertyName + ", System.String) like '%" + textBox1.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView2.Columns[2].DataPropertyName + ", System.String) like '%" + textBox12.Text.Replace("'", "''") + "%'");
            dataGridView2.DataSource = bs;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView3.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView3.Columns[2].DataPropertyName + ", System.String) like '%" + textBox6.Text.Replace("'", "''") + "%'");
            dataGridView3.DataSource = bs;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView4.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView4.Columns[2].DataPropertyName + ", System.String) like '%" + textBox8.Text.Replace("'", "''") + "%'");
            dataGridView4.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView1.Columns[3].DataPropertyName + ", System.String) like '%" + textBox2.Text.Replace("'", "''") + "%'");
            dataGridView1.DataSource = bs;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView2.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView2.Columns[3].DataPropertyName + ", System.String) like '%" + textBox11.Text.Replace("'", "''") + "%'");
            dataGridView2.DataSource = bs;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView3.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView3.Columns[3].DataPropertyName + ", System.String) like '%" + textBox5.Text.Replace("'", "''") + "%'");
            dataGridView3.DataSource = bs;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView4.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView4.Columns[3].DataPropertyName + ", System.String) like '%" + textBox7.Text.Replace("'", "''") + "%'");
            dataGridView4.DataSource = bs;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView5.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView5.Columns[2].DataPropertyName + ", System.String) like '%" + textBox10.Text.Replace("'", "''") + "%'");
            dataGridView5.DataSource = bs;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView5.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView5.Columns[3].DataPropertyName + ", System.String) like '%" + textBox13.Text.Replace("'", "''") + "%'");
            dataGridView5.DataSource = bs;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView5.DataSource;
            bs.Filter = string.Format("CONVERT(" + this.dataGridView5.Columns[4].DataPropertyName + ", System.String) like '%" + textBox9.Text.Replace("'", "''") + "%'");
            dataGridView5.DataSource = bs;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox10.Text = "";
            textBox13.Text = "";
            textBox9.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
    }
}
    