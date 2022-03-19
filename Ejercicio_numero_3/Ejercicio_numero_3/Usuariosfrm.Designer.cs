
namespace Ejercicio_numero_3
{
    partial class Usuariosfrm
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
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RolUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EdadTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GeneroComboBox = new System.Windows.Forms.ComboBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.UsuariosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(243, 14);
            this.CodigoTextBox.MaxLength = 15;
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(233, 22);
            this.CodigoTextBox.TabIndex = 0;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(243, 48);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(233, 22);
            this.NombreTextBox.TabIndex = 1;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Enabled = false;
            this.IdentidadTextBox.Location = new System.Drawing.Point(243, 78);
            this.IdentidadTextBox.MaxLength = 15;
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(233, 22);
            this.IdentidadTextBox.TabIndex = 2;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Enabled = false;
            this.ContraseñaTextBox.Location = new System.Drawing.Point(243, 166);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(233, 22);
            this.ContraseñaTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "RolUsuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contraseña";
            // 
            // RolUsuarioComboBox
            // 
            this.RolUsuarioComboBox.Enabled = false;
            this.RolUsuarioComboBox.FormattingEnabled = true;
            this.RolUsuarioComboBox.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO"});
            this.RolUsuarioComboBox.Location = new System.Drawing.Point(243, 108);
            this.RolUsuarioComboBox.Name = "RolUsuarioComboBox";
            this.RolUsuarioComboBox.Size = new System.Drawing.Size(233, 23);
            this.RolUsuarioComboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad";
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Enabled = false;
            this.EdadTextBox.Location = new System.Drawing.Point(243, 194);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(233, 22);
            this.EdadTextBox.TabIndex = 14;
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.Enabled = false;
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.GeneroComboBox.Location = new System.Drawing.Point(243, 137);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(233, 23);
            this.GeneroComboBox.TabIndex = 15;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(161, 233);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.Enabled = false;
            this.EditarButton.Location = new System.Drawing.Point(242, 233);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(75, 23);
            this.EditarButton.TabIndex = 17;
            this.EditarButton.Text = "Editar";
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Location = new System.Drawing.Point(323, 233);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 18;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(404, 233);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 19;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(485, 233);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 20;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(-1, 262);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.Size = new System.Drawing.Size(844, 215);
            this.UsuariosDataGridView.TabIndex = 21;
            // 
            // Usuariosfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 479);
            this.Controls.Add(this.UsuariosDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GeneroComboBox);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RolUsuarioComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.IdentidadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Usuariosfrm";
            this.Text = "Usuariosfrm";
            this.Load += new System.EventHandler(this.Usuariosfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.MaskedTextBox NombreTextBox;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.MaskedTextBox ContraseñaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RolUsuarioComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox EdadTextBox;
        private System.Windows.Forms.ComboBox GeneroComboBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView UsuariosDataGridView;
    }
}