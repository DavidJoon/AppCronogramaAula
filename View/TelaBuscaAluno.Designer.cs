
namespace AppCronogramaAula.View
{
    partial class TelaBuscaAluno
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesqNomAlu = new System.Windows.Forms.Button();
            this.textBoxPesqNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExcAlu = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonPesqCodAlu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(95, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.buttonPesqNomAlu);
            this.tabPage2.Controls.Add(this.textBoxPesqNome);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.email,
            this.fone});
            this.dataGridView1.Location = new System.Drawing.Point(6, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 160;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.Width = 160;
            // 
            // fone
            // 
            this.fone.HeaderText = "Fone";
            this.fone.Name = "fone";
            this.fone.Width = 80;
            // 
            // buttonPesqNomAlu
            // 
            this.buttonPesqNomAlu.BackColor = System.Drawing.Color.Orange;
            this.buttonPesqNomAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesqNomAlu.Location = new System.Drawing.Point(434, 33);
            this.buttonPesqNomAlu.Name = "buttonPesqNomAlu";
            this.buttonPesqNomAlu.Size = new System.Drawing.Size(75, 23);
            this.buttonPesqNomAlu.TabIndex = 6;
            this.buttonPesqNomAlu.Text = "Pesquisar";
            this.buttonPesqNomAlu.UseVisualStyleBackColor = false;
            this.buttonPesqNomAlu.Click += new System.EventHandler(this.buttonPesqNomAlu_Click);
            // 
            // textBoxPesqNome
            // 
            this.textBoxPesqNome.Location = new System.Drawing.Point(177, 33);
            this.textBoxPesqNome.Name = "textBoxPesqNome";
            this.textBoxPesqNome.Size = new System.Drawing.Size(251, 23);
            this.textBoxPesqNome.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Digite o Nome do Aluno:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.buttonExcAlu);
            this.tabPage1.Controls.Add(this.buttonAlterar);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonPesqCodAlu);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(108, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Código:";
            // 
            // buttonExcAlu
            // 
            this.buttonExcAlu.BackColor = System.Drawing.Color.Brown;
            this.buttonExcAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcAlu.Location = new System.Drawing.Point(407, 218);
            this.buttonExcAlu.Name = "buttonExcAlu";
            this.buttonExcAlu.Size = new System.Drawing.Size(75, 23);
            this.buttonExcAlu.TabIndex = 14;
            this.buttonExcAlu.Text = "Excluir";
            this.buttonExcAlu.UseVisualStyleBackColor = false;
            this.buttonExcAlu.Click += new System.EventHandler(this.buttonExcAlu_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Location = new System.Drawing.Point(311, 219);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 13;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 23);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 23);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(278, 23);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome:";
            // 
            // buttonPesqCodAlu
            // 
            this.buttonPesqCodAlu.BackColor = System.Drawing.Color.Orange;
            this.buttonPesqCodAlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesqCodAlu.Location = new System.Drawing.Point(311, 25);
            this.buttonPesqCodAlu.Name = "buttonPesqCodAlu";
            this.buttonPesqCodAlu.Size = new System.Drawing.Size(75, 23);
            this.buttonPesqCodAlu.TabIndex = 3;
            this.buttonPesqCodAlu.Text = "Pesquisar";
            this.buttonPesqCodAlu.UseVisualStyleBackColor = false;
            this.buttonPesqCodAlu.Click += new System.EventHandler(this.buttonPesqCodAlu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gerenciamento de Dados dos Alunos";
            // 
            // TelaBuscaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(709, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaBuscaAluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaBuscaAluno";
            this.Load += new System.EventHandler(this.TelaBuscaAluno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonPesqCodAlu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcAlu;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPesqNomAlu;
        private System.Windows.Forms.TextBox textBoxPesqNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn fone;
    }
}