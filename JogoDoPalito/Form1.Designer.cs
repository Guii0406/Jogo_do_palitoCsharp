namespace JogoDoPalito
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
            this.numUDquantidade = new System.Windows.Forms.NumericUpDown();
            this.BtnJogar = new System.Windows.Forms.Button();
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.maskedRetirar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistroDeJogadas = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDquantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDquantidade
            // 
            this.numUDquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numUDquantidade.Location = new System.Drawing.Point(383, 36);
            this.numUDquantidade.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUDquantidade.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUDquantidade.Name = "numUDquantidade";
            this.numUDquantidade.Size = new System.Drawing.Size(100, 23);
            this.numUDquantidade.TabIndex = 0;
            this.numUDquantidade.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // BtnJogar
            // 
            this.BtnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnJogar.Location = new System.Drawing.Point(504, 33);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(93, 32);
            this.BtnJogar.TabIndex = 1;
            this.BtnJogar.Text = "Jogar";
            this.BtnJogar.UseVisualStyleBackColor = true;
            this.BtnJogar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnRetirar.Location = new System.Drawing.Point(504, 89);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(93, 32);
            this.BtnRetirar.TabIndex = 2;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            this.BtnRetirar.Visible = false;
            this.BtnRetirar.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedRetirar
            // 
            this.maskedRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedRetirar.Location = new System.Drawing.Point(383, 94);
            this.maskedRetirar.Mask = "9";
            this.maskedRetirar.Name = "maskedRetirar";
            this.maskedRetirar.PromptChar = ' ';
            this.maskedRetirar.Size = new System.Drawing.Size(100, 23);
            this.maskedRetirar.TabIndex = 3;
            this.maskedRetirar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha a quantidade de palitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantos palitos deseja retirar? ";
            this.label2.Visible = false;
            // 
            // RegistroDeJogadas
            // 
            this.RegistroDeJogadas.BackColor = System.Drawing.Color.White;
            this.RegistroDeJogadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistroDeJogadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RegistroDeJogadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RegistroDeJogadas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RegistroDeJogadas.Location = new System.Drawing.Point(0, 144);
            this.RegistroDeJogadas.Name = "RegistroDeJogadas";
            this.RegistroDeJogadas.ReadOnly = true;
            this.RegistroDeJogadas.Size = new System.Drawing.Size(794, 296);
            this.RegistroDeJogadas.TabIndex = 6;
            this.RegistroDeJogadas.Text = "";
            this.RegistroDeJogadas.TextChanged += new System.EventHandler(this.RegistroDeJogadas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 440);
            this.Controls.Add(this.RegistroDeJogadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedRetirar);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.BtnJogar);
            this.Controls.Add(this.numUDquantidade);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do Palito";
            ((System.ComponentModel.ISupportInitialize)(this.numUDquantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUDquantidade;
        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.MaskedTextBox maskedRetirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RegistroDeJogadas;
    }
}

