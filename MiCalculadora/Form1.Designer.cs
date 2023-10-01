namespace MiCalculadora
{
    partial class Form1
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
            operar = new Button();
            limpiar = new Button();
            cerrar = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            operador1 = new Label();
            operacion = new Label();
            operador2 = new Label();
            representarR = new Label();
            binario = new RadioButton();
            decima = new RadioButton();
            resultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // operar
            // 
            operar.Location = new Point(103, 498);
            operar.Name = "operar";
            operar.Size = new Size(223, 71);
            operar.TabIndex = 0;
            operar.Text = "Operar";
            operar.UseVisualStyleBackColor = true;
            operar.Click += button1_Click;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(504, 498);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(223, 71);
            limpiar.TabIndex = 1;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // cerrar
            // 
            cerrar.Location = new Point(913, 493);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(223, 76);
            cerrar.TabIndex = 3;
            cerrar.Text = "Cerrar";
            cerrar.UseVisualStyleBackColor = true;
            cerrar.Click += cerrar_click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(516, 407);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 36);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(103, 407);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 43);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(913, 407);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 43);
            textBox2.TabIndex = 6;
            // 
            // operador1
            // 
            operador1.AutoSize = true;
            operador1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            operador1.Location = new Point(103, 338);
            operador1.Name = "operador1";
            operador1.Size = new Size(217, 37);
            operador1.TabIndex = 7;
            operador1.Text = "Primer operador:";
            // 
            // operacion
            // 
            operacion.AutoSize = true;
            operacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            operacion.Location = new Point(533, 338);
            operacion.Name = "operacion";
            operacion.Size = new Size(152, 37);
            operacion.TabIndex = 8;
            operacion.Text = "Operacion::";
            // 
            // operador2
            // 
            operador2.AutoSize = true;
            operador2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            operador2.Location = new Point(894, 338);
            operador2.Name = "operador2";
            operador2.Size = new Size(246, 37);
            operador2.TabIndex = 9;
            operador2.Text = "Segundo operador:";
            // 
            // representarR
            // 
            representarR.AutoSize = true;
            representarR.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            representarR.Location = new Point(394, 176);
            representarR.Name = "representarR";
            representarR.Size = new Size(232, 28);
            representarR.TabIndex = 10;
            representarR.Text = "Representar resultado en:\r\n";
            // 
            // binario
            // 
            binario.AutoSize = true;
            binario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            binario.Location = new Point(478, 255);
            binario.Name = "binario";
            binario.Size = new Size(74, 24);
            binario.TabIndex = 11;
            binario.TabStop = true;
            binario.Text = "binario";
            binario.UseVisualStyleBackColor = true;
            binario.MouseClick += Binario_MouseClick;
           
            // 
            // decima
            // 
            decima.AutoSize = true;
            decima.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            decima.Location = new Point(577, 255);
            decima.Name = "decima";
            decima.Size = new Size(80, 24);
            decima.TabIndex = 12;
            decima.TabStop = true;
            decima.Text = "decimal";
            decima.UseVisualStyleBackColor = true;
            decima.MouseClick += Decima_MouseClick;
            
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            resultado.Location = new Point(63, 46);
            resultado.Name = "resultado";
            resultado.Size = new Size(207, 46);
            resultado.TabIndex = 13;
            resultado.Text = "RESULTADO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(276, 46);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 621);
            Controls.Add(label1);
            Controls.Add(resultado);
            Controls.Add(decima);
            Controls.Add(binario);
            Controls.Add(representarR);
            Controls.Add(operador2);
            Controls.Add(operacion);
            Controls.Add(operador1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(cerrar);
            Controls.Add(limpiar);
            Controls.Add(operar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Button operar;
        private Button limpiar;
        private Button cerrar;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label operador1;
        private Label operacion;
        private Label operador2;
        private Label representarR;
        private RadioButton binario;
        private RadioButton decima;
        private Label resultado;
        private Label label1;
    }
}