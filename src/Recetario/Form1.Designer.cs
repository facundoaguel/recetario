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
            this.button1 = new System.Windows.Forms.Button();
            this.AgregarI = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PedirI = new System.Windows.Forms.Button();
            this.Lista_Ingredientes = new System.Windows.Forms.ListBox();
            this.Lista_Recetas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.EliminarI = new System.Windows.Forms.Button();
            this.Ingredientes_Receta = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR RECETA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarI
            // 
            this.AgregarI.Location = new System.Drawing.Point(315, 215);
            this.AgregarI.Name = "AgregarI";
            this.AgregarI.Size = new System.Drawing.Size(173, 23);
            this.AgregarI.TabIndex = 1;
            this.AgregarI.Text = "AGREGAR INGREDIENTE";
            this.AgregarI.UseVisualStyleBackColor = true;
            this.AgregarI.Click += new System.EventHandler(this.AgregarI_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "COCINAR RECETA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "MODIFICAR RECETA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "ELIMINAR RECETA";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // PedirI
            // 
            this.PedirI.Location = new System.Drawing.Point(264, 111);
            this.PedirI.Name = "PedirI";
            this.PedirI.Size = new System.Drawing.Size(54, 23);
            this.PedirI.TabIndex = 5;
            this.PedirI.Text = "PEDIR INGREDIENTE";
            this.PedirI.UseVisualStyleBackColor = true;
            // 
            // Lista_Ingredientes
            // 
            this.Lista_Ingredientes.FormattingEnabled = true;
            this.Lista_Ingredientes.Location = new System.Drawing.Point(518, 12);
            this.Lista_Ingredientes.Name = "Lista_Ingredientes";
            this.Lista_Ingredientes.Size = new System.Drawing.Size(198, 355);
            this.Lista_Ingredientes.TabIndex = 6;
            // 
            // Lista_Recetas
            // 
            this.Lista_Recetas.FormattingEnabled = true;
            this.Lista_Recetas.Location = new System.Drawing.Point(336, 256);
            this.Lista_Recetas.Name = "Lista_Recetas";
            this.Lista_Recetas.Size = new System.Drawing.Size(140, 82);
            this.Lista_Recetas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "NombreReceta";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(123, 20);
            this.textBox5.TabIndex = 17;
            // 
            // EliminarI
            // 
            this.EliminarI.Location = new System.Drawing.Point(264, 141);
            this.EliminarI.Name = "EliminarI";
            this.EliminarI.Size = new System.Drawing.Size(54, 23);
            this.EliminarI.TabIndex = 18;
            this.EliminarI.Text = "ELIMINAR INGREDIENTE";
            this.EliminarI.UseVisualStyleBackColor = true;
            // 
            // Ingredientes_Receta
            // 
            this.Ingredientes_Receta.FormattingEnabled = true;
            this.Ingredientes_Receta.Location = new System.Drawing.Point(379, 12);
            this.Ingredientes_Receta.Name = "Ingredientes_Receta";
            this.Ingredientes_Receta.Size = new System.Drawing.Size(78, 95);
            this.Ingredientes_Receta.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ingredientes_Receta);
            this.Controls.Add(this.EliminarI);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lista_Recetas);
            this.Controls.Add(this.Lista_Ingredientes);
            this.Controls.Add(this.PedirI);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AgregarI);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AgregarI;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button PedirI;
        private System.Windows.Forms.ListBox Lista_Ingredientes;
        private System.Windows.Forms.ListBox Lista_Recetas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button EliminarI;
        private System.Windows.Forms.ListBox Ingredientes_Receta;
        private System.Windows.Forms.TextBox textBox1;
    }
}

