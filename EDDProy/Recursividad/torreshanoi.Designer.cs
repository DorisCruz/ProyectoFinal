namespace EDDemo
{
    partial class torreshanoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnResolver = new System.Windows.Forms.Button();
            this.lstMovimientos = new System.Windows.Forms.ListBox();
            this.numDiscos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de discos:";
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(246, 187);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 1;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // lstMovimientos
            // 
            this.lstMovimientos.FormattingEnabled = true;
            this.lstMovimientos.Location = new System.Drawing.Point(405, 151);
            this.lstMovimientos.Name = "lstMovimientos";
            this.lstMovimientos.Size = new System.Drawing.Size(120, 95);
            this.lstMovimientos.TabIndex = 2;
            // 
            // numDiscos
            // 
            this.numDiscos.Location = new System.Drawing.Point(201, 149);
            this.numDiscos.Name = "numDiscos";
            this.numDiscos.Size = new System.Drawing.Size(120, 20);
            this.numDiscos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "T o r r e s   d e   h a n o i";
            // 
            // torreshanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDiscos);
            this.Controls.Add(this.lstMovimientos);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.label1);
            this.Name = "torreshanoi";
            this.Text = "torreshanoi";
            ((System.ComponentModel.ISupportInitialize)(this.numDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.ListBox lstMovimientos;
        private System.Windows.Forms.NumericUpDown numDiscos;
        private System.Windows.Forms.Label label2;
    }
}