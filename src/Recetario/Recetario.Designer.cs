namespace Recetario
{
    partial class Recetario
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
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.ingredientesreceta_comboBox = new System.Windows.Forms.ComboBox();
            this.cantidadingreceta_textBox = new System.Windows.Forms.TextBox();
            this.agregaringreceta_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminaringreceta_button = new System.Windows.Forms.Button();
            this.ingredientesReceta_listBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cocinar_button = new System.Windows.Forms.Button();
            this.recetas_listBox = new System.Windows.Forms.ListBox();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.modificar_button = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.modificaringreceta_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.crearreceta_button = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(106, 38);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_textBox.TabIndex = 1;
            // 
            // ingredientesreceta_comboBox
            // 
            this.ingredientesreceta_comboBox.FormattingEnabled = true;
            this.ingredientesreceta_comboBox.Location = new System.Drawing.Point(26, 83);
            this.ingredientesreceta_comboBox.Name = "ingredientesreceta_comboBox";
            this.ingredientesreceta_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ingredientesreceta_comboBox.TabIndex = 3;
            this.ingredientesreceta_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cantidadingreceta_textBox
            // 
            this.cantidadingreceta_textBox.Location = new System.Drawing.Point(106, 110);
            this.cantidadingreceta_textBox.Name = "cantidadingreceta_textBox";
            this.cantidadingreceta_textBox.Size = new System.Drawing.Size(41, 20);
            this.cantidadingreceta_textBox.TabIndex = 4;
            // 
            // agregaringreceta_button
            // 
            this.agregaringreceta_button.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregaringreceta_button.Location = new System.Drawing.Point(191, 111);
            this.agregaringreceta_button.Name = "agregaringreceta_button";
            this.agregaringreceta_button.Size = new System.Drawing.Size(88, 47);
            this.agregaringreceta_button.TabIndex = 5;
            this.agregaringreceta_button.Text = "+";
            this.agregaringreceta_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminaringreceta_button);
            this.groupBox2.Controls.Add(this.ingredientesReceta_listBox);
            this.groupBox2.Location = new System.Drawing.Point(402, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 228);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes de la receta";
            // 
            // eliminaringreceta_button
            // 
            this.eliminaringreceta_button.Location = new System.Drawing.Point(28, 200);
            this.eliminaringreceta_button.Name = "eliminaringreceta_button";
            this.eliminaringreceta_button.Size = new System.Drawing.Size(126, 23);
            this.eliminaringreceta_button.TabIndex = 3;
            this.eliminaringreceta_button.Text = "Eliminar";
            this.eliminaringreceta_button.UseVisualStyleBackColor = true;
            // 
            // ingredientesReceta_listBox
            // 
            this.ingredientesReceta_listBox.DisplayMember = "IngredienteReceta";
            this.ingredientesReceta_listBox.FormattingEnabled = true;
            this.ingredientesReceta_listBox.Location = new System.Drawing.Point(28, 34);
            this.ingredientesReceta_listBox.Name = "ingredientesReceta_listBox";
            this.ingredientesReceta_listBox.Size = new System.Drawing.Size(126, 160);
            this.ingredientesReceta_listBox.TabIndex = 0;
            this.ingredientesReceta_listBox.SelectedIndexChanged += new System.EventHandler(this.ingredientesReceta_listBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.crearreceta_button);
            this.groupBox3.Controls.Add(this.nombre_textBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(34, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 523);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar receta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cocinar_button);
            this.groupBox1.Controls.Add(this.recetas_listBox);
            this.groupBox1.Controls.Add(this.eliminar_button);
            this.groupBox1.Controls.Add(this.modificar_button);
            this.groupBox1.Location = new System.Drawing.Point(281, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 220);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de recetas";
            // 
            // cocinar_button
            // 
            this.cocinar_button.Location = new System.Drawing.Point(26, 35);
            this.cocinar_button.Name = "cocinar_button";
            this.cocinar_button.Size = new System.Drawing.Size(144, 23);
            this.cocinar_button.TabIndex = 9;
            this.cocinar_button.Text = "Cocinar";
            this.cocinar_button.UseVisualStyleBackColor = true;
            this.cocinar_button.Click += new System.EventHandler(this.cocinar_button_Click);
            // 
            // recetas_listBox
            // 
            this.recetas_listBox.DisplayMember = "Nombre";
            this.recetas_listBox.FormattingEnabled = true;
            this.recetas_listBox.Location = new System.Drawing.Point(191, 35);
            this.recetas_listBox.Name = "recetas_listBox";
            this.recetas_listBox.Size = new System.Drawing.Size(113, 160);
            this.recetas_listBox.TabIndex = 6;
            // 
            // eliminar_button
            // 
            this.eliminar_button.Location = new System.Drawing.Point(26, 160);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(144, 23);
            this.eliminar_button.TabIndex = 8;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            // 
            // modificar_button
            // 
            this.modificar_button.Location = new System.Drawing.Point(26, 98);
            this.modificar_button.Name = "modificar_button";
            this.modificar_button.Size = new System.Drawing.Size(144, 23);
            this.modificar_button.TabIndex = 7;
            this.modificar_button.Text = "Modificar";
            this.modificar_button.UseVisualStyleBackColor = true;
            this.modificar_button.Click += new System.EventHandler(this.modificar_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.modificaringreceta_button);
            this.groupBox4.Controls.Add(this.ingredientesreceta_comboBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cantidadingreceta_textBox);
            this.groupBox4.Controls.Add(this.agregaringreceta_button);
            this.groupBox4.Location = new System.Drawing.Point(57, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 176);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar ingredientes";
            // 
            // modificaringreceta_button
            // 
            this.modificaringreceta_button.Location = new System.Drawing.Point(191, 24);
            this.modificaringreceta_button.Name = "modificaringreceta_button";
            this.modificaringreceta_button.Size = new System.Drawing.Size(88, 40);
            this.modificaringreceta_button.TabIndex = 11;
            this.modificaringreceta_button.Text = "Modificar";
            this.modificaringreceta_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad:";
            // 
            // crearreceta_button
            // 
            this.crearreceta_button.Location = new System.Drawing.Point(26, 73);
            this.crearreceta_button.Name = "crearreceta_button";
            this.crearreceta_button.Size = new System.Drawing.Size(183, 52);
            this.crearreceta_button.TabIndex = 12;
            this.crearreceta_button.Text = "CREAR RECETA";
            this.crearreceta_button.UseVisualStyleBackColor = true;
            this.crearreceta_button.Click += new System.EventHandler(this.crearreceta_button_Click);
            // 
            // Recetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 569);
            this.Controls.Add(this.groupBox3);
            this.Name = "Recetario";
            this.Text = "Recetario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.ComboBox ingredientesreceta_comboBox;
        private System.Windows.Forms.TextBox cantidadingreceta_textBox;
        private System.Windows.Forms.Button agregaringreceta_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eliminaringreceta_button;
        private System.Windows.Forms.ListBox ingredientesReceta_listBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Button modificar_button;
        private System.Windows.Forms.ListBox recetas_listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button crearreceta_button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cocinar_button;
        private System.Windows.Forms.Button modificaringreceta_button;
    }
}