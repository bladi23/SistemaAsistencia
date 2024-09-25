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
            this.pictureBxLupaBuscar = new System.Windows.Forms.PictureBox();
            this.txt_simulaLinea = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_guardar_personal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelPaginado = new System.Windows.Forms.Panel();
            this.btn_paginaSiguiente = new System.Windows.Forms.Button();
            this.btn_paginaAnterior = new System.Windows.Forms.Button();
            this.btn_primeraPagina = new System.Windows.Forms.Button();
            this.btn_ultimaPagina = new System.Windows.Forms.Button();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.data_lista_departamentos = new System.Windows.Forms.DataGridView();
            this.EditarD = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_agregarDepartamento = new System.Windows.Forms.Button();
            this.PanelCargo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_editarCampo = new System.Windows.Forms.Button();
            this.btn_volver_Cargos = new System.Windows.Forms.Button();
            this.btn_aggCargo = new System.Windows.Forms.Button();
            this.txt_agg_cargo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_agregarCargo = new System.Windows.Forms.Button();
            this.data_lista_cargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.PanelDepartamento = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_editarDepartamento = new System.Windows.Forms.Button();
            this.btn_volver_departamentos = new System.Windows.Forms.Button();
            this.btn_aggDepartameno = new System.Windows.Forms.Button();
            this.txt_agg_departamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Panel_btn_guardar_personal = new System.Windows.Forms.Panel();
            this.btn_guardar_cambios_personal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxLupaBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelPaginado.SuspendLayout();
            this.PanelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_departamentos)).BeginInit();
            this.PanelCargo.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_cargos)).BeginInit();
            this.PanelDepartamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_btn_guardar_personal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.pictureBxLupaBuscar);
            this.panel1.Controls.Add(this.txt_simulaLinea);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2115, 138);
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
            // pictureBxLupaBuscar
            // 
            this.pictureBxLupaBuscar.Image = global::SistemaAsistencia.Properties.Resources.buscar;
            this.pictureBxLupaBuscar.Location = new System.Drawing.Point(467, 71);
            this.pictureBxLupaBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBxLupaBuscar.Name = "pictureBxLupaBuscar";
            this.pictureBxLupaBuscar.Size = new System.Drawing.Size(64, 53);
            this.pictureBxLupaBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBxLupaBuscar.TabIndex = 2;
            this.pictureBxLupaBuscar.TabStop = false;
            // 
            // txt_simulaLinea
            // 
            this.txt_simulaLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_simulaLinea.Location = new System.Drawing.Point(80, 123);
            this.txt_simulaLinea.Margin = new System.Windows.Forms.Padding(4);
            this.txt_simulaLinea.Name = "txt_simulaLinea";
            this.txt_simulaLinea.Size = new System.Drawing.Size(372, 1);
            this.txt_simulaLinea.TabIndex = 1;
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
            this.dataGridView1.Size = new System.Drawing.Size(2115, 955);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PanelPaginado
            // 
            this.PanelPaginado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelPaginado.Controls.Add(this.btn_paginaSiguiente);
            this.PanelPaginado.Controls.Add(this.btn_paginaAnterior);
            this.PanelPaginado.Controls.Add(this.btn_primeraPagina);
            this.PanelPaginado.Controls.Add(this.btn_ultimaPagina);
            this.PanelPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelPaginado.Location = new System.Drawing.Point(0, 1093);
            this.PanelPaginado.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPaginado.Name = "PanelPaginado";
            this.PanelPaginado.Size = new System.Drawing.Size(2115, 123);
            this.PanelPaginado.TabIndex = 2;
            // 
            // btn_paginaSiguiente
            // 
            this.btn_paginaSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paginaSiguiente.Location = new System.Drawing.Point(431, 20);
            this.btn_paginaSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_paginaSiguiente.Name = "btn_paginaSiguiente";
            this.btn_paginaSiguiente.Size = new System.Drawing.Size(291, 68);
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
            this.btn_ultimaPagina.Location = new System.Drawing.Point(1149, 20);
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
            this.PanelRegistros.Controls.Add(this.panel12);
            this.PanelRegistros.Controls.Add(this.panel11);
            this.PanelRegistros.Controls.Add(this.panel10);
            this.PanelRegistros.Controls.Add(this.panel9);
            this.PanelRegistros.Controls.Add(this.panel8);
            this.PanelRegistros.Controls.Add(this.data_lista_departamentos);
            this.PanelRegistros.Controls.Add(this.btn_agregarDepartamento);
            this.PanelRegistros.Controls.Add(this.PanelCargo);
            this.PanelRegistros.Controls.Add(this.btn_agregarCargo);
            this.PanelRegistros.Controls.Add(this.data_lista_cargos);
            this.PanelRegistros.Controls.Add(this.txt_cargo);
            this.PanelRegistros.Controls.Add(this.txt_departamento);
            this.PanelRegistros.Controls.Add(this.btn_regresar);
            this.PanelRegistros.Controls.Add(this.PanelDepartamento);
            this.PanelRegistros.Controls.Add(this.Panel_btn_guardar_personal);
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
            this.PanelRegistros.Size = new System.Drawing.Size(1964, 935);
            this.PanelRegistros.TabIndex = 3;
            this.PanelRegistros.Visible = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DimGray;
            this.panel12.Location = new System.Drawing.Point(160, 471);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(330, 1);
            this.panel12.TabIndex = 35;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(156, 227);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(330, 1);
            this.panel11.TabIndex = 34;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(156, 169);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(721, 1);
            this.panel10.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Location = new System.Drawing.Point(156, 111);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(721, 1);
            this.panel9.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(156, 54);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(721, 1);
            this.panel8.TabIndex = 31;
            // 
            // data_lista_departamentos
            // 
            this.data_lista_departamentos.AllowUserToAddRows = false;
            this.data_lista_departamentos.AllowUserToDeleteRows = false;
            this.data_lista_departamentos.AllowUserToResizeRows = false;
            this.data_lista_departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_lista_departamentos.ColumnHeadersVisible = false;
            this.data_lista_departamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarD});
            this.data_lista_departamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_lista_departamentos.Location = new System.Drawing.Point(156, 230);
            this.data_lista_departamentos.Margin = new System.Windows.Forms.Padding(4);
            this.data_lista_departamentos.Name = "data_lista_departamentos";
            this.data_lista_departamentos.RowHeadersWidth = 51;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.data_lista_departamentos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_lista_departamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_lista_departamentos.Size = new System.Drawing.Size(381, 139);
            this.data_lista_departamentos.TabIndex = 25;
            this.data_lista_departamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_lista_departamentos_CellClick);
            this.data_lista_departamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_lista_cargos_CellContentClick);
            // 
            // EditarD
            // 
            this.EditarD.HeaderText = "EditarD";
            this.EditarD.Image = global::SistemaAsistencia.Properties.Resources.editar;
            this.EditarD.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarD.MinimumWidth = 6;
            this.EditarD.Name = "EditarD";
            this.EditarD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditarD.Width = 125;
            // 
            // btn_agregarDepartamento
            // 
            this.btn_agregarDepartamento.BackColor = System.Drawing.Color.Silver;
            this.btn_agregarDepartamento.Location = new System.Drawing.Point(516, 190);
            this.btn_agregarDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregarDepartamento.Name = "btn_agregarDepartamento";
            this.btn_agregarDepartamento.Size = new System.Drawing.Size(280, 36);
            this.btn_agregarDepartamento.TabIndex = 28;
            this.btn_agregarDepartamento.Text = "+ Agregar Departamento ";
            this.btn_agregarDepartamento.UseVisualStyleBackColor = false;
            this.btn_agregarDepartamento.Click += new System.EventHandler(this.btn_agregarDepartamento_Click);
            // 
            // PanelCargo
            // 
            this.PanelCargo.Controls.Add(this.comboBox1);
            this.PanelCargo.Controls.Add(this.panel3);
            this.PanelCargo.Controls.Add(this.label6);
            this.PanelCargo.Controls.Add(this.panel4);
            this.PanelCargo.Controls.Add(this.txt_agg_cargo);
            this.PanelCargo.Controls.Add(this.label9);
            this.PanelCargo.Location = new System.Drawing.Point(883, 446);
            this.PanelCargo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCargo.Name = "PanelCargo";
            this.PanelCargo.Size = new System.Drawing.Size(546, 223);
            this.PanelCargo.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(168, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Departamento:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_editarCampo);
            this.panel4.Controls.Add(this.btn_volver_Cargos);
            this.panel4.Controls.Add(this.btn_aggCargo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 76);
            this.panel4.TabIndex = 24;
            // 
            // btn_editarCampo
            // 
            this.btn_editarCampo.BackColor = System.Drawing.Color.Silver;
            this.btn_editarCampo.Location = new System.Drawing.Point(4, 10);
            this.btn_editarCampo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editarCampo.Name = "btn_editarCampo";
            this.btn_editarCampo.Size = new System.Drawing.Size(171, 62);
            this.btn_editarCampo.TabIndex = 24;
            this.btn_editarCampo.Text = "Editar";
            this.btn_editarCampo.UseVisualStyleBackColor = false;
            this.btn_editarCampo.Click += new System.EventHandler(this.btn_editarCampo_Click);
            // 
            // btn_volver_Cargos
            // 
            this.btn_volver_Cargos.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver_Cargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_Cargos.Image = global::SistemaAsistencia.Properties.Resources.volver_flecha;
            this.btn_volver_Cargos.Location = new System.Drawing.Point(359, 16);
            this.btn_volver_Cargos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volver_Cargos.Name = "btn_volver_Cargos";
            this.btn_volver_Cargos.Size = new System.Drawing.Size(103, 56);
            this.btn_volver_Cargos.TabIndex = 23;
            this.btn_volver_Cargos.UseVisualStyleBackColor = false;
            this.btn_volver_Cargos.Click += new System.EventHandler(this.btn_volver_Cargos_Click);
            // 
            // btn_aggCargo
            // 
            this.btn_aggCargo.BackColor = System.Drawing.Color.Silver;
            this.btn_aggCargo.Location = new System.Drawing.Point(180, 10);
            this.btn_aggCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aggCargo.Name = "btn_aggCargo";
            this.btn_aggCargo.Size = new System.Drawing.Size(171, 62);
            this.btn_aggCargo.TabIndex = 3;
            this.btn_aggCargo.Text = "Agregar";
            this.btn_aggCargo.UseVisualStyleBackColor = false;
            this.btn_aggCargo.Click += new System.EventHandler(this.btn_guardarCargo_Click);
            // 
            // txt_agg_cargo
            // 
            this.txt_agg_cargo.BackColor = System.Drawing.Color.DarkGray;
            this.txt_agg_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_agg_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agg_cargo.Location = new System.Drawing.Point(168, 17);
            this.txt_agg_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_agg_cargo.Name = "txt_agg_cargo";
            this.txt_agg_cargo.Size = new System.Drawing.Size(238, 23);
            this.txt_agg_cargo.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cargo: ";
            // 
            // btn_agregarCargo
            // 
            this.btn_agregarCargo.BackColor = System.Drawing.Color.Silver;
            this.btn_agregarCargo.Location = new System.Drawing.Point(520, 436);
            this.btn_agregarCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregarCargo.Name = "btn_agregarCargo";
            this.btn_agregarCargo.Size = new System.Drawing.Size(280, 36);
            this.btn_agregarCargo.TabIndex = 27;
            this.btn_agregarCargo.Text = "+ Agregar Cargo ";
            this.btn_agregarCargo.UseVisualStyleBackColor = false;
            this.btn_agregarCargo.Click += new System.EventHandler(this.btn_agregarCargo_Click);
            // 
            // data_lista_cargos
            // 
            this.data_lista_cargos.AllowUserToAddRows = false;
            this.data_lista_cargos.AllowUserToDeleteRows = false;
            this.data_lista_cargos.AllowUserToResizeRows = false;
            this.data_lista_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_lista_cargos.ColumnHeadersVisible = false;
            this.data_lista_cargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            this.data_lista_cargos.Location = new System.Drawing.Point(156, 475);
            this.data_lista_cargos.Margin = new System.Windows.Forms.Padding(4);
            this.data_lista_cargos.Name = "data_lista_cargos";
            this.data_lista_cargos.RowHeadersWidth = 51;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.data_lista_cargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.data_lista_cargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_lista_cargos.Size = new System.Drawing.Size(437, 126);
            this.data_lista_cargos.TabIndex = 26;
            this.data_lista_cargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_lista_cargos_CellContentClick_1);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "Editar";
            this.EditarC.Image = global::SistemaAsistencia.Properties.Resources.editar;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.MinimumWidth = 6;
            this.EditarC.Name = "EditarC";
            this.EditarC.Width = 125;
            // 
            // txt_cargo
            // 
            this.txt_cargo.BackColor = System.Drawing.Color.DarkGray;
            this.txt_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo.Location = new System.Drawing.Point(160, 442);
            this.txt_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(330, 23);
            this.txt_cargo.TabIndex = 24;
            this.txt_cargo.TextChanged += new System.EventHandler(this.txt_cargo_TextChanged);
            // 
            // txt_departamento
            // 
            this.txt_departamento.BackColor = System.Drawing.Color.DarkGray;
            this.txt_departamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento.Location = new System.Drawing.Point(156, 198);
            this.txt_departamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(330, 23);
            this.txt_departamento.TabIndex = 23;
            this.txt_departamento.TextChanged += new System.EventHandler(this.txt_departamento_TextChanged);
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
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // PanelDepartamento
            // 
            this.PanelDepartamento.Controls.Add(this.panel7);
            this.PanelDepartamento.Controls.Add(this.panel2);
            this.PanelDepartamento.Controls.Add(this.txt_agg_departamento);
            this.PanelDepartamento.Controls.Add(this.label8);
            this.PanelDepartamento.Location = new System.Drawing.Point(883, 239);
            this.PanelDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDepartamento.Name = "PanelDepartamento";
            this.PanelDepartamento.Size = new System.Drawing.Size(576, 199);
            this.PanelDepartamento.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(158, 46);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 1);
            this.panel7.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_editarDepartamento);
            this.panel2.Controls.Add(this.btn_volver_departamentos);
            this.panel2.Controls.Add(this.btn_aggDepartameno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 103);
            this.panel2.TabIndex = 23;
            // 
            // btn_editarDepartamento
            // 
            this.btn_editarDepartamento.BackColor = System.Drawing.Color.Silver;
            this.btn_editarDepartamento.Location = new System.Drawing.Point(9, 17);
            this.btn_editarDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editarDepartamento.Name = "btn_editarDepartamento";
            this.btn_editarDepartamento.Size = new System.Drawing.Size(171, 62);
            this.btn_editarDepartamento.TabIndex = 23;
            this.btn_editarDepartamento.Text = "Editar";
            this.btn_editarDepartamento.UseVisualStyleBackColor = false;
            this.btn_editarDepartamento.Click += new System.EventHandler(this.btn_editarDepartamento_Click);
            // 
            // btn_volver_departamentos
            // 
            this.btn_volver_departamentos.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver_departamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_departamentos.Image = global::SistemaAsistencia.Properties.Resources.volver_flecha;
            this.btn_volver_departamentos.Location = new System.Drawing.Point(377, 23);
            this.btn_volver_departamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volver_departamentos.Name = "btn_volver_departamentos";
            this.btn_volver_departamentos.Size = new System.Drawing.Size(103, 56);
            this.btn_volver_departamentos.TabIndex = 22;
            this.btn_volver_departamentos.UseVisualStyleBackColor = false;
            this.btn_volver_departamentos.Click += new System.EventHandler(this.btn_volver_departamentos_Click);
            // 
            // btn_aggDepartameno
            // 
            this.btn_aggDepartameno.BackColor = System.Drawing.Color.Silver;
            this.btn_aggDepartameno.Location = new System.Drawing.Point(198, 17);
            this.btn_aggDepartameno.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aggDepartameno.Name = "btn_aggDepartameno";
            this.btn_aggDepartameno.Size = new System.Drawing.Size(171, 62);
            this.btn_aggDepartameno.TabIndex = 3;
            this.btn_aggDepartameno.Text = "Agregar";
            this.btn_aggDepartameno.UseVisualStyleBackColor = false;
            this.btn_aggDepartameno.Click += new System.EventHandler(this.btn_guardarDepar_Click);
            // 
            // txt_agg_departamento
            // 
            this.txt_agg_departamento.BackColor = System.Drawing.Color.DarkGray;
            this.txt_agg_departamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_agg_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agg_departamento.Location = new System.Drawing.Point(158, 18);
            this.txt_agg_departamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_agg_departamento.Name = "txt_agg_departamento";
            this.txt_agg_departamento.Size = new System.Drawing.Size(238, 23);
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
            // Panel_btn_guardar_personal
            // 
            this.Panel_btn_guardar_personal.Controls.Add(this.btn_guardar_cambios_personal);
            this.Panel_btn_guardar_personal.Controls.Add(this.btn_guardar_personal);
            this.Panel_btn_guardar_personal.Location = new System.Drawing.Point(316, 673);
            this.Panel_btn_guardar_personal.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_btn_guardar_personal.Name = "Panel_btn_guardar_personal";
            this.Panel_btn_guardar_personal.Size = new System.Drawing.Size(387, 80);
            this.Panel_btn_guardar_personal.TabIndex = 19;
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
            this.label4.Location = new System.Drawing.Point(5, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Departamento:";
            // 
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.Color.DarkGray;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(156, 140);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(721, 23);
            this.txt_cedula.TabIndex = 11;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.DarkGray;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(156, 82);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(721, 23);
            this.txt_apellido.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.DarkGray;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(156, 26);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(721, 23);
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
            this.label2.Location = new System.Drawing.Point(69, 447);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "EditarD";
            this.dataGridViewImageColumn1.Image = global::SistemaAsistencia.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 33);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.Size = new System.Drawing.Size(2115, 1216);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBxLupaBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelPaginado.ResumeLayout(false);
            this.PanelRegistros.ResumeLayout(false);
            this.PanelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_departamentos)).EndInit();
            this.PanelCargo.ResumeLayout(false);
            this.PanelCargo.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_lista_cargos)).EndInit();
            this.PanelDepartamento.ResumeLayout(false);
            this.PanelDepartamento.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Panel_btn_guardar_personal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PanelPaginado;
        private System.Windows.Forms.Panel txt_simulaLinea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBxLupaBuscar;
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
        private System.Windows.Forms.Panel Panel_btn_guardar_personal;
        private System.Windows.Forms.Panel PanelDepartamento;
        private System.Windows.Forms.Button btn_guardar_cambios_personal;
        private System.Windows.Forms.Button btn_primeraPagina;
        private System.Windows.Forms.Button btn_ultimaPagina;
        private System.Windows.Forms.Button btn_paginaSiguiente;
        private System.Windows.Forms.Button btn_paginaAnterior;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_agg_departamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.DataGridView data_lista_departamentos;
        private System.Windows.Forms.DataGridView data_lista_cargos;
        private System.Windows.Forms.Button btn_agregarCargo;
        private System.Windows.Forms.Panel PanelCargo;
        private System.Windows.Forms.TextBox txt_agg_cargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_aggCargo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_aggDepartameno;
        private System.Windows.Forms.Button btn_agregarDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn EditarD;
        private System.Windows.Forms.Button btn_volver_departamentos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.Button btn_volver_Cargos;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_editarCampo;
        private System.Windows.Forms.Button btn_editarDepartamento;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
