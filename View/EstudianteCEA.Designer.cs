namespace ProyectoFinal.View
{
    partial class EstudianteCEA
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
            dataGridView1 = new DataGridView();
            btn_ActualizarEstudiante = new Button();
            btn_EliminarEstudiante = new Button();
            txt_Actualizar = new TextBox();
            txt_Eliminar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_RegistrarEstudiante = new Button();
            label3 = new Label();
            btn_ActualizarTablaEstudiantes = new Button();
            btn_Menu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1178, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btn_ActualizarEstudiante
            // 
            btn_ActualizarEstudiante.Location = new Point(554, 70);
            btn_ActualizarEstudiante.Name = "btn_ActualizarEstudiante";
            btn_ActualizarEstudiante.Size = new Size(94, 29);
            btn_ActualizarEstudiante.TabIndex = 1;
            btn_ActualizarEstudiante.Text = "Actualizar";
            btn_ActualizarEstudiante.UseVisualStyleBackColor = true;
            btn_ActualizarEstudiante.Click += btn_ActualizarEstudiante_Click;
            // 
            // btn_EliminarEstudiante
            // 
            btn_EliminarEstudiante.Location = new Point(554, 135);
            btn_EliminarEstudiante.Name = "btn_EliminarEstudiante";
            btn_EliminarEstudiante.Size = new Size(94, 29);
            btn_EliminarEstudiante.TabIndex = 2;
            btn_EliminarEstudiante.Text = "Eliminar";
            btn_EliminarEstudiante.UseVisualStyleBackColor = true;
            btn_EliminarEstudiante.Click += btn_EliminarEstudiante_Click;
            // 
            // txt_Actualizar
            // 
            txt_Actualizar.Location = new Point(367, 70);
            txt_Actualizar.Name = "txt_Actualizar";
            txt_Actualizar.Size = new Size(125, 27);
            txt_Actualizar.TabIndex = 3;
            // 
            // txt_Eliminar
            // 
            txt_Eliminar.Location = new Point(367, 135);
            txt_Eliminar.Name = "txt_Eliminar";
            txt_Eliminar.Size = new Size(125, 27);
            txt_Eliminar.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 74);
            label1.Name = "label1";
            label1.Size = new Size(270, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingresa Matricula para Actualizar Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 138);
            label2.Name = "label2";
            label2.Size = new Size(270, 20);
            label2.TabIndex = 6;
            label2.Text = "ingresa Matricula para eliminar registro";
            // 
            // btn_RegistrarEstudiante
            // 
            btn_RegistrarEstudiante.Location = new Point(570, 469);
            btn_RegistrarEstudiante.Name = "btn_RegistrarEstudiante";
            btn_RegistrarEstudiante.Size = new Size(105, 29);
            btn_RegistrarEstudiante.TabIndex = 7;
            btn_RegistrarEstudiante.Text = "Registrar";
            btn_RegistrarEstudiante.UseVisualStyleBackColor = true;
            btn_RegistrarEstudiante.Click += btn_RegistrarEstudiante_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 473);
            label3.Name = "label3";
            label3.Size = new Size(183, 20);
            label3.TabIndex = 8;
            label3.Text = "Agregar nuevo estudiante:";
            // 
            // btn_ActualizarTablaEstudiantes
            // 
            btn_ActualizarTablaEstudiantes.Location = new Point(1073, 138);
            btn_ActualizarTablaEstudiantes.Name = "btn_ActualizarTablaEstudiantes";
            btn_ActualizarTablaEstudiantes.Size = new Size(101, 58);
            btn_ActualizarTablaEstudiantes.TabIndex = 10;
            btn_ActualizarTablaEstudiantes.Text = "Actualizar Tabla";
            btn_ActualizarTablaEstudiantes.UseVisualStyleBackColor = true;
            btn_ActualizarTablaEstudiantes.Click += btn_ActualizarTablaEstudiantes_Click;
            // 
            // btn_Menu
            // 
            btn_Menu.Location = new Point(1073, 442);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(101, 56);
            btn_Menu.TabIndex = 11;
            btn_Menu.Text = "Regresar Menu";
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // EstudianteCEA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 548);
            Controls.Add(btn_Menu);
            Controls.Add(btn_ActualizarTablaEstudiantes);
            Controls.Add(label3);
            Controls.Add(btn_RegistrarEstudiante);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Eliminar);
            Controls.Add(txt_Actualizar);
            Controls.Add(btn_EliminarEstudiante);
            Controls.Add(btn_ActualizarEstudiante);
            Controls.Add(dataGridView1);
            Name = "EstudianteCEA";
            Text = "EstudianteCEA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_ActualizarEstudiante;
        private Button btn_EliminarEstudiante;
        private TextBox txt_Actualizar;
        private TextBox txt_Eliminar;
        private Label label1;
        private Label label2;
        private Button btn_RegistrarEstudiante;
        private Label label3;
       // private Button btn_RegresarMenu;
        private Button btn_ActualizarTablaEstudiantes;
        private Button btn_Menu;
    }
}