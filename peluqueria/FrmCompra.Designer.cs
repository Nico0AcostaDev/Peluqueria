namespace peluqueria
{
    partial class FrmCompra
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
            label1 = new Label();
            dgvProductos = new DataGridView();
            label2 = new Label();
            dgvProveedores = new DataGridView();
            dgvOrden = new DataGridView();
            Pedido = new Label();
            btnAceptar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrden).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 27);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(398, 213);
            dgvProductos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Proveedores";
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 275);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(398, 213);
            dgvProveedores.TabIndex = 3;
            // 
            // dgvOrden
            // 
            dgvOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrden.Location = new Point(477, 101);
            dgvOrden.Name = "dgvOrden";
            dgvOrden.Size = new Size(350, 273);
            dgvOrden.TabIndex = 4;
            // 
            // Pedido
            // 
            Pedido.AutoSize = true;
            Pedido.Location = new Point(477, 64);
            Pedido.Name = "Pedido";
            Pedido.Size = new Size(44, 15);
            Pedido.TabIndex = 5;
            Pedido.Text = "Pedido";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(724, 418);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 47);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(765, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 497);
            Controls.Add(button2);
            Controls.Add(btnAceptar);
            Controls.Add(Pedido);
            Controls.Add(dgvOrden);
            Controls.Add(dgvProveedores);
            Controls.Add(label2);
            Controls.Add(dgvProductos);
            Controls.Add(label1);
            Name = "FrmCompra";
            Text = "Orden Compra";
            Load += FrmCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProductos;
        private Label label2;
        private DataGridView dgvProveedores;
        private DataGridView dgvOrden;
        private Label Pedido;
        private Button btnAceptar;
        private Button button2;
    }
}