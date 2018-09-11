namespace RegistroLibros.UI.Registros
{
    partial class rTipos
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.Windows.Forms.Label cantidadLabel;
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.tipoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            descripcionLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 80);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(104, 77);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(225, 22);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(12, 43);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(55, 17);
            tipoIdLabel.TabIndex = 5;
            tipoIdLabel.Text = "Tipo Id:";
            // 
            // tipoIdNumericUpDown
            // 
            this.tipoIdNumericUpDown.Location = new System.Drawing.Point(104, 45);
            this.tipoIdNumericUpDown.Name = "tipoIdNumericUpDown";
            this.tipoIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.tipoIdNumericUpDown.TabIndex = 6;
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Eliminar.Image = global::RegistroLibros.Properties.Resources.if_cross_24_103181;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar.Location = new System.Drawing.Point(254, 159);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 62);
            this.Eliminar.TabIndex = 15;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Guardar.Image = global::RegistroLibros.Properties.Resources.if_floppy_disk_save_103863;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardar.Location = new System.Drawing.Point(129, 159);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 62);
            this.Guardar.TabIndex = 14;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nuevo.Image = global::RegistroLibros.Properties.Resources.if_new10_216291;
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevo.Location = new System.Drawing.Point(12, 160);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 61);
            this.Nuevo.TabIndex = 13;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevo.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Image = global::RegistroLibros.Properties.Resources.if_search_126577;
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscar.Location = new System.Drawing.Point(243, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(86, 58);
            this.Buscar.TabIndex = 12;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(12, 115);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(68, 17);
            cantidadLabel.TabIndex = 16;
            cantidadLabel.Text = "Cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(104, 112);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.ReadOnly = true;
            this.cantidadTextBox.Size = new System.Drawing.Size(120, 22);
            this.cantidadTextBox.TabIndex = 17;
            // 
            // rTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 233);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Name = "rTipos";
            this.Text = "rTipos";
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown tipoIdNumericUpDown;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox cantidadTextBox;
    }
}