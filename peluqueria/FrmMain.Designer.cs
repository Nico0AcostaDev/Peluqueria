namespace peluqueria
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            ventaServicioToolStripMenuItem = new ToolStripMenuItem();
            generarServicioVentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventaServicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventaServicioToolStripMenuItem
            // 
            ventaServicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarServicioVentaToolStripMenuItem });
            ventaServicioToolStripMenuItem.Name = "ventaServicioToolStripMenuItem";
            ventaServicioToolStripMenuItem.Size = new Size(92, 20);
            ventaServicioToolStripMenuItem.Text = "Venta Servicio";
            // 
            // generarServicioVentaToolStripMenuItem
            // 
            generarServicioVentaToolStripMenuItem.Name = "generarServicioVentaToolStripMenuItem";
            generarServicioVentaToolStripMenuItem.Size = new Size(191, 22);
            generarServicioVentaToolStripMenuItem.Text = "Generar Servicio Venta";
            generarServicioVentaToolStripMenuItem.Click += generarServicioVentaToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ventaServicioToolStripMenuItem;
        private ToolStripMenuItem generarServicioVentaToolStripMenuItem;
    }
}
