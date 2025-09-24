namespace PTriangulo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mTxtBoxA = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxB = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxC = new System.Windows.Forms.MaskedTextBox();
            this.btnConfere = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnSai = new System.Windows.Forms.Button();
            this.mTxtBoxResulado = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errPladoA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPLadoB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPLadoC = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errPladoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPLadoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPLadoC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado C";
            // 
            // mTxtBoxA
            // 
            this.mTxtBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBoxA.Location = new System.Drawing.Point(249, 72);
            this.mTxtBoxA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTxtBoxA.Name = "mTxtBoxA";
            this.mTxtBoxA.Size = new System.Drawing.Size(112, 32);
            this.mTxtBoxA.TabIndex = 3;
            this.mTxtBoxA.Validated += new System.EventHandler(this.mTxtBoxA_Validated);
            // 
            // mTxtBoxB
            // 
            this.mTxtBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBoxB.Location = new System.Drawing.Point(249, 139);
            this.mTxtBoxB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTxtBoxB.Name = "mTxtBoxB";
            this.mTxtBoxB.Size = new System.Drawing.Size(112, 32);
            this.mTxtBoxB.TabIndex = 4;
            this.mTxtBoxB.Validated += new System.EventHandler(this.mTxtBoxB_Validated);
            // 
            // mTxtBoxC
            // 
            this.mTxtBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBoxC.Location = new System.Drawing.Point(249, 207);
            this.mTxtBoxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTxtBoxC.Name = "mTxtBoxC";
            this.mTxtBoxC.Size = new System.Drawing.Size(112, 32);
            this.mTxtBoxC.TabIndex = 5;
            this.mTxtBoxC.Validated += new System.EventHandler(this.mTxtBoxC_Validated);
            // 
            // btnConfere
            // 
            this.btnConfere.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfere.Location = new System.Drawing.Point(528, 57);
            this.btnConfere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfere.Name = "btnConfere";
            this.btnConfere.Size = new System.Drawing.Size(125, 43);
            this.btnConfere.TabIndex = 6;
            this.btnConfere.Text = "Conferir";
            this.btnConfere.UseVisualStyleBackColor = true;
            this.btnConfere.Click += new System.EventHandler(this.btnConfere_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.Location = new System.Drawing.Point(528, 131);
            this.btnLimpa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(125, 43);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnSai
            // 
            this.btnSai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.Location = new System.Drawing.Point(528, 207);
            this.btnSai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(125, 43);
            this.btnSai.TabIndex = 8;
            this.btnSai.Text = "Sair";
            this.btnSai.UseVisualStyleBackColor = true;
            this.btnSai.Click += new System.EventHandler(this.btnSai_Click);
            // 
            // mTxtBoxResulado
            // 
            this.mTxtBoxResulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtBoxResulado.Location = new System.Drawing.Point(357, 293);
            this.mTxtBoxResulado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTxtBoxResulado.Name = "mTxtBoxResulado";
            this.mTxtBoxResulado.ReadOnly = true;
            this.mTxtBoxResulado.Size = new System.Drawing.Size(127, 32);
            this.mTxtBoxResulado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // errPladoA
            // 
            this.errPladoA.ContainerControl = this;
            // 
            // errPLadoB
            // 
            this.errPLadoB.ContainerControl = this;
            // 
            // errPLadoC
            // 
            this.errPLadoC.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mTxtBoxResulado);
            this.Controls.Add(this.btnSai);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnConfere);
            this.Controls.Add(this.mTxtBoxC);
            this.Controls.Add(this.mTxtBoxB);
            this.Controls.Add(this.mTxtBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPladoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPLadoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPLadoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mTxtBoxA;
        private System.Windows.Forms.MaskedTextBox mTxtBoxB;
        private System.Windows.Forms.MaskedTextBox mTxtBoxC;
        private System.Windows.Forms.Button btnConfere;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.MaskedTextBox mTxtBoxResulado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errPladoA;
        private System.Windows.Forms.ErrorProvider errPLadoB;
        private System.Windows.Forms.ErrorProvider errPLadoC;
    }
}

