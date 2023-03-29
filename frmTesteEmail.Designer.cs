
namespace ContabSys
{
    partial class frmTesteEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteEmail));
            this.grbDePara = new System.Windows.Forms.GroupBox();
            this.txtAssuntoTitulo = new System.Windows.Forms.TextBox();
            this.txtEnviarPara = new System.Windows.Forms.TextBox();
            this.lblSubjectLine = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtEnviadoPor = new System.Windows.Forms.TextBox();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.grbDePara.SuspendLayout();
            this.grpMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDePara
            // 
            this.grbDePara.Controls.Add(this.txtEnviadoPor);
            this.grbDePara.Controls.Add(this.lblRemetente);
            this.grbDePara.Controls.Add(this.txtAssuntoTitulo);
            this.grbDePara.Controls.Add(this.txtEnviarPara);
            this.grbDePara.Controls.Add(this.lblSubjectLine);
            this.grbDePara.Controls.Add(this.lblDestinatario);
            this.grbDePara.Location = new System.Drawing.Point(21, 12);
            this.grbDePara.Name = "grbDePara";
            this.grbDePara.Size = new System.Drawing.Size(485, 100);
            this.grbDePara.TabIndex = 5;
            this.grbDePara.TabStop = false;
            this.grbDePara.Text = "De: Para";
            // 
            // txtAssuntoTitulo
            // 
            this.txtAssuntoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssuntoTitulo.Location = new System.Drawing.Point(79, 70);
            this.txtAssuntoTitulo.Name = "txtAssuntoTitulo";
            this.txtAssuntoTitulo.Size = new System.Drawing.Size(399, 21);
            this.txtAssuntoTitulo.TabIndex = 5;
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviarPara.Location = new System.Drawing.Point(79, 45);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(399, 21);
            this.txtEnviarPara.TabIndex = 3;
            this.txtEnviarPara.Text = "marcos.magalhaes@samsys.pt";
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(20, 74);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(48, 13);
            this.lblSubjectLine.TabIndex = 2;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(37, 48);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Para:";
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.txtMensagem);
            this.grpMensagem.Location = new System.Drawing.Point(21, 119);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(485, 235);
            this.grpMensagem.TabIndex = 6;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(6, 20);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(472, 197);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(424, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.Location = new System.Drawing.Point(27, 363);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 33);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Add Attachment";
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.Enabled = false;
            this.txtEnviadoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviadoPor.Location = new System.Drawing.Point(79, 19);
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(399, 21);
            this.txtEnviadoPor.TabIndex = 7;
            this.txtEnviadoPor.Text = "marcosmagalhaes86@outlook.pt";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(44, 23);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(24, 13);
            this.lblRemetente.TabIndex = 6;
            this.lblRemetente.Text = "De:";
            // 
            // frmTesteEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 408);
            this.Controls.Add(this.grbDePara);
            this.Controls.Add(this.grpMensagem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Email";
            this.Load += new System.EventHandler(this.frmTesteEmail_Load_1);
            this.grbDePara.ResumeLayout(false);
            this.grbDePara.PerformLayout();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grbDePara;
        internal System.Windows.Forms.TextBox txtAssuntoTitulo;
        internal System.Windows.Forms.TextBox txtEnviarPara;
        internal System.Windows.Forms.Label lblSubjectLine;
        internal System.Windows.Forms.Label lblDestinatario;
        internal System.Windows.Forms.GroupBox grpMensagem;
        internal System.Windows.Forms.TextBox txtMensagem;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnEnviar;
        internal System.Windows.Forms.OpenFileDialog ofd1;
        internal System.Windows.Forms.TextBox txtEnviadoPor;
        internal System.Windows.Forms.Label lblRemetente;
    }
}