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
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(159, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaciar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVaciar.Location = new System.Drawing.Point(459, 297);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 36;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(240, 157);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(57, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ver lista del:";
            // 
            // btnDI
            // 
            this.btnDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnDI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDI.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDI.Location = new System.Drawing.Point(231, 234);
            this.btnDI.Name = "btnDI";
            this.btnDI.Size = new System.Drawing.Size(141, 26);
            this.btnDI.TabIndex = 33;
            this.btnDI.Text = "Primero al ultimo";
            this.btnDI.UseVisualStyleBackColor = false;
            this.btnDI.Click += new System.EventHandler(this.btnDI_Click);
            // 
            // btnID
            // 
            this.btnID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnID.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnID.Location = new System.Drawing.Point(59, 234);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(155, 26);
            this.btnID.TabIndex = 31;
            this.btnID.Text = "Ultimo al primero";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(78, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textnum
            // 
            this.textnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.textnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnum.ForeColor = System.Drawing.SystemColors.Window;
            this.textnum.Location = new System.Drawing.Point(196, 131);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(100, 13);
            this.textnum.TabIndex = 29;
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.ForeColor = System.Drawing.SystemColors.Window;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(440, 122);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(122, 169);
            this.list.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese un numero: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(182, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "L I S T A   D O B L E";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 52);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(98)))), ((int)(((byte)(5)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 67);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(634, 10);
            this.flowLayoutPanel2.TabIndex = 41;
            // 
            // listadoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(635, 363);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.Name = "listadoble";
            this.Text = "listadoble";
            this.Load += new System.EventHandler(this.listadoble_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}