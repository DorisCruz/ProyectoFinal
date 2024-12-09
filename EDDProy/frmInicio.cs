using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colas mColas = new Colas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listasimple lis = new listasimple();   
            lis.MdiParent = this;
            lis.Show(); 
        }

        private void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadoble lisd = new listadoble(); 
            lisd.MdiParent = this;
            lisd.Show();    
        }

        private void listaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listacircular lisc = new listacircular();
            lisc.MdiParent = this;
            lisc.Show();    
        }

        private void sumaDeArreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sumararreglos sumarar = new sumararreglos();
            sumarar.MdiParent = this;
            sumarar.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fibonacci fibo = new fibonacci();
            fibo.MdiParent = this;
            fibo.Show();    
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            factorial fac = new factorial();
            fac.MdiParent = this;   
            fac.Show();
        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exponente ex = new exponente(); 
            ex.MdiParent = this;
            ex.Show();  
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busquedabinaria bi = new busquedabinaria();
            bi.MdiParent = this;
            bi.Show();
        }

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            torresdehanoi tdh = new torresdehanoi();
            tdh.MdiParent = this;
            tdh.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burbuja burbuja = new Burbuja();
            burbuja.MdiParent = this;
            burbuja.Show();
        }

        private void intercalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            intercalacion inte = new intercalacion();
            inte.MdiParent = this;
            inte.Show();


        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuicksort quicksort = new frmQuicksort();
            quicksort.MdiParent = this; 
            quicksort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix rad = new frmRadix();
            rad.MdiParent = this;
            rad.Show();
        }

        private void shellsortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellsort shell = new frmShellsort();
            shell.MdiParent = this;
            shell.Show();
        }

        private void mezclaNaturalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNatural na = new frmNatural();
            na.MdiParent = this;
            na.Show();
        }
    }
}
