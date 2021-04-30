
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IDProduto = new System.Windows.Forms.TextBox();
            this.txt_CategoriaProduto = new System.Windows.Forms.TextBox();
            this.txt_EstoqueProduto = new System.Windows.Forms.TextBox();
            this.txt_ValorProduto = new System.Windows.Forms.TextBox();
            this.txt_NomeProduto = new System.Windows.Forms.TextBox();
            this.txt_FornecedorProduto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ESTOQUE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CATEGORIA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "FORNECEDOR:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_IDProduto
            // 
            this.txt_IDProduto.Location = new System.Drawing.Point(101, 32);
            this.txt_IDProduto.Name = "txt_IDProduto";
            this.txt_IDProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_IDProduto.TabIndex = 6;
            // 
            // txt_CategoriaProduto
            // 
            this.txt_CategoriaProduto.Location = new System.Drawing.Point(101, 175);
            this.txt_CategoriaProduto.Name = "txt_CategoriaProduto";
            this.txt_CategoriaProduto.Size = new System.Drawing.Size(181, 20);
            this.txt_CategoriaProduto.TabIndex = 7;
            // 
            // txt_EstoqueProduto
            // 
            this.txt_EstoqueProduto.Location = new System.Drawing.Point(101, 139);
            this.txt_EstoqueProduto.Name = "txt_EstoqueProduto";
            this.txt_EstoqueProduto.Size = new System.Drawing.Size(81, 20);
            this.txt_EstoqueProduto.TabIndex = 8;
            // 
            // txt_ValorProduto
            // 
            this.txt_ValorProduto.Location = new System.Drawing.Point(101, 102);
            this.txt_ValorProduto.Name = "txt_ValorProduto";
            this.txt_ValorProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorProduto.TabIndex = 9;
            // 
            // txt_NomeProduto
            // 
            this.txt_NomeProduto.Location = new System.Drawing.Point(101, 66);
            this.txt_NomeProduto.Name = "txt_NomeProduto";
            this.txt_NomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeProduto.TabIndex = 10;
            // 
            // txt_FornecedorProduto
            // 
            this.txt_FornecedorProduto.Location = new System.Drawing.Point(101, 211);
            this.txt_FornecedorProduto.Name = "txt_FornecedorProduto";
            this.txt_FornecedorProduto.Size = new System.Drawing.Size(271, 20);
            this.txt_FornecedorProduto.TabIndex = 11;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_FornecedorProduto);
            this.Controls.Add(this.txt_NomeProduto);
            this.Controls.Add(this.txt_ValorProduto);
            this.Controls.Add(this.txt_EstoqueProduto);
            this.Controls.Add(this.txt_CategoriaProduto);
            this.Controls.Add(this.txt_IDProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProduto";
            this.Text = "PRODUTO";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IDProduto;
        private System.Windows.Forms.TextBox txt_CategoriaProduto;
        private System.Windows.Forms.TextBox txt_EstoqueProduto;
        private System.Windows.Forms.TextBox txt_ValorProduto;
        private System.Windows.Forms.TextBox txt_NomeProduto;
        private System.Windows.Forms.TextBox txt_FornecedorProduto;
    }
}