namespace Practica_4._7___Ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.kilometrajeInicio = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.kilometrajeFin = new System.Windows.Forms.Label();
            this.cantidadE = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.btnKilometros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // kilometrajeInicio
            // 
            this.kilometrajeInicio.AutoSize = true;
            this.kilometrajeInicio.Location = new System.Drawing.Point(46, 33);
            this.kilometrajeInicio.Name = "kilometrajeInicio";
            this.kilometrajeInicio.Size = new System.Drawing.Size(100, 13);
            this.kilometrajeInicio.TabIndex = 0;
            this.kilometrajeInicio.Text = "Kilometraje de inicio";
            this.kilometrajeInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(164, 31);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(164, 88);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // kilometrajeFin
            // 
            this.kilometrajeFin.AutoSize = true;
            this.kilometrajeFin.Location = new System.Drawing.Point(46, 88);
            this.kilometrajeFin.Name = "kilometrajeFin";
            this.kilometrajeFin.Size = new System.Drawing.Size(87, 13);
            this.kilometrajeFin.TabIndex = 2;
            this.kilometrajeFin.Text = "Kilometraje de fin";
            this.kilometrajeFin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cantidadE
            // 
            this.cantidadE.AutoSize = true;
            this.cantidadE.Location = new System.Drawing.Point(49, 149);
            this.cantidadE.Name = "cantidadE";
            this.cantidadE.Size = new System.Drawing.Size(111, 13);
            this.cantidadE.TabIndex = 4;
            this.cantidadE.Text = "Cantidad obtenida (€):";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(198, 149);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 5;
            this.resultado.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(126, 179);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(111, 33);
            this.calcular.TabIndex = 6;
            this.calcular.Text = "CALCULAR";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // btnKilometros
            // 
            this.btnKilometros.Location = new System.Drawing.Point(126, 218);
            this.btnKilometros.Name = "btnKilometros";
            this.btnKilometros.Size = new System.Drawing.Size(111, 33);
            this.btnKilometros.TabIndex = 7;
            this.btnKilometros.Text = "Mostrar Kilometros";
            this.btnKilometros.UseVisualStyleBackColor = true;
            this.btnKilometros.Visible = false;
            this.btnKilometros.Click += new System.EventHandler(this.btnKilometros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 273);
            this.Controls.Add(this.btnKilometros);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.cantidadE);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.kilometrajeFin);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.kilometrajeInicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kilometrajeInicio;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label kilometrajeFin;
        private System.Windows.Forms.Label cantidadE;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button btnKilometros;
    }
}

