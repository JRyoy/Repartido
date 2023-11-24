namespace WinFormsDeliExpress
{
    partial class Inicio
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
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelContraseña = new Label();
            NombreUsuario = new Label();
            InicioSesion = new Label();
            BotCambiar1 = new Button();
            BotEntrar1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelContraseña);
            groupBox1.Controls.Add(NombreUsuario);
            groupBox1.Controls.Add(InicioSesion);
            groupBox1.Controls.Add(BotCambiar1);
            groupBox1.Controls.Add(BotEntrar1);
            groupBox1.Location = new Point(209, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " ";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(101, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(101, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 5;
            // 
            // labelContraseña
            // 
            labelContraseña.Anchor = AnchorStyles.None;
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(101, 153);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(67, 15);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña";
            // 
            // NombreUsuario
            // 
            NombreUsuario.Anchor = AnchorStyles.None;
            NombreUsuario.AutoSize = true;
            NombreUsuario.Location = new Point(101, 92);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(109, 15);
            NombreUsuario.TabIndex = 3;
            NombreUsuario.Text = "Nombre de usuario";
            NombreUsuario.Click += label2_Click;
            // 
            // InicioSesion
            // 
            InicioSesion.Anchor = AnchorStyles.None;
            InicioSesion.AutoSize = true;
            InicioSesion.Location = new Point(168, 46);
            InicioSesion.Name = "InicioSesion";
            InicioSesion.Size = new Size(76, 15);
            InicioSesion.TabIndex = 2;
            InicioSesion.Text = "Iniciar Sesion";
            InicioSesion.Click += label1_Click;
            // 
            // BotCambiar1
            // 
            BotCambiar1.Anchor = AnchorStyles.None;
            BotCambiar1.Location = new Point(86, 238);
            BotCambiar1.Name = "BotCambiar1";
            BotCambiar1.Size = new Size(125, 23);
            BotCambiar1.TabIndex = 1;
            BotCambiar1.Text = "Cambiar Contraseña";
            BotCambiar1.UseVisualStyleBackColor = true;
            BotCambiar1.Click += BotCambiar1_Click;
            // 
            // BotEntrar1
            // 
            BotEntrar1.Anchor = AnchorStyles.None;
            BotEntrar1.Location = new Point(272, 238);
            BotEntrar1.Name = "BotEntrar1";
            BotEntrar1.Size = new Size(75, 23);
            BotEntrar1.TabIndex = 0;
            BotEntrar1.Text = "Entrar";
            BotEntrar1.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DeliExpress";
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            SizeChanged += Inicio_SizeChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BotCambiar1;
        private Button BotEntrar1;
        private Label InicioSesion;
        private Label NombreUsuario;
        private Label labelContraseña;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}