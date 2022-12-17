
namespace FormularioCliente
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
            this.lbltipoMoneda = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblnit = new System.Windows.Forms.Label();
            this.txtmoneda = new System.Windows.Forms.TextBox();
            this.txtmodalidad = new System.Windows.Forms.TextBox();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltipoMoneda
            // 
            this.lbltipoMoneda.AutoSize = true;
            this.lbltipoMoneda.Location = new System.Drawing.Point(12, 18);
            this.lbltipoMoneda.Name = "lbltipoMoneda";
            this.lbltipoMoneda.Size = new System.Drawing.Size(111, 17);
            this.lbltipoMoneda.TabIndex = 0;
            this.lbltipoMoneda.Text = "Tipo de moneda";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(16, 52);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(73, 17);
            this.lblModalidad.TabIndex = 1;
            this.lblModalidad.Text = "modalidad";
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Location = new System.Drawing.Point(24, 84);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(23, 17);
            this.lblnit.TabIndex = 2;
            this.lblnit.Text = "nit";
            this.lblnit.Click += new System.EventHandler(this.lblnit_Click);
            // 
            // txtmoneda
            // 
            this.txtmoneda.Location = new System.Drawing.Point(154, 15);
            this.txtmoneda.Name = "txtmoneda";
            this.txtmoneda.Size = new System.Drawing.Size(100, 22);
            this.txtmoneda.TabIndex = 5;
            // 
            // txtmodalidad
            // 
            this.txtmodalidad.Location = new System.Drawing.Point(154, 52);
            this.txtmodalidad.Name = "txtmodalidad";
            this.txtmodalidad.Size = new System.Drawing.Size(100, 22);
            this.txtmodalidad.TabIndex = 6;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(154, 84);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(100, 22);
            this.txtnit.TabIndex = 7;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(36, 394);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(67, 17);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "resultado";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(24, 128);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(62, 17);
            this.lblcantidad.TabIndex = 9;
            this.lblcantidad.Text = "cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txtmodalidad);
            this.Controls.Add(this.txtmoneda);
            this.Controls.Add(this.lblnit);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.lbltipoMoneda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipoMoneda;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.TextBox txtmoneda;
        private System.Windows.Forms.TextBox txtmodalidad;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox textBox1;
    }
}

