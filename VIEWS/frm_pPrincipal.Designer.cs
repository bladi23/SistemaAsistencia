namespace SistemaAsistencia.VIEWS
{
    partial class frm_pPrincipal
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
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_imagen = new System.Windows.Forms.Button();
            this.btn_menuPrincipal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(29, 606);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(190, 69);
            this.lbl_fecha.TabIndex = 0;
            this.lbl_fecha.Text = "label1";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(29, 537);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(190, 69);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_imagen);
            this.panel1.Location = new System.Drawing.Point(742, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 300);
            this.panel1.TabIndex = 2;
            // 
            // btn_imagen
            // 
            this.btn_imagen.Image = global::SistemaAsistencia.Properties.Resources.Huella;
            this.btn_imagen.Location = new System.Drawing.Point(3, 3);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(313, 294);
            this.btn_imagen.TabIndex = 0;
            this.btn_imagen.UseVisualStyleBackColor = true;
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.Location = new System.Drawing.Point(947, 626);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(166, 56);
            this.btn_menuPrincipal.TabIndex = 3;
            this.btn_menuPrincipal.Text = "Menú Principal";
            this.btn_menuPrincipal.UseVisualStyleBackColor = true;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // frm_pPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btn_menuPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_pPrincipal";
            this.Text = "frm_pPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.Button btn_menuPrincipal;
    }
}