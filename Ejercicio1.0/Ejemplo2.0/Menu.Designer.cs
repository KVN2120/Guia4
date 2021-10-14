namespace Ejemplo2._0
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.btndocentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(438, 116);
            this.btnsalir.Size = new System.Drawing.Size(165, 89);
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiantes.Location = new System.Drawing.Point(53, 116);
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.Size = new System.Drawing.Size(165, 89);
            this.btnestudiantes.TabIndex = 1;
            this.btnestudiantes.Text = "Registro Estudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = true;
            this.btnestudiantes.Click += new System.EventHandler(this.btnestudiantes_Click);
            // 
            // btndocentes
            // 
            this.btndocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocentes.Location = new System.Drawing.Point(251, 116);
            this.btndocentes.Name = "btndocentes";
            this.btndocentes.Size = new System.Drawing.Size(165, 89);
            this.btndocentes.TabIndex = 2;
            this.btndocentes.Text = "Registro Docentes";
            this.btndocentes.UseVisualStyleBackColor = true;
            this.btndocentes.Click += new System.EventHandler(this.btndocentes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 334);
            this.Controls.Add(this.btndocentes);
            this.Controls.Add(this.btnestudiantes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnestudiantes, 0);
            this.Controls.SetChildIndex(this.btndocentes, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.Button btndocentes;
    }
}