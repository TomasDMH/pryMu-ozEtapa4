namespace pryMuñozEtapa4
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
            this.cmdListar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.cmdAvion = new System.Windows.Forms.Button();
            this.cmdBarco = new System.Windows.Forms.Button();
            this.cmdAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(391, 334);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(228, 58);
            this.cmdListar.TabIndex = 0;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 16;
            this.lstVehiculos.Location = new System.Drawing.Point(35, 32);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(272, 404);
            this.lstVehiculos.TabIndex = 2;
            // 
            // cmdAvion
            // 
            this.cmdAvion.Location = new System.Drawing.Point(391, 124);
            this.cmdAvion.Name = "cmdAvion";
            this.cmdAvion.Size = new System.Drawing.Size(228, 58);
            this.cmdAvion.TabIndex = 3;
            this.cmdAvion.Text = "Crear Avión";
            this.cmdAvion.UseVisualStyleBackColor = true;
            this.cmdAvion.Click += new System.EventHandler(this.cmdAvion_Click);
            // 
            // cmdBarco
            // 
            this.cmdBarco.Location = new System.Drawing.Point(391, 188);
            this.cmdBarco.Name = "cmdBarco";
            this.cmdBarco.Size = new System.Drawing.Size(228, 58);
            this.cmdBarco.TabIndex = 4;
            this.cmdBarco.Text = "Crear Barco";
            this.cmdBarco.UseVisualStyleBackColor = true;
            this.cmdBarco.Click += new System.EventHandler(this.cmdBarco_Click);
            // 
            // cmdAuto
            // 
            this.cmdAuto.Location = new System.Drawing.Point(391, 60);
            this.cmdAuto.Name = "cmdAuto";
            this.cmdAuto.Size = new System.Drawing.Size(228, 58);
            this.cmdAuto.TabIndex = 5;
            this.cmdAuto.Text = "Crear Auto";
            this.cmdAuto.UseVisualStyleBackColor = true;
            this.cmdAuto.Click += new System.EventHandler(this.cmdAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.cmdAuto);
            this.Controls.Add(this.cmdBarco);
            this.Controls.Add(this.cmdAvion);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdListar);
            this.Name = "Form1";
            this.Text = "Etapa 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Button cmdAvion;
        private System.Windows.Forms.Button cmdBarco;
        private System.Windows.Forms.Button cmdAuto;
    }
}

