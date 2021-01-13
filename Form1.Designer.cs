
namespace ProyectoTarea1_DIbujarFormulario
{
    partial class RegistrosUsuariosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrosUsuariosForm));
            this.IDLabel = new System.Windows.Forms.Label();
            this.AliasLabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClaveMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmarClaveMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CostoxHoraLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NivelLabel = new System.Windows.Forms.Label();
            this.NivelComboBox = new System.Windows.Forms.ComboBox();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(50, 55);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 20);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.Click += new System.EventHandler(this.IDLabel_Click);
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(50, 98);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(41, 20);
            this.AliasLabel.TabIndex = 1;
            this.AliasLabel.Text = "Alias";
            this.AliasLabel.Click += new System.EventHandler(this.AliasLabel_Click);
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Location = new System.Drawing.Point(50, 140);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(70, 20);
            this.NombresLabel.TabIndex = 2;
            this.NombresLabel.Text = "Nombres";
            this.NombresLabel.Click += new System.EventHandler(this.NombresLabel_Click);
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(50, 186);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(45, 20);
            this.ClaveLabel.TabIndex = 3;
            this.ClaveLabel.Text = "Clave";
            this.ClaveLabel.Click += new System.EventHandler(this.ClaveLabel_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(134, 55);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(113, 27);
            this.IDTextBox.TabIndex = 4;
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Location = new System.Drawing.Point(134, 95);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(162, 27);
            this.AliasTextBox.TabIndex = 5;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(134, 140);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(300, 27);
            this.NombresTextBox.TabIndex = 6;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(450, 143);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 20);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirmar Clave";
            // 
            // ClaveMaskedTextBox
            // 
            this.ClaveMaskedTextBox.Location = new System.Drawing.Point(134, 183);
            this.ClaveMaskedTextBox.Name = "ClaveMaskedTextBox";
            this.ClaveMaskedTextBox.PasswordChar = '*';
            this.ClaveMaskedTextBox.ShortcutsEnabled = false;
            this.ClaveMaskedTextBox.Size = new System.Drawing.Size(125, 27);
            this.ClaveMaskedTextBox.TabIndex = 11;
            // 
            // ConfirmarClaveMaskedTextBox
            // 
            this.ConfirmarClaveMaskedTextBox.Location = new System.Drawing.Point(403, 183);
            this.ConfirmarClaveMaskedTextBox.Name = "ConfirmarClaveMaskedTextBox";
            this.ConfirmarClaveMaskedTextBox.PasswordChar = '*';
            this.ConfirmarClaveMaskedTextBox.ShortcutsEnabled = false;
            this.ConfirmarClaveMaskedTextBox.Size = new System.Drawing.Size(125, 27);
            this.ConfirmarClaveMaskedTextBox.TabIndex = 13;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(502, 140);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(227, 27);
            this.EmailTextBox.TabIndex = 14;
            // 
            // CostoxHoraLabel
            // 
            this.CostoxHoraLabel.AutoSize = true;
            this.CostoxHoraLabel.Location = new System.Drawing.Point(545, 186);
            this.CostoxHoraLabel.Name = "CostoxHoraLabel";
            this.CostoxHoraLabel.Size = new System.Drawing.Size(95, 20);
            this.CostoxHoraLabel.TabIndex = 15;
            this.CostoxHoraLabel.Text = "Costo x Hora";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(646, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 27);
            this.textBox1.TabIndex = 16;
            // 
            // NivelLabel
            // 
            this.NivelLabel.AutoSize = true;
            this.NivelLabel.Location = new System.Drawing.Point(545, 92);
            this.NivelLabel.Name = "NivelLabel";
            this.NivelLabel.Size = new System.Drawing.Size(43, 20);
            this.NivelLabel.TabIndex = 17;
            this.NivelLabel.Text = "Nivel";
            // 
            // NivelComboBox
            // 
            this.NivelComboBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NivelComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NivelComboBox.FormattingEnabled = true;
            this.NivelComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante"});
            this.NivelComboBox.Location = new System.Drawing.Point(594, 92);
            this.NivelComboBox.Name = "NivelComboBox";
            this.NivelComboBox.Size = new System.Drawing.Size(135, 28);
            this.NivelComboBox.TabIndex = 18;
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(646, 51);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(73, 24);
            this.ActivoCheckBox.TabIndex = 19;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(188, 254);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(108, 64);
            this.NuevoButton.TabIndex = 20;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(343, 254);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(108, 64);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(493, 254);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(114, 64);
            this.EliminarButton.TabIndex = 22;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(253, 47);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(43, 42);
            this.BuscarButton.TabIndex = 23;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // RegistrosUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.NivelComboBox);
            this.Controls.Add(this.NivelLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CostoxHoraLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ConfirmarClaveMaskedTextBox);
            this.Controls.Add(this.ClaveMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.AliasTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.AliasLabel);
            this.Controls.Add(this.IDLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrosUsuariosForm";
            this.Text = "Registros de Usuarios";
            this.Load += new System.EventHandler(this.RegistrosUsuariosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label AliasLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ClaveMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ConfirmarClaveMaskedTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label CostoxHoraLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NivelLabel;
        private System.Windows.Forms.ComboBox NivelComboBox;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
    }
}

