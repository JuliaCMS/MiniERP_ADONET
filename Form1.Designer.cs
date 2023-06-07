namespace MiniERPAdoNet
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
            tabControl1 = new TabControl();
            tabPageCadastroProdutos = new TabPage();
            dataGridViewProdutos = new DataGridView();
            label2 = new Label();
            btnAdicionarProduto = new Button();
            label1 = new Label();
            panel1 = new Panel();
            textBoxCNPJVinculo = new TextBox();
            label20 = new Label();
            textBoxPreco = new TextBox();
            textBoxQuantidade = new TextBox();
            comboBoxCor = new ComboBox();
            comboBoxTamanho = new ComboBox();
            comboBoxTipo = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabPageCadastroFornecedores = new TabPage();
            buttonMostrarFornecedores = new Button();
            buttonDeletarFornecedor = new Button();
            buttonAtualizarFornecedor = new Button();
            dataGridViewFornecedores = new DataGridView();
            label3 = new Label();
            buttonAdicionarFornecedor = new Button();
            label9 = new Label();
            panel2 = new Panel();
            textBoxTelFornecedor = new TextBox();
            textBoxEndFornecedor = new TextBox();
            textBoxCNPJ = new TextBox();
            textBoxNomeFornecedor = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabPageCadastroClientes = new TabPage();
            dataGridViewClientes = new DataGridView();
            label12 = new Label();
            button2 = new Button();
            label15 = new Label();
            panel3 = new Panel();
            textBoxTelCliente = new TextBox();
            textBoxEndCliente = new TextBox();
            textBoxCPF = new TextBox();
            textBoxNomeCliente = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            tabPageNotas = new TabPage();
            label21 = new Label();
            dataGridViewNota = new DataGridView();
            buttonGerarPDF = new Button();
            buttonEnviarNota = new Button();
            label22 = new Label();
            panel4 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            tabControl1.SuspendLayout();
            tabPageCadastroProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            panel1.SuspendLayout();
            tabPageCadastroFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).BeginInit();
            panel2.SuspendLayout();
            tabPageCadastroClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel3.SuspendLayout();
            tabPageNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNota).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCadastroProdutos);
            tabControl1.Controls.Add(tabPageCadastroFornecedores);
            tabControl1.Controls.Add(tabPageCadastroClientes);
            tabControl1.Controls.Add(tabPageNotas);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1023, 546);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCadastroProdutos
            // 
            tabPageCadastroProdutos.BackColor = Color.Transparent;
            tabPageCadastroProdutos.Controls.Add(dataGridViewProdutos);
            tabPageCadastroProdutos.Controls.Add(label2);
            tabPageCadastroProdutos.Controls.Add(btnAdicionarProduto);
            tabPageCadastroProdutos.Controls.Add(label1);
            tabPageCadastroProdutos.Controls.Add(panel1);
            tabPageCadastroProdutos.Location = new Point(4, 29);
            tabPageCadastroProdutos.Name = "tabPageCadastroProdutos";
            tabPageCadastroProdutos.Padding = new Padding(3);
            tabPageCadastroProdutos.Size = new Size(1015, 513);
            tabPageCadastroProdutos.TabIndex = 0;
            tabPageCadastroProdutos.Text = "Cadastro de Produtos";
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewProdutos.AllowUserToDeleteRows = false;
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(28, 275);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.RowHeadersWidth = 51;
            dataGridViewProdutos.RowTemplate.Height = 29;
            dataGridViewProdutos.Size = new Size(960, 222);
            dataGridViewProdutos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(351, 241);
            label2.Name = "label2";
            label2.Size = new Size(267, 31);
            label2.TabIndex = 2;
            label2.Text = "ESTOQUE DE PRODUTOS";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarProduto.Location = new Point(303, 173);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(364, 29);
            btnAdicionarProduto.TabIndex = 1;
            btnAdicionarProduto.Text = "Adicionar";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 13);
            label1.Name = "label1";
            label1.Size = new Size(118, 31);
            label1.TabIndex = 0;
            label1.Text = "PRODUTO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxCNPJVinculo);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(textBoxPreco);
            panel1.Controls.Add(textBoxQuantidade);
            panel1.Controls.Add(comboBoxCor);
            panel1.Controls.Add(comboBoxTamanho);
            panel1.Controls.Add(comboBoxTipo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(162, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 120);
            panel1.TabIndex = 0;
            // 
            // textBoxCNPJVinculo
            // 
            textBoxCNPJVinculo.Location = new Point(467, 58);
            textBoxCNPJVinculo.Name = "textBoxCNPJVinculo";
            textBoxCNPJVinculo.Size = new Size(176, 27);
            textBoxCNPJVinculo.TabIndex = 17;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(345, 61);
            label20.Name = "label20";
            label20.Size = new Size(120, 20);
            label20.TabIndex = 16;
            label20.Text = "CNPJ Fornecedor";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(487, 11);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(70, 27);
            textBoxPreco.TabIndex = 15;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(321, 11);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(70, 27);
            textBoxQuantidade.TabIndex = 14;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Items.AddRange(new object[] { "Preto", "Branco", "Jeans" });
            comboBoxCor.Location = new Point(188, 58);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(151, 28);
            comboBoxCor.TabIndex = 13;
            // 
            // comboBoxTamanho
            // 
            comboBoxTamanho.FormattingEnabled = true;
            comboBoxTamanho.Items.AddRange(new object[] { "P", "M", "G" });
            comboBoxTamanho.Location = new Point(82, 58);
            comboBoxTamanho.Name = "comboBoxTamanho";
            comboBoxTamanho.Size = new Size(59, 28);
            comboBoxTamanho.TabIndex = 12;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Camiseta", "Calça", "Moletom", "Vestido", "Shorts" });
            comboBoxTipo.Location = new Point(52, 14);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(151, 28);
            comboBoxTipo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(149, 61);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 9;
            label8.Text = "Cor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 61);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 8;
            label7.Text = "Tamanho";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 14);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 7;
            label6.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 14);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 17);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo";
            // 
            // tabPageCadastroFornecedores
            // 
            tabPageCadastroFornecedores.Controls.Add(buttonMostrarFornecedores);
            tabPageCadastroFornecedores.Controls.Add(buttonDeletarFornecedor);
            tabPageCadastroFornecedores.Controls.Add(buttonAtualizarFornecedor);
            tabPageCadastroFornecedores.Controls.Add(dataGridViewFornecedores);
            tabPageCadastroFornecedores.Controls.Add(label3);
            tabPageCadastroFornecedores.Controls.Add(buttonAdicionarFornecedor);
            tabPageCadastroFornecedores.Controls.Add(label9);
            tabPageCadastroFornecedores.Controls.Add(panel2);
            tabPageCadastroFornecedores.Location = new Point(4, 29);
            tabPageCadastroFornecedores.Name = "tabPageCadastroFornecedores";
            tabPageCadastroFornecedores.Padding = new Padding(3);
            tabPageCadastroFornecedores.Size = new Size(1015, 513);
            tabPageCadastroFornecedores.TabIndex = 1;
            tabPageCadastroFornecedores.Text = "Cadastro de Fornecedores";
            tabPageCadastroFornecedores.UseVisualStyleBackColor = true;
            // 
            // buttonMostrarFornecedores
            // 
            buttonMostrarFornecedores.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMostrarFornecedores.Location = new Point(312, 478);
            buttonMostrarFornecedores.Name = "buttonMostrarFornecedores";
            buttonMostrarFornecedores.Size = new Size(219, 29);
            buttonMostrarFornecedores.TabIndex = 11;
            buttonMostrarFornecedores.Text = "Mostrar todos";
            buttonMostrarFornecedores.UseVisualStyleBackColor = true;
            buttonMostrarFornecedores.Click += buttonMostrarFornecedores_Click;
            // 
            // buttonDeletarFornecedor
            // 
            buttonDeletarFornecedor.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeletarFornecedor.Location = new Point(762, 478);
            buttonDeletarFornecedor.Name = "buttonDeletarFornecedor";
            buttonDeletarFornecedor.Size = new Size(219, 29);
            buttonDeletarFornecedor.TabIndex = 10;
            buttonDeletarFornecedor.Text = "Deletar";
            buttonDeletarFornecedor.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizarFornecedor
            // 
            buttonAtualizarFornecedor.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAtualizarFornecedor.Location = new Point(537, 478);
            buttonAtualizarFornecedor.Name = "buttonAtualizarFornecedor";
            buttonAtualizarFornecedor.Size = new Size(219, 29);
            buttonAtualizarFornecedor.TabIndex = 9;
            buttonAtualizarFornecedor.Text = "Atualizar";
            buttonAtualizarFornecedor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFornecedores
            // 
            dataGridViewFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornecedores.Location = new Point(34, 254);
            dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            dataGridViewFornecedores.RowHeadersWidth = 51;
            dataGridViewFornecedores.RowTemplate.Height = 29;
            dataGridViewFornecedores.Size = new Size(947, 218);
            dataGridViewFornecedores.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(351, 220);
            label3.Name = "label3";
            label3.Size = new Size(301, 31);
            label3.TabIndex = 7;
            label3.Text = "TABELA DE FORNECEDORES";
            // 
            // buttonAdicionarFornecedor
            // 
            buttonAdicionarFornecedor.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionarFornecedor.Location = new Point(247, 166);
            buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            buttonAdicionarFornecedor.Size = new Size(552, 29);
            buttonAdicionarFornecedor.TabIndex = 6;
            buttonAdicionarFornecedor.Text = "Adicionar";
            buttonAdicionarFornecedor.UseVisualStyleBackColor = true;
            buttonAdicionarFornecedor.Click += buttonAdicionarFornecedor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(151, 19);
            label9.Name = "label9";
            label9.Size = new Size(160, 31);
            label9.TabIndex = 4;
            label9.Text = "FORNECEDOR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBoxTelFornecedor);
            panel2.Controls.Add(textBoxEndFornecedor);
            panel2.Controls.Add(textBoxCNPJ);
            panel2.Controls.Add(textBoxNomeFornecedor);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(151, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 107);
            panel2.TabIndex = 5;
            // 
            // textBoxTelFornecedor
            // 
            textBoxTelFornecedor.Location = new Point(522, 58);
            textBoxTelFornecedor.Name = "textBoxTelFornecedor";
            textBoxTelFornecedor.Size = new Size(202, 27);
            textBoxTelFornecedor.TabIndex = 17;
            // 
            // textBoxEndFornecedor
            // 
            textBoxEndFornecedor.Location = new Point(84, 58);
            textBoxEndFornecedor.Name = "textBoxEndFornecedor";
            textBoxEndFornecedor.Size = new Size(352, 27);
            textBoxEndFornecedor.TabIndex = 16;
            // 
            // textBoxCNPJ
            // 
            textBoxCNPJ.Location = new Point(506, 14);
            textBoxCNPJ.Name = "textBoxCNPJ";
            textBoxCNPJ.Size = new Size(218, 27);
            textBoxCNPJ.TabIndex = 15;
            // 
            // textBoxNomeFornecedor
            // 
            textBoxNomeFornecedor.Location = new Point(63, 14);
            textBoxNomeFornecedor.Name = "textBoxNomeFornecedor";
            textBoxNomeFornecedor.Size = new Size(373, 27);
            textBoxNomeFornecedor.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(450, 58);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 9;
            label10.Text = "Telefone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 58);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 8;
            label11.Text = "Endereço";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(459, 17);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 6;
            label13.Text = "CNPJ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 17);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 5;
            label14.Text = "Nome";
            // 
            // tabPageCadastroClientes
            // 
            tabPageCadastroClientes.Controls.Add(dataGridViewClientes);
            tabPageCadastroClientes.Controls.Add(label12);
            tabPageCadastroClientes.Controls.Add(button2);
            tabPageCadastroClientes.Controls.Add(label15);
            tabPageCadastroClientes.Controls.Add(panel3);
            tabPageCadastroClientes.Location = new Point(4, 29);
            tabPageCadastroClientes.Name = "tabPageCadastroClientes";
            tabPageCadastroClientes.Size = new Size(1015, 513);
            tabPageCadastroClientes.TabIndex = 2;
            tabPageCadastroClientes.Text = "Cadastro de Clientes";
            tabPageCadastroClientes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(34, 271);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.RowTemplate.Height = 29;
            dataGridViewClientes.Size = new Size(947, 232);
            dataGridViewClientes.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(351, 237);
            label12.Name = "label12";
            label12.Size = new Size(229, 31);
            label12.TabIndex = 12;
            label12.Text = "TABELA DE CLIENTES";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(340, 166);
            button2.Name = "button2";
            button2.Size = new Size(364, 29);
            button2.TabIndex = 11;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(151, 19);
            label15.Name = "label15";
            label15.Size = new Size(100, 31);
            label15.TabIndex = 9;
            label15.Text = "CLIENTE";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBoxTelCliente);
            panel3.Controls.Add(textBoxEndCliente);
            panel3.Controls.Add(textBoxCPF);
            panel3.Controls.Add(textBoxNomeCliente);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(151, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(738, 107);
            panel3.TabIndex = 10;
            // 
            // textBoxTelCliente
            // 
            textBoxTelCliente.Location = new Point(522, 58);
            textBoxTelCliente.Name = "textBoxTelCliente";
            textBoxTelCliente.Size = new Size(202, 27);
            textBoxTelCliente.TabIndex = 17;
            // 
            // textBoxEndCliente
            // 
            textBoxEndCliente.Location = new Point(84, 58);
            textBoxEndCliente.Name = "textBoxEndCliente";
            textBoxEndCliente.Size = new Size(352, 27);
            textBoxEndCliente.TabIndex = 16;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(506, 14);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(218, 27);
            textBoxCPF.TabIndex = 15;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(63, 14);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(373, 27);
            textBoxNomeCliente.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(450, 58);
            label16.Name = "label16";
            label16.Size = new Size(66, 20);
            label16.TabIndex = 9;
            label16.Text = "Telefone";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(7, 58);
            label17.Name = "label17";
            label17.Size = new Size(71, 20);
            label17.TabIndex = 8;
            label17.Text = "Endereço";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(459, 17);
            label18.Name = "label18";
            label18.Size = new Size(33, 20);
            label18.TabIndex = 6;
            label18.Text = "CPF";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(7, 17);
            label19.Name = "label19";
            label19.Size = new Size(50, 20);
            label19.TabIndex = 5;
            label19.Text = "Nome";
            // 
            // tabPageNotas
            // 
            tabPageNotas.Controls.Add(label21);
            tabPageNotas.Controls.Add(dataGridViewNota);
            tabPageNotas.Controls.Add(buttonGerarPDF);
            tabPageNotas.Controls.Add(buttonEnviarNota);
            tabPageNotas.Controls.Add(label22);
            tabPageNotas.Controls.Add(panel4);
            tabPageNotas.Location = new Point(4, 29);
            tabPageNotas.Name = "tabPageNotas";
            tabPageNotas.Size = new Size(1015, 513);
            tabPageNotas.TabIndex = 3;
            tabPageNotas.Text = "Lançamento de Notas";
            tabPageNotas.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(428, 216);
            label21.Name = "label21";
            label21.Size = new Size(164, 31);
            label21.TabIndex = 18;
            label21.Text = "NOTA GERADA";
            // 
            // dataGridViewNota
            // 
            dataGridViewNota.AllowUserToAddRows = false;
            dataGridViewNota.AllowUserToDeleteRows = false;
            dataGridViewNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNota.Location = new Point(43, 250);
            dataGridViewNota.Name = "dataGridViewNota";
            dataGridViewNota.ReadOnly = true;
            dataGridViewNota.RowHeadersWidth = 51;
            dataGridViewNota.RowTemplate.Height = 29;
            dataGridViewNota.Size = new Size(950, 210);
            dataGridViewNota.TabIndex = 17;
            // 
            // buttonGerarPDF
            // 
            buttonGerarPDF.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarPDF.Location = new Point(639, 472);
            buttonGerarPDF.Name = "buttonGerarPDF";
            buttonGerarPDF.Size = new Size(364, 29);
            buttonGerarPDF.TabIndex = 16;
            buttonGerarPDF.Text = "Gerar PDF da nota";
            buttonGerarPDF.UseVisualStyleBackColor = true;
            // 
            // buttonEnviarNota
            // 
            buttonEnviarNota.Font = new Font("Segoe UI Variable Display Semib", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEnviarNota.Location = new Point(319, 161);
            buttonEnviarNota.Name = "buttonEnviarNota";
            buttonEnviarNota.Size = new Size(364, 29);
            buttonEnviarNota.TabIndex = 15;
            buttonEnviarNota.Text = "Enviar";
            buttonEnviarNota.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Variable Display Semib", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(319, 14);
            label22.Name = "label22";
            label22.Size = new Size(263, 31);
            label22.TabIndex = 13;
            label22.Text = "LANÇAMENTO DE NOTA";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label26);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(319, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 107);
            panel4.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(95, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 14);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 27);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(92, 14);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 27);
            textBox4.TabIndex = 14;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(7, 58);
            label24.Name = "label24";
            label24.Size = new Size(83, 20);
            label24.TabIndex = 8;
            label24.Text = "CPF Cliente";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(166, 17);
            label25.Name = "label25";
            label25.Size = new Size(87, 20);
            label25.TabIndex = 6;
            label25.Text = "Quantidade";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(7, 17);
            label26.Name = "label26";
            label26.Size = new Size(81, 20);
            label26.TabIndex = 5;
            label26.Text = "ID Produto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 570);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPageCadastroProdutos.ResumeLayout(false);
            tabPageCadastroProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageCadastroFornecedores.ResumeLayout(false);
            tabPageCadastroFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornecedores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPageCadastroClientes.ResumeLayout(false);
            tabPageCadastroClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPageNotas.ResumeLayout(false);
            tabPageNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNota).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCadastroProdutos;
        private TabPage tabPageCadastroFornecedores;
        private TabPage tabPageCadastroClientes;
        private TabPage tabPageNotas;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnAdicionarProduto;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxCNPJVinculo;
        private Label label8;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxCor;
        private ComboBox comboBoxTamanho;
        private TextBox textBoxPreco;
        private TextBox textBoxQuantidade;
        private DataGridView dataGridViewClientes;
        private Label label12;
        private Button button2;
        private Label label15;
        private Panel panel3;
        private TextBox textBoxTelCliente;
        private TextBox textBoxEndCliente;
        private TextBox textBoxCPF;
        private TextBox textBoxNomeCliente;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView dataGridViewFornecedores;
        private Label label3;
        private Button buttonAdicionarFornecedor;
        private Label label9;
        private Panel panel2;
        private TextBox textBoxTelFornecedor;
        private TextBox textBoxEndFornecedor;
        private TextBox textBoxCNPJ;
        private TextBox textBoxNomeFornecedor;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private DataGridView dataGridView2;
        private DataGridView dataGridViewProdutos;
        private Label label20;
        private Button button3;
        private Label label22;
        private Panel panel4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button buttonGerarPDF;
        private Label label21;
        private DataGridView dataGridViewNota;
        private Button buttonEnviarNota;
        private Button buttonAtualizarFornecedor;
        private Button buttonDeletarFornecedor;
        private Button buttonMostrarFornecedores;
    }
}