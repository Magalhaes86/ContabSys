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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }
        // SqlCommand cmd;
        // SqlConnection cn;
        // SqlDataReader dr;

        MySqlConnection connection; 
        MySqlCommand command;
        MySqlDataReader dr;

        private void password_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);
            connection.Open();
            txtpassword.UseSystemPasswordChar = true;
        }









        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                command = new MySqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", connection);
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Config Config = new Config();
                    Config.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Não foi encontrada nenhuma conta com este username e esta password ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {

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

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {
            btnlogin.BackColor = SystemColors.ActiveCaption;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.BackColor = SystemColors.ButtonFace;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == true)
            {
                txtpassword.UseSystemPasswordChar = false;
                //  button1.Text = "Hide";
                button2.Visible = false;
                button1.Visible = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                // button1.Text = "Show";
                button2.Visible = true;
                button1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == true)
            {
                txtpassword.UseSystemPasswordChar = false;
                //  button1.Text = "Hide";
                button2.Visible = false;
                button1.Visible = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                // button1.Text = "Show";
                button2.Visible = true;
                button1.Visible = false;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

    

