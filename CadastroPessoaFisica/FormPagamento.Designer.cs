
namespace CadastroPessoaFisica
{
    partial class FormPagamento
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
            this.txt_IdPagamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FormaPagamento = new System.Windows.Forms.TextBox();
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
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
            // txt_IdPagamento
            // 
            this.txt_IdPagamento.Location = new System.Drawing.Point(71, 13);
            this.txt_IdPagamento.Name = "txt_IdPagamento";
            this.txt_IdPagamento.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPagamento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txt_FormaPagamento
            // 
            this.txt_FormaPagamento.Location = new System.Drawing.Point(71, 56);
            this.txt_FormaPagamento.Name = "txt_FormaPagamento";
            this.txt_FormaPagamento.Size = new System.Drawing.Size(100, 20);
            this.txt_FormaPagamento.TabIndex = 3;
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(16, 97);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(385, 126);
            this.dgv_Dados.TabIndex = 4;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 273);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.txt_FormaPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdPagamento);
            this.Controls.Add(this.label1);
            this.Name = "FormPagamento";
            this.Text = "Formas de Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FormaPagamento;
        private System.Windows.Forms.DataGridView dgv_Dados;
    }
}