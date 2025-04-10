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
    public partial class FrmListaSimple: Form
    {
        clases.ListaSimple ls = new clases.ListaSimple();
        public FrmListaSimple()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listNumeros.Items.Clear();
            ls.insertar(int.Parse(txtNumero.Text));
            ls.mostrar(listNumeros);
            txtNumero.Clear();
            txtNumero.Focus();
        }
    }
}
