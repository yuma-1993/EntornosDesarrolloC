namespace Practica2CastingNumeros
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
            this.labEntero = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.btConvertir1 = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.labReal = new System.Windows.Forms.Label();
            this.btConvertir2 = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.labDoble = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labEntero
            // 
            this.labEntero.AutoSize = true;
            this.labEntero.Location = new System.Drawing.Point(12, 23);
            this.labEntero.Name = "labEntero";
            this.labEntero.Size = new System.Drawing.Size(121, 13);
            this.labEntero.TabIndex = 0;
            this.labEntero.Text = "Dime un número Entero:";
            this.labEntero.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(150, 20);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 1;
            // 
            // btConvertir1
            // 
            this.btConvertir1.Location = new System.Drawing.Point(281, 9);
            this.btConvertir1.Name = "btConvertir1";
            this.btConvertir1.Size = new System.Drawing.Size(75, 40);
            this.btConvertir1.TabIndex = 2;
            this.btConvertir1.Text = "Convertir";
            this.btConvertir1.UseVisualStyleBackColor = true;
            this.btConvertir1.Click += new System.EventHandler(this.btConvertir1_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(150, 66);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 4;
            // 
            // labReal
            // 
            this.labReal.AutoSize = true;
            this.labReal.Location = new System.Drawing.Point(12, 69);
            this.labReal.Name = "labReal";
            this.labReal.Size = new System.Drawing.Size(109, 13);
            this.labReal.TabIndex = 3;
            this.labReal.Text = "Dime un número Real";
            this.labReal.Click += new System.EventHandler(this.label2_Click);
            // 
            // btConvertir2
            // 
            this.btConvertir2.Location = new System.Drawing.Point(281, 55);
            this.btConvertir2.Name = "btConvertir2";
            this.btConvertir2.Size = new System.Drawing.Size(75, 40);
            this.btConvertir2.TabIndex = 5;
            this.btConvertir2.Text = "Convertir";
            this.btConvertir2.UseVisualStyleBackColor = true;
            this.btConvertir2.Click += new System.EventHandler(this.btConvertir2_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(281, 151);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 40);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(150, 123);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 7;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(150, 171);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 8;
            // 
            // labDoble
            // 
            this.labDoble.AutoSize = true;
            this.labDoble.Location = new System.Drawing.Point(12, 126);
            this.labDoble.Name = "labDoble";
            this.labDoble.Size = new System.Drawing.Size(117, 13);
            this.labDoble.TabIndex = 9;
            this.labDoble.Text = "El doble del número es:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "La mitad del número es:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDoble);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConvertir2);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.labReal);
            this.Controls.Add(this.btConvertir1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.labEntero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEntero;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button btConvertir1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label labReal;
        private System.Windows.Forms.Button btConvertir2;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label labDoble;
        private System.Windows.Forms.Label label1;
    }
}

