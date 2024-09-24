namespace SistemaAsistencia.VIEWS
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_guardar_personal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.btn_paginaSiguiente = new System.Windows.Forms.Button();
            this.btn_paginaAnterior = new System.Windows.Forms.Button();
            this.btn_primeraPagina = new System.Windows.Forms.Button();
            this.btn_ultimaPagina = new System.Windows.Forms.Button();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.cmb_Cargo = new System.Windows.Forms.ComboBox();
            this.cmb_Departamento = new System.Windows.Forms.ComboBox();
            this.btn_agregaCargoDepartamento = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.PanelCargos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_guardar_cambios_personal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelPaginado.SuspendLayout();
            this.PanelRegistros.SuspendLayout();
            this.PanelCargos.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 112);
            this.panel1.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::SistemaAsistencia.Properties.Resources.agregar_usuario__1_;
            this.btn_agregar.Location = new System.Drawing.Point(1112, 18);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(89, 84);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaAsistencia.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(350, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(60, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 2);
            this.panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(60, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 19);
            this.textBox1.TabIndex = 0;
            // 
            // btn_guardar_personal
            // 
            this.btn_guardar_personal.Location = new System.Drawing.Point(3, 18);
            this.btn_guardar_personal.Name = "btn_guardar_personal";
            this.btn_guardar_personal.Size = new System.Drawing.Size(138, 63);
            this.btn_guardar_personal.TabIndex = 3;
            this.btn_guardar_personal.Text = "Guardar";
            this.btn_guardar_personal.UseVisualStyleBackColor = true;
            this.btn_guardar_personal.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1326, 606);
            this.dataGridView1.TabIndex = 1;
            // 
            // PanelPaginado
            // 
            this.PanelPaginado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelPaginado.Controls.Add(this.btn_paginaSiguiente);
            this.PanelPaginado.Controls.Add(this.btn_paginaAnterior);
            this.PanelPaginado.Controls.Add(this.btn_primeraPagina);
            this.PanelPaginado.Controls.Add(this.btn_ultimaPagina);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 718);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(1326, 100);
            this.PanelPaginado.TabIndex = 2;
            // 
            // btn_paginaSiguiente
            // 
            this.btn_paginaSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paginaSiguiente.Location = new System.Drawing.Point(323, 16);
            this.btn_paginaSiguiente.Name = "btn_paginaSiguiente";
            this.btn_paginaSiguiente.Size = new System.Drawing.Size(221, 70);
            this.btn_paginaSiguiente.TabIndex = 6;
            this.btn_paginaSiguiente.Text = "Pagina Siguiente";
            this.btn_paginaSiguiente.UseVisualStyleBackColor = true;
            // 
            // btn_paginaAnterior
            // 
            this.btn_paginaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paginaAnterior.Location = new System.Drawing.Point(94, 16);
            this.btn_paginaAnterior.Name = "btn_paginaAnterior";
            this.btn_paginaAnterior.Size = new System.Drawing.Size(201, 70);
            this.btn_paginaAnterior.TabIndex = 5;
            this.btn_paginaAnterior.Text = "Pagina Anterior";
            this.btn_paginaAnterior.UseVisualStyleBackColor = true;
            // 
            // btn_primeraPagina
            // 
            this.btn_primeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primeraPagina.Location = new System.Drawing.Point(1047, 16);
            this.btn_primeraPagina.Name = "btn_primeraPagina";
            this.btn_primeraPagina.Size = new System.Drawing.Size(209, 70);
            this.btn_primeraPagina.TabIndex = 4;
            this.btn_primeraPagina.Text = "Primera Pagina";
            this.btn_primeraPagina.UseVisualStyleBackColor = true;
            // 
            // btn_ultimaPagina
            // 
            this.btn_ultimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ultimaPagina.Location = new System.Drawing.Point(809, 16);
            this.btn_ultimaPagina.Name = "btn_ultimaPagina";
            this.btn_ultimaPagina.Size = new System.Drawing.Size(196, 70);
            this.btn_ultimaPagina.TabIndex = 2;
            this.btn_ultimaPagina.Text = "Ultima Pagina";
            this.btn_ultimaPagina.UseVisualStyleBackColor = true;
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.BackColor = System.Drawing.Color.DarkGray;
            this.PanelRegistros.Controls.Add(this.cmb_Cargo);
            this.PanelRegistros.Controls.Add(this.cmb_Departamento);
            this.PanelRegistros.Controls.Add(this.btn_agregaCargoDepartamento);
            this.PanelRegistros.Controls.Add(this.btn_regresar);
            this.PanelRegistros.Controls.Add(this.PanelCargos);
            this.PanelRegistros.Controls.Add(this.panel10);
            this.PanelRegistros.Controls.Add(this.label4);
            this.PanelRegistros.Controls.Add(this.txt_cedula);
            this.PanelRegistros.Controls.Add(this.txt_apellido);
            this.PanelRegistros.Controls.Add(this.txt_nombre);
            this.PanelRegistros.Controls.Add(this.label5);
            this.PanelRegistros.Controls.Add(this.label3);
            this.PanelRegistros.Controls.Add(this.label2);
            this.PanelRegistros.Controls.Add(this.label1);
            this.PanelRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelRegistros.Location = new System.Drawing.Point(51, 128);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(1230, 572);
            this.PanelRegistros.TabIndex = 3;
            this.PanelRegistros.Visible = false;
            // 
            // cmb_Cargo
            // 
            this.cmb_Cargo.FormattingEnabled = true;
            this.cmb_Cargo.Location = new System.Drawing.Point(287, 293);
            this.cmb_Cargo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Cargo.Name = "cmb_Cargo";
            this.cmb_Cargo.Size = new System.Drawing.Size(227, 28);
            this.cmb_Cargo.TabIndex = 24;
            // 
            // cmb_Departamento
            // 
            this.cmb_Departamento.FormattingEnabled = true;
            this.cmb_Departamento.Location = new System.Drawing.Point(287, 235);
            this.cmb_Departamento.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Departamento.Name = "cmb_Departamento";
            this.cmb_Departamento.Size = new System.Drawing.Size(227, 28);
            this.cmb_Departamento.TabIndex = 23;
            this.cmb_Departamento.SelectedIndexChanged += new System.EventHandler(this.cmb_Departamento_SelectedIndexChanged);
            // 
            // btn_agregaCargoDepartamento
            // 
            this.btn_agregaCargoDepartamento.Location = new System.Drawing.Point(541, 234);
            this.btn_agregaCargoDepartamento.Name = "btn_agregaCargoDepartamento";
            this.btn_agregaCargoDepartamento.Size = new System.Drawing.Size(282, 29);
            this.btn_agregaCargoDepartamento.TabIndex = 22;
            this.btn_agregaCargoDepartamento.Text = "+ Agregar Cargo / Departamento";
            this.btn_agregaCargoDepartamento.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Image = global::SistemaAsistencia.Properties.Resources.volver_flecha;
            this.btn_regresar.Location = new System.Drawing.Point(761, 43);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(103, 80);
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.UseVisualStyleBackColor = false;
            // 
            // PanelCargos
            // 
            this.PanelCargos.Controls.Add(this.button1);
            this.PanelCargos.Controls.Add(this.button2);
            this.PanelCargos.Controls.Add(this.textBox4);
            this.PanelCargos.Controls.Add(this.textBox7);
            this.PanelCargos.Controls.Add(this.label8);
            this.PanelCargos.Controls.Add(this.label6);
            this.PanelCargos.Location = new System.Drawing.Point(728, 315);
            this.PanelCargos.Name = "PanelCargos";
            this.PanelCargos.Size = new System.Drawing.Size(401, 234);
            this.PanelCargos.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 63);
            this.button1.TabIndex = 25;
            this.button1.Text = "Guardar *";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 63);
            this.button2.TabIndex = 24;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkGray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(155, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 26);
            this.textBox4.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkGray;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(155, 100);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(179, 26);
            this.textBox7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Departamento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cargo: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_guardar_cambios_personal);
            this.panel10.Controls.Add(this.btn_guardar_personal);
            this.panel10.Location = new System.Drawing.Point(287, 337);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(321, 98);
            this.panel10.TabIndex = 19;
            // 
            // btn_guardar_cambios_personal
            // 
            this.btn_guardar_cambios_personal.Location = new System.Drawing.Point(147, 18);
            this.btn_guardar_cambios_personal.Name = "btn_guardar_cambios_personal";
            this.btn_guardar_cambios_personal.Size = new System.Drawing.Size(138, 63);
            this.btn_guardar_cambios_personal.TabIndex = 4;
            this.btn_guardar_cambios_personal.Text = "Guardar *";
            this.btn_guardar_cambios_personal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Departamento:";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.DarkGray;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(287, 183);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(464, 26);
            this.txt_cedula.TabIndex = 11;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.DarkGray;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(287, 136);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(464, 26);
            this.txt_apellido.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.DarkGray;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(287, 90);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(464, 26);
            this.txt_nombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1326, 818);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            this.PanelCargos.ResumeLayout(false);
            this.PanelCargos.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelRegistros;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar_personal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel PanelCargos;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar_cambios_personal;
        private System.Windows.Forms.Button btn_primeraPagina;
        private System.Windows.Forms.Button btn_ultimaPagina;
        private System.Windows.Forms.Button btn_paginaSiguiente;
        private System.Windows.Forms.Button btn_paginaAnterior;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_agregaCargoDepartamento;
        private System.Windows.Forms.ComboBox cmb_Cargo;
        private System.Windows.Forms.ComboBox cmb_Departamento;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
