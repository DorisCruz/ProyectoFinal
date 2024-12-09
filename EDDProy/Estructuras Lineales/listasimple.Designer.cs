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
            this.btnElim = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.listashow = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(72, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Posicion en la lista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(72, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ingresa un numero:";
            // 
            // textnum
            // 
            this.textnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.textnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnum.ForeColor = System.Drawing.SystemColors.Window;
            this.textnum.Location = new System.Drawing.Point(75, 154);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(100, 13);
            this.textnum.TabIndex = 28;
            // 
            // txtpos
            // 
            this.txtpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.txtpos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpos.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpos.Location = new System.Drawing.Point(75, 210);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(100, 13);
            this.txtpos.TabIndex = 27;
            // 
            // btnBus
            // 
            this.btnBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnBus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBus.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBus.Location = new System.Drawing.Point(74, 279);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(75, 23);
            this.btnBus.TabIndex = 26;
            this.btnBus.Text = "Buscar";
            this.btnBus.UseVisualStyleBackColor = false;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(350, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Vaciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnElim
            // 
            this.btnElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnElim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElim.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElim.Location = new System.Drawing.Point(155, 250);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(75, 23);
            this.btnElim.TabIndex = 23;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Location = new System.Drawing.Point(74, 250);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // listashow
            // 
            this.listashow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listashow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(80)))));
            this.listashow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listashow.ForeColor = System.Drawing.SystemColors.Window;
            this.listashow.FormattingEnabled = true;
            this.listashow.Location = new System.Drawing.Point(329, 138);
            this.listashow.Name = "listashow";
            this.listashow.Size = new System.Drawing.Size(120, 169);
            this.listashow.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 54);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "L I S T A   S I M P L E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(78)))), ((int)(((byte)(249)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(597, 10);
            this.flowLayoutPanel2.TabIndex = 42;
            // 
            // listasimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(561, 390);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox listashow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}