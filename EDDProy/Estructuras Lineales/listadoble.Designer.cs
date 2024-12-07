namespace EDDemo
{
    partial class listadoble
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDI = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textnum = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(258, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(565, 312);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 36;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(355, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ver lista del:";
            // 
            // btnDI
            // 
            this.btnDI.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDI.Location = new System.Drawing.Point(321, 283);
            this.btnDI.Name = "btnDI";
            this.btnDI.Size = new System.Drawing.Size(141, 23);
            this.btnDI.TabIndex = 33;
            this.btnDI.Text = "Primero al ultimo";
            this.btnDI.UseVisualStyleBackColor = true;
            this.btnDI.Click += new System.EventHandler(this.btnDI_Click);
            // 
            // btnID
            // 
            this.btnID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.Location = new System.Drawing.Point(149, 283);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(155, 23);
            this.btnID.TabIndex = 31;
            this.btnID.Text = "Ultimo al primero";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(168, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(286, 180);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(100, 20);
            this.textnum.TabIndex = 29;
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(549, 172);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(91, 134);
            this.list.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese un numero: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "L I S T A S  D O B L E S";
            // 
            // listadoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDI);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "listadoble";
            this.Text = "listadoble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDI;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textnum;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}