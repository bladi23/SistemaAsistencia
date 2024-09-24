namespace SistemaAsistencia.VIEWS
{
    partial class frm_Registro
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Id_Huella = new System.Windows.Forms.Label();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.txt_Id_Huella = new System.Windows.Forms.TextBox();
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, Coloque su dedo en el detector huella para registrar su asistencia.";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(89, 181);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(97, 25);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombres:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(192, 181);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(608, 30);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(193, 239);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(608, 30);
            this.txt_Apellido.TabIndex = 5;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(89, 239);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(98, 25);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "Apellidos:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(969, 127);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(426, 476);
            this.textBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 254);
            this.dataGridView1.TabIndex = 7;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(63, 670);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 69);
            this.lbl_fecha.TabIndex = 8;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(70, 739);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 69);
            this.lbl_Hora.TabIndex = 9;
            // 
            // lbl_Id_Huella
            // 
            this.lbl_Id_Huella.AutoSize = true;
            this.lbl_Id_Huella.Location = new System.Drawing.Point(89, 286);
            this.lbl_Id_Huella.Name = "lbl_Id_Huella";
            this.lbl_Id_Huella.Size = new System.Drawing.Size(91, 25);
            this.lbl_Id_Huella.TabIndex = 10;
            this.lbl_Id_Huella.Text = "ID Huella";
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Location = new System.Drawing.Point(89, 329);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(87, 25);
            this.lbl_Mensaje.TabIndex = 11;
            this.lbl_Mensaje.Text = "Mensaje";
            // 
            // txt_Id_Huella
            // 
            this.txt_Id_Huella.Location = new System.Drawing.Point(193, 286);
            this.txt_Id_Huella.Name = "txt_Id_Huella";
            this.txt_Id_Huella.Size = new System.Drawing.Size(608, 30);
            this.txt_Id_Huella.TabIndex = 12;
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.Location = new System.Drawing.Point(192, 329);
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(608, 30);
            this.txt_Mensaje.TabIndex = 13;
            // 
            // frm_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 790);
            this.Controls.Add(this.txt_Mensaje);
            this.Controls.Add(this.txt_Id_Huella);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.lbl_Id_Huella);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Registro";
            this.Text = "Resgistro de Asistencia.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Registro_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Label lbl_Id_Huella;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.TextBox txt_Id_Huella;
        private System.Windows.Forms.TextBox txt_Mensaje;
    }
}