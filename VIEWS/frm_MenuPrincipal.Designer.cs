namespace SistemaAsistencia.VIEWS
{
    partial class frm_MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.PanelPadre = new System.Windows.Forms.Panel();
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.PanelPadre.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.btnConsultas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 840);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel17);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 279);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 561);
            this.panel4.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label1);
            this.panel17.Controls.Add(this.pictureBox1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 102);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(213, 459);
            this.panel17.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BLADOLEX";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SistemaAsistencia.Properties.Resources.logoBladolex;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRegistro);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 102);
            this.panel5.TabIndex = 0;
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Image = global::SistemaAsistencia.Properties.Resources.despertador;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(17, 12);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(196, 90);
            this.btnRegistro.TabIndex = 3;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 12);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(17, 90);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(213, 12);
            this.panel6.TabIndex = 0;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Location = new System.Drawing.Point(0, 175);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(213, 89);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(0, 0);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(213, 175);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.UseVisualStyleBackColor = false;
            // 
            // PanelPadre
            // 
            this.PanelPadre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelPadre.Controls.Add(this.panelBienvenida);
            this.PanelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPadre.Location = new System.Drawing.Point(213, 0);
            this.PanelPadre.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPadre.Name = "PanelPadre";
            this.PanelPadre.Size = new System.Drawing.Size(1497, 840);
            this.PanelPadre.TabIndex = 1;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.Controls.Add(this.label2);
            this.panelBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBienvenida.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenida.Margin = new System.Windows.Forms.Padding(4);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(1497, 840);
            this.panelBienvenida.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1497, 840);
            this.label2.TabIndex = 0;
            this.label2.Text = "BIENVENIDO A BLADOLEX";
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.PanelPadre);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.PanelPadre.ResumeLayout(false);
            this.panelBienvenida.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelPadre;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBienvenida;
        private System.Windows.Forms.Label label2;
    }
}