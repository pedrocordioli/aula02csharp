
namespace aula02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Valor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.Color.Pink;
            this.txtValor1.Location = new System.Drawing.Point(12, 70);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(143, 20);
            this.txtValor1.TabIndex = 1;
            this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.Color.Pink;
            this.txtValor2.Location = new System.Drawing.Point(218, 70);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(143, 20);
            this.txtValor2.TabIndex = 2;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(230, 44);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(119, 23);
            this.a.TabIndex = 3;
            this.a.Text = "Segundo Valor";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(149, 109);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(83, 23);
            this.lab1.TabIndex = 4;
            this.lab1.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Pink;
            this.txtResultado.Location = new System.Drawing.Point(12, 135);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(349, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.Black;
            this.Calcular.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.Color.Pink;
            this.Calcular.Location = new System.Drawing.Point(367, 70);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(146, 85);
            this.Calcular.TabIndex = 6;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label2;
    }
}

