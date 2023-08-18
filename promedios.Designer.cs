namespace clase4
{
    partial class promedios
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
            button1 = new Button();
            button3 = new Button();
            PromedioLabel = new Label();
            PromedioExampleLabel = new Label();
            MedianaLabel = new Label();
            MedianaTextBox = new TextBox();
            ModaLabel = new Label();
            ModaTextBox = new TextBox();
            ModaBTN = new Button();
            MedianaBTN = new Button();
            PromedioBTN = new Button();
            PromedioTextBox = new TextBox();
            PromedioResltTextBox = new TextBox();
            MedianaResltTextBox = new TextBox();
            ModaResltTextBox = new TextBox();
            LimpiarBTN = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(423, 477);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(119, 40);
            button1.TabIndex = 0;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(119, 477);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(119, 40);
            button3.TabIndex = 2;
            button3.Text = "REGRESAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PromedioLabel
            // 
            PromedioLabel.AutoSize = true;
            PromedioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PromedioLabel.Location = new Point(179, 56);
            PromedioLabel.Name = "PromedioLabel";
            PromedioLabel.Size = new Size(318, 21);
            PromedioLabel.TabIndex = 4;
            PromedioLabel.Text = "Calculadora de Promedios, Mediana y Moda.";
            // 
            // PromedioExampleLabel
            // 
            PromedioExampleLabel.AutoSize = true;
            PromedioExampleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PromedioExampleLabel.Location = new Point(119, 118);
            PromedioExampleLabel.Name = "PromedioExampleLabel";
            PromedioExampleLabel.Size = new Size(74, 20);
            PromedioExampleLabel.TabIndex = 5;
            PromedioExampleLabel.Text = "Promedio";
            PromedioExampleLabel.Click += PromedioExampleLabel_Click;
            // 
            // MedianaLabel
            // 
            MedianaLabel.AutoSize = true;
            MedianaLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MedianaLabel.Location = new Point(119, 224);
            MedianaLabel.Name = "MedianaLabel";
            MedianaLabel.Size = new Size(67, 20);
            MedianaLabel.TabIndex = 6;
            MedianaLabel.Text = "Mediana";
            // 
            // MedianaTextBox
            // 
            MedianaTextBox.Location = new Point(119, 279);
            MedianaTextBox.Name = "MedianaTextBox";
            MedianaTextBox.Size = new Size(179, 25);
            MedianaTextBox.TabIndex = 7;
            // 
            // ModaLabel
            // 
            ModaLabel.AutoSize = true;
            ModaLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ModaLabel.Location = new Point(119, 342);
            ModaLabel.Name = "ModaLabel";
            ModaLabel.Size = new Size(48, 20);
            ModaLabel.TabIndex = 8;
            ModaLabel.Text = "Moda";
            // 
            // ModaTextBox
            // 
            ModaTextBox.Location = new Point(119, 389);
            ModaTextBox.Name = "ModaTextBox";
            ModaTextBox.Size = new Size(179, 25);
            ModaTextBox.TabIndex = 9;
            // 
            // ModaBTN
            // 
            ModaBTN.Location = new Point(318, 375);
            ModaBTN.Margin = new Padding(3, 2, 3, 2);
            ModaBTN.Name = "ModaBTN";
            ModaBTN.Size = new Size(119, 40);
            ModaBTN.TabIndex = 10;
            ModaBTN.Text = "CALCULAR";
            ModaBTN.UseVisualStyleBackColor = true;
            ModaBTN.Click += ModaBTN_Click;
            // 
            // MedianaBTN
            // 
            MedianaBTN.Location = new Point(318, 265);
            MedianaBTN.Margin = new Padding(3, 2, 3, 2);
            MedianaBTN.Name = "MedianaBTN";
            MedianaBTN.Size = new Size(119, 40);
            MedianaBTN.TabIndex = 11;
            MedianaBTN.Text = "CALCULAR";
            MedianaBTN.UseVisualStyleBackColor = true;
            MedianaBTN.Click += MedianaBTN_Click;
            // 
            // PromedioBTN
            // 
            PromedioBTN.Location = new Point(318, 148);
            PromedioBTN.Margin = new Padding(3, 2, 3, 2);
            PromedioBTN.Name = "PromedioBTN";
            PromedioBTN.Size = new Size(119, 40);
            PromedioBTN.TabIndex = 12;
            PromedioBTN.Text = "CALCULAR";
            PromedioBTN.UseVisualStyleBackColor = true;
            PromedioBTN.Click += PromedioBTN_Click;
            // 
            // PromedioTextBox
            // 
            PromedioTextBox.Location = new Point(119, 162);
            PromedioTextBox.Name = "PromedioTextBox";
            PromedioTextBox.Size = new Size(179, 25);
            PromedioTextBox.TabIndex = 3;
            // 
            // PromedioResltTextBox
            // 
            PromedioResltTextBox.Location = new Point(459, 162);
            PromedioResltTextBox.Name = "PromedioResltTextBox";
            PromedioResltTextBox.ReadOnly = true;
            PromedioResltTextBox.Size = new Size(83, 25);
            PromedioResltTextBox.TabIndex = 13;
            // 
            // MedianaResltTextBox
            // 
            MedianaResltTextBox.Location = new Point(459, 279);
            MedianaResltTextBox.Name = "MedianaResltTextBox";
            MedianaResltTextBox.ReadOnly = true;
            MedianaResltTextBox.Size = new Size(83, 25);
            MedianaResltTextBox.TabIndex = 14;
            // 
            // ModaResltTextBox
            // 
            ModaResltTextBox.Location = new Point(459, 389);
            ModaResltTextBox.Name = "ModaResltTextBox";
            ModaResltTextBox.ReadOnly = true;
            ModaResltTextBox.Size = new Size(83, 25);
            ModaResltTextBox.TabIndex = 15;
            // 
            // LimpiarBTN
            // 
            LimpiarBTN.Location = new Point(274, 477);
            LimpiarBTN.Margin = new Padding(3, 2, 3, 2);
            LimpiarBTN.Name = "LimpiarBTN";
            LimpiarBTN.Size = new Size(119, 40);
            LimpiarBTN.TabIndex = 16;
            LimpiarBTN.Text = "LIMPIAR";
            LimpiarBTN.UseVisualStyleBackColor = true;
            LimpiarBTN.Click += LimpiarBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 98);
            label1.Name = "label1";
            label1.Size = new Size(126, 19);
            label1.TabIndex = 17;
            label1.Text = "Eje: 80, 90, 100, 30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 224);
            label2.Name = "label2";
            label2.Size = new Size(184, 19);
            label2.TabIndex = 18;
            label2.Text = "Eje: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 342);
            label3.Name = "label3";
            label3.Size = new Size(164, 19);
            label3.TabIndex = 19;
            label3.Text = "Eje: 30, 30, 30, 10, 15, 20";
            // 
            // promedios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 577);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LimpiarBTN);
            Controls.Add(ModaResltTextBox);
            Controls.Add(MedianaResltTextBox);
            Controls.Add(PromedioResltTextBox);
            Controls.Add(PromedioBTN);
            Controls.Add(MedianaBTN);
            Controls.Add(ModaBTN);
            Controls.Add(ModaTextBox);
            Controls.Add(ModaLabel);
            Controls.Add(MedianaTextBox);
            Controls.Add(MedianaLabel);
            Controls.Add(PromedioExampleLabel);
            Controls.Add(PromedioLabel);
            Controls.Add(PromedioTextBox);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "promedios";
            Text = "promedios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Label PromedioLabel;
        private Label PromedioExampleLabel;
        private Label MedianaLabel;
        private TextBox MedianaTextBox;
        private Label ModaLabel;
        private TextBox ModaTextBox;
        private Button ModaBTN;
        private Button MedianaBTN;
        private Button PromedioBTN;
        private TextBox PromedioTextBox;
        private TextBox PromedioResltTextBox;
        private TextBox MedianaResltTextBox;
        private TextBox ModaResltTextBox;
        private Button LimpiarBTN;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}