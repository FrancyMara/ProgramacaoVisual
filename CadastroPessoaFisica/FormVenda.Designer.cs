
namespace CadastroPessoaFisica
{
    partial class FormVenda
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
            this.dgv_ItensVenda = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CodigoBarras = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TotalVenda = new System.Windows.Forms.Label();
            this.combo_Cliente = new System.Windows.Forms.ComboBox();
            this.btn_SalvarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ItensVenda
            // 
            this.dgv_ItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItensVenda.Location = new System.Drawing.Point(12, 148);
            this.dgv_ItensVenda.Name = "dgv_ItensVenda";
            this.dgv_ItensVenda.Size = new System.Drawing.Size(236, 93);
            this.dgv_ItensVenda.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL:";
            // 
            // txt_CodigoBarras
            // 
            this.txt_CodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoBarras.Location = new System.Drawing.Point(241, 13);
            this.txt_CodigoBarras.Name = "txt_CodigoBarras";
            this.txt_CodigoBarras.Size = new System.Drawing.Size(311, 62);
            this.txt_CodigoBarras.TabIndex = 3;
            this.txt_CodigoBarras.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Códido de Barras:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_AdicionarProdutoVenda);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente:";
            this.label4.UseWaitCursor = true;
            // 
            // lbl_TotalVenda
            // 
            this.lbl_TotalVenda.AutoSize = true;
            this.lbl_TotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalVenda.Location = new System.Drawing.Point(561, 369);
            this.lbl_TotalVenda.Name = "lbl_TotalVenda";
            this.lbl_TotalVenda.Size = new System.Drawing.Size(0, 31);
            this.lbl_TotalVenda.TabIndex = 8;
            // 
            // combo_Cliente
            // 
            this.combo_Cliente.FormattingEnabled = true;
            this.combo_Cliente.Location = new System.Drawing.Point(241, 81);
            this.combo_Cliente.Name = "combo_Cliente";
            this.combo_Cliente.Size = new System.Drawing.Size(311, 21);
            this.combo_Cliente.TabIndex = 9;
            // 
            // btn_SalvarVenda
            // 
            this.btn_SalvarVenda.Location = new System.Drawing.Point(277, 196);
            this.btn_SalvarVenda.Name = "btn_SalvarVenda";
            this.btn_SalvarVenda.Size = new System.Drawing.Size(196, 45);
            this.btn_SalvarVenda.TabIndex = 10;
            this.btn_SalvarVenda.Text = "CONFIRMAR";
            this.btn_SalvarVenda.UseVisualStyleBackColor = true;
            this.btn_SalvarVenda.Click += new System.EventHandler(this.btn_SalvarVenda_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 288);
            this.Controls.Add(this.btn_SalvarVenda);
            this.Controls.Add(this.combo_Cliente);
            this.Controls.Add(this.lbl_TotalVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CodigoBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_ItensVenda);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ItensVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_CodigoBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TotalVenda;
        private System.Windows.Forms.ComboBox combo_Cliente;
        private System.Windows.Forms.Button btn_SalvarVenda;
    }
}