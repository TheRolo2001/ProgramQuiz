namespace Cuestionario
{
    partial class FormCuestionario
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
            this.Opcion1 = new System.Windows.Forms.RadioButton();
            this.Opcion2 = new System.Windows.Forms.RadioButton();
            this.Opcion4 = new System.Windows.Forms.RadioButton();
            this.Opcion3 = new System.Windows.Forms.RadioButton();
            this.Pregunta1 = new System.Windows.Forms.Label();
            this.BtnVerficar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Puntaje = new System.Windows.Forms.TextBox();
            this.LbCorrectas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbIncorrectas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GroupBox.AutoSize = true;
            this.GroupBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.GroupBox.Controls.Add(this.Opcion1);
            this.GroupBox.Controls.Add(this.Opcion2);
            this.GroupBox.Controls.Add(this.Opcion4);
            this.GroupBox.Controls.Add(this.Opcion3);
            this.GroupBox.Controls.Add(this.Pregunta1);
            this.GroupBox.Controls.Add(this.BtnVerficar1);
            this.GroupBox.Font = new System.Drawing.Font("Niagara Engraved", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(36, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GroupBox.Size = new System.Drawing.Size(860, 295);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Cuestionario 1";
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // Opcion1
            // 
            this.Opcion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Opcion1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion1.AutoEllipsis = true;
            this.Opcion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Opcion1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion1.Location = new System.Drawing.Point(12, 100);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Padding = new System.Windows.Forms.Padding(0, 0, 300, 50);
            this.Opcion1.Size = new System.Drawing.Size(410, 79);
            this.Opcion1.TabIndex = 12;
            this.Opcion1.Text = "A";
            this.Opcion1.UseVisualStyleBackColor = false;
            // 
            // Opcion2
            // 
            this.Opcion2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion2.AutoEllipsis = true;
            this.Opcion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Opcion2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Opcion2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion2.Location = new System.Drawing.Point(438, 100);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Padding = new System.Windows.Forms.Padding(300, 0, 0, 50);
            this.Opcion2.Size = new System.Drawing.Size(410, 79);
            this.Opcion2.TabIndex = 11;
            this.Opcion2.Text = "B";
            this.Opcion2.UseVisualStyleBackColor = false;
            // 
            // Opcion4
            // 
            this.Opcion4.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion4.AutoEllipsis = true;
            this.Opcion4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Opcion4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Opcion4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion4.Location = new System.Drawing.Point(438, 195);
            this.Opcion4.Name = "Opcion4";
            this.Opcion4.Padding = new System.Windows.Forms.Padding(300, 0, 0, 50);
            this.Opcion4.Size = new System.Drawing.Size(410, 79);
            this.Opcion4.TabIndex = 10;
            this.Opcion4.Text = "C";
            this.Opcion4.UseVisualStyleBackColor = false;
            // 
            // Opcion3
            // 
            this.Opcion3.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion3.AutoEllipsis = true;
            this.Opcion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Opcion3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion3.Location = new System.Drawing.Point(12, 195);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Padding = new System.Windows.Forms.Padding(0, 0, 300, 50);
            this.Opcion3.Size = new System.Drawing.Size(410, 79);
            this.Opcion3.TabIndex = 9;
            this.Opcion3.Text = "C";
            this.Opcion3.UseVisualStyleBackColor = false;
            // 
            // Pregunta1
            // 
            this.Pregunta1.AutoSize = true;
            this.Pregunta1.Location = new System.Drawing.Point(26, 53);
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Size = new System.Drawing.Size(0, 19);
            this.Pregunta1.TabIndex = 6;
            // 
            // BtnVerficar1
            // 
            this.BtnVerficar1.Location = new System.Drawing.Point(393, 21);
            this.BtnVerficar1.Name = "BtnVerficar1";
            this.BtnVerficar1.Size = new System.Drawing.Size(75, 23);
            this.BtnVerficar1.TabIndex = 4;
            this.BtnVerficar1.Text = "Verficar";
            this.BtnVerficar1.UseVisualStyleBackColor = true;
            this.BtnVerficar1.Click += new System.EventHandler(this.BtnVerficar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(413, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje:";
            // 
            // Puntaje
            // 
            this.Puntaje.Location = new System.Drawing.Point(465, 329);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(100, 20);
            this.Puntaje.TabIndex = 2;
            // 
            // LbCorrectas
            // 
            this.LbCorrectas.Location = new System.Drawing.Point(465, 365);
            this.LbCorrectas.Name = "LbCorrectas";
            this.LbCorrectas.Size = new System.Drawing.Size(100, 20);
            this.LbCorrectas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(348, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Respuestas Correctas";
            // 
            // LbIncorrectas
            // 
            this.LbIncorrectas.Location = new System.Drawing.Point(465, 406);
            this.LbIncorrectas.Name = "LbIncorrectas";
            this.LbIncorrectas.Size = new System.Drawing.Size(100, 20);
            this.LbIncorrectas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(340, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Respuestas Incorrectas";
            // 
            // FormCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(932, 448);
            this.Controls.Add(this.LbIncorrectas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbCorrectas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox);
            this.Name = "FormCuestionario";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Puntaje;
        private System.Windows.Forms.Button BtnVerficar1;
        private System.Windows.Forms.TextBox LbCorrectas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LbIncorrectas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label Pregunta1;
        private System.Windows.Forms.RadioButton Opcion2;
        private System.Windows.Forms.RadioButton Opcion4;
        private System.Windows.Forms.RadioButton Opcion3;
        private System.Windows.Forms.RadioButton Opcion1;
    }
}

