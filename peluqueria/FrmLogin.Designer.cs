namespace peluqueria
{
    partial class FrmLogin
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
            usuario_textbox = new TextBox();
            contraseña_textbox = new TextBox();
            aceptar_button = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // usuario_textbox
            // 
            usuario_textbox.Location = new Point(78, 116);
            usuario_textbox.Name = "usuario_textbox";
            usuario_textbox.Size = new Size(150, 23);
            usuario_textbox.TabIndex = 0;
            // 
            // contraseña_textbox
            // 
            contraseña_textbox.Location = new Point(78, 171);
            contraseña_textbox.Name = "contraseña_textbox";
            contraseña_textbox.PasswordChar = '*';
            contraseña_textbox.Size = new Size(150, 23);
            contraseña_textbox.TabIndex = 1;
            // 
            // aceptar_button
            // 
            aceptar_button.Location = new Point(112, 240);
            aceptar_button.Name = "aceptar_button";
            aceptar_button.Size = new Size(89, 41);
            aceptar_button.TabIndex = 2;
            aceptar_button.Text = "Ingresar";
            aceptar_button.UseVisualStyleBackColor = true;
            aceptar_button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 98);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 153);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LoginFoto;
            pictureBox2.Location = new Point(-237, -32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(608, 501);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(318, 356);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aceptar_button);
            Controls.Add(contraseña_textbox);
            Controls.Add(usuario_textbox);
            Controls.Add(pictureBox2);
            Name = "FrmLogin";
            Text = "Peluqueria";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usuario_textbox;
        private TextBox contraseña_textbox;
        private Button aceptar_button;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}