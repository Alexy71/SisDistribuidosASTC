
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
            this.lblproducto = new System.Windows.Forms.Label();
            this.lblpreciounitario = new System.Windows.Forms.Label();
            this.lblpreciototal = new System.Windows.Forms.Label();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxpreciounitario = new System.Windows.Forms.TextBox();
            this.textBoxpreciototal = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
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
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(323, 15);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(64, 17);
            this.lblproducto.TabIndex = 11;
            this.lblproducto.Text = "producto";
            // 
            // lblpreciounitario
            // 
            this.lblpreciounitario.AutoSize = true;
            this.lblpreciounitario.Location = new System.Drawing.Point(323, 57);
            this.lblpreciounitario.Name = "lblpreciounitario";
            this.lblpreciounitario.Size = new System.Drawing.Size(94, 17);
            this.lblpreciounitario.TabIndex = 12;
            this.lblpreciounitario.Text = "preciounitario";
            // 
            // lblpreciototal
            // 
            this.lblpreciototal.AutoSize = true;
            this.lblpreciototal.Location = new System.Drawing.Point(323, 98);
            this.lblpreciototal.Name = "lblpreciototal";
            this.lblpreciototal.Size = new System.Drawing.Size(78, 17);
            this.lblpreciototal.TabIndex = 13;
            this.lblpreciototal.Text = "precio total";
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(428, 9);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(100, 22);
            this.textBoxproducto.TabIndex = 14;
            // 
            // textBoxpreciounitario
            // 
            this.textBoxpreciounitario.Location = new System.Drawing.Point(424, 51);
            this.textBoxpreciounitario.Name = "textBoxpreciounitario";
            this.textBoxpreciounitario.Size = new System.Drawing.Size(100, 22);
            this.textBoxpreciounitario.TabIndex = 15;
            // 
            // textBoxpreciototal
            // 
            this.textBoxpreciototal.Location = new System.Drawing.Point(426, 110);
            this.textBoxpreciototal.Name = "textBoxpreciototal";
            this.textBoxpreciototal.Size = new System.Drawing.Size(100, 22);
            this.textBoxpreciototal.TabIndex = 16;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(109, 231);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 17;
            this.btnenviar.Text = "enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.textBoxpreciototal);
            this.Controls.Add(this.textBoxpreciounitario);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.lblpreciototal);
            this.Controls.Add(this.lblpreciounitario);
            this.Controls.Add(this.lblproducto);
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
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label lblpreciounitario;
        private System.Windows.Forms.Label lblpreciototal;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.TextBox textBoxpreciounitario;
        private System.Windows.Forms.TextBox textBoxpreciototal;
        private System.Windows.Forms.Button btnenviar;
    }
}

