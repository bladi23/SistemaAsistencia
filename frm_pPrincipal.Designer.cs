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
            this.btn_imagen = new System.Windows.Forms.Button();
            this.btn_menuPrincipal = new System.Windows.Forms.Button();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo2 = new System.Windows.Forms.Label();
            this.lbl_Leyenda = new System.Windows.Forms.Label();
            this.lbl_Leyenda2 = new System.Windows.Forms.Label();
            this.lbl_ID_Huella = new System.Windows.Forms.Label();
            this.lbl_MensajeHuella = new System.Windows.Forms.Label();
            this.txt_IdHuella = new System.Windows.Forms.TextBox();
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(29, 606);
            this.lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 69);
            this.lbl_fecha.TabIndex = 0;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(29, 537);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(0, 69);
            this.lbl_hora.TabIndex = 1;
            // 
            // btn_imagen
            // 
            this.btn_imagen.Image = global::SistemaAsistencia.Properties.Resources.Huella;
            this.btn_imagen.Location = new System.Drawing.Point(1105, 211);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(313, 294);
            this.btn_imagen.TabIndex = 0;
            this.btn_imagen.UseVisualStyleBackColor = true;
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.Location = new System.Drawing.Point(41, 706);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(166, 56);
            this.btn_menuPrincipal.TabIndex = 3;
            this.btn_menuPrincipal.Text = "Menú Principal";
            this.btn_menuPrincipal.UseVisualStyleBackColor = true;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombres.Location = new System.Drawing.Point(41, 185);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(151, 36);
            this.lbl_Nombres.TabIndex = 4;
            this.lbl_Nombres.Text = "Nombres:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombres.Location = new System.Drawing.Point(198, 180);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(444, 34);
            this.txt_nombres.TabIndex = 5;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.BackColor = System.Drawing.SystemColors.Control;
            this.txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(198, 248);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(444, 34);
            this.txt_apellidos.TabIndex = 7;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellidos.Location = new System.Drawing.Point(35, 253);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(157, 36);
            this.lbl_Apellidos.TabIndex = 6;
            this.lbl_Apellidos.Text = "Apellidos:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(198, 288);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 1);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(198, 220);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(444, 1);
            this.textBox2.TabIndex = 9;
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.Font = new System.Drawing.Font("Monospac821 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo1.Location = new System.Drawing.Point(633, 29);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(318, 72);
            this.lbl_titulo1.TabIndex = 10;
            this.lbl_titulo1.Text = "BLADOLEX";
            // 
            // lbl_titulo2
            // 
            this.lbl_titulo2.AutoSize = true;
            this.lbl_titulo2.Font = new System.Drawing.Font("Monospac821 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo2.Location = new System.Drawing.Point(203, 101);
            this.lbl_titulo2.Name = "lbl_titulo2";
            this.lbl_titulo2.Size = new System.Drawing.Size(1254, 72);
            this.lbl_titulo2.TabIndex = 11;
            this.lbl_titulo2.Text = "Sistema de Gestión de Asistencias ";
            // 
            // lbl_Leyenda
            // 
            this.lbl_Leyenda.AutoSize = true;
            this.lbl_Leyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Leyenda.Location = new System.Drawing.Point(936, 522);
            this.lbl_Leyenda.Name = "lbl_Leyenda";
            this.lbl_Leyenda.Size = new System.Drawing.Size(710, 36);
            this.lbl_Leyenda.TabIndex = 12;
            this.lbl_Leyenda.Text = "Por favor, Coloque su dedo en el lector de huella";
            // 
            // lbl_Leyenda2
            // 
            this.lbl_Leyenda2.AutoSize = true;
            this.lbl_Leyenda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Leyenda2.Location = new System.Drawing.Point(1113, 558);
            this.lbl_Leyenda2.Name = "lbl_Leyenda2";
            this.lbl_Leyenda2.Size = new System.Drawing.Size(364, 36);
            this.lbl_Leyenda2.TabIndex = 13;
            this.lbl_Leyenda2.Text = "Para realizar su registro.";
            // 
            // lbl_ID_Huella
            // 
            this.lbl_ID_Huella.AutoSize = true;
            this.lbl_ID_Huella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Huella.Location = new System.Drawing.Point(35, 326);
            this.lbl_ID_Huella.Name = "lbl_ID_Huella";
            this.lbl_ID_Huella.Size = new System.Drawing.Size(145, 36);
            this.lbl_ID_Huella.TabIndex = 15;
            this.lbl_ID_Huella.Text = "ID Huella";
            // 
            // lbl_MensajeHuella
            // 
            this.lbl_MensajeHuella.AutoSize = true;
            this.lbl_MensajeHuella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeHuella.Location = new System.Drawing.Point(35, 400);
            this.lbl_MensajeHuella.Name = "lbl_MensajeHuella";
            this.lbl_MensajeHuella.Size = new System.Drawing.Size(159, 36);
            this.lbl_MensajeHuella.TabIndex = 17;
            this.lbl_MensajeHuella.Text = "Mensajes:";
            // 
            // txt_IdHuella
            // 
            this.txt_IdHuella.BackColor = System.Drawing.SystemColors.Control;
            this.txt_IdHuella.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdHuella.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdHuella.Location = new System.Drawing.Point(198, 326);
            this.txt_IdHuella.Name = "txt_IdHuella";
            this.txt_IdHuella.Size = new System.Drawing.Size(100, 34);
            this.txt_IdHuella.TabIndex = 18;
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Mensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mensaje.Location = new System.Drawing.Point(196, 400);
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(442, 34);
            this.txt_Mensaje.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(196, 365);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 1);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(196, 438);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(444, 1);
            this.textBox4.TabIndex = 21;
            // 
            // frm_pPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 774);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_Mensaje);
            this.Controls.Add(this.txt_IdHuella);
            this.Controls.Add(this.lbl_MensajeHuella);
            this.Controls.Add(this.lbl_ID_Huella);
            this.Controls.Add(this.lbl_Leyenda2);
            this.Controls.Add(this.lbl_Leyenda);
            this.Controls.Add(this.lbl_titulo2);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.btn_menuPrincipal);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.lbl_fecha);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_pPrincipal";
            this.Text = "frm_pPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_pPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btn_imagen;
        private System.Windows.Forms.Button btn_menuPrincipal;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Label lbl_titulo2;
        private System.Windows.Forms.Label lbl_Leyenda;
        private System.Windows.Forms.Label lbl_Leyenda2;
        private System.Windows.Forms.Label lbl_ID_Huella;
        private System.Windows.Forms.Label lbl_MensajeHuella;
        private System.Windows.Forms.TextBox txt_IdHuella;
        private System.Windows.Forms.TextBox txt_Mensaje;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}