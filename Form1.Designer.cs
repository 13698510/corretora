
namespace INSURANCES
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dginsurance = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSEGURADORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLIMPAR = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.SEGURADORA = new System.Windows.Forms.Label();
            this.ATIVO = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btALTERAR = new System.Windows.Forms.Button();
            this.btEXCLUIR = new System.Windows.Forms.Button();
            this.btSALVAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dginsurance)).BeginInit();
            this.SuspendLayout();
            // 
            // dginsurance
            // 
            this.dginsurance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dginsurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNOME,
            this.ColumnCPF,
            this.ColumnSEGURADORA,
            this.ColumnATIVO});
            this.dginsurance.Location = new System.Drawing.Point(46, 208);
            this.dginsurance.Name = "dginsurance";
            this.dginsurance.Size = new System.Drawing.Size(578, 150);
            this.dginsurance.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 50;
            // 
            // ColumnNOME
            // 
            this.ColumnNOME.HeaderText = "NOME";
            this.ColumnNOME.Name = "ColumnNOME";
            this.ColumnNOME.Width = 200;
            // 
            // ColumnCPF
            // 
            this.ColumnCPF.HeaderText = "CPF";
            this.ColumnCPF.Name = "ColumnCPF";
            // 
            // ColumnSEGURADORA
            // 
            this.ColumnSEGURADORA.HeaderText = "SEGURADORA";
            this.ColumnSEGURADORA.Name = "ColumnSEGURADORA";
            // 
            // ColumnATIVO
            // 
            this.ColumnATIVO.HeaderText = "ATIVO";
            this.ColumnATIVO.Name = "ColumnATIVO";
            this.ColumnATIVO.Width = 50;
            // 
            // btLIMPAR
            // 
            this.btLIMPAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btLIMPAR.ForeColor = System.Drawing.Color.Black;
            this.btLIMPAR.Location = new System.Drawing.Point(87, 152);
            this.btLIMPAR.Name = "btLIMPAR";
            this.btLIMPAR.Size = new System.Drawing.Size(75, 23);
            this.btLIMPAR.TabIndex = 1;
            this.btLIMPAR.Text = "LIMPAR";
            this.btLIMPAR.UseVisualStyleBackColor = false;
            this.btLIMPAR.Click += new System.EventHandler(this.LIMPAR_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(70, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Location = new System.Drawing.Point(70, 33);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(39, 13);
            this.NOME.TabIndex = 3;
            this.NOME.Text = "NOME";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(70, 62);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 4;
            this.CPF.Text = "CPF";
            // 
            // SEGURADORA
            // 
            this.SEGURADORA.AutoSize = true;
            this.SEGURADORA.Location = new System.Drawing.Point(70, 86);
            this.SEGURADORA.Name = "SEGURADORA";
            this.SEGURADORA.Size = new System.Drawing.Size(83, 13);
            this.SEGURADORA.TabIndex = 5;
            this.SEGURADORA.Text = "SEGURADORA";
            // 
            // ATIVO
            // 
            this.ATIVO.AutoSize = true;
            this.ATIVO.Location = new System.Drawing.Point(70, 113);
            this.ATIVO.Name = "ATIVO";
            this.ATIVO.Size = new System.Drawing.Size(39, 13);
            this.ATIVO.TabIndex = 6;
            this.ATIVO.Text = "ATIVO";
            this.ATIVO.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(112, 106);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // btALTERAR
            // 
            this.btALTERAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btALTERAR.Location = new System.Drawing.Point(184, 152);
            this.btALTERAR.Name = "btALTERAR";
            this.btALTERAR.Size = new System.Drawing.Size(75, 23);
            this.btALTERAR.TabIndex = 12;
            this.btALTERAR.Text = "ALTERAR";
            this.btALTERAR.UseVisualStyleBackColor = false;
            this.btALTERAR.Click += new System.EventHandler(this.btALTERAR_Click);
            // 
            // btEXCLUIR
            // 
            this.btEXCLUIR.BackColor = System.Drawing.Color.Red;
            this.btEXCLUIR.Location = new System.Drawing.Point(292, 152);
            this.btEXCLUIR.Name = "btEXCLUIR";
            this.btEXCLUIR.Size = new System.Drawing.Size(75, 23);
            this.btEXCLUIR.TabIndex = 13;
            this.btEXCLUIR.Text = "EXCLUIR";
            this.btEXCLUIR.UseVisualStyleBackColor = false;
            this.btEXCLUIR.Click += new System.EventHandler(this.brEXCLUIR_Click);
            // 
            // btSALVAR
            // 
            this.btSALVAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSALVAR.Location = new System.Drawing.Point(392, 152);
            this.btSALVAR.Name = "btSALVAR";
            this.btSALVAR.Size = new System.Drawing.Size(75, 23);
            this.btSALVAR.TabIndex = 14;
            this.btSALVAR.Text = "SALVAR";
            this.btSALVAR.UseVisualStyleBackColor = false;
            this.btSALVAR.Click += new System.EventHandler(this.btSALVAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 379);
            this.Controls.Add(this.btSALVAR);
            this.Controls.Add(this.btEXCLUIR);
            this.Controls.Add(this.btALTERAR);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ATIVO);
            this.Controls.Add(this.SEGURADORA);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btLIMPAR);
            this.Controls.Add(this.dginsurance);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Insurance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dginsurance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dginsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSEGURADORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnATIVO;
        private System.Windows.Forms.Button btLIMPAR;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label SEGURADORA;
        private System.Windows.Forms.Label ATIVO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btALTERAR;
        private System.Windows.Forms.Button btEXCLUIR;
        private System.Windows.Forms.Button btSALVAR;
    }
}

