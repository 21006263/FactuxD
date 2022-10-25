namespace FactuxD
{
    partial class MantenimientoCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApeCli = new System.Windows.Forms.TextBox();
            this.txtINomCli = new System.Windows.Forms.TextBox();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 75);
            this.button1.Size = new System.Drawing.Size(185, 23);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 143);
            this.button2.Size = new System.Drawing.Size(185, 23);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 270);
            this.button3.Size = new System.Drawing.Size(185, 23);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 207);
            this.button4.Size = new System.Drawing.Size(185, 23);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(475, 333);
            this.btnSalir.Size = new System.Drawing.Size(185, 23);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(93, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Cliente";
            // 
            // txtApeCli
            // 
            this.txtApeCli.Location = new System.Drawing.Point(233, 239);
            this.txtApeCli.Name = "txtApeCli";
            this.txtApeCli.Size = new System.Drawing.Size(157, 23);
            this.txtApeCli.TabIndex = 13;
            // 
            // txtINomCli
            // 
            this.txtINomCli.Location = new System.Drawing.Point(233, 170);
            this.txtINomCli.Name = "txtINomCli";
            this.txtINomCli.Size = new System.Drawing.Size(157, 23);
            this.txtINomCli.TabIndex = 12;
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(233, 110);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(157, 23);
            this.txtIdCli.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(445, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 357);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApeCli);
            this.Controls.Add(this.txtINomCli);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.txtIdCli, 0);
            this.Controls.SetChildIndex(this.txtINomCli, 0);
            this.Controls.SetChildIndex(this.txtApeCli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApeCli;
        private TextBox txtINomCli;
        private TextBox txtIdCli;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}