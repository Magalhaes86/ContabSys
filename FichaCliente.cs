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

namespace ContabSys
{
    public partial class FichaCliente : Form
    {
        public FichaCliente()
        {
            InitializeComponent();
        }



        MySqlConnection connection = new MySqlConnection(@"server=localhost;database=ContabSysDB;port=3308;userid=root;password=xd");


        MySqlCommand command;


        private void FichaCliente_Load(object sender, EventArgs e)
        {

       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListagemClientes frmclientes = new ListagemClientes();
            frmclientes.ShowDialog();
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

        }

        public void RefreshDataGridaddLancamentos()
        {
            string selectQuery = "SELECT * FROM lancamentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView3.DataSource = table;

        }

        public void RefreshDataGridRecepcaoDocumentos()
        {
            string selectQuery = "SELECT * FROM recepcaodocumentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }

        public void RefreshDataGridRecebimentos()
        {
            string selectQuery = "SELECT * FROM recebimentos WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView5.DataSource = table;

        }


        public void RefreshDataGridSelecaoEArguivo()
        {
            string selectQuery = "SELECT * FROM selecaoearquivo WHERE CodCliente =" + int.Parse(tbId.Text);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView2.DataSource = table;

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

        private void button21_Click(object sender, EventArgs e)
        {
            // Atualizar os datagrid este comando é para ficar no load, para já nao pode pq obriga a ter um ID do cliente 
            RefreshALLDataGrid();
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
    }
}
    