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
            PedidoMaterialesText = new TextBox();
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
            FechaText = new TextBox();
            label6 = new Label();
            MaterialesListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label7 = new Label();
            CantidadText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedido Materiales Número";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // PedidoMaterialesText
            // 
            PedidoMaterialesText.Location = new Point(270, 14);
            PedidoMaterialesText.Margin = new Padding(3, 2, 3, 2);
            PedidoMaterialesText.Name = "PedidoMaterialesText";
            PedidoMaterialesText.Size = new Size(188, 23);
            PedidoMaterialesText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 164);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 0;
            label2.Text = "Seleccione el material a solicitar";
            // 
            // MaterialCombo
            // 
            MaterialCombo.FormattingEnabled = true;
            MaterialCombo.Location = new Point(270, 158);
            MaterialCombo.Margin = new Padding(3, 2, 3, 2);
            MaterialCombo.Name = "MaterialCombo";
            MaterialCombo.Size = new Size(188, 23);
            MaterialCombo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 195);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 0;
            label3.Text = "Ingrese la cantidad a solicitar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 227);
            label4.Name = "label4";
            label4.Size = new Size(175, 15);
            label4.TabIndex = 0;
            label4.Text = "Ingrese la descripción adicional ";
            // 
            // DescAdicText
            // 
            DescAdicText.Location = new Point(270, 222);
            DescAdicText.Margin = new Padding(3, 2, 3, 2);
            DescAdicText.Name = "DescAdicText";
            DescAdicText.Size = new Size(188, 23);
            DescAdicText.TabIndex = 5;
            // 
            // AgregarBoton
            // 
            AgregarBoton.Location = new Point(374, 254);
            AgregarBoton.Margin = new Padding(3, 2, 3, 2);
            AgregarBoton.Name = "AgregarBoton";
            AgregarBoton.Size = new Size(82, 45);
            AgregarBoton.TabIndex = 6;
            AgregarBoton.Text = "Agregar";
            AgregarBoton.UseVisualStyleBackColor = true;
            // 
            // AprobarBoton
            // 
            AprobarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AprobarBoton.ForeColor = Color.FromArgb(0, 192, 0);
            AprobarBoton.Location = new Point(28, 658);
            AprobarBoton.Margin = new Padding(3, 2, 3, 2);
            AprobarBoton.Name = "AprobarBoton";
            AprobarBoton.Size = new Size(86, 40);
            AprobarBoton.TabIndex = 7;
            AprobarBoton.Text = "Enviar a aprobación";
            AprobarBoton.UseVisualStyleBackColor = true;
            // 
            // AComprasBoton
            // 
            AComprasBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AComprasBoton.Location = new Point(155, 658);
            AComprasBoton.Margin = new Padding(3, 2, 3, 2);
            AComprasBoton.Name = "AComprasBoton";
            AComprasBoton.Size = new Size(82, 40);
            AComprasBoton.TabIndex = 8;
            AComprasBoton.Text = "Enviar a compras";
            AComprasBoton.UseVisualStyleBackColor = true;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelarBoton.ForeColor = Color.Red;
            CancelarBoton.Location = new Point(383, 658);
            CancelarBoton.Margin = new Padding(3, 2, 3, 2);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(82, 40);
            CancelarBoton.TabIndex = 9;
            CancelarBoton.Text = "Cancelar Pedido";
            CancelarBoton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 50);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 0;
            label5.Text = "Fecha de pedido";
            // 
            // FechaText
            // 
            FechaText.Location = new Point(270, 45);
            FechaText.Margin = new Padding(3, 2, 3, 2);
            FechaText.Name = "FechaText";
            FechaText.Size = new Size(188, 23);
            FechaText.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(67, 272);
            label6.Name = "label6";
            label6.Size = new Size(238, 30);
            label6.TabIndex = 0;
            label6.Text = "Materiales solicitados";
            // 
            // MaterialesListView
            // 
            MaterialesListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            MaterialesListView.Location = new Point(20, 305);
            MaterialesListView.Name = "MaterialesListView";
            MaterialesListView.Size = new Size(438, 179);
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
            label7.Location = new Point(20, 123);
            label7.Name = "label7";
            label7.Size = new Size(416, 15);
            label7.TabIndex = 11;
            label7.Text = "Seleccione los materiales a solicitar  y presione agregar para ponerlo en la lista";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(270, 192);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(188, 23);
            CantidadText.TabIndex = 12;
            // 
            // PedidoMaterialesOficinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 732);
            Controls.Add(CantidadText);
            Controls.Add(label7);
            Controls.Add(MaterialesListView);
            Controls.Add(label6);
            Controls.Add(FechaText);
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
            Controls.Add(PedidoMaterialesText);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PedidoMaterialesOficinaForm";
            Text = "Pedido de Materiales Oficina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PedidoMaterialesText;
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
        private TextBox FechaText;
        private Label label6;
        private ListView MaterialesListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label7;
        private TextBox CantidadText;
    }
}
