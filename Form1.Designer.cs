namespace calculaCedula
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
            this.btnCalculo = new System.Windows.Forms.Button();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(282, 51);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(103, 23);
            this.btnCalculo.TabIndex = 0;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(110, 53);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(154, 20);
            this.txtcedula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cedula";
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(111, 95);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(13, 13);
            this.lbresult.TabIndex = 3;
            this.lbresult.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 349);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.btnCalculo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcular Numero de cedula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbresult;
    }
}

