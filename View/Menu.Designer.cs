namespace ProyectoFinal
{
    partial class Form1
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
            btn_Estudiantes = new Button();
            btn_Asistencia = new Button();
            btn_Materias = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_Estudiantes
            // 
            btn_Estudiantes.Location = new Point(112, 255);
            btn_Estudiantes.Name = "btn_Estudiantes";
            btn_Estudiantes.Size = new Size(94, 29);
            btn_Estudiantes.TabIndex = 0;
            btn_Estudiantes.Text = "Estudiantes";
            btn_Estudiantes.UseVisualStyleBackColor = true;
            btn_Estudiantes.Click += btn_Estudiantes_Click;
            // 
            // btn_Asistencia
            // 
            btn_Asistencia.Location = new Point(335, 255);
            btn_Asistencia.Name = "btn_Asistencia";
            btn_Asistencia.Size = new Size(94, 29);
            btn_Asistencia.TabIndex = 1;
            btn_Asistencia.Text = "Asistencia";
            btn_Asistencia.UseVisualStyleBackColor = true;
            // 
            // btn_Materias
            // 
            btn_Materias.Location = new Point(552, 255);
            btn_Materias.Name = "btn_Materias";
            btn_Materias.Size = new Size(94, 29);
            btn_Materias.TabIndex = 2;
            btn_Materias.Text = "Materias";
            btn_Materias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 95);
            label1.Name = "label1";
            label1.Size = new Size(154, 38);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 162);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 4;
            label2.Text = "Selecciona una Opción";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Materias);
            Controls.Add(btn_Asistencia);
            Controls.Add(btn_Estudiantes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Estudiantes;
        private Button btn_Asistencia;
        private Button btn_Materias;
        private Label label1;
        private Label label2;
    }
}
