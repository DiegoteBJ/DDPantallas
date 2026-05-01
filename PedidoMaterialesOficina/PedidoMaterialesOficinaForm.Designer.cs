namespace DDPantallas.PedidoMaterialesOficina
{
    partial class PedidoMaterialesOficinaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            MaterialCombo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            DescAdicText = new TextBox();
            AgregarBoton = new Button();
            AprobarBoton = new Button();
            AComprasBoton = new Button();
            CancelarBoton = new Button();
            label5 = new Label();
            label6 = new Label();
            MaterialesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label7 = new Label();
            CantidadText = new TextBox();
            QuitarBoton = new Button();
            ImprimeNroPedidoLabel = new Label();
            ImprimeFechaLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 0;
            label1.Text = "Pedido Materiales Número";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 186);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 0;
            label2.Text = "Seleccione el material a solicitar";
            // 
            // MaterialCombo
            // 
            MaterialCombo.FormattingEnabled = true;
            MaterialCombo.Location = new Point(309, 178);
            MaterialCombo.Name = "MaterialCombo";
            MaterialCombo.Size = new Size(214, 28);
            MaterialCombo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 227);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 0;
            label3.Text = "Ingrese la cantidad a solicitar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 270);
            label4.Name = "label4";
            label4.Size = new Size(222, 20);
            label4.TabIndex = 0;
            label4.Text = "Ingrese la descripción adicional ";
            // 
            // DescAdicText
            // 
            DescAdicText.Location = new Point(309, 263);
            DescAdicText.Name = "DescAdicText";
            DescAdicText.Size = new Size(214, 27);
            DescAdicText.TabIndex = 5;
            // 
            // AgregarBoton
            // 
            AgregarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AgregarBoton.ForeColor = Color.Lime;
            AgregarBoton.Location = new Point(317, 631);
            AgregarBoton.Name = "AgregarBoton";
            AgregarBoton.Size = new Size(94, 60);
            AgregarBoton.TabIndex = 6;
            AgregarBoton.Text = "Agregar";
            AgregarBoton.UseVisualStyleBackColor = true;
            AgregarBoton.Click += AgregarBoton_Click;
            // 
            // AprobarBoton
            // 
            AprobarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AprobarBoton.ForeColor = Color.FromArgb(0, 192, 0);
            AprobarBoton.Location = new Point(23, 744);
            AprobarBoton.Name = "AprobarBoton";
            AprobarBoton.Size = new Size(98, 53);
            AprobarBoton.TabIndex = 7;
            AprobarBoton.Text = "Enviar a aprobación";
            AprobarBoton.UseVisualStyleBackColor = true;
            // 
            // AComprasBoton
            // 
            AComprasBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AComprasBoton.Location = new Point(168, 744);
            AComprasBoton.Name = "AComprasBoton";
            AComprasBoton.Size = new Size(94, 53);
            AComprasBoton.TabIndex = 8;
            AComprasBoton.Text = "Enviar a compras";
            AComprasBoton.UseVisualStyleBackColor = true;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelarBoton.ForeColor = Color.Red;
            CancelarBoton.Location = new Point(429, 744);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(94, 53);
            CancelarBoton.TabIndex = 9;
            CancelarBoton.Text = "Cancelar Pedido";
            CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 67);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 0;
            label5.Text = "Fecha de pedido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(125, 319);
            label6.Name = "label6";
            label6.Size = new Size(298, 37);
            label6.TabIndex = 0;
            label6.Text = "Materiales solicitados";
            // 
            // MaterialesListView
            // 
            MaterialesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            MaterialesListView.Location = new Point(23, 374);
            MaterialesListView.Margin = new Padding(3, 4, 3, 4);
            MaterialesListView.Name = "MaterialesListView";
            MaterialesListView.Size = new Size(500, 237);
            MaterialesListView.TabIndex = 10;
            MaterialesListView.UseCompatibleStateImageBehavior = false;
            MaterialesListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Descripcion";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Descrip. Adicional";
            columnHeader3.Width = 180;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 136);
            label7.Name = "label7";
            label7.Size = new Size(554, 20);
            label7.TabIndex = 11;
            label7.Text = "Seleccione los materiales a solicitar  y presione agregar para ponerlo en la lista";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(309, 223);
            CantidadText.Margin = new Padding(3, 4, 3, 4);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(214, 27);
            CantidadText.TabIndex = 12;
            // 
            // QuitarBoton
            // 
            QuitarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            QuitarBoton.ForeColor = Color.Red;
            QuitarBoton.Location = new Point(429, 631);
            QuitarBoton.Name = "QuitarBoton";
            QuitarBoton.Size = new Size(94, 60);
            QuitarBoton.TabIndex = 13;
            QuitarBoton.Text = "Quitar";
            QuitarBoton.UseVisualStyleBackColor = true;
            QuitarBoton.Click += QuitarBoton_Click;
            // 
            // ImprimeNroPedidoLabel
            // 
            ImprimeNroPedidoLabel.AutoSize = true;
            ImprimeNroPedidoLabel.Location = new Point(309, 25);
            ImprimeNroPedidoLabel.Name = "ImprimeNroPedidoLabel";
            ImprimeNroPedidoLabel.Size = new Size(111, 20);
            ImprimeNroPedidoLabel.TabIndex = 14;
            ImprimeNroPedidoLabel.Text = "0010-00001234";
            ImprimeNroPedidoLabel.Click += ImprimeNroPedidoLabel_Click;
            // 
            // ImprimeFechaLabel
            // 
            ImprimeFechaLabel.AutoSize = true;
            ImprimeFechaLabel.Location = new Point(309, 67);
            ImprimeFechaLabel.Name = "ImprimeFechaLabel";
            ImprimeFechaLabel.Size = new Size(85, 20);
            ImprimeFechaLabel.TabIndex = 15;
            ImprimeFechaLabel.Text = "30/04/2026";
            // 
            // PedidoMaterialesOficinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 810);
            Controls.Add(ImprimeFechaLabel);
            Controls.Add(ImprimeNroPedidoLabel);
            Controls.Add(QuitarBoton);
            Controls.Add(CantidadText);
            Controls.Add(label7);
            Controls.Add(MaterialesListView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CancelarBoton);
            Controls.Add(AComprasBoton);
            Controls.Add(AprobarBoton);
            Controls.Add(AgregarBoton);
            Controls.Add(DescAdicText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MaterialCombo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PedidoMaterialesOficinaForm";
            Text = "Pedido de Materiales Oficina";
            Load += PedidoMaterialesOficinaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MaterialCombo;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox DescAdicText;
        private Button AgregarBoton;
        private Button AprobarBoton;
        private Button AComprasBoton;
        private Button CancelarBoton;
        private Label label5;
        private Label label6;
        private ListView MaterialesListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label7;
        private TextBox CantidadText;
        private Button QuitarBoton;
        private Label ImprimeNroPedidoLabel;
        private Label ImprimeFechaLabel;
    }
}
