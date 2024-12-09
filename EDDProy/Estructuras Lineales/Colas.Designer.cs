namespace EDDemo
{
    partial class Colas
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(115, 258);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum.Location = new System.Drawing.Point(64, 164);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 13);
            this.txtnum.TabIndex = 30;
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaciar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVaciar.Location = new System.Drawing.Point(365, 351);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 29;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(61, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ingresa un numero:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(155, 217);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(64, 217);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.ForeColor = System.Drawing.SystemColors.Window;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(327, 124);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(149, 221);
            this.list.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(597, 62);
            this.flowLayoutPanel1.TabIndex = 39;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(198, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "C O L A S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(42)))), ((int)(((byte)(151)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(597, 10);
            this.flowLayoutPanel2.TabIndex = 40;
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(557, 401);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.list);
            this.Name = "Colas";
            this.Text = "Colas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}