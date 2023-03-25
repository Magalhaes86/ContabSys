using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabSys
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsavesettings_Click(object sender, EventArgs e)
        {
            try

            {
                

                Properties.Settings.Default.username = tbuser.Text;
                Properties.Settings.Default.password = tbpassword.Text;
                Properties.Settings.Default.basedados = Properties.Settings.Default.basedados;
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

                textBox1.Text = Properties.Settings.Default.basedados;


                tbhost.Text = Properties.Settings.Default.server;

                tbporta.Text = Properties.Settings.Default.porta;
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
