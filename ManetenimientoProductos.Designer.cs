namespace FactuxD
{
    partial class ManetenimientoProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtIdPro = new MiLibreria.ErrorTxtBox();
            this.txtNomPro = new MiLibreria.ErrorTxtBox();
            this.txtPrecioPro = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 79);
            this.button1.Size = new System.Drawing.Size(185, 23);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 136);
            this.button2.Size = new System.Drawing.Size(185, 23);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 199);
            this.button3.Size = new System.Drawing.Size(185, 23);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 263);
            this.button4.Size = new System.Drawing.Size(185, 23);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(408, 337);
            this.btnSalir.Size = new System.Drawing.Size(185, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(61, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Precio";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(378, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 318);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // txtIdPro
            // 
            this.txtIdPro.Location = new System.Drawing.Point(201, 129);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(157, 23);
            this.txtIdPro.TabIndex = 12;
            this.txtIdPro.Validar = true;
            this.txtIdPro.TextChanged += new System.EventHandler(this.txtIdPro_TextChanged);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(201, 192);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(157, 23);
            this.txtNomPro.TabIndex = 13;
            this.txtNomPro.Validar = true;
            // 
            // txtPrecioPro
            // 
            this.txtPrecioPro.Location = new System.Drawing.Point(201, 258);
            this.txtPrecioPro.Name = "txtPrecioPro";
            this.txtPrecioPro.Size = new System.Drawing.Size(157, 23);
            this.txtPrecioPro.TabIndex = 14;
            this.txtPrecioPro.Validar = true;
            // 
            // ManetenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 424);
            this.Controls.Add(this.txtPrecioPro);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ManetenimientoProductos";
            this.Text = "ManetenimientoProducto";
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdPro, 0);
            this.Controls.SetChildIndex(this.txtNomPro, 0);
            this.Controls.SetChildIndex(this.txtPrecioPro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private MiLibreria.ErrorTxtBox txtIdPro;
        private MiLibreria.ErrorTxtBox txtNomPro;
        private MiLibreria.ErrorTxtBox txtPrecioPro;
    }
}