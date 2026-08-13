using System;
using System.Windows.Forms;

namespace PedidosFarmacia
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, string tipo, int cantidad, string distribuidor, bool principal, bool secundaria)
        {
            InitializeComponent();

            this.Text = "Pedido al distribuidor " + distribuidor;

            lblResumenMedicamento.Text = cantidad + " unidades del " + tipo + " " + nombre;

            string direccion = "";
            if (principal && secundaria)
            {
                direccion = "Av. El Dorado n. 92-31 y para la situada en Cra. 7 n. 127-48";
            }
            else if (principal)
            {
                direccion = "Av. El Dorado n. 92-31";
            }
            else if (secundaria)
            {
                direccion = "Cra. 7 n. 127-48";
            }
            lblDireccionEnvio.Text = "Para la farmacia situada en " + direccion;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}