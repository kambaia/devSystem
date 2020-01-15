namespace DevExpress.views
{
    partial class frm_addPagamento
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
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_selectMeses = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_banco = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_multa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_formaPag = new System.Windows.Forms.ComboBox();
            this.txt_reciboNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_turno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_turma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_classe = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btn_SelecionarMeses = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.Location = new System.Drawing.Point(97, 19);
            this.txt_pesquisa.Multiline = true;
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(913, 25);
            this.txt_pesquisa.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Pesquisar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancelar);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_selectMeses);
            this.groupBox3.Controls.Add(this.dgv_dados);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 196);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualizar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(911, 159);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(92, 30);
            this.btn_cancelar.TabIndex = 89;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(821, 159);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 30);
            this.btn_delete.TabIndex = 88;
            this.btn_delete.Text = "Deletar";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_selectMeses
            // 
            this.btn_selectMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectMeses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectMeses.Location = new System.Drawing.Point(645, 159);
            this.btn_selectMeses.Name = "btn_selectMeses";
            this.btn_selectMeses.Size = new System.Drawing.Size(170, 30);
            this.btn_selectMeses.TabIndex = 87;
            this.btn_selectMeses.Text = "Selecionar os meses";
            this.btn_selectMeses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_selectMeses.UseVisualStyleBackColor = true;
            this.btn_selectMeses.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(6, 25);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dados.Size = new System.Drawing.Size(997, 128);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.DoubleClick += new System.EventHandler(this.dgv_dados_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_SelecionarMeses);
            this.groupBox4.Controls.Add(this.maskedTextBox1);
            this.groupBox4.Controls.Add(this.cb_banco);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_multa);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_troco);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cb_formaPag);
            this.groupBox4.Controls.Add(this.txt_reciboNum);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_total);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txt_preco);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(320, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(697, 211);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados do Pagamento";
            // 
            // cb_banco
            // 
            this.cb_banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_banco.FormattingEnabled = true;
            this.cb_banco.Items.AddRange(new object[] {
            "BFA",
            "BAI",
            "BPC",
            "ATLANTICO"});
            this.cb_banco.Location = new System.Drawing.Point(573, 119);
            this.cb_banco.Name = "cb_banco";
            this.cb_banco.Size = new System.Drawing.Size(108, 26);
            this.cb_banco.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(519, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 75;
            this.label12.Text = "Banco:";
            // 
            // txt_multa
            // 
            this.txt_multa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_multa.Location = new System.Drawing.Point(573, 81);
            this.txt_multa.Multiline = true;
            this.txt_multa.Name = "txt_multa";
            this.txt_multa.Size = new System.Drawing.Size(108, 27);
            this.txt_multa.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(519, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 73;
            this.label13.Text = "Multa:";
            // 
            // txt_troco
            // 
            this.txt_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_troco.Location = new System.Drawing.Point(405, 118);
            this.txt_troco.Multiline = true;
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.Size = new System.Drawing.Size(108, 27);
            this.txt_troco.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Troco:";
            // 
            // cb_formaPag
            // 
            this.cb_formaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_formaPag.FormattingEnabled = true;
            this.cb_formaPag.Items.AddRange(new object[] {
            "TPA",
            "Boleto"});
            this.cb_formaPag.Location = new System.Drawing.Point(168, 115);
            this.cb_formaPag.Name = "cb_formaPag";
            this.cb_formaPag.Size = new System.Drawing.Size(102, 26);
            this.cb_formaPag.TabIndex = 67;
            // 
            // txt_reciboNum
            // 
            this.txt_reciboNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reciboNum.Location = new System.Drawing.Point(448, 47);
            this.txt_reciboNum.Multiline = true;
            this.txt_reciboNum.Name = "txt_reciboNum";
            this.txt_reciboNum.Size = new System.Drawing.Size(233, 27);
            this.txt_reciboNum.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Recibo Nº:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(405, 85);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(108, 27);
            this.txt_total.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 63;
            this.label10.Text = "Total:";
            // 
            // txt_preco
            // 
            this.txt_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preco.Location = new System.Drawing.Point(168, 147);
            this.txt_preco.Multiline = true;
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(102, 27);
            this.txt_preco.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 61;
            this.label6.Text = "Preço Unitário:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 60;
            this.label7.Text = "Forma de Pagamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "Data de Pagamento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Mês a Pagar:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(158, 80);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 26);
            this.maskedTextBox1.TabIndex = 91;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cb_turno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_turma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_curso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_classe);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 211);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do estudante";
            // 
            // cb_turno
            // 
            this.cb_turno.FormattingEnabled = true;
            this.cb_turno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.cb_turno.Location = new System.Drawing.Point(62, 170);
            this.cb_turno.Name = "cb_turno";
            this.cb_turno.Size = new System.Drawing.Size(211, 28);
            this.cb_turno.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Curso:";
            // 
            // cb_turma
            // 
            this.cb_turma.FormattingEnabled = true;
            this.cb_turma.Location = new System.Drawing.Point(62, 134);
            this.cb_turma.Name = "cb_turma";
            this.cb_turma.Size = new System.Drawing.Size(211, 28);
            this.cb_turma.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Classe:";
            // 
            // cb_curso
            // 
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Items.AddRange(new object[] {
            "CEJ",
            "CFB"});
            this.cb_curso.Location = new System.Drawing.Point(62, 100);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(211, 28);
            this.cb_curso.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Turno:";
            // 
            // cb_classe
            // 
            this.cb_classe.FormattingEnabled = true;
            this.cb_classe.Items.AddRange(new object[] {
            "1ª",
            "2ª",
            "3ª",
            "4ª",
            "5ª",
            "6ª",
            "7ª",
            "8ª",
            "9ª",
            "10ª",
            "11ª",
            "12ª",
            "13ª"});
            this.cb_classe.Location = new System.Drawing.Point(62, 64);
            this.cb_classe.Name = "cb_classe";
            this.cb_classe.Size = new System.Drawing.Size(211, 28);
            this.cb_classe.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Turma:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(62, 31);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 27);
            this.txtNome.TabIndex = 67;
            // 
            // btn_SelecionarMeses
            // 
            this.btn_SelecionarMeses.BackColor = System.Drawing.Color.White;
            this.btn_SelecionarMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelecionarMeses.Location = new System.Drawing.Point(158, 41);
            this.btn_SelecionarMeses.Name = "btn_SelecionarMeses";
            this.btn_SelecionarMeses.Size = new System.Drawing.Size(172, 33);
            this.btn_SelecionarMeses.TabIndex = 92;
            this.btn_SelecionarMeses.Text = "Selecionar os meses";
            this.btn_SelecionarMeses.UseVisualStyleBackColor = false;
            this.btn_SelecionarMeses.Click += new System.EventHandler(this.btn_SelecionarMeses_Click);
            // 
            // frm_addPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_addPagamento";
            this.Text = "Pagamento de Propínas";
            this.Load += new System.EventHandler(this.frm_addPagamento_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_selectMeses;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_banco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_multa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_formaPag;
        private System.Windows.Forms.TextBox txt_reciboNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_turno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_turma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_classe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_SelecionarMeses;
    }
}