namespace Mac
{
    partial class F_Mac
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_lista1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LB_lista1
            // 
            this.LB_lista1.FormattingEnabled = true;
            this.LB_lista1.HorizontalScrollbar = true;
            this.LB_lista1.Location = new System.Drawing.Point(12, 12);
            this.LB_lista1.Name = "LB_lista1";
            this.LB_lista1.ScrollAlwaysVisible = true;
            this.LB_lista1.Size = new System.Drawing.Size(260, 238);
            this.LB_lista1.TabIndex = 0;
            // 
            // F_Mac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LB_lista1);
            this.Name = "F_Mac";
            this.Text = "MAC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Mac_FormClosing);
            this.Load += new System.EventHandler(this.F_Mac_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_lista1;
    }
}

