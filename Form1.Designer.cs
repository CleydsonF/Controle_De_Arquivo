namespace Aula_WindowsForm_01_Exercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCriarPasta = new System.Windows.Forms.TextBox();
            this.txtDeletarPasta = new System.Windows.Forms.TextBox();
            this.txtNomeDoArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriarPastas = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Pasta a ser Criada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Pasta a ser Deletada";
            // 
            // txtCriarPasta
            // 
            this.txtCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriarPasta.Location = new System.Drawing.Point(50, 43);
            this.txtCriarPasta.Name = "txtCriarPasta";
            this.txtCriarPasta.Size = new System.Drawing.Size(218, 26);
            this.txtCriarPasta.TabIndex = 2;
            // 
            // txtDeletarPasta
            // 
            this.txtDeletarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeletarPasta.Location = new System.Drawing.Point(50, 108);
            this.txtDeletarPasta.Name = "txtDeletarPasta";
            this.txtDeletarPasta.Size = new System.Drawing.Size(218, 26);
            this.txtDeletarPasta.TabIndex = 3;
            this.txtDeletarPasta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNomeDoArquivo
            // 
            this.txtNomeDoArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoArquivo.Location = new System.Drawing.Point(50, 171);
            this.txtNomeDoArquivo.Name = "txtNomeDoArquivo";
            this.txtNomeDoArquivo.Size = new System.Drawing.Size(218, 26);
            this.txtNomeDoArquivo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Arquivo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCriarPastas
            // 
            this.btnCriarPastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPastas.Location = new System.Drawing.Point(315, 26);
            this.btnCriarPastas.Name = "btnCriarPastas";
            this.btnCriarPastas.Size = new System.Drawing.Size(75, 43);
            this.btnCriarPastas.TabIndex = 6;
            this.btnCriarPastas.Text = "Criar Pasta";
            this.btnCriarPastas.UseVisualStyleBackColor = true;
            this.btnCriarPastas.Click += new System.EventHandler(this.btnCriarPasta_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(315, 91);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 43);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar Pasta";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(315, 214);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 47);
            this.btnMover.TabIndex = 9;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome da Pasta Origem";
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaOrigem.Location = new System.Drawing.Point(50, 235);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(218, 26);
            this.txtPastaOrigem.TabIndex = 11;
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPastaDestino.Location = new System.Drawing.Point(50, 300);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(218, 26);
            this.txtPastaDestino.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome da Pasta Destino";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 359);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCriarPastas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeDoArquivo);
            this.Controls.Add(this.txtDeletarPasta);
            this.Controls.Add(this.txtCriarPasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCriarPasta;
        private System.Windows.Forms.TextBox txtDeletarPasta;
        private System.Windows.Forms.TextBox txtNomeDoArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriarPastas;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPastaOrigem;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Label label5;
    }
}

