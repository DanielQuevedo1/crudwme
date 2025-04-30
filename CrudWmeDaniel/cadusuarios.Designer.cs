namespace CrudWmeDaniel
{
    partial class cadusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadusuarios));
            label1 = new Label();
            textBox_nome = new TextBox();
            btn_add = new Button();
            maskedTextBox_Telefone = new MaskedTextBox();
            txt_telefone = new Label();
            label3 = new Label();
            textBox_pesquisa_nome = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_cidade = new Label();
            textBox_email = new TextBox();
            textBox_endereco = new TextBox();
            textBox_bairro = new TextBox();
            textBox_cidade = new TextBox();
            textBox_uf = new TextBox();
            textBox_num = new TextBox();
            textBox_CPF = new TextBox();
            btn_salvar = new Button();
            btn_buscar = new Button();
            btn_editar = new Button();
            btn_excluir = new Button();
            btn_listar = new Button();
            dataGridView_clientes = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // textBox_nome
            // 
            textBox_nome.Location = new Point(32, 70);
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new Size(135, 27);
            textBox_nome.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(12, 409);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(113, 29);
            btn_add.TabIndex = 2;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // maskedTextBox_Telefone
            // 
            maskedTextBox_Telefone.Location = new Point(31, 141);
            maskedTextBox_Telefone.Mask = "(00)00000-0000";
            maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            maskedTextBox_Telefone.Size = new Size(135, 27);
            maskedTextBox_Telefone.TabIndex = 3;
            // 
            // txt_telefone
            // 
            txt_telefone.AutoSize = true;
            txt_telefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_telefone.Location = new Point(32, 118);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(73, 20);
            txt_telefone.TabIndex = 4;
            txt_telefone.Text = "Telefone:";
            txt_telefone.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 9);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 5;
            label3.Text = "Pesquisar nome:";
            // 
            // textBox_pesquisa_nome
            // 
            textBox_pesquisa_nome.Location = new Point(168, 9);
            textBox_pesquisa_nome.Name = "textBox_pesquisa_nome";
            textBox_pesquisa_nome.Size = new Size(306, 27);
            textBox_pesquisa_nome.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(226, 118);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(32, 188);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(226, 251);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 9;
            label6.Text = "Número: ";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(226, 188);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 11;
            label8.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(226, 47);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 12;
            label9.Text = "CPF (ID):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(32, 313);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 13;
            label10.Text = "UF: ";
            // 
            // txt_cidade
            // 
            txt_cidade.AutoSize = true;
            txt_cidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txt_cidade.Location = new Point(32, 251);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(64, 20);
            txt_cidade.TabIndex = 14;
            txt_cidade.Text = "Cidade: ";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(226, 141);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(135, 27);
            textBox_email.TabIndex = 15;
            // 
            // textBox_endereco
            // 
            textBox_endereco.Location = new Point(32, 211);
            textBox_endereco.Name = "textBox_endereco";
            textBox_endereco.Size = new Size(135, 27);
            textBox_endereco.TabIndex = 16;
            // 
            // textBox_bairro
            // 
            textBox_bairro.Location = new Point(226, 211);
            textBox_bairro.Name = "textBox_bairro";
            textBox_bairro.Size = new Size(135, 27);
            textBox_bairro.TabIndex = 17;
            // 
            // textBox_cidade
            // 
            textBox_cidade.Location = new Point(31, 274);
            textBox_cidade.Name = "textBox_cidade";
            textBox_cidade.Size = new Size(135, 27);
            textBox_cidade.TabIndex = 18;
            // 
            // textBox_uf
            // 
            textBox_uf.Location = new Point(32, 336);
            textBox_uf.Name = "textBox_uf";
            textBox_uf.Size = new Size(135, 27);
            textBox_uf.TabIndex = 19;
            // 
            // textBox_num
            // 
            textBox_num.Location = new Point(226, 274);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(135, 27);
            textBox_num.TabIndex = 20;
            // 
            // textBox_CPF
            // 
            textBox_CPF.Location = new Point(226, 70);
            textBox_CPF.Name = "textBox_CPF";
            textBox_CPF.Size = new Size(135, 27);
            textBox_CPF.TabIndex = 21;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(131, 409);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(94, 29);
            btn_salvar.TabIndex = 22;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(231, 409);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(94, 29);
            btn_buscar.TabIndex = 23;
            btn_buscar.Text = "Pesquisar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(331, 409);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(94, 29);
            btn_editar.TabIndex = 24;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(431, 409);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 29);
            btn_excluir.TabIndex = 25;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_listar
            // 
            btn_listar.Location = new Point(531, 409);
            btn_listar.Name = "btn_listar";
            btn_listar.Size = new Size(94, 29);
            btn_listar.TabIndex = 26;
            btn_listar.Text = "Listar";
            btn_listar.UseVisualStyleBackColor = true;
            btn_listar.Click += btn_listar_Click;
            // 
            // dataGridView_clientes
            // 
            dataGridView_clientes.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_clientes.Location = new Point(383, 77);
            dataGridView_clientes.Name = "dataGridView_clientes";
            dataGridView_clientes.RowHeadersWidth = 51;
            dataGridView_clientes.Size = new Size(270, 326);
            dataGridView_clientes.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(479, 47);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 28;
            label2.Text = "Listagem: ";
            // 
            // cadusuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(671, 450);
            Controls.Add(label2);
            Controls.Add(dataGridView_clientes);
            Controls.Add(btn_listar);
            Controls.Add(btn_excluir);
            Controls.Add(btn_editar);
            Controls.Add(btn_buscar);
            Controls.Add(btn_salvar);
            Controls.Add(textBox_CPF);
            Controls.Add(textBox_num);
            Controls.Add(textBox_uf);
            Controls.Add(textBox_cidade);
            Controls.Add(textBox_bairro);
            Controls.Add(textBox_endereco);
            Controls.Add(textBox_email);
            Controls.Add(txt_cidade);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_pesquisa_nome);
            Controls.Add(label3);
            Controls.Add(txt_telefone);
            Controls.Add(maskedTextBox_Telefone);
            Controls.Add(btn_add);
            Controls.Add(textBox_nome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "cadusuarios";
            Text = "Clientes - Cadastro";
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_nome;
        private Button btn_add;
        private MaskedTextBox maskedTextBox_Telefone;
        private Label txt_telefone;
        private Label label3;
        private TextBox textBox_pesquisa_nome;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label txt_cidade;
        private TextBox textBox_email;
        private TextBox textBox_endereco;
        private TextBox textBox_bairro;
        private TextBox textBox_cidade;
        private TextBox textBox_uf;
        private TextBox textBox_num;
        private TextBox textBox_CPF;
        private Button btn_salvar;
        private Button btn_buscar;
        private Button btn_editar;
        private Button btn_excluir;
        private Button btn_listar;
        private DataGridView dataGridView_clientes;
        private Label label2;
    }
}