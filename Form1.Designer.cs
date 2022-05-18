namespace Descuentos
{
    partial class Form1
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
            this.txtSueldoData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.dvgDeducciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSueldoData
            // 
            this.txtSueldoData.Location = new System.Drawing.Point(228, 21);
            this.txtSueldoData.Name = "txtSueldoData";
            this.txtSueldoData.Size = new System.Drawing.Size(198, 22);
            this.txtSueldoData.TabIndex = 0;
            this.txtSueldoData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su sueldo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deducciones:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.Color.Lime;
            this.botonIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonIngresar.Location = new System.Drawing.Point(432, 21);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(75, 23);
            this.botonIngresar.TabIndex = 3;
            this.botonIngresar.Text = "Enter";
            this.botonIngresar.UseVisualStyleBackColor = false;
            this.botonIngresar.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // dvgDeducciones
            // 
            this.dvgDeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDeducciones.Location = new System.Drawing.Point(12, 87);
            this.dvgDeducciones.Name = "dvgDeducciones";
            this.dvgDeducciones.RowHeadersWidth = 51;
            this.dvgDeducciones.RowTemplate.Height = 24;
            this.dvgDeducciones.Size = new System.Drawing.Size(999, 313);
            this.dvgDeducciones.TabIndex = 4;
            this.dvgDeducciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1013, 406);
            this.Controls.Add(this.dvgDeducciones);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSueldoData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSueldoData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.DataGridView dvgDeducciones;
    }
}

