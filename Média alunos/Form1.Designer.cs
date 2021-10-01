
namespace Média_alunos
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
            this.nome = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.Notas = new System.Windows.Forms.Label();
            this.ativ1 = new System.Windows.Forms.Label();
            this.ativ2 = new System.Windows.Forms.Label();
            this.ativ3 = new System.Windows.Forms.Label();
            this.ativ4 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtnascimento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.boxresultado = new System.Windows.Forms.GroupBox();
            this.média = new System.Windows.Forms.Label();
            this.txtmédia = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.RoyalBlue;
            this.nome.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome.Location = new System.Drawing.Point(114, 54);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(61, 20);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
           
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.BackColor = System.Drawing.Color.RoyalBlue;
            this.Nascimento.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nascimento.Location = new System.Drawing.Point(26, 99);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(186, 20);
            this.Nascimento.TabIndex = 1;
            this.Nascimento.Text = "Data de Nascimento:";
            // 
            // Notas
            // 
            this.Notas.AutoSize = true;
            this.Notas.BackColor = System.Drawing.Color.RoyalBlue;
            this.Notas.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Notas.Location = new System.Drawing.Point(53, 150);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(122, 20);
            this.Notas.TabIndex = 2;
            this.Notas.Text = "Insira notas:";
            // 
            // ativ1
            // 
            this.ativ1.AutoSize = true;
            this.ativ1.BackColor = System.Drawing.Color.RoyalBlue;
            this.ativ1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ativ1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ativ1.Location = new System.Drawing.Point(324, 187);
            this.ativ1.Name = "ativ1";
            this.ativ1.Size = new System.Drawing.Size(105, 20);
            this.ativ1.TabIndex = 3;
            this.ativ1.Text = "Atividade 1";
        
            // 
            // ativ2
            // 
            this.ativ2.AutoSize = true;
            this.ativ2.BackColor = System.Drawing.Color.RoyalBlue;
            this.ativ2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ativ2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ativ2.Location = new System.Drawing.Point(324, 225);
            this.ativ2.Name = "ativ2";
            this.ativ2.Size = new System.Drawing.Size(105, 20);
            this.ativ2.TabIndex = 4;
            this.ativ2.Text = "Atividade 2";
            // 
            // ativ3
            // 
            this.ativ3.AutoSize = true;
            this.ativ3.BackColor = System.Drawing.Color.RoyalBlue;
            this.ativ3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ativ3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ativ3.Location = new System.Drawing.Point(324, 260);
            this.ativ3.Name = "ativ3";
            this.ativ3.Size = new System.Drawing.Size(106, 20);
            this.ativ3.TabIndex = 5;
            this.ativ3.Text = "Atividade 3";
            // 
            // ativ4
            // 
            this.ativ4.AutoSize = true;
            this.ativ4.BackColor = System.Drawing.Color.RoyalBlue;
            this.ativ4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ativ4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ativ4.Location = new System.Drawing.Point(324, 301);
            this.ativ4.Name = "ativ4";
            this.ativ4.Size = new System.Drawing.Size(107, 20);
            this.ativ4.TabIndex = 6;
            this.ativ4.Text = "Atividade 4";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(380, 331);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(185, 54);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(394, 23);
            this.txtnome.TabIndex = 8;
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(218, 99);
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(361, 23);
            this.txtnascimento.TabIndex = 9;
            this.txtnascimento.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Font = new System.Drawing.Font("Scoop Normal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(316, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "\"Calcular Notas\"";
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(181, 151);
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(398, 23);
            this.txtnotas.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(441, 190);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(31, 23);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(441, 228);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(31, 23);
            this.numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(441, 263);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(31, 23);
            this.numericUpDown3.TabIndex = 14;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(441, 302);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(31, 23);
            this.numericUpDown4.TabIndex = 15;
            // 
            // boxresultado
            // 
            this.boxresultado.Location = new System.Drawing.Point(304, 371);
            this.boxresultado.Name = "boxresultado";
            this.boxresultado.Size = new System.Drawing.Size(200, 67);
            this.boxresultado.TabIndex = 16;
            this.boxresultado.TabStop = false;
            this.boxresultado.Text = "lblresultados";
            // 
            // média
            // 
            this.média.AutoSize = true;
            this.média.BackColor = System.Drawing.Color.RoyalBlue;
            this.média.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.média.Location = new System.Drawing.Point(504, 190);
            this.média.Name = "média";
            this.média.Size = new System.Drawing.Size(61, 20);
            this.média.TabIndex = 17;
            this.média.Text = "Média";
            // 
            // txtmédia
            // 
            this.txtmédia.Location = new System.Drawing.Point(571, 190);
            this.txtmédia.Name = "txtmédia";
            this.txtmédia.Size = new System.Drawing.Size(100, 23);
            this.txtmédia.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Média_alunos.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 453);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtmédia);
            this.Controls.Add(this.média);
            this.Controls.Add(this.boxresultado);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtnotas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.ativ4);
            this.Controls.Add(this.ativ3);
            this.Controls.Add(this.ativ2);
            this.Controls.Add(this.ativ1);
            this.Controls.Add(this.Notas);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label Notas;
        private System.Windows.Forms.Label ativ1;
        private System.Windows.Forms.Label ativ2;
        private System.Windows.Forms.Label ativ3;
        private System.Windows.Forms.Label ativ4;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.DateTimePicker txtnascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox boxresultado;
        private System.Windows.Forms.Label média;
        private System.Windows.Forms.TextBox txtmédia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

