namespace peluqueria
{
    partial class FrmVentaServicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            producto_label = new Label();
            label1 = new Label();
            dgvServicios = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            dgvProductoCarrito = new DataGridView();
            dgvServicioCarrito = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductoCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicioCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 74);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(433, 210);
            dgvProductos.TabIndex = 0;
            // 
            // producto_label
            // 
            producto_label.AutoSize = true;
            producto_label.Location = new Point(12, 47);
            producto_label.Name = "producto_label";
            producto_label.Size = new Size(61, 15);
            producto_label.TabIndex = 1;
            producto_label.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 296);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Servicios";
            // 
            // dgvServicios
            // 
            dgvServicios.BackgroundColor = SystemColors.ButtonHighlight;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(12, 324);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.Size = new Size(433, 210);
            dgvServicios.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 68);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Productos";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(841, 495);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(634, 465);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Total a pagar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 278);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Servicios";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(634, 495);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvProductoCarrito
            // 
            dgvProductoCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductoCarrito.Location = new Point(634, 86);
            dgvProductoCarrito.Name = "dgvProductoCarrito";
            dgvProductoCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductoCarrito.Size = new Size(334, 174);
            dgvProductoCarrito.TabIndex = 9;
            // 
            // dgvServicioCarrito
            // 
            dgvServicioCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicioCarrito.Location = new Point(634, 303);
            dgvServicioCarrito.Name = "dgvServicioCarrito";
            dgvServicioCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicioCarrito.Size = new Size(334, 139);
            dgvServicioCarrito.TabIndex = 10;
            // 
            // button3
            // 
            button3.Location = new Point(791, 21);
            button3.Name = "button3";
            button3.Size = new Size(114, 26);
            button3.TabIndex = 11;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(451, 74);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 12;
            button4.Text = "Añadir Producto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(451, 324);
            button5.Name = "button5";
            button5.Size = new Size(121, 23);
            button5.TabIndex = 13;
            button5.Text = "Añadir Servicio";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FrmVentaServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 552);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dgvServicioCarrito);
            Controls.Add(dgvProductoCarrito);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dgvServicios);
            Controls.Add(label1);
            Controls.Add(producto_label);
            Controls.Add(dgvProductos);
            Name = "FrmVentaServicio";
            Text = "Venta Servicio";
            Load += FrmVentaServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductoCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicioCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label producto_label;
        private Label label1;
        private DataGridView dgvServicios;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Button button2;
        private DataGridView dgvProductoCarrito;
        private DataGridView dgvServicioCarrito;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}