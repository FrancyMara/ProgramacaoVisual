
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
            this.SuspendLayout();
            // 
            // FormProduto
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_CategoriaProduto;
        private System.Windows.Forms.TextBox txt_EstoqueProduto;
        private System.Windows.Forms.TextBox txt_ValorProduto;
        private System.Windows.Forms.TextBox txt_NomeProduto;
        private System.Windows.Forms.TextBox txt_FornecedorProduto;
        private System.Windows.Forms.DataGridView dgv_Dados;
    }
}