using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class FrmListaCircular : Form
    {
        clases.ListaCircular lc = new clases.ListaCircular(); 
        public FrmListaCircular()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            lc.insertar(int.Parse(txtNumero.Text));
            lc.mostrar(listNumeros);
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lc.eliminar(int.Parse(txtNumero.Text));
            listNumeros.Items.Clear();
            lc.mostrar(listNumeros);
            txtNumero.Clear();
            txtNumero.Focus();
        }
    }
}
