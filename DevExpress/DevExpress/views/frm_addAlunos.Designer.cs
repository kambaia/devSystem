namespace DevExpress.views
{
    partial class frm_Aluno
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_TelefPai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_NomePai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TelefMae = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NomeMae = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_foto = new System.Windows.Forms.TextBox();
            this.btn_AddFoto = new System.Windows.Forms.Button();
            this.pb_fotoAluno = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Rua = new System.Windows.Forms.TextBox();
            this.txt_NascAluno = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Nacionalidade = new System.Windows.Forms.TextBox();
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_BIaluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAluno)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancelar);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_salvar);
            this.groupBox3.Controls.Add(this.dgv_dados);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(149, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(867, 249);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualizar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(769, 213);
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
            this.btn_delete.Location = new System.Drawing.Point(679, 213);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 30);
            this.btn_delete.TabIndex = 88;
            this.btn_delete.Text = "Deletar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Location = new System.Drawing.Point(588, 213);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(85, 30);
            this.btn_salvar.TabIndex = 87;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(6, 25);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(855, 182);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.DoubleClick += new System.EventHandler(this.dgv_dados_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_TelefPai);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_NomePai);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_TelefMae);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_NomeMae);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(605, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 211);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filiação";
            // 
            // txt_TelefPai
            // 
            this.txt_TelefPai.Location = new System.Drawing.Point(115, 144);
            this.txt_TelefPai.Multiline = true;
            this.txt_TelefPai.Name = "txt_TelefPai";
            this.txt_TelefPai.Size = new System.Drawing.Size(162, 25);
            this.txt_TelefPai.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Telefone:";
            // 
            // txt_NomePai
            // 
            this.txt_NomePai.Location = new System.Drawing.Point(115, 110);
            this.txt_NomePai.Multiline = true;
            this.txt_NomePai.Name = "txt_NomePai";
            this.txt_NomePai.Size = new System.Drawing.Size(218, 25);
            this.txt_NomePai.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome do Pai:";
            // 
            // txt_TelefMae
            // 
            this.txt_TelefMae.Location = new System.Drawing.Point(115, 71);
            this.txt_TelefMae.Multiline = true;
            this.txt_TelefMae.Name = "txt_TelefMae";
            this.txt_TelefMae.Size = new System.Drawing.Size(162, 25);
            this.txt_TelefMae.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone:";
            // 
            // txt_NomeMae
            // 
            this.txt_NomeMae.Location = new System.Drawing.Point(115, 36);
            this.txt_NomeMae.Multiline = true;
            this.txt_NomeMae.Name = "txt_NomeMae";
            this.txt_NomeMae.Size = new System.Drawing.Size(218, 25);
            this.txt_NomeMae.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome da Mãe:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_foto);
            this.groupBox2.Controls.Add(this.btn_AddFoto);
            this.groupBox2.Controls.Add(this.pb_fotoAluno);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 207);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto";
            // 
            // txt_foto
            // 
            this.txt_foto.Location = new System.Drawing.Point(11, 135);
            this.txt_foto.Multiline = true;
            this.txt_foto.Name = "txt_foto";
            this.txt_foto.Size = new System.Drawing.Size(106, 25);
            this.txt_foto.TabIndex = 14;
            // 
            // btn_AddFoto
            // 
            this.btn_AddFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFoto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFoto.Location = new System.Drawing.Point(33, 166);
            this.btn_AddFoto.Name = "btn_AddFoto";
            this.btn_AddFoto.Size = new System.Drawing.Size(55, 29);
            this.btn_AddFoto.TabIndex = 35;
            this.btn_AddFoto.Text = "Add";
            this.btn_AddFoto.UseVisualStyleBackColor = true;
            // 
            // pb_fotoAluno
            // 
            this.pb_fotoAluno.Location = new System.Drawing.Point(6, 25);
            this.pb_fotoAluno.Name = "pb_fotoAluno";
            this.pb_fotoAluno.Size = new System.Drawing.Size(115, 104);
            this.pb_fotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fotoAluno.TabIndex = 0;
            this.pb_fotoAluno.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Rua);
            this.groupBox1.Controls.Add(this.txt_NascAluno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cb_genero);
            this.groupBox1.Controls.Add(this.txt_Bairro);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Nacionalidade);
            this.groupBox1.Controls.Add(this.txt_provincia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_Telefone);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_BIaluno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nomeAluno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 211);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificação";
            // 
            // txt_Rua
            // 
            this.txt_Rua.Location = new System.Drawing.Point(378, 142);
            this.txt_Rua.Multiline = true;
            this.txt_Rua.Name = "txt_Rua";
            this.txt_Rua.Size = new System.Drawing.Size(189, 25);
            this.txt_Rua.TabIndex = 12;
            // 
            // txt_NascAluno
            // 
            this.txt_NascAluno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_NascAluno.Location = new System.Drawing.Point(129, 110);
            this.txt_NascAluno.Name = "txt_NascAluno";
            this.txt_NascAluno.Size = new System.Drawing.Size(148, 26);
            this.txt_NascAluno.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(302, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Rua:";
            // 
            // cb_genero
            // 
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_genero.Location = new System.Drawing.Point(378, 45);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(189, 28);
            this.cb_genero.TabIndex = 28;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(378, 111);
            this.txt_Bairro.Multiline = true;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(189, 25);
            this.txt_Bairro.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(302, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Genero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bairro:";
            // 
            // txt_Nacionalidade
            // 
            this.txt_Nacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nacionalidade.Location = new System.Drawing.Point(110, 170);
            this.txt_Nacionalidade.Multiline = true;
            this.txt_Nacionalidade.Name = "txt_Nacionalidade";
            this.txt_Nacionalidade.Size = new System.Drawing.Size(167, 25);
            this.txt_Nacionalidade.TabIndex = 14;
            // 
            // txt_provincia
            // 
            this.txt_provincia.Location = new System.Drawing.Point(378, 79);
            this.txt_provincia.Multiline = true;
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(189, 25);
            this.txt_provincia.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Provincia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Nacionalidade:";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(110, 142);
            this.txt_Telefone.Multiline = true;
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(167, 25);
            this.txt_Telefone.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "Telefone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "Nascimento:";
            // 
            // txt_BIaluno
            // 
            this.txt_BIaluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BIaluno.Location = new System.Drawing.Point(129, 78);
            this.txt_BIaluno.Multiline = true;
            this.txt_BIaluno.Name = "txt_BIaluno";
            this.txt_BIaluno.Size = new System.Drawing.Size(148, 25);
            this.txt_BIaluno.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bilhe. Identidade:";
            // 
            // txt_nomeAluno
            // 
            this.txt_nomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeAluno.Location = new System.Drawing.Point(66, 47);
            this.txt_nomeAluno.Multiline = true;
            this.txt_nomeAluno.Name = "txt_nomeAluno";
            this.txt_nomeAluno.Size = new System.Drawing.Size(211, 25);
            this.txt_nomeAluno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // frm_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 490);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Aluno";
            this.Text = "Inscrever Aluno";
            this.Load += new System.EventHandler(this.frm_Aluno_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoAluno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_TelefPai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_NomePai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TelefMae;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NomeMae;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddFoto;
        private System.Windows.Forms.PictureBox pb_fotoAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Rua;
        private System.Windows.Forms.DateTimePicker txt_NascAluno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Nacionalidade;
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_BIaluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_foto;
    }
}