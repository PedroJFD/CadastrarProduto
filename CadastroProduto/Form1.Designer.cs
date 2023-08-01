namespace CadastroProduto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tx_cod = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tx_descricao = new TextBox();
            label4 = new Label();
            tx_preco = new TextBox();
            label5 = new Label();
            tx_lucro = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            tx_venda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(165, 36);
            label1.Name = "label1";
            label1.Size = new Size(284, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produto";
            // 
            // tx_cod
            // 
            tx_cod.Location = new Point(157, 106);
            tx_cod.Name = "tx_cod";
            tx_cod.Size = new Size(100, 23);
            tx_cod.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 109);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 109);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 4;
            label3.Text = "Descricao:";
            // 
            // tx_descricao
            // 
            tx_descricao.Location = new Point(447, 106);
            tx_descricao.Name = "tx_descricao";
            tx_descricao.Size = new Size(100, 23);
            tx_descricao.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 6;
            label4.Text = "Preco de Aquisicao:";
            // 
            // tx_preco
            // 
            tx_preco.Location = new Point(157, 161);
            tx_preco.Name = "tx_preco";
            tx_preco.Size = new Size(100, 23);
            tx_preco.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(377, 164);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Lucro %:";
            // 
            // tx_lucro
            // 
            tx_lucro.Location = new Point(447, 161);
            tx_lucro.Name = "tx_lucro";
            tx_lucro.Size = new Size(100, 23);
            tx_lucro.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(310, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 9;
            button1.Text = "Novo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 216);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 10;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(472, 216);
            button3.Name = "button3";
            button3.Size = new Size(75, 36);
            button3.TabIndex = 11;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(506, 150);
            dataGridView1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 219);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 14;
            label6.Text = "Valor de Venda:";
            // 
            // tx_venda
            // 
            tx_venda.Location = new Point(157, 216);
            tx_venda.Name = "tx_venda";
            tx_venda.Size = new Size(100, 23);
            tx_venda.TabIndex = 13;
            tx_venda.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 421);
            Controls.Add(label6);
            Controls.Add(tx_venda);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(tx_lucro);
            Controls.Add(label4);
            Controls.Add(tx_preco);
            Controls.Add(label3);
            Controls.Add(tx_descricao);
            Controls.Add(label2);
            Controls.Add(tx_cod);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx_cod;
        private Label label2;
        private Label label3;
        private TextBox tx_descricao;
        private Label label4;
        private TextBox tx_preco;
        private Label label5;
        private TextBox tx_lucro;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox tx_venda;
    }
}