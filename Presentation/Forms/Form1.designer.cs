namespace Cuestionario
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.opcion2 = new System.Windows.Forms.RadioButton();
            this.BtnVerficar1 = new System.Windows.Forms.Button();
            this.opcion4 = new System.Windows.Forms.RadioButton();
            this.opcion3 = new System.Windows.Forms.RadioButton();
            this.opcion1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Puntaje = new System.Windows.Forms.TextBox();
            this.LbCorrectas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbIncorrectas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pregunta1 = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox.Controls.Add(this.Pregunta1);
            this.GroupBox.Controls.Add(this.opcion2);
            this.GroupBox.Controls.Add(this.BtnVerficar1);
            this.GroupBox.Controls.Add(this.opcion4);
            this.GroupBox.Controls.Add(this.opcion3);
            this.GroupBox.Controls.Add(this.opcion1);
            this.GroupBox.Font = new System.Drawing.Font("Niagara Engraved", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(49, 13);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GroupBox.Size = new System.Drawing.Size(672, 296);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Cuestionario 1";
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // opcion2
            // 
            this.opcion2.AutoSize = true;
            this.opcion2.Location = new System.Drawing.Point(29, 183);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(32, 23);
            this.opcion2.TabIndex = 5;
            this.opcion2.Text = "B";
            this.opcion2.UseVisualStyleBackColor = true;
            // 
            // BtnVerficar1
            // 
            this.BtnVerficar1.Location = new System.Drawing.Point(572, 248);
            this.BtnVerficar1.Name = "BtnVerficar1";
            this.BtnVerficar1.Size = new System.Drawing.Size(75, 23);
            this.BtnVerficar1.TabIndex = 4;
            this.BtnVerficar1.Text = "Verficar";
            this.BtnVerficar1.UseVisualStyleBackColor = true;
            this.BtnVerficar1.Click += new System.EventHandler(this.BtnVerficar1_Click);
            // 
            // opcion4
            // 
            this.opcion4.AutoSize = true;
            this.opcion4.Location = new System.Drawing.Point(356, 183);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(32, 23);
            this.opcion4.TabIndex = 3;
            this.opcion4.Text = "D";
            this.opcion4.UseVisualStyleBackColor = true;
            // 
            // opcion3
            // 
            this.opcion3.AutoSize = true;
            this.opcion3.Location = new System.Drawing.Point(356, 107);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(32, 23);
            this.opcion3.TabIndex = 2;
            this.opcion3.Text = "C";
            this.opcion3.UseVisualStyleBackColor = true;
            // 
            // opcion1
            // 
            this.opcion1.AutoSize = true;
            this.opcion1.Location = new System.Drawing.Point(29, 107);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(31, 23);
            this.opcion1.TabIndex = 0;
            this.opcion1.Text = "A";
            this.opcion1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje:";
            // 
            // Puntaje
            // 
            this.Puntaje.Location = new System.Drawing.Point(860, 31);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(100, 20);
            this.Puntaje.TabIndex = 2;
            // 
            // LbCorrectas
            // 
            this.LbCorrectas.Location = new System.Drawing.Point(860, 70);
            this.LbCorrectas.Name = "LbCorrectas";
            this.LbCorrectas.Size = new System.Drawing.Size(100, 20);
            this.LbCorrectas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Respuestas Correctas";
            // 
            // LbIncorrectas
            // 
            this.LbIncorrectas.Location = new System.Drawing.Point(862, 108);
            this.LbIncorrectas.Name = "LbIncorrectas";
            this.LbIncorrectas.Size = new System.Drawing.Size(100, 20);
            this.LbIncorrectas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Respuestas Incorrectas";
            // 
            // Pregunta1
            // 
            this.Pregunta1.AutoSize = true;
            this.Pregunta1.Location = new System.Drawing.Point(29, 56);
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Size = new System.Drawing.Size(0, 19);
            this.Pregunta1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 531);
            this.Controls.Add(this.LbIncorrectas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbCorrectas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton opcion4;
        private System.Windows.Forms.RadioButton opcion3;
        private System.Windows.Forms.RadioButton opcion1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Puntaje;
        private System.Windows.Forms.Button BtnVerficar1;
        private System.Windows.Forms.TextBox LbCorrectas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LbIncorrectas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton opcion2;
        private System.Windows.Forms.Label Pregunta;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label Pregunta1;
    }
}

