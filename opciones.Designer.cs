namespace clase4
{
    partial class opciones
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
            ConversorFormBTN = new Button();
            button2 = new Button();
            OptionsFormLabel = new Label();
            button3 = new Button();
            UsernameLabel = new Label();
            RolLabel = new Label();
            SuspendLayout();
            // 
            // ConversorFormBTN
            // 
            ConversorFormBTN.Location = new Point(71, 78);
            ConversorFormBTN.Margin = new Padding(3, 2, 3, 2);
            ConversorFormBTN.Name = "ConversorFormBTN";
            ConversorFormBTN.Size = new Size(105, 41);
            ConversorFormBTN.TabIndex = 0;
            ConversorFormBTN.Text = "Conversor de Unidades";
            ConversorFormBTN.UseVisualStyleBackColor = true;
            ConversorFormBTN.Click += ConversorFormBTN_Click;
            // 
            // button2
            // 
            button2.Location = new Point(267, 78);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(107, 41);
            button2.TabIndex = 1;
            button2.Text = "Promedio de Notas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OptionsFormLabel
            // 
            OptionsFormLabel.AutoSize = true;
            OptionsFormLabel.Location = new Point(156, 43);
            OptionsFormLabel.Name = "OptionsFormLabel";
            OptionsFormLabel.Size = new Size(137, 15);
            OptionsFormLabel.TabIndex = 2;
            OptionsFormLabel.Text = "Opciones de calculadora";
            // 
            // button3
            // 
            button3.Location = new Point(174, 149);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 3;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = SystemColors.MenuHighlight;
            UsernameLabel.Location = new Point(12, 9);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(77, 25);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "Usuario";
            // 
            // RolLabel
            // 
            RolLabel.AutoSize = true;
            RolLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RolLabel.ForeColor = SystemColors.Highlight;
            RolLabel.Location = new Point(379, 9);
            RolLabel.Name = "RolLabel";
            RolLabel.Size = new Size(38, 25);
            RolLabel.TabIndex = 5;
            RolLabel.Text = "Rol";
            // 
            // opciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 288);
            Controls.Add(RolLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(button3);
            Controls.Add(OptionsFormLabel);
            Controls.Add(button2);
            Controls.Add(ConversorFormBTN);
            Margin = new Padding(3, 2, 3, 2);
            Name = "opciones";
            Text = "opciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConversorFormBTN;
        private Button button2;
        private Label OptionsFormLabel;
        private Button button3;
        private Label UsernameLabel;
        public Label RolLabel;
        private Label label3;
    }
}