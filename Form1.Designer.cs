namespace clase4
{
    partial class Login
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
            PasswordTextBox = new TextBox();
            IngresarBTN = new Button();
            LimpiarBTN = new Button();
            LabelUsuario = new Label();
            LabelContraseña = new Label();
            UserNameComboBox = new ComboBox();
            SuspendLayout();
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(126, 168);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(211, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // IngresarBTN
            // 
            IngresarBTN.Location = new Point(126, 216);
            IngresarBTN.Margin = new Padding(3, 2, 3, 2);
            IngresarBTN.Name = "IngresarBTN";
            IngresarBTN.Size = new Size(95, 35);
            IngresarBTN.TabIndex = 2;
            IngresarBTN.Text = "INGRESAR";
            IngresarBTN.UseVisualStyleBackColor = true;
            IngresarBTN.Click += IngresarBTN_Click_1;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(242, 216);
            LimpiarBTN.Margin = new Padding(3, 2, 3, 2);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(95, 35);
            LimpiarBTN.TabIndex = 3;
            LimpiarBTN.Text = "LIMPIAR";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.Location = new Point(199, 104);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(56, 15);
            LabelUsuario.TabIndex = 4;
            LabelUsuario.Text = "USUARIO";
            LabelUsuario.Click += label1_Click;
            // 
            // LabelContraseña
            // 
            LabelContraseña.AutoSize = true;
            LabelContraseña.Location = new Point(185, 151);
            LabelContraseña.Name = "LabelContraseña";
            LabelContraseña.Size = new Size(83, 15);
            LabelContraseña.TabIndex = 5;
            LabelContraseña.Text = "CONTRASEÑA";
            LabelContraseña.Click += label2_Click;
            // 
            // UserNameComboBox
            // 
            UserNameComboBox.BackColor = SystemColors.Window;
            UserNameComboBox.FormattingEnabled = true;
            UserNameComboBox.Items.AddRange(new object[] { "Juan", "Admin" });
            UserNameComboBox.Location = new Point(126, 121);
            UserNameComboBox.Margin = new Padding(3, 2, 3, 2);
            UserNameComboBox.Name = "UserNameComboBox";
            UserNameComboBox.Size = new Size(211, 23);
            UserNameComboBox.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 349);
            Controls.Add(UserNameComboBox);
            Controls.Add(LabelContraseña);
            Controls.Add(LabelUsuario);
            Controls.Add(LimpiarBTN);
            Controls.Add(IngresarBTN);
            Controls.Add(PasswordTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox PasswordTextBox;
        private Button IngresarBTN;
        private Button LimpiarBTN;
        private Label LabelUsuario;
        private Label LabelContraseña;
        private ComboBox UserNameComboBox;
    }
}