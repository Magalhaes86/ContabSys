﻿
namespace ContabSys
{
    partial class addseleccaoEarquivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addseleccaoEarquivo));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbnif = new System.Windows.Forms.TextBox();
            this.tbnomecliente = new System.Windows.Forms.TextBox();
            this.tbobs = new System.Windows.Forms.TextBox();
            this.tbcodcliente = new System.Windows.Forms.TextBox();
            this.tbidcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // tbnif
            // 
            this.tbnif.Location = new System.Drawing.Point(291, 46);
            this.tbnif.Name = "tbnif";
            this.tbnif.ReadOnly = true;
            this.tbnif.Size = new System.Drawing.Size(294, 20);
            this.tbnif.TabIndex = 31;
            // 
            // tbnomecliente
            // 
            this.tbnomecliente.Location = new System.Drawing.Point(291, 16);
            this.tbnomecliente.Name = "tbnomecliente";
            this.tbnomecliente.ReadOnly = true;
            this.tbnomecliente.Size = new System.Drawing.Size(294, 20);
            this.tbnomecliente.TabIndex = 32;
            // 
            // tbobs
            // 
            this.tbobs.Location = new System.Drawing.Point(44, 99);
            this.tbobs.Multiline = true;
            this.tbobs.Name = "tbobs";
            this.tbobs.Size = new System.Drawing.Size(541, 77);
            this.tbobs.TabIndex = 33;
            // 
            // tbcodcliente
            // 
            this.tbcodcliente.Location = new System.Drawing.Point(116, 13);
            this.tbcodcliente.Name = "tbcodcliente";
            this.tbcodcliente.ReadOnly = true;
            this.tbcodcliente.Size = new System.Drawing.Size(112, 20);
            this.tbcodcliente.TabIndex = 34;
            // 
            // tbidcliente
            // 
            this.tbidcliente.Location = new System.Drawing.Point(116, 46);
            this.tbidcliente.Name = "tbidcliente";
            this.tbidcliente.ReadOnly = true;
            this.tbidcliente.Size = new System.Drawing.Size(112, 20);
            this.tbidcliente.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nif:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Obs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cod. Lançamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Cliente:";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Tomato;
            this.btncancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.Location = new System.Drawing.Point(512, 191);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(73, 33);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Maroon;
            this.btnRemover.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(511, 253);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(74, 33);
            this.btnRemover.TabIndex = 21;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnUPDATE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.Location = new System.Drawing.Point(323, 187);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(92, 33);
            this.btnUPDATE.TabIndex = 22;
            this.btnUPDATE.Text = "Update";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(187, 228);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(243, 43);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Fazer Lançamento para outra entidade";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Green;
            this.btnGravar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Location = new System.Drawing.Point(206, 187);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(92, 33);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // addseleccaoEarquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 314);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbnif);
            this.Controls.Add(this.tbnomecliente);
            this.Controls.Add(this.tbobs);
            this.Controls.Add(this.tbcodcliente);
            this.Controls.Add(this.tbidcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addseleccaoEarquivo";
            this.Text = "Selecção e Arquivo";
            this.Load += new System.EventHandler(this.addseleccaoEarquivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox tbnif;
        internal System.Windows.Forms.TextBox tbnomecliente;
        internal System.Windows.Forms.TextBox tbobs;
        internal System.Windows.Forms.TextBox tbcodcliente;
        internal System.Windows.Forms.TextBox tbidcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.Button btnRemover;
        internal System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnGravar;
    }
}