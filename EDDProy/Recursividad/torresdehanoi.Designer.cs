namespace EDDemo
{
    partial class torresdehanoi
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
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.numDiscos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMovimientos
            // 
            this.lstMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.lstMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMovimientos.ForeColor = System.Drawing.SystemColors.Window;
            this.lstMovimientos.FormattingEnabled = true;
            this.lstMovimientos.Location = new System.Drawing.Point(293, 145);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(153, 221);
            this.lstMovimientos.TabIndex = 0;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(47)))));
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResolver.Location = new System.Drawing.Point(81, 213);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 2;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // numDiscos
            // 
            this.numDiscos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.numDiscos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDiscos.ForeColor = System.Drawing.SystemColors.Window;
            this.numDiscos.Location = new System.Drawing.Point(81, 162);
            this.numDiscos.Name = "numDiscos";
            this.numDiscos.Size = new System.Drawing.Size(120, 16);
            this.numDiscos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de discos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(47)))));
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(63)))), ((int)(((byte)(187)))));
            this.label4.Location = new System.Drawing.Point(89, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(369, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "T O R R E S  D E  H A N O I";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(2)))), ((int)(((byte)(47)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 83);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tiempo de ejecucion: ";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tiempo.Location = new System.Drawing.Point(191, 266);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(0, 14);
            this.tiempo.TabIndex = 56;
            // 
            // torresdehanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(525, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDiscos);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.lstMovimientos);
            this.Name = "torresdehanoi";
            this.Text = "torresdehanoi";
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMovimientos;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.NumericUpDown numDiscos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tiempo;
    }
}