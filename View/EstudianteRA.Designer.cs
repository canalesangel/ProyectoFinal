namespace ProyectoFinal.View
{
    partial class EstudianteRA
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
            btn_RegistrarEstudiante = new Button();
            btn_ActualizarEstudiante = new Button();
            btn_ConsultarEstudiantes = new Button();
            txt_Matricula = new TextBox();
            txt_Nombre = new TextBox();
            txt_ApellidoP = new TextBox();
            txt_Correo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_ApellidoM = new TextBox();
            label7 = new Label();
            txt_Telefono = new TextBox();
            label8 = new Label();
            txt_Carrera = new TextBox();
            label9 = new Label();
            txt_Semestre = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txt_Estado = new ListBox();
            label12 = new Label();
            dtp_FechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // btn_RegistrarEstudiante
            // 
            btn_RegistrarEstudiante.Location = new Point(199, 518);
            btn_RegistrarEstudiante.Name = "btn_RegistrarEstudiante";
            btn_RegistrarEstudiante.Size = new Size(94, 29);
            btn_RegistrarEstudiante.TabIndex = 0;
            btn_RegistrarEstudiante.Text = "Registrar";
            btn_RegistrarEstudiante.UseVisualStyleBackColor = true;
            btn_RegistrarEstudiante.Click += btn_RegistrarEstudiante_Click;
            // 
            // btn_ActualizarEstudiante
            // 
            btn_ActualizarEstudiante.Location = new Point(367, 518);
            btn_ActualizarEstudiante.Name = "btn_ActualizarEstudiante";
            btn_ActualizarEstudiante.Size = new Size(94, 29);
            btn_ActualizarEstudiante.TabIndex = 1;
            btn_ActualizarEstudiante.Text = "Actualizar";
            btn_ActualizarEstudiante.UseVisualStyleBackColor = true;
            btn_ActualizarEstudiante.Click += btn_ActualizarEstudiante_Click;
            // 
            // btn_ConsultarEstudiantes
            // 
            btn_ConsultarEstudiantes.Location = new Point(533, 518);
            btn_ConsultarEstudiantes.Name = "btn_ConsultarEstudiantes";
            btn_ConsultarEstudiantes.Size = new Size(94, 29);
            btn_ConsultarEstudiantes.TabIndex = 2;
            btn_ConsultarEstudiantes.Text = "Consulta";
            btn_ConsultarEstudiantes.UseVisualStyleBackColor = true;
            btn_ConsultarEstudiantes.Click += btn_ConsultarEstudiantes_Click;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Location = new Point(325, 39);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(230, 27);
            txt_Matricula.TabIndex = 3;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(325, 78);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(230, 27);
            txt_Nombre.TabIndex = 4;
            // 
            // txt_ApellidoP
            // 
            txt_ApellidoP.Location = new Point(325, 118);
            txt_ApellidoP.Name = "txt_ApellidoP";
            txt_ApellidoP.Size = new Size(230, 27);
            txt_ApellidoP.TabIndex = 5;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(325, 204);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(230, 27);
            txt_Correo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 39);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 8;
            label1.Text = "Matricula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 85);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 118);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 10;
            label3.Text = "Apellido Paterno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 441);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 11;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 207);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 12;
            label5.Text = "Correo Electronico:";
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 23;
            // 
            // txt_ApellidoM
            // 
            txt_ApellidoM.Location = new Point(325, 161);
            txt_ApellidoM.Name = "txt_ApellidoM";
            txt_ApellidoM.Size = new Size(230, 27);
            txt_ApellidoM.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 246);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 16;
            label7.Text = "Telefono:";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(322, 246);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(230, 27);
            txt_Telefono.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 290);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 18;
            label8.Text = "Carrera:";
            // 
            // txt_Carrera
            // 
            txt_Carrera.Location = new Point(322, 290);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(230, 27);
            txt_Carrera.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 335);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 20;
            label9.Text = "Semestre:";
            // 
            // txt_Semestre
            // 
            txt_Semestre.Location = new Point(322, 335);
            txt_Semestre.Name = "txt_Semestre";
            txt_Semestre.Size = new Size(230, 27);
            txt_Semestre.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(259, 383);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 22;
            label10.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(186, 164);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 24;
            label11.Text = "Apellido Materno:";
            // 
            // txt_Estado
            // 
            txt_Estado.FormattingEnabled = true;
            txt_Estado.Items.AddRange(new object[] { "Activo", "Baja", "Suspendido" });
            txt_Estado.Location = new Point(325, 383);
            txt_Estado.Name = "txt_Estado";
            txt_Estado.Size = new Size(221, 24);
            txt_Estado.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(356, 471);
            label12.Name = "label12";
            label12.Size = new Size(160, 20);
            label12.TabIndex = 27;
            label12.Text = "Formato: dd-mm-aaaa";
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.Location = new Point(325, 436);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(250, 27);
            dtp_FechaNacimiento.TabIndex = 28;
            // 
            // EstudianteRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 589);
            Controls.Add(dtp_FechaNacimiento);
            Controls.Add(label12);
            Controls.Add(txt_Estado);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_Semestre);
            Controls.Add(label8);
            Controls.Add(txt_Carrera);
            Controls.Add(label7);
            Controls.Add(txt_Telefono);
            Controls.Add(label6);
            Controls.Add(txt_ApellidoM);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Correo);
            Controls.Add(txt_ApellidoP);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Matricula);
            Controls.Add(btn_ConsultarEstudiantes);
            Controls.Add(btn_ActualizarEstudiante);
            Controls.Add(btn_RegistrarEstudiante);
            Name = "EstudianteRA";
            Text = "VEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_RegistrarEstudiante;
        private Button btn_ActualizarEstudiante;
        private Button btn_ConsultarEstudiantes;
        private TextBox txt_Matricula;
        private TextBox txt_Nombre;
        private TextBox txt_ApellidoP;
        private TextBox txt_Correo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_ApellidoM;
        private Label label7;
        private TextBox txt_Telefono;
        private Label label8;
        private TextBox txt_Carrera;
        private Label label9;
        private TextBox txt_Semestre;
        private Label label10;
        private Label label11;
        private ListBox txt_Estado;
        private Label label12;
        private DateTimePicker dtp_FechaNacimiento;
    }
}