
namespace McCullochPitts
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
            this.btnMcCulloch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMcCulloch
            // 
            this.btnMcCulloch.Location = new System.Drawing.Point(266, 344);
            this.btnMcCulloch.Name = "btnMcCulloch";
            this.btnMcCulloch.Size = new System.Drawing.Size(75, 23);
            this.btnMcCulloch.TabIndex = 0;
            this.btnMcCulloch.Text = "button1";
            this.btnMcCulloch.UseVisualStyleBackColor = true;
            this.btnMcCulloch.Click += new System.EventHandler(this.btnMcCulloch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 532);
            this.Controls.Add(this.btnMcCulloch);
            this.Name = "Form1";
            this.Text = "McCulloch Pitts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMcCulloch;
    }
}

