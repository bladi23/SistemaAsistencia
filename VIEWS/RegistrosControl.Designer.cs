namespace SistemaAsistencia.VIEWS
{
    partial class RegistrosControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_RegistrosAsistencias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrosAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RegistrosAsistencias
            // 
            this.dgv_RegistrosAsistencias.AllowUserToAddRows = false;
            this.dgv_RegistrosAsistencias.AllowUserToDeleteRows = false;
            this.dgv_RegistrosAsistencias.AllowUserToResizeRows = false;
            this.dgv_RegistrosAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RegistrosAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RegistrosAsistencias.Location = new System.Drawing.Point(0, 77);
            this.dgv_RegistrosAsistencias.MultiSelect = false;
            this.dgv_RegistrosAsistencias.Name = "dgv_RegistrosAsistencias";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_RegistrosAsistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_RegistrosAsistencias.RowHeadersWidth = 51;
            this.dgv_RegistrosAsistencias.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.dgv_RegistrosAsistencias.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_RegistrosAsistencias.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_RegistrosAsistencias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgv_RegistrosAsistencias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_RegistrosAsistencias.RowTemplate.Height = 24;
            this.dgv_RegistrosAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RegistrosAsistencias.Size = new System.Drawing.Size(1032, 640);
            this.dgv_RegistrosAsistencias.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 77);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 717);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 100);
            this.panel2.TabIndex = 2;
            // 
            // RegistrosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.dgv_RegistrosAsistencias);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrosControl";
            this.Size = new System.Drawing.Size(1032, 817);
            this.Load += new System.EventHandler(this.RegistrosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrosAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RegistrosAsistencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
