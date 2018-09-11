namespace RegistroLibros.UI.Registros
{
    partial class RegistroLibro
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
            this.IDNumericoUpDowm = new System.Windows.Forms.NumericUpDown();
            this.Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.SiglasTextBox = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericoUpDowm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IDNumericoUpDowm
            // 
            this.IDNumericoUpDowm.Location = new System.Drawing.Point(116, 43);
            this.IDNumericoUpDowm.Name = "IDNumericoUpDowm";
            this.IDNumericoUpDowm.Size = new System.Drawing.Size(120, 22);
            this.IDNumericoUpDowm.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Image = global::RegistroLibros.Properties.Resources.if_search_126577;
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscar.Location = new System.Drawing.Point(250, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(86, 58);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Siglas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "TipoId";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(116, 76);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(220, 22);
            this.DescripcionTextBox.TabIndex = 6;
            // 
            // SiglasTextBox
            // 
            this.SiglasTextBox.Location = new System.Drawing.Point(116, 107);
            this.SiglasTextBox.Name = "SiglasTextBox";
            this.SiglasTextBox.Size = new System.Drawing.Size(220, 22);
            this.SiglasTextBox.TabIndex = 7;
            // 
            // Nuevo
            // 
            this.Nuevo.Image = global::RegistroLibros.Properties.Resources.if_new10_216291;
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevo.Location = new System.Drawing.Point(28, 195);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 61);
            this.Nuevo.TabIndex = 9;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Image = global::RegistroLibros.Properties.Resources.if_floppy_disk_save_103863;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardar.Location = new System.Drawing.Point(145, 194);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 62);
            this.Guardar.TabIndex = 10;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Image = global::RegistroLibros.Properties.Resources.if_cross_24_103181;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar.Location = new System.Drawing.Point(261, 194);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 62);
            this.Eliminar.TabIndex = 11;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(116, 139);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(186, 24);
            this.tipoIdComboBox.TabIndex = 13;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(308, 140);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(28, 23);
            this.Nuevobutton.TabIndex = 14;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // RegistroLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(379, 280);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.SiglasTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.IDNumericoUpDowm);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RegistroLibro";
            this.Text = "Registro Libro";
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericoUpDowm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDNumericoUpDowm;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.TextBox SiglasTextBox;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
        private System.Windows.Forms.Button Nuevobutton;
    }
}