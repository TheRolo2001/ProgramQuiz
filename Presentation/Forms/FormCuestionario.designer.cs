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
            this.GroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox.AutoSize = true;
            this.GroupBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.GroupBox.Controls.Add(this.Opcion1);
            this.GroupBox.Controls.Add(this.Opcion2);
            this.GroupBox.Controls.Add(this.Opcion4);
            this.GroupBox.Controls.Add(this.Opcion3);
            this.GroupBox.Controls.Add(this.Pregunta1);
            this.GroupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(11, 10);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GroupBox.Size = new System.Drawing.Size(1113, 438);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Cuestionario 1";

            // 
            // Opcion1
            // 
            this.Opcion1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Opcion1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion1.AutoEllipsis = true;
            this.Opcion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Opcion1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion1.Location = new System.Drawing.Point(3, 95);
            this.Opcion1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Padding = new System.Windows.Forms.Padding(0, 0, 400, 54);
            this.Opcion1.Size = new System.Drawing.Size(546, 150);
            this.Opcion1.TabIndex = 12;
            this.Opcion1.Text = "A";
            this.Opcion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Opcion1.UseVisualStyleBackColor = false;
            // 
            // Opcion2
            // 
            this.Opcion2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Opcion2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion2.AutoEllipsis = true;
            this.Opcion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Opcion2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Opcion2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion2.Location = new System.Drawing.Point(564, 95);
            this.Opcion2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Opcion2.Name = "Opcion2";
            this.Opcion2.Padding = new System.Windows.Forms.Padding(400, 0, 0, 54);
            this.Opcion2.Size = new System.Drawing.Size(546, 150);
            this.Opcion2.TabIndex = 11;
            this.Opcion2.Text = "B";
            this.Opcion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Opcion2.UseVisualStyleBackColor = false;
            // 
            // Opcion4
            // 
            this.Opcion4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Opcion4.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion4.AutoEllipsis = true;
            this.Opcion4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Opcion4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Opcion4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion4.Location = new System.Drawing.Point(564, 268);
            this.Opcion4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Opcion4.Name = "Opcion4";
            this.Opcion4.Padding = new System.Windows.Forms.Padding(400, 0, 0, 54);
            this.Opcion4.Size = new System.Drawing.Size(546, 150);
            this.Opcion4.TabIndex = 10;
            this.Opcion4.Text = "C";
            this.Opcion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Opcion4.UseVisualStyleBackColor = false;
            // 
            // Opcion3
            // 
            this.Opcion3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Opcion3.Appearance = System.Windows.Forms.Appearance.Button;
            this.Opcion3.AutoEllipsis = true;
            this.Opcion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Opcion3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Opcion3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opcion3.Location = new System.Drawing.Point(3, 268);
            this.Opcion3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Opcion3.Name = "Opcion3";
            this.Opcion3.Padding = new System.Windows.Forms.Padding(0, 0, 400, 54);
            this.Opcion3.Size = new System.Drawing.Size(546, 150);
            this.Opcion3.TabIndex = 9;
            this.Opcion3.Text = "C";
            this.Opcion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Opcion3.UseVisualStyleBackColor = false;
            // 
            // Pregunta1
            // 
            this.Pregunta1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pregunta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(1)))), ((int)(((byte)(226)))));
            this.Pregunta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pregunta1.ForeColor = System.Drawing.Color.Black;
            this.Pregunta1.Location = new System.Drawing.Point(3, 34);
            this.Pregunta1.Name = "Pregunta1";
            this.Pregunta1.Size = new System.Drawing.Size(1107, 40);
            this.Pregunta1.TabIndex = 6;
            this.Pregunta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnVerficar1
            // 
            this.BtnVerficar1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnVerficar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnVerficar1.ForeColor = System.Drawing.Color.Black;
            this.BtnVerficar1.Location = new System.Drawing.Point(0, 602);
            this.BtnVerficar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnVerficar1.Name = "BtnVerficar1";
            this.BtnVerficar1.Size = new System.Drawing.Size(1136, 48);
            this.BtnVerficar1.TabIndex = 4;
            this.BtnVerficar1.Text = "Verficar";
            this.BtnVerficar1.UseVisualStyleBackColor = false;
            this.BtnVerficar1.Click += new System.EventHandler(this.BtnVerficar1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(410, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Puntaje
            // 
            this.Puntaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Puntaje.Location = new System.Drawing.Point(577, 478);
            this.Puntaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(132, 21);
            this.Puntaje.TabIndex = 2;
            this.Puntaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbCorrectas
            // 
            this.LbCorrectas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCorrectas.Location = new System.Drawing.Point(577, 517);
            this.LbCorrectas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LbCorrectas.Name = "LbCorrectas";
            this.LbCorrectas.Size = new System.Drawing.Size(132, 21);
            this.LbCorrectas.TabIndex = 6;
            this.LbCorrectas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(410, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Respuestas Correctas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbIncorrectas
            // 
            this.LbIncorrectas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbIncorrectas.Location = new System.Drawing.Point(577, 557);
            this.LbIncorrectas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LbIncorrectas.Name = "LbIncorrectas";
            this.LbIncorrectas.Size = new System.Drawing.Size(132, 21);
            this.LbIncorrectas.TabIndex = 8;
            this.LbIncorrectas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(410, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Respuestas Incorrectas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1136, 650);
            this.Controls.Add(this.BtnVerficar1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.LbIncorrectas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbCorrectas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCuestionario";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox.ResumeLayout(false);
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

