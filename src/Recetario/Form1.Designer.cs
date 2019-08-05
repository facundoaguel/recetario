namespace Recetario
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eliminar_button = new System.Windows.Forms.Button();
            this.modificar_button = new System.Windows.Forms.Button();
            this.agregar_button = new System.Windows.Forms.Button();
            this.recetas_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminaring_button = new System.Windows.Forms.Button();
            this.ingredientesReceta_listBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stocking_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eliminar_button);
            this.groupBox1.Controls.Add(this.modificar_button);
            this.groupBox1.Controls.Add(this.agregar_button);
            this.groupBox1.Controls.Add(this.recetas_listBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recetario";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // eliminar_button
            // 
            this.eliminar_button.Location = new System.Drawing.Point(67, 199);
            this.eliminar_button.Name = "eliminar_button";
            this.eliminar_button.Size = new System.Drawing.Size(211, 23);
            this.eliminar_button.TabIndex = 3;
            this.eliminar_button.Text = "Eliminar";
            this.eliminar_button.UseVisualStyleBackColor = true;
            // 
            // modificar_button
            // 
            this.modificar_button.Location = new System.Drawing.Point(182, 170);
            this.modificar_button.Name = "modificar_button";
            this.modificar_button.Size = new System.Drawing.Size(96, 23);
            this.modificar_button.TabIndex = 2;
            this.modificar_button.Text = "Modificar";
            this.modificar_button.UseVisualStyleBackColor = true;
            // 
            // agregar_button
            // 
            this.agregar_button.Location = new System.Drawing.Point(67, 170);
            this.agregar_button.Name = "agregar_button";
            this.agregar_button.Size = new System.Drawing.Size(99, 23);
            this.agregar_button.TabIndex = 1;
            this.agregar_button.Text = "Agregar";
            this.agregar_button.UseVisualStyleBackColor = true;
            this.agregar_button.Click += new System.EventHandler(this.agregar_button_Click);
            // 
            // recetas_listBox
            // 
            this.recetas_listBox.DisplayMember = "Nombre";
            this.recetas_listBox.FormattingEnabled = true;
            this.recetas_listBox.Location = new System.Drawing.Point(67, 30);
            this.recetas_listBox.Name = "recetas_listBox";
            this.recetas_listBox.Size = new System.Drawing.Size(211, 134);
            this.recetas_listBox.TabIndex = 0;
            this.recetas_listBox.SelectedIndexChanged += new System.EventHandler(this.Recetas_listBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminaring_button);
            this.groupBox2.Controls.Add(this.ingredientesReceta_listBox);
            this.groupBox2.Location = new System.Drawing.Point(403, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes de la receta";
            // 
            // eliminaring_button
            // 
            this.eliminaring_button.Location = new System.Drawing.Point(40, 183);
            this.eliminaring_button.Name = "eliminaring_button";
            this.eliminaring_button.Size = new System.Drawing.Size(126, 23);
            this.eliminaring_button.TabIndex = 3;
            this.eliminaring_button.Text = "Eliminar";
            this.eliminaring_button.UseVisualStyleBackColor = true;
            // 
            // ingredientesReceta_listBox
            // 
            this.ingredientesReceta_listBox.DisplayMember = "IngredienteReceta";
            this.ingredientesReceta_listBox.FormattingEnabled = true;
            this.ingredientesReceta_listBox.Location = new System.Drawing.Point(40, 32);
            this.ingredientesReceta_listBox.Name = "ingredientesReceta_listBox";
            this.ingredientesReceta_listBox.Size = new System.Drawing.Size(126, 134);
            this.ingredientesReceta_listBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stocking_button);
            this.groupBox3.Location = new System.Drawing.Point(26, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ingredientes";
            // 
            // stocking_button
            // 
            this.stocking_button.Location = new System.Drawing.Point(67, 35);
            this.stocking_button.Name = "stocking_button";
            this.stocking_button.Size = new System.Drawing.Size(211, 23);
            this.stocking_button.TabIndex = 0;
            this.stocking_button.Text = "Dirigirse al stock";
            this.stocking_button.UseVisualStyleBackColor = true;
            this.stocking_button.Click += new System.EventHandler(this.stocking_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button eliminar_button;
        private System.Windows.Forms.Button modificar_button;
        private System.Windows.Forms.Button agregar_button;
        private System.Windows.Forms.ListBox recetas_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eliminaring_button;
        private System.Windows.Forms.ListBox ingredientesReceta_listBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button stocking_button;
    }
}

