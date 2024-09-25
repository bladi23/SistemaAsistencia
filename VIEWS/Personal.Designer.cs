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
            this.PanelCargo = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_agg_cargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.data_lista_cargos = new System.Windows.Forms.DataGridView();
            this.data_lista_departamentos = new System.Windows.Forms.DataGridView();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.btn_agregaCargoDepartamento = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.PanelDepartamento = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_agg_departamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.PanelCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_cargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_departamentos)).BeginInit();
            this.PanelDepartamento.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2036, 138);
            this.panel1.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = global::SistemaAsistencia.Properties.Resources.agregar_usuario__1_;
            this.btn_agregar.Location = new System.Drawing.Point(1483, 22);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(119, 103);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaAsistencia.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(467, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(80, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 2);
            this.panel3.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btn_guardar_personal
            // 
            this.btn_guardar_personal.Location = new System.Drawing.Point(20, 4);
            this.btn_guardar_personal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar_personal.Name = "btn_guardar_personal";
            this.btn_guardar_personal.Size = new System.Drawing.Size(171, 62);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2036, 746);
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
            this.PanelPaginado.Location = new System.Drawing.Point(0, 884);
            this.PanelPaginado.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(2036, 123);
            this.PanelPaginado.TabIndex = 2;
            // 
            // btn_paginaSiguiente
            // 
            this.btn_paginaSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paginaSiguiente.Location = new System.Drawing.Point(431, 20);
            this.btn_paginaSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_paginaSiguiente.Name = "btn_paginaSiguiente";
            this.btn_paginaSiguiente.Size = new System.Drawing.Size(290, 68);
            this.btn_paginaSiguiente.TabIndex = 6;
            this.btn_paginaSiguiente.Text = "Pagina Siguiente";
            this.btn_paginaSiguiente.UseVisualStyleBackColor = true;
            // 
            // btn_paginaAnterior
            // 
            this.btn_paginaAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paginaAnterior.Location = new System.Drawing.Point(125, 20);
            this.btn_paginaAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_paginaAnterior.Name = "btn_paginaAnterior";
            this.btn_paginaAnterior.Size = new System.Drawing.Size(248, 68);
            this.btn_paginaAnterior.TabIndex = 5;
            this.btn_paginaAnterior.Text = "Pagina Anterior";
            this.btn_paginaAnterior.UseVisualStyleBackColor = true;
            // 
            // btn_primeraPagina
            // 
            this.btn_primeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primeraPagina.Location = new System.Drawing.Point(1465, 20);
            this.btn_primeraPagina.Margin = new System.Windows.Forms.Padding(4);
            this.btn_primeraPagina.Name = "btn_primeraPagina";
            this.btn_primeraPagina.Size = new System.Drawing.Size(268, 68);
            this.btn_primeraPagina.TabIndex = 4;
            this.btn_primeraPagina.Text = "Primera Pagina";
            this.btn_primeraPagina.UseVisualStyleBackColor = true;
            // 
            // btn_ultimaPagina
            // 
            this.btn_ultimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ultimaPagina.Location = new System.Drawing.Point(1150, 20);
            this.btn_ultimaPagina.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ultimaPagina.Name = "btn_ultimaPagina";
            this.btn_ultimaPagina.Size = new System.Drawing.Size(261, 68);
            this.btn_ultimaPagina.TabIndex = 2;
            this.btn_ultimaPagina.Text = "Ultima Pagina";
            this.btn_ultimaPagina.UseVisualStyleBackColor = true;
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.BackColor = System.Drawing.Color.DarkGray;
            this.PanelRegistros.Controls.Add(this.PanelCargo);
            this.PanelRegistros.Controls.Add(this.button3);
            this.PanelRegistros.Controls.Add(this.data_lista_cargos);
            this.PanelRegistros.Controls.Add(this.data_lista_departamentos);
            this.PanelRegistros.Controls.Add(this.txt_cargo);
            this.PanelRegistros.Controls.Add(this.txt_departamento);
            this.PanelRegistros.Controls.Add(this.btn_agregaCargoDepartamento);
            this.PanelRegistros.Controls.Add(this.btn_regresar);
            this.PanelRegistros.Controls.Add(this.PanelDepartamento);
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
            this.PanelRegistros.Location = new System.Drawing.Point(68, 158);
            this.PanelRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(1964, 704);
            this.PanelRegistros.TabIndex = 3;
            this.PanelRegistros.Visible = false;
            // 
            // PanelCargo
            // 
            this.PanelCargo.Controls.Add(this.button4);
            this.PanelCargo.Controls.Add(this.button5);
            this.PanelCargo.Controls.Add(this.txt_agg_cargo);
            this.PanelCargo.Controls.Add(this.label9);
            this.PanelCargo.Location = new System.Drawing.Point(902, 445);
            this.PanelCargo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCargo.Name = "PanelCargo";
            this.PanelCargo.Size = new System.Drawing.Size(413, 117);
            this.PanelCargo.TabIndex = 26;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 39);
            this.button4.TabIndex = 25;
            this.button4.Text = "Guardar *";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 63);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 39);
            this.button5.TabIndex = 24;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txt_agg_cargo
            // 
            this.txt_agg_cargo.BackColor = System.Drawing.Color.DarkGray;
            this.txt_agg_cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_agg_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agg_cargo.Location = new System.Drawing.Point(156, 13);
            this.txt_agg_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_agg_cargo.Name = "txt_agg_cargo";
            this.txt_agg_cargo.Size = new System.Drawing.Size(238, 30);
            this.txt_agg_cargo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cargo: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 391);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 36);
            this.button3.TabIndex = 27;
            this.button3.Text = "+ Agregar Cargo ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // data_lista_cargos
            // 
            this.data_lista_cargos.AllowUserToAddRows = false;
            this.data_lista_cargos.AllowUserToDeleteRows = false;
            this.data_lista_cargos.AllowUserToResizeRows = false;
            this.data_lista_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_lista_cargos.Location = new System.Drawing.Point(156, 445);
            this.data_lista_cargos.Margin = new System.Windows.Forms.Padding(4);
            this.data_lista_cargos.Name = "data_lista_cargos";
            this.data_lista_cargos.RowHeadersWidth = 51;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_lista_cargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_lista_cargos.Size = new System.Drawing.Size(639, 125);
            this.data_lista_cargos.TabIndex = 26;
            // 
            // data_lista_departamentos
            // 
            this.data_lista_departamentos.AllowUserToAddRows = false;
            this.data_lista_departamentos.AllowUserToDeleteRows = false;
            this.data_lista_departamentos.AllowUserToResizeRows = false;
            this.data_lista_departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_lista_departamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_lista_departamentos.Location = new System.Drawing.Point(156, 256);
            this.data_lista_departamentos.Margin = new System.Windows.Forms.Padding(4);
            this.data_lista_departamentos.Name = "data_lista_departamentos";
            this.data_lista_departamentos.RowHeadersWidth = 51;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_lista_departamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_lista_departamentos.Size = new System.Drawing.Size(566, 120);
            this.data_lista_departamentos.TabIndex = 25;
            this.data_lista_departamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_lista_cargos_CellContentClick);
            // 
            // txt_cargo
            // 
            this.txt_cargo.BackColor = System.Drawing.Color.DarkGray;
            this.txt_cargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.Location = new System.Drawing.Point(156, 397);
            this.txt_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(330, 30);
            this.txt_cargo.TabIndex = 24;
            // 
            // txt_departamento
            // 
            this.txt_departamento.BackColor = System.Drawing.Color.DarkGray;
            this.txt_departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento.Location = new System.Drawing.Point(156, 206);
            this.txt_departamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(330, 30);
            this.txt_departamento.TabIndex = 23;
            this.txt_departamento.TextChanged += new System.EventHandler(this.txt_departamento_TextChanged);
            // 
            // btn_agregaCargoDepartamento
            // 
            this.btn_agregaCargoDepartamento.Location = new System.Drawing.Point(544, 202);
            this.btn_agregaCargoDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregaCargoDepartamento.Name = "btn_agregaCargoDepartamento";
            this.btn_agregaCargoDepartamento.Size = new System.Drawing.Size(280, 36);
            this.btn_agregaCargoDepartamento.TabIndex = 22;
            this.btn_agregaCargoDepartamento.Text = "+  Departamento";
            this.btn_agregaCargoDepartamento.UseVisualStyleBackColor = true;
            this.btn_agregaCargoDepartamento.Click += new System.EventHandler(this.btn_agregaCargoDepartamento_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Image = global::SistemaAsistencia.Properties.Resources.volver_flecha;
            this.btn_regresar.Location = new System.Drawing.Point(929, 62);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(97, 75);
            this.btn_regresar.TabIndex = 21;
            this.btn_regresar.UseVisualStyleBackColor = false;
            // 
            // PanelDepartamento
            // 
            this.PanelDepartamento.Controls.Add(this.button1);
            this.PanelDepartamento.Controls.Add(this.button2);
            this.PanelDepartamento.Controls.Add(this.txt_agg_departamento);
            this.PanelDepartamento.Controls.Add(this.label8);
            this.PanelDepartamento.Location = new System.Drawing.Point(901, 259);
            this.PanelDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDepartamento.Name = "PanelDepartamento";
            this.PanelDepartamento.Size = new System.Drawing.Size(414, 117);
            this.PanelDepartamento.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Guardar *";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_agg_departamento
            // 
            this.txt_agg_departamento.BackColor = System.Drawing.Color.DarkGray;
            this.txt_agg_departamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_agg_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agg_departamento.Location = new System.Drawing.Point(157, 15);
            this.txt_agg_departamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_agg_departamento.Name = "txt_agg_departamento";
            this.txt_agg_departamento.Size = new System.Drawing.Size(238, 30);
            this.txt_agg_departamento.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Departamento: ";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_guardar_cambios_personal);
            this.panel10.Controls.Add(this.btn_guardar_personal);
            this.panel10.Location = new System.Drawing.Point(312, 585);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(386, 80);
            this.panel10.TabIndex = 19;
            // 
            // btn_guardar_cambios_personal
            // 
            this.btn_guardar_cambios_personal.Location = new System.Drawing.Point(204, 4);
            this.btn_guardar_cambios_personal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar_cambios_personal.Name = "btn_guardar_cambios_personal";
            this.btn_guardar_cambios_personal.Size = new System.Drawing.Size(168, 62);
            this.btn_guardar_cambios_personal.TabIndex = 4;
            this.btn_guardar_cambios_personal.Text = "Guardar *";
            this.btn_guardar_cambios_personal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Departamento:";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.DarkGray;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(156, 140);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(721, 30);
            this.txt_cedula.TabIndex = 11;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.DarkGray;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(156, 82);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(721, 30);
            this.txt_apellido.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.DarkGray;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(156, 26);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(721, 30);
            this.txt_nombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PanelPaginado);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(2036, 1007);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            this.PanelCargo.ResumeLayout(false);
            this.PanelCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_cargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_departamentos)).EndInit();
            this.PanelDepartamento.ResumeLayout(false);
            this.PanelDepartamento.PerformLayout();
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
        private System.Windows.Forms.Panel PanelDepartamento;
        private System.Windows.Forms.Button btn_guardar_cambios_personal;
        private System.Windows.Forms.Button btn_primeraPagina;
        private System.Windows.Forms.Button btn_ultimaPagina;
        private System.Windows.Forms.Button btn_paginaSiguiente;
        private System.Windows.Forms.Button btn_paginaAnterior;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_agregaCargoDepartamento;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_agg_departamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.DataGridView data_lista_departamentos;
        private System.Windows.Forms.DataGridView data_lista_cargos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel PanelCargo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_agg_cargo;
        private System.Windows.Forms.Label label9;
    }
}
