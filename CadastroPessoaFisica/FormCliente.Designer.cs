
namespace CadastroPessoaFisica
{
    partial class FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TelefoneCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EmailCliente = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Location = new System.Drawing.Point(65, 10);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(129, 20);
            this.txt_IdCliente.TabIndex = 1;
            this.txt_IdCliente.Leave += new System.EventHandler(this.CarregarCadastroLeaveId);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Location = new System.Drawing.Point(65, 42);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(254, 20);
            this.txt_NomeCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // txt_TelefoneCliente
            // 
            this.txt_TelefoneCliente.Location = new System.Drawing.Point(65, 72);
            this.txt_TelefoneCliente.Name = "txt_TelefoneCliente";
            this.txt_TelefoneCliente.Size = new System.Drawing.Size(254, 20);
            this.txt_TelefoneCliente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail:";
            // 
            // txt_EmailCliente
            // 
            this.txt_EmailCliente.Location = new System.Drawing.Point(65, 105);
            this.txt_EmailCliente.Name = "txt_EmailCliente";
            this.txt_EmailCliente.Size = new System.Drawing.Size(254, 20);
            this.txt_EmailCliente.TabIndex = 7;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(244, 131);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 8;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(16, 176);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(371, 158);
            this.dgv_Dados.TabIndex = 9;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(222, 340);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 10;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(312, 340);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 11;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 393);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_EmailCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_TelefoneCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TelefoneCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EmailCliente;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView dgv_Dados;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Remover;
    }
}