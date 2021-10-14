namespace Ejemplo2._0
{
    partial class FrmRegistroDocentes
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox3, 0);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 151);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 95);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 39);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 33);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 145);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 89);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(256, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registro Docentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Materia:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 24);
            this.textBox4.TabIndex = 7;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(32, 298);
            this.dgv1.Name = "dgv1";
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(674, 147);
            this.dgv1.TabIndex = 7;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // FrmRegistroDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 467);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label4);
            this.Name = "FrmRegistroDocentes";
            this.Text = "FrmRegistroDocentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistroDocentes_FormClosed);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dgv1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox4;
        protected System.Windows.Forms.DataGridView dgv1;
    }
}