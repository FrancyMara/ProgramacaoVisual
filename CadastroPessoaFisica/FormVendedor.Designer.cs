
namespace CadastroPessoaFisica
{
    partial class FormVendedor
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
            this.txt_IdVendedor = new System.Windows.Forms.TextBox();
            this.txt_NomeVendedor = new System.Windows.Forms.TextBox();
            this.txt_CpfVendedor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_Dados = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // txt_IdVendedor
            // 
            this.txt_IdVendedor.Location = new System.Drawing.Point(58, 10);
            this.txt_IdVendedor.Name = "txt_IdVendedor";
            this.txt_IdVendedor.Size = new System.Drawing.Size(100, 20);
            this.txt_IdVendedor.TabIndex = 3;
            // 
            // txt_NomeVendedor
            // 
            this.txt_NomeVendedor.Location = new System.Drawing.Point(58, 46);
            this.txt_NomeVendedor.Name = "txt_NomeVendedor";
            this.txt_NomeVendedor.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeVendedor.TabIndex = 4;
            // 
            // txt_CpfVendedor
            // 
            this.txt_CpfVendedor.Location = new System.Drawing.Point(58, 85);
            this.txt_CpfVendedor.Name = "txt_CpfVendedor";
            this.txt_CpfVendedor.Size = new System.Drawing.Size(100, 20);
            this.txt_CpfVendedor.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_SalvarVendedor);
            // 
            // dgv_Dados
            // 
            this.dgv_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dados.Location = new System.Drawing.Point(16, 134);
            this.dgv_Dados.Name = "dgv_Dados";
            this.dgv_Dados.Size = new System.Drawing.Size(566, 214);
            this.dgv_Dados.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_EditarVendedor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(507, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_RemoverVendedor);
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_Dados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_CpfVendedor);
            this.Controls.Add(this.txt_NomeVendedor);
            this.Controls.Add(this.txt_IdVendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVendedor";
            this.Text = "FormVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdVendedor;
        private System.Windows.Forms.TextBox txt_NomeVendedor;
        private System.Windows.Forms.TextBox txt_CpfVendedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Dados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}