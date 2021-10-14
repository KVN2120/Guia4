namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.btncirculo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmayor = new System.Windows.Forms.TextBox();
            this.txtmenor = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 243);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btncirculo);
            this.tabPage1.Controls.Add(this.txtlado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuadrado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btncalcular);
            this.tabPage2.Controls.Add(this.txt2);
            this.tabPage2.Controls.Add(this.lbl3);
            this.tabPage2.Controls.Add(this.lbl4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Circulo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado:";
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(163, 54);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(235, 24);
            this.txtlado.TabIndex = 1;
            // 
            // btncirculo
            // 
            this.btncirculo.Location = new System.Drawing.Point(470, 44);
            this.btncirculo.Name = "btncirculo";
            this.btncirculo.Size = new System.Drawing.Size(109, 45);
            this.btncirculo.TabIndex = 2;
            this.btncirculo.Text = "Calcular";
            this.btncirculo.UseVisualStyleBackColor = true;
            this.btncirculo.Click += new System.EventHandler(this.btncirculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respuesta:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(26, 147);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(83, 18);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "Respuesta:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(26, 66);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(51, 18);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Radio:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(128, 60);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(223, 24);
            this.txt2.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(464, 51);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(118, 48);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtmenor);
            this.tabPage3.Controls.Add(this.txtmayor);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(637, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rombo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Diagonal mayor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Diagonal menor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Respuesta:";
            // 
            // txtmayor
            // 
            this.txtmayor.Location = new System.Drawing.Point(169, 45);
            this.txtmayor.Name = "txtmayor";
            this.txtmayor.Size = new System.Drawing.Size(192, 24);
            this.txtmayor.TabIndex = 4;
            // 
            // txtmenor
            // 
            this.txtmenor.Location = new System.Drawing.Point(169, 103);
            this.txtmenor.Name = "txtmenor";
            this.txtmenor.Size = new System.Drawing.Size(192, 24);
            this.txtmenor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(682, 277);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Figuras";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncirculo;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtmenor;
        private System.Windows.Forms.TextBox txtmayor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

