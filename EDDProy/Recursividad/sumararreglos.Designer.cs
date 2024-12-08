namespace EDDemo
{
    partial class sumararreglos
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
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.arreglo1 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(117, 179);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(120, 20);
            this.numero.TabIndex = 0;
            // 
            // arreglo1
            // 
            this.arreglo1.AutoSize = true;
            this.arreglo1.Location = new System.Drawing.Point(114, 351);
            this.arreglo1.Name = "arreglo1";
            this.arreglo1.Size = new System.Drawing.Size(46, 13);
            this.arreglo1.TabIndex = 1;
            this.arreglo1.Text = "Arreglo: ";
            this.arreglo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Location = new System.Drawing.Point(114, 326);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(112, 13);
            this.tiempo.TabIndex = 2;
            this.tiempo.Text = "Tiempo de ejecucion: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(117, 219);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Sumar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(114, 303);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(61, 13);
            this.resultado.TabIndex = 4;
            this.resultado.Text = "Resultado: ";
            // 
            // sumararreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.arreglo1);
            this.Controls.Add(this.numero);
            this.Name = "sumararreglos";
            this.Text = "sumararreglos";
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.Label arreglo1;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label resultado;
    }
}