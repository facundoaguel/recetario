namespace Recetario
{
    partial class VistaIngredientes
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
            this.stockingredientes_listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.cantidad_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agregaringrediente_button = new System.Windows.Forms.Button();
            this.modificaring_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantidadminima_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.precio_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminaring_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockingredientes_listBox
            // 
            this.stockingredientes_listBox.DisplayMember = "MostrarDatos";
            this.stockingredientes_listBox.FormattingEnabled = true;
            this.stockingredientes_listBox.Location = new System.Drawing.Point(360, 72);
            this.stockingredientes_listBox.Name = "stockingredientes_listBox";
            this.stockingredientes_listBox.Size = new System.Drawing.Size(120, 186);
            this.stockingredientes_listBox.TabIndex = 2;
            this.stockingredientes_listBox.SelectedIndexChanged += new System.EventHandler(this.stockingredientes_listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(75, 29);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(157, 20);
            this.nombre_textBox.TabIndex = 4;
            // 
            // cantidad_textBox
            // 
            this.cantidad_textBox.Location = new System.Drawing.Point(75, 55);
            this.cantidad_textBox.Name = "cantidad_textBox";
            this.cantidad_textBox.Size = new System.Drawing.Size(157, 20);
            this.cantidad_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad:";
            // 
            // agregaringrediente_button
            // 
            this.agregaringrediente_button.Location = new System.Drawing.Point(39, 169);
            this.agregaringrediente_button.Name = "agregaringrediente_button";
            this.agregaringrediente_button.Size = new System.Drawing.Size(193, 23);
            this.agregaringrediente_button.TabIndex = 7;
            this.agregaringrediente_button.Text = "Agregar Ingrediente";
            this.agregaringrediente_button.UseVisualStyleBackColor = true;
            this.agregaringrediente_button.Click += new System.EventHandler(this.agregaringrediente_button_Click);
            // 
            // modificaring_button
            // 
            this.modificaring_button.Location = new System.Drawing.Point(39, 205);
            this.modificaring_button.Name = "modificaring_button";
            this.modificaring_button.Size = new System.Drawing.Size(193, 23);
            this.modificaring_button.TabIndex = 8;
            this.modificaring_button.Text = "Modificar";
            this.modificaring_button.UseVisualStyleBackColor = true;
            this.modificaring_button.Click += new System.EventHandler(this.modificaring_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cantidadminima_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.precio_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre_textBox);
            this.groupBox1.Controls.Add(this.modificaring_button);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.agregaringrediente_button);
            this.groupBox1.Controls.Add(this.cantidad_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(55, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cantidadminima_textBox
            // 
            this.cantidadminima_textBox.Location = new System.Drawing.Point(115, 81);
            this.cantidadminima_textBox.Name = "cantidadminima_textBox";
            this.cantidadminima_textBox.Size = new System.Drawing.Size(117, 20);
            this.cantidadminima_textBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad minima:";
            // 
            // precio_textBox
            // 
            this.precio_textBox.Location = new System.Drawing.Point(90, 107);
            this.precio_textBox.Name = "precio_textBox";
            this.precio_textBox.Size = new System.Drawing.Size(142, 20);
            this.precio_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precio (Kg):";
            // 
            // eliminaring_button
            // 
            this.eliminaring_button.Location = new System.Drawing.Point(360, 277);
            this.eliminaring_button.Name = "eliminaring_button";
            this.eliminaring_button.Size = new System.Drawing.Size(120, 23);
            this.eliminaring_button.TabIndex = 11;
            this.eliminaring_button.Text = "Eliminar";
            this.eliminaring_button.UseVisualStyleBackColor = true;
            this.eliminaring_button.Click += new System.EventHandler(this.eliminaring_button_Click);
            // 
            // VistaIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 339);
            this.Controls.Add(this.eliminaring_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stockingredientes_listBox);
            this.Name = "VistaIngredientes";
            this.Text = "VistaIngredientes";
            this.Load += new System.EventHandler(this.VistaRecetas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox stockingredientes_listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox cantidad_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregaringrediente_button;
        private System.Windows.Forms.Button modificaring_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox precio_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminaring_button;
        private System.Windows.Forms.TextBox cantidadminima_textBox;
        private System.Windows.Forms.Label label4;
    }
}