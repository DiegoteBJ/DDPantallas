namespace DDPantallas.PedidoMaterialesOficina
{
    public partial class PedidoMaterialesOficinaForm : Form
    {
        private PedidoMaterialesOficinaModelo modelo = new();

        public PedidoMaterialesOficinaForm()
        {
            InitializeComponent();
        }

        private void PedidoMaterialesOficinaForm_Load(object sender, EventArgs e)
        {
            MaterialesListView.Items.Clear();
            //Todavía el formulario no está visible, es el momento de cargar todos los
            //necesarios para su funcionamiento, como por ejemplo, los datos de la base de datos, o los datos de prueba.

            var materiales = modelo.Materiales;

            MaterialCombo.Items.Clear();
            MaterialCombo.DisplayMember = "Descripcion";
            foreach (var material in materiales)
            {
                MaterialCombo.Items.Add(material);
            }

        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CantidadText.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //sale del método inmediatamente.
            }

            if (MaterialCombo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un material.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //sale del método inmediatamente.
            }

            var material = ((Material)MaterialCombo.SelectedItem);

            var materialSeleccionado = new MaterialSolicitado();
            materialSeleccionado.DescripcionAdicional = DescAdicText.Text;
            materialSeleccionado.Cantidad = cantidad;
            materialSeleccionado.MaterialId = material.Id;

            //1) Validar los datos y pedirle al modelo que los "agregue".
            if (!modelo.Agregar(materialSeleccionado)) //el modelo valida, tira sus propios errores y devuelve false o agrega
            {
                return; //si no es válido, no se hace nada más.
            }

            //actualizar la lista: creamos un nuevo item....
            ListViewItem item = new();
            item.Text = material.Descripcion;
            item.SubItems.Add(cantidad.ToString()); //Los subitems van de la columna 2 en adelante.
            item.SubItems.Add(DescAdicText.Text);
            item.Tag = material.Id;

            //lo agregamos a la lista.
            MaterialesListView.Items.Add(item);
        }

        private void QuitarBoton_Click(object sender, EventArgs e)
        {
            //1)Validar lo estrictamente necesario
            if (MaterialesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un material de la lista para quitar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; //sale del método inmediatamente.
            }

            //2)Hacer la operacion. Si el sistema "pincha" y se cierra es que faltó alguna validación.
            var itemSeleccionado = MaterialesListView.SelectedItems[0];
            var materialId = (int)itemSeleccionado.Tag;
            modelo.Deseleccionar(materialId);
        }
    }
}
