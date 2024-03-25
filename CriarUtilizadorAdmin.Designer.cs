
namespace ContabSys
{
    partial class CriarUtilizadorAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarUtilizadorAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbldelete = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.lbldelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnnovo);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btngravar);
            this.panel1.Controls.Add(this.Atualizar);
            this.panel1.Controls.Add(this.tbid);
            this.panel1.Controls.Add(this.tbpassword);
            this.panel1.Controls.Add(this.tbuser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 175);
            this.panel1.TabIndex = 0;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btncancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncancelar.Location = new System.Drawing.Point(416, 47);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(84, 28);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            this.btncancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            this.btncancelar.MouseHover += new System.EventHandler(this.btncancelar_MouseHover);
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.Location = new System.Drawing.Point(380, 88);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(109, 15);
            this.lbldelete.TabIndex = 58;
            this.lbldelete.Text = "Eliminar o Registo";
            this.lbldelete.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ContabSys.Properties.Resources.delete_icon_png_16;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(451, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 57;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnovo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnnovo.Location = new System.Drawing.Point(36, 44);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(84, 28);
            this.btnnovo.TabIndex = 3;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            this.btnnovo.MouseLeave += new System.EventHandler(this.btnnovo_MouseLeave);
            this.btnnovo.MouseHover += new System.EventHandler(this.btnnovo_MouseHover);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btneditar.Enabled = false;
            this.btneditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btneditar.Location = new System.Drawing.Point(230, 44);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(84, 28);
            this.btneditar.TabIndex = 6;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            this.btneditar.MouseLeave += new System.EventHandler(this.btneditar_MouseLeave);
            this.btneditar.MouseHover += new System.EventHandler(this.btneditar_MouseHover);
            // 
            // btngravar
            // 
            this.btngravar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btngravar.Enabled = false;
            this.btngravar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btngravar.Location = new System.Drawing.Point(131, 44);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(84, 28);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = false;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            this.btngravar.MouseLeave += new System.EventHandler(this.btngravar_MouseLeave);
            this.btngravar.MouseHover += new System.EventHandler(this.btngravar_MouseHover);
            // 
            // Atualizar
            // 
            this.Atualizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Atualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Atualizar.Location = new System.Drawing.Point(131, 44);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(84, 28);
            this.Atualizar.TabIndex = 7;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = false;
            this.Atualizar.Visible = false;
            this.Atualizar.Click += new System.EventHandler(this.btnupdate_Click);
            this.Atualizar.MouseLeave += new System.EventHandler(this.Atualizar_MouseLeave);
            this.Atualizar.MouseHover += new System.EventHandler(this.Atualizar_MouseHover);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(55, 12);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(83, 20);
            this.tbid.TabIndex = 4;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(100, 124);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(258, 20);
            this.tbpassword.TabIndex = 2;
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(100, 89);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(258, 20);
            this.tbuser.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 306);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CriarUtilizadorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarUtilizadorAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Utilizador Administrador";
            this.Load += new System.EventHandler(this.CriarUtilizadorAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Label lbldelete;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button btncancelar;
    }
}