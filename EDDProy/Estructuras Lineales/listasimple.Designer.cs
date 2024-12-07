namespace EDDemo
{
    partial class listasimple
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textnum = new System.Windows.Forms.TextBox();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.btnBus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listashow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Posixion en la lista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Igresa un numero:";
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(162, 151);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(100, 20);
            this.textnum.TabIndex = 28;
            // 
            // txtpos
            // 
            this.txtpos.Location = new System.Drawing.Point(162, 207);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(100, 20);
            this.txtpos.TabIndex = 27;
            // 
            // btnBus
            // 
            this.btnBus.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBus.Location = new System.Drawing.Point(161, 276);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(75, 23);
            this.btnBus.TabIndex = 26;
            this.btnBus.Text = "Buscar";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Vaciar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(567, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Menu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnElim
            // 
            this.btnElim.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.Location = new System.Drawing.Point(242, 247);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(75, 23);
            this.btnElim.TabIndex = 23;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(161, 247);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // listashow
            // 
            this.listashow.FormattingEnabled = true;
            this.listashow.Location = new System.Drawing.Point(416, 135);
            this.listashow.Name = "listashow";
            this.listashow.Size = new System.Drawing.Size(120, 121);
            this.listashow.TabIndex = 21;
            // 
            // listasimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listashow);
            this.Name = "listasimple";
            this.Text = "listasimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.TextBox txtpos;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox listashow;
    }
}