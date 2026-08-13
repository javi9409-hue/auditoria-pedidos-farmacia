namespace PedidosFarmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCantidad.Clear();

            cmbTipo.SelectedIndex = -1;

            rbCruzVerde.Checked = false;
            rbAudifarma.Checked = false;
            rbCopidrogas.Checked = false;

            rbPrincipal.Checked = false;
            rbSecundaria.Checked = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del medicamento.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de medicamento del menú desplegable.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad de producto debe ser un número entero positivo (mayor a 0).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string distribuidor = "";
            if (rbCruzVerde.Checked) distribuidor = "Cruz Verde";
            else if (rbAudifarma.Checked) distribuidor = "Audifarma";
            else if (rbCopidrogas.Checked) distribuidor = "Copidrogas";

            if (string.IsNullOrEmpty(distribuidor))
            {
                MessageBox.Show("Debe seleccionar un distribuidor farmacéutico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!rbPrincipal.Checked && !rbSecundaria.Checked)
            {
                MessageBox.Show("Debe seleccionar una sucursal (Principal o Secundaria) para el envío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool sucursalPrincipal = rbPrincipal.Checked;
            bool sucursalSecundaria = rbSecundaria.Checked;

            Form2 ventanaResumen = new Form2(
                nombre,
                cmbTipo.SelectedItem.ToString(),
                cantidad,
                distribuidor,
                sucursalPrincipal,
                sucursalSecundaria
            );

            DialogResult resultado = ventanaResumen.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                txtNombre.Clear();
                txtCantidad.Clear();
                cmbTipo.SelectedIndex = -1;
                rbCruzVerde.Checked = false;
                rbAudifarma.Checked = false;
                rbCopidrogas.Checked = false;
                rbPrincipal.Checked = false;
                rbSecundaria.Checked = false;
            }
        }
    }
}