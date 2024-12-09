namespace EDDemo
{
    partial class listacircular
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(240, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaciar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVaciar.Location = new System.Drawing.Point(401, 347);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 26);
            this.btnVaciar.TabIndex = 27;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(73, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ingresa un numero:";
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.ForeColor = System.Drawing.SystemColors.Window;
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(374, 153);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(136, 169);
            this.list.TabIndex = 25;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnum.Location = new System.Drawing.Point(76, 172);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(126, 13);
            this.txtnum.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(159, 209);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(76, 209);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 26);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.UseWaitCursor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(120, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "L I S T A   C I R C U L A R";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 59);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(142)))), ((int)(((byte)(27)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(597, 10);
            this.flowLayoutPanel2.TabIndex = 43;
            // 
            // listacircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(594, 405);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "listacircular";
            this.Text = "listacircular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}