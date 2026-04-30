namespace DDPantallas
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpSolicitante = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDepartamento = new Label();
            cmbDepartamento = new ComboBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            grpMateriales = new GroupBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            dgvMateriales = new DataGridView();
            colMaterial = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colUnidad = new DataGridViewTextBoxColumn();
            colObservaciones = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            lblAprobador = new Label();
            txtAprobador = new TextBox();
            lblEstado = new Label();
            lblEstadoValor = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEnviar = new Button();
            grpSolicitante.SuspendLayout();
            grpMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(180, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(450, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de Pedido de Materiales de Oficina";
            // 
            // grpSolicitante
            // 
            grpSolicitante.Controls.Add(lblNombre);
            grpSolicitante.Controls.Add(txtNombre);
            grpSolicitante.Controls.Add(lblDepartamento);
            grpSolicitante.Controls.Add(cmbDepartamento);
            grpSolicitante.Controls.Add(lblCorreo);
            grpSolicitante.Controls.Add(txtCorreo);
            grpSolicitante.Controls.Add(lblTelefono);
            grpSolicitante.Controls.Add(txtTelefono);
            grpSolicitante.Location = new Point(20, 50);
            grpSolicitante.Name = "grpSolicitante";
            grpSolicitante.Size = new Size(760, 120);
            grpSolicitante.TabIndex = 1;
            grpSolicitante.TabStop = false;
            grpSolicitante.Text = "Datos del Solicitante";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            lblDepartamento.Location = new Point(380, 30);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(100, 23);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento/Área:";
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.Location = new Point(520, 27);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(200, 28);
            cmbDepartamento.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(20, 70);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(100, 23);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(150, 67);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(380, 70);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(100, 23);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono Interno:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(520, 67);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 27);
            txtTelefono.TabIndex = 7;
            // 
            // grpMateriales
            // 
            grpMateriales.Controls.Add(lblFecha);
            grpMateriales.Controls.Add(dtpFecha);
            grpMateriales.Controls.Add(dgvMateriales);
            grpMateriales.Controls.Add(btnAgregar);
            grpMateriales.Controls.Add(btnEliminar);
            grpMateriales.Location = new Point(20, 180);
            grpMateriales.Name = "grpMateriales";
            grpMateriales.Size = new Size(760, 300);
            grpMateriales.TabIndex = 2;
            grpMateriales.TabStop = false;
            grpMateriales.Text = "Materiales a Solicitar";
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(20, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(100, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha del Pedido:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(150, 27);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 27);
            dtpFecha.TabIndex = 1;
            // 
            // dgvMateriales
            // 
            dgvMateriales.ColumnHeadersHeight = 29;
            dgvMateriales.Columns.AddRange(new DataGridViewColumn[] { colMaterial, colCantidad, colUnidad, colObservaciones });
            dgvMateriales.Location = new Point(20, 70);
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.RowHeadersWidth = 51;
            dgvMateriales.Size = new Size(600, 150);
            dgvMateriales.TabIndex = 2;
            // 
            // colMaterial
            // 
            colMaterial.HeaderText = "Nombre del Material";
            colMaterial.MinimumWidth = 6;
            colMaterial.Name = "colMaterial";
            colMaterial.Width = 125;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.Width = 125;
            // 
            // colUnidad
            // 
            colUnidad.HeaderText = "Unidad";
            colUnidad.MinimumWidth = 6;
            colUnidad.Name = "colUnidad";
            colUnidad.Width = 125;
            // 
            // colObservaciones
            // 
            colObservaciones.HeaderText = "Observaciones";
            colObservaciones.MinimumWidth = 6;
            colObservaciones.Name = "colObservaciones";
            colObservaciones.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(640, 70);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Material";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(640, 110);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Material";
            // 
            // lblPrioridad
            // 
            lblPrioridad.Location = new Point(20, 500);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(100, 23);
            lblPrioridad.TabIndex = 3;
            lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.Location = new Point(90, 497);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(100, 28);
            cmbPrioridad.TabIndex = 4;
            // 
            // lblAprobador
            // 
            lblAprobador.Location = new Point(220, 500);
            lblAprobador.Name = "lblAprobador";
            lblAprobador.Size = new Size(100, 23);
            lblAprobador.TabIndex = 5;
            lblAprobador.Text = "Aprobador:";
            // 
            // txtAprobador
            // 
            txtAprobador.Location = new Point(300, 497);
            txtAprobador.Name = "txtAprobador";
            txtAprobador.Size = new Size(200, 27);
            txtAprobador.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(520, 500);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado del Pedido:";
            // 
            // lblEstadoValor
            // 
            lblEstadoValor.Location = new Point(640, 500);
            lblEstadoValor.Name = "lblEstadoValor";
            lblEstadoValor.Size = new Size(100, 23);
            lblEstadoValor.TabIndex = 8;
            lblEstadoValor.Text = "Pendiente";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 540);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar Pedido";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(350, 540);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(550, 540);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 11;
            btnEnviar.Text = "Enviar por Correo";
            // 
            // Form2
            // 
            ClientSize = new Size(800, 637);
            Controls.Add(lblTitulo);
            Controls.Add(grpSolicitante);
            Controls.Add(grpMateriales);
            Controls.Add(lblPrioridad);
            Controls.Add(cmbPrioridad);
            Controls.Add(lblAprobador);
            Controls.Add(txtAprobador);
            Controls.Add(lblEstado);
            Controls.Add(lblEstadoValor);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviar);
            Name = "Form2";
            Text = "Formulario de Pedido de Materiales de Oficina";
            grpSolicitante.ResumeLayout(false);
            grpSolicitante.PerformLayout();
            grpMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpSolicitante;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpMateriales;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblAprobador;
        private System.Windows.Forms.TextBox txtAprobador;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
    }
}
