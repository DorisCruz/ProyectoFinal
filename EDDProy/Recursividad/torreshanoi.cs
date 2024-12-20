﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class torreshanoi : Form
    {
        private Hanoi hanoi;
        public torreshanoi()
        {
            InitializeComponent();
            hanoi = new Hanoi();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                int discos = (int)numDiscos.Value;

                if (discos <= 0)
                {
                    MessageBox.Show("Por favor, selecciona un número válido de discos.");
                    return;
                }

                hanoi.Movimientos.Clear();
                lstMovimientos.Items.Clear();

                hanoi.Resolver(discos, "Origen", "Destino", "Auxiliar");

                foreach (string movimiento in hanoi.Movimientos)
                {
                    lstMovimientos.Items.Add(movimiento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
