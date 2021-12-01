
namespace CrudWithAdoNETFinal
{
    partial class frmNuevo
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
            this.tlpNuevo = new System.Windows.Forms.TableLayoutPanel();
            this.pNuevo = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalirNuevo = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.tlpNuevo.SuspendLayout();
            this.pNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNuevo
            // 
            this.tlpNuevo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tlpNuevo.ColumnCount = 1;
            this.tlpNuevo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNuevo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNuevo.Controls.Add(this.pNuevo, 0, 0);
            this.tlpNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNuevo.Location = new System.Drawing.Point(0, 0);
            this.tlpNuevo.Name = "tlpNuevo";
            this.tlpNuevo.RowCount = 1;
            this.tlpNuevo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNuevo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNuevo.Size = new System.Drawing.Size(411, 299);
            this.tlpNuevo.TabIndex = 0;
            // 
            // pNuevo
            // 
            this.pNuevo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pNuevo.Controls.Add(this.txtEdad);
            this.pNuevo.Controls.Add(this.btnSalirNuevo);
            this.pNuevo.Controls.Add(this.btnGuardar);
            this.pNuevo.Controls.Add(this.txtDireccion);
            this.pNuevo.Controls.Add(this.txtApellido);
            this.pNuevo.Controls.Add(this.txtNombre);
            this.pNuevo.Controls.Add(this.lblEdad);
            this.pNuevo.Controls.Add(this.lblDireccion);
            this.pNuevo.Controls.Add(this.lblApellido);
            this.pNuevo.Controls.Add(this.lblNombre);
            this.pNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNuevo.Location = new System.Drawing.Point(3, 3);
            this.pNuevo.Name = "pNuevo";
            this.pNuevo.Size = new System.Drawing.Size(405, 293);
            this.pNuevo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(34, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(27, 139);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(77, 19);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(57, 194);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 19);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 85);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(236, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 138);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(236, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(110, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalirNuevo
            // 
            this.btnSalirNuevo.Location = new System.Drawing.Point(271, 247);
            this.btnSalirNuevo.Name = "btnSalirNuevo";
            this.btnSalirNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnSalirNuevo.TabIndex = 9;
            this.btnSalirNuevo.Text = "Salir";
            this.btnSalirNuevo.UseVisualStyleBackColor = true;
            this.btnSalirNuevo.Click += new System.EventHandler(this.btnSalirNuevo_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(110, 193);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(236, 20);
            this.txtEdad.TabIndex = 10;
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 299);
            this.Controls.Add(this.tlpNuevo);
            this.Name = "frmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevo";
            this.Load += new System.EventHandler(this.frmNuevo_Load);
            this.tlpNuevo.ResumeLayout(false);
            this.pNuevo.ResumeLayout(false);
            this.pNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNuevo;
        private System.Windows.Forms.Panel pNuevo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSalirNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEdad;
    }
}