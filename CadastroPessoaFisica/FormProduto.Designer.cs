
namespace CadastroPessoaFisica
{
    partial class FormProduto
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IdProduto = new System.Windows.Forms.TextBox();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.txt_precoProduto = new System.Windows.Forms.TextBox();
            this.txt_estoqueProduto = new System.Windows.Forms.TextBox();
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.combo_Categoria = new System.Windows.Forms.ComboBox();
            this.combo_Fornecedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estoque:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fornecedor:";
            // 
            // txt_IdProduto
            // 
            this.txt_IdProduto.Location = new System.Drawing.Point(135, 22);
            this.txt_IdProduto.Name = "txt_IdProduto";
            this.txt_IdProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_IdProduto.TabIndex = 6;
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(389, 26);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(319, 20);
            this.txt_nomeProduto.TabIndex = 7;
            // 
            // txt_precoProduto
            // 
            this.txt_precoProduto.Location = new System.Drawing.Point(135, 58);
            this.txt_precoProduto.Name = "txt_precoProduto";
            this.txt_precoProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_precoProduto.TabIndex = 8;
            // 
            // txt_estoqueProduto
            // 
            this.txt_estoqueProduto.Location = new System.Drawing.Point(389, 64);
            this.txt_estoqueProduto.Name = "txt_estoqueProduto";
            this.txt_estoqueProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_estoqueProduto.TabIndex = 9;
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(62, 156);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(646, 150);
            this.dgv_Dados.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(307, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "REMOVER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // combo_Categoria
            // 
            this.combo_Categoria.FormattingEnabled = true;
            this.combo_Categoria.Location = new System.Drawing.Point(135, 93);
            this.combo_Categoria.Name = "combo_Categoria";
            this.combo_Categoria.Size = new System.Drawing.Size(163, 21);
            this.combo_Categoria.TabIndex = 16;
            this.combo_Categoria.Text = "Selecione uma categoria";
            // 
            // combo_Fornecedor
            // 
            this.combo_Fornecedor.FormattingEnabled = true;
            this.combo_Fornecedor.Location = new System.Drawing.Point(389, 96);
            this.combo_Fornecedor.Name = "combo_Fornecedor";
            this.combo_Fornecedor.Size = new System.Drawing.Size(319, 21);
            this.combo_Fornecedor.TabIndex = 17;
            this.combo_Fornecedor.Text = "Selecione um fornecedor";
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 373);
            this.Controls.Add(this.combo_Fornecedor);
            this.Controls.Add(this.combo_Categoria);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.txt_estoqueProduto);
            this.Controls.Add(this.txt_precoProduto);
            this.Controls.Add(this.txt_nomeProduto);
            this.Controls.Add(this.txt_IdProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IdProduto;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.TextBox txt_precoProduto;
        private System.Windows.Forms.TextBox txt_estoqueProduto;
        private System.Windows.Forms.DataGridView dgv_Dados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox combo_Categoria;
        private System.Windows.Forms.ComboBox combo_Fornecedor;
    }
}