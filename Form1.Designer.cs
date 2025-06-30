namespace LineaRectaPOOGUI
{
    partial class LineaRectaGUI
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbPrograma = new System.Windows.Forms.Label();
            this.lbPunto1 = new System.Windows.Forms.Label();
            this.lbpuntox = new System.Windows.Forms.Label();
            this.puntoy = new System.Windows.Forms.Label();
            this.lbpunto2 = new System.Windows.Forms.Label();
            this.puntox2 = new System.Windows.Forms.Label();
            this.lbpuntoy2 = new System.Windows.Forms.Label();
            this.txtPuntoX_1 = new System.Windows.Forms.TextBox();
            this.txtPuntoY_1 = new System.Windows.Forms.TextBox();
            this.txtPuntoX_2 = new System.Windows.Forms.TextBox();
            this.txtPuntoY_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalcular.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(270, 370);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 37);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(459, 369);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbPrograma
            // 
            this.lbPrograma.AutoSize = true;
            this.lbPrograma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrograma.Location = new System.Drawing.Point(227, 21);
            this.lbPrograma.Name = "lbPrograma";
            this.lbPrograma.Size = new System.Drawing.Size(353, 23);
            this.lbPrograma.TabIndex = 2;
            this.lbPrograma.Text = "Programa para calular la distancia de una recta";
            // 
            // lbPunto1
            // 
            this.lbPunto1.AutoSize = true;
            this.lbPunto1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPunto1.Location = new System.Drawing.Point(348, 44);
            this.lbPunto1.Name = "lbPunto1";
            this.lbPunto1.Size = new System.Drawing.Size(133, 20);
            this.lbPunto1.TabIndex = 3;
            this.lbPunto1.Text = "Ingresa el punto 1";
            this.lbPunto1.Click += new System.EventHandler(this.lbPunto1_Click);
            // 
            // lbpuntox
            // 
            this.lbpuntox.AutoSize = true;
            this.lbpuntox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpuntox.Location = new System.Drawing.Point(266, 82);
            this.lbpuntox.Name = "lbpuntox";
            this.lbpuntox.Size = new System.Drawing.Size(61, 23);
            this.lbpuntox.TabIndex = 4;
            this.lbpuntox.Text = "PuntoX";
            // 
            // puntoy
            // 
            this.puntoy.AutoSize = true;
            this.puntoy.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntoy.Location = new System.Drawing.Point(266, 115);
            this.puntoy.Name = "puntoy";
            this.puntoy.Size = new System.Drawing.Size(60, 23);
            this.puntoy.TabIndex = 5;
            this.puntoy.Text = "PuntoY";
            // 
            // lbpunto2
            // 
            this.lbpunto2.AutoSize = true;
            this.lbpunto2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpunto2.Location = new System.Drawing.Point(348, 152);
            this.lbpunto2.Name = "lbpunto2";
            this.lbpunto2.Size = new System.Drawing.Size(135, 20);
            this.lbpunto2.TabIndex = 6;
            this.lbpunto2.Text = "Ingresa el punto 2";
            // 
            // puntox2
            // 
            this.puntox2.AutoSize = true;
            this.puntox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntox2.Location = new System.Drawing.Point(266, 186);
            this.puntox2.Name = "puntox2";
            this.puntox2.Size = new System.Drawing.Size(61, 23);
            this.puntox2.TabIndex = 7;
            this.puntox2.Text = "PuntoX";
            // 
            // lbpuntoy2
            // 
            this.lbpuntoy2.AutoSize = true;
            this.lbpuntoy2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpuntoy2.Location = new System.Drawing.Point(266, 221);
            this.lbpuntoy2.Name = "lbpuntoy2";
            this.lbpuntoy2.Size = new System.Drawing.Size(60, 23);
            this.lbpuntoy2.TabIndex = 8;
            this.lbpuntoy2.Text = "PuntoY";
            // 
            // txtPuntoX_1
            // 
            this.txtPuntoX_1.Location = new System.Drawing.Point(333, 86);
            this.txtPuntoX_1.Name = "txtPuntoX_1";
            this.txtPuntoX_1.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoX_1.TabIndex = 9;
            // 
            // txtPuntoY_1
            // 
            this.txtPuntoY_1.Location = new System.Drawing.Point(333, 115);
            this.txtPuntoY_1.Name = "txtPuntoY_1";
            this.txtPuntoY_1.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoY_1.TabIndex = 10;
            // 
            // txtPuntoX_2
            // 
            this.txtPuntoX_2.Location = new System.Drawing.Point(333, 186);
            this.txtPuntoX_2.Name = "txtPuntoX_2";
            this.txtPuntoX_2.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoX_2.TabIndex = 11;
            // 
            // txtPuntoY_2
            // 
            this.txtPuntoY_2.Location = new System.Drawing.Point(333, 221);
            this.txtPuntoY_2.Name = "txtPuntoY_2";
            this.txtPuntoY_2.Size = new System.Drawing.Size(100, 20);
            this.txtPuntoY_2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "La distacia entre A y B es de";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbRespuesta
            // 
            this.LbRespuesta.AutoSize = true;
            this.LbRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRespuesta.Location = new System.Drawing.Point(382, 315);
            this.LbRespuesta.Name = "LbRespuesta";
            this.LbRespuesta.Size = new System.Drawing.Size(99, 20);
            this.LbRespuesta.TabIndex = 14;
            this.LbRespuesta.Text = "__________";
            // 
            // LineaRectaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbRespuesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuntoY_2);
            this.Controls.Add(this.txtPuntoX_2);
            this.Controls.Add(this.txtPuntoY_1);
            this.Controls.Add(this.txtPuntoX_1);
            this.Controls.Add(this.lbpuntoy2);
            this.Controls.Add(this.puntox2);
            this.Controls.Add(this.lbpunto2);
            this.Controls.Add(this.puntoy);
            this.Controls.Add(this.lbpuntox);
            this.Controls.Add(this.lbPunto1);
            this.Controls.Add(this.lbPrograma);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Name = "LineaRectaGUI";
            this.Text = "LineaRetaGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbPrograma;
        private System.Windows.Forms.Label lbPunto1;
        private System.Windows.Forms.Label lbpuntox;
        private System.Windows.Forms.Label puntoy;
        private System.Windows.Forms.Label lbpunto2;
        private System.Windows.Forms.Label puntox2;
        private System.Windows.Forms.Label lbpuntoy2;
        private System.Windows.Forms.TextBox txtPuntoX_1;
        private System.Windows.Forms.TextBox txtPuntoY_1;
        private System.Windows.Forms.TextBox txtPuntoX_2;
        private System.Windows.Forms.TextBox txtPuntoY_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbRespuesta;
    }
}

