namespace CrudSimples01
{
    partial class FrmCrudSimples
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtNome03 = new System.Windows.Forms.TextBox();
            this.TxtID03 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TxtID02 = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TxtNome01 = new System.Windows.Forms.TextBox();
            this.TxtID01 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnUpdate);
            this.groupBox1.Controls.Add(this.TxtNome03);
            this.groupBox1.Controls.Add(this.TxtID03);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.TxtID02);
            this.groupBox1.Controls.Add(this.BtnInsert);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.BtnSelect);
            this.groupBox1.Controls.Add(this.TxtNome01);
            this.groupBox1.Controls.Add(this.TxtID01);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRUD";
            // 
            // LblStatus
            // 
            this.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStatus.Location = new System.Drawing.Point(146, 472);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(359, 26);
            this.LblStatus.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(412, 424);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtNome03
            // 
            this.TxtNome03.Location = new System.Drawing.Point(243, 428);
            this.TxtNome03.Name = "TxtNome03";
            this.TxtNome03.Size = new System.Drawing.Size(100, 20);
            this.TxtNome03.TabIndex = 13;
            // 
            // TxtID03
            // 
            this.TxtID03.Location = new System.Drawing.Point(53, 427);
            this.TxtID03.Name = "TxtID03";
            this.TxtID03.Size = new System.Drawing.Size(100, 20);
            this.TxtID03.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(412, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TxtID02
            // 
            this.TxtID02.Location = new System.Drawing.Point(53, 381);
            this.TxtID02.Name = "TxtID02";
            this.TxtID02.Size = new System.Drawing.Size(100, 20);
            this.TxtID02.TabIndex = 9;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(412, 329);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(243, 333);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(100, 20);
            this.TxtNome.TabIndex = 7;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(412, 278);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 5;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TxtNome01
            // 
            this.TxtNome01.Location = new System.Drawing.Point(243, 282);
            this.TxtNome01.Name = "TxtNome01";
            this.TxtNome01.Size = new System.Drawing.Size(100, 20);
            this.TxtNome01.TabIndex = 4;
            // 
            // TxtID01
            // 
            this.TxtID01.Location = new System.Drawing.Point(53, 281);
            this.TxtID01.Name = "TxtID01";
            this.TxtID01.Size = new System.Drawing.Size(100, 20);
            this.TxtID01.TabIndex = 3;
            this.TxtID01.Text = "2";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(270, 241);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 2;
            this.Nome.Text = "Nome";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(77, 241);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnConsultar);
            this.groupBox2.Controls.Add(this.dgTabela);
            this.groupBox2.Location = new System.Drawing.Point(29, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar uma Tabela Initeira";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(383, 19);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // dgTabela
            // 
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Location = new System.Drawing.Point(24, 19);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.Size = new System.Drawing.Size(325, 150);
            this.dgTabela.TabIndex = 0;
            // 
            // FrmCrudSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 556);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCrudSimples";
            this.Text = "Exemplo Crud Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtNome03;
        private System.Windows.Forms.TextBox TxtID03;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox TxtID02;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TxtNome01;
        private System.Windows.Forms.TextBox TxtID01;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView dgTabela;
    }
}

