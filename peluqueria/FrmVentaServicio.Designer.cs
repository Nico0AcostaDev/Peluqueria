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
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductoCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicioCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(7, 32);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(433, 219);
            dgvProductos.TabIndex = 0;
            // 
            // producto_label
            // 
            producto_label.AutoSize = true;
            producto_label.Location = new Point(7, 5);
            producto_label.Name = "producto_label";
            producto_label.Size = new Size(61, 15);
            producto_label.TabIndex = 1;
            producto_label.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 271);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Servicios";
            // 
            // dgvServicios
            // 
            dgvServicios.BackgroundColor = SystemColors.ButtonHighlight;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(7, 298);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.Size = new Size(433, 233);
            dgvServicios.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(815, 12);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Productos";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1022, 495);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(815, 465);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Total a pagar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(815, 234);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Servicios";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(815, 495);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvProductoCarrito
            // 
            dgvProductoCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductoCarrito.Location = new Point(815, 42);
            dgvProductoCarrito.Name = "dgvProductoCarrito";
            dgvProductoCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductoCarrito.Size = new Size(386, 174);
            dgvProductoCarrito.TabIndex = 9;
            // 
            // dgvServicioCarrito
            // 
            dgvServicioCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicioCarrito.Location = new Point(815, 259);
            dgvServicioCarrito.Name = "dgvServicioCarrito";
            dgvServicioCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicioCarrito.Size = new Size(386, 139);
            dgvServicioCarrito.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(446, 32);
            button4.Name = "button4";
            button4.Size = new Size(44, 37);
            button4.TabIndex = 12;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(446, 298);
            button5.Name = "button5";
            button5.Size = new Size(44, 36);
            button5.TabIndex = 13;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(815, 414);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Cliente:";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(815, 438);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 16;
            label7.Text = "Empleado:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(517, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(248, 219);
            dataGridView1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(517, 5);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 18;
            label8.Text = "Clientes";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(517, 298);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(248, 233);
            dataGridView2.TabIndex = 19;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(517, 271);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 20;
            label9.Text = "Empleado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Shop;
            pictureBox1.Location = new Point(796, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 540);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // FrmVentaServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 555);
            Controls.Add(label9);
            Controls.Add(dataGridView2);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
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
            Controls.Add(pictureBox1);
            Name = "FrmVentaServicio";
            Text = "Venta Servicio";
            Load += FrmVentaServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductoCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicioCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button4;
        private Button button5;
        private Label label5;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label8;
        private DataGridView dataGridView2;
        private Label label9;
        private PictureBox pictureBox1;
    }
}