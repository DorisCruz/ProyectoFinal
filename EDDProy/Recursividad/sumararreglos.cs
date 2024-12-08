using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class sumararreglos : Form
    {
        public sumararreglos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int tamaño = (int)numero.Value;

                if (tamaño <= 0)
                {
                    MessageBox.Show("El tamaño del arreglo debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] arreglo = SumarArreglos.CrearArreglo(tamaño);

                Stopwatch cronometro = Stopwatch.StartNew();

                int suma = SumarArreglos.Sumar(arreglo);
                cronometro.Stop();

                string numerosFormateados = string.Join(" ", arreglo.Select(num => $"[{num}]"));

                arreglo1.Text = numerosFormateados;

                resultado.Text = suma.ToString();

                tiempo.Text = $"{cronometro.Elapsed.TotalMilliseconds} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

