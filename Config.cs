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
namespace ContabSys
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }


        MySqlConnection connection = new MySqlConnection(@"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password);
        MySqlCommand command;


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsavesettings_Click(object sender, EventArgs e)
        {
            try

            {
                

                Properties.Settings.Default.username = tbuser.Text;
                Properties.Settings.Default.password = tbpassword.Text;
                // Properties.Settings.Default.basedados = Properties.Settings.Default.basedados;
                Properties.Settings.Default.basedados = tbbasedados.Text;
                Properties.Settings.Default.server = tbhost.Text;
                Properties.Settings.Default.porta = tbporta.Text;
                Properties.Settings.Default.Save();
              
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                tbuser.Text = Properties.Settings.Default.username;

                tbpassword.Text = Properties.Settings.Default.password;

                tbbasedados.Text = Properties.Settings.Default.basedados;


                tbhost.Text = Properties.Settings.Default.server;

                tbporta.Text = Properties.Settings.Default.porta;
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }


      
            

        


        private void button3_Click(object sender, EventArgs e)
        {


            string constring = @"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password + ";convertzerodatetime=true";

       

            string file = textBox3.Text+"\\ContabSysDB.sql";
          //  string file = file1+file2;
            // string file = textBox1.Text+"\\ContabSysDB.sql";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }

        // Antigo Botao Guardar

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    string constring = @"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password + ";convertzerodatetime=true";

        //    //string file = textBox1.Text + "\\ContabSysDB.sql";
        //    string file = textBox3.Text + "\\ContabSysDB.sql";



        //    //string file2 = tbnovaloc.Text;
        //    //string file3 = "ContabSysDB.sql";
        //    //string file = file2 + file3;


        //    using (MySqlConnection conn = new MySqlConnection(constring))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            using (MySqlBackup mb = new MySqlBackup(cmd))
        //            {
        //                cmd.Connection = conn;
        //                conn.Open();
        //                mb.ExportToFile(file);
        //                conn.Close();
        //            }
        //        }
        //    }
        //}


       
      
          

       

        private void button5_Click(object sender, EventArgs e)
        {

            string diretoria = textBox4.Text;
            textBox4.Text = diretoria;

            string cadena = @"server=" + Properties.Settings.Default.server + ";database=" + Properties.Settings.Default.basedados + ";port=" + Properties.Settings.Default.porta + ";userid=" + Properties.Settings.Default.username + ";password=" + Properties.Settings.Default.password + ";convertzerodatetime=true";
            MySqlConnection conexion = new MySqlConnection(cadena);
            MySqlCommand comando = new MySqlCommand();
            MySqlBackup respaldo = new MySqlBackup(comando);

            comando.Connection = conexion;
            conexion.Open();

            respaldo.ImportFromFile(diretoria);
            conexion.Close();
            MessageBox.Show("Base de dados restaurada com sucesso");





        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox4.Text = ofd.FileName;
              
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

       

        private void btngravardadosemail_Click(object sender, EventArgs e)
        {
            try

            {


                Properties.Settings.Default.SmtpServer = tbsmtpserver.Text;
                Properties.Settings.Default.MailAddress = tbemail.Text;
                Properties.Settings.Default.PortaEmail = tbemailporta.Text;
                Properties.Settings.Default.emailUser = tbemailuser.Text;
                Properties.Settings.Default.emailPassword = tbemailpassword.Text;
                Properties.Settings.Default.Save();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnobteremail_Click(object sender, EventArgs e)
        {
            try

            {

                tbsmtpserver.Text = Properties.Settings.Default.SmtpServer;
                tbemail.Text = Properties.Settings.Default.MailAddress;
                tbemailporta.Text = Properties.Settings.Default.PortaEmail;
                tbemailuser.Text = Properties.Settings.Default.emailUser;
                tbemailpassword.Text = Properties.Settings.Default.emailPassword;
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CriarUtilizadorAdmin CriarUtilizadorAdmin = new CriarUtilizadorAdmin();
            CriarUtilizadorAdmin.ShowDialog();
        }
    }
    }


