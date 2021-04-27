using Controller.Funcoes;

namespace CadastroPessoaFisica
{
    partial class FormPessoaFisica
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.txt_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Itens = new System.Windows.Forms.ListBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RG:";
            // 
            // txt_RG
            // 
            this.txt_RG.Location = new System.Drawing.Point(119, 75);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(100, 20);
            this.txt_RG.TabIndex = 2;
            // 
            // txt_CPF
            // 
            this.txt_CPF.Location = new System.Drawing.Point(119, 101);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(142, 20);
            this.txt_CPF.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.Location = new System.Drawing.Point(25, 131);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(92, 13);
            this.lbl_DataNascimento.TabIndex = 4;
            this.lbl_DataNascimento.Text = "Data Nascimento:";
            // 
            // txt_Nascimento
            // 
            this.txt_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Nascimento.Location = new System.Drawing.Point(119, 127);
            this.txt_Nascimento.Name = "txt_Nascimento";
            this.txt_Nascimento.Size = new System.Drawing.Size(100, 20);
            this.txt_Nascimento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(119, 49);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(345, 20);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Formulário de Pessoa Fisica";
            // 
            // lb_Itens
            // 
            this.lb_Itens.FormattingEnabled = true;
            this.lb_Itens.Location = new System.Drawing.Point(12, 194);
            this.lb_Itens.Name = "lb_Itens";
            this.lb_Itens.Size = new System.Drawing.Size(470, 82);
            this.lb_Itens.TabIndex = 9;
            this.lb_Itens.TabStop = false;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(225, 126);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.TabStop = false;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(407, 165);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 11;
            this.btn_Remover.TabStop = false;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(326, 165);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 12;
            this.btn_Editar.TabStop = false;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(12, 282);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(470, 124);
            this.dgv_Dados.TabIndex = 13;
            this.dgv_Dados.TabStop = false;
            // 
            // FormPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 418);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.lb_Itens);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nascimento);
            this.Controls.Add(this.lbl_DataNascimento);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.label1);
            this.Name = "FormPessoaFisica";
            this.Text = "Formulário de Pessoa Fisica";
            this.Load += new System.EventHandler(this.FormPessoaFisica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.TextBox txt_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.DateTimePicker txt_Nascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_Itens;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.DataGridView dgv_Dados;
    }
}

