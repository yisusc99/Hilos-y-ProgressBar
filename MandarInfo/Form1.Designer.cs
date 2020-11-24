namespace MandarInfo
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
            this.Carga = new System.Windows.Forms.Button();
            this.Envia = new System.Windows.Forms.Button();
            this.Progresa = new System.Windows.Forms.ProgressBar();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Carga
            // 
            this.Carga.Location = new System.Drawing.Point(95, 89);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(126, 52);
            this.Carga.TabIndex = 0;
            this.Carga.Text = "Cargar Form";
            this.Carga.UseVisualStyleBackColor = true;
            this.Carga.Click += new System.EventHandler(this.Carga_Click);
            // 
            // Envia
            // 
            this.Envia.Location = new System.Drawing.Point(95, 156);
            this.Envia.Name = "Envia";
            this.Envia.Size = new System.Drawing.Size(126, 52);
            this.Envia.TabIndex = 1;
            this.Envia.Text = "Enviar texto";
            this.Envia.UseVisualStyleBackColor = true;
            this.Envia.Click += new System.EventHandler(this.Envia_Click);
            // 
            // Progresa
            // 
            this.Progresa.Location = new System.Drawing.Point(12, 226);
            this.Progresa.Name = "Progresa";
            this.Progresa.Size = new System.Drawing.Size(286, 23);
            this.Progresa.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(57, 44);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(211, 23);
            this.txt.TabIndex = 3;
            this.txt.Text = "por def";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.Progresa);
            this.Controls.Add(this.Envia);
            this.Controls.Add(this.Carga);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Carga;
        private System.Windows.Forms.Button Envia;
        private System.Windows.Forms.ProgressBar Progresa;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
    }
}

