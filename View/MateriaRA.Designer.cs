namespace ProyectoFinal.View
{
    partial class MateriaRA
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
            btn_Registro = new Button();
            btn_Actualizar = new Button();
            btn_Consulta = new Button();
            SuspendLayout();
            // 
            // btn_Registro
            // 
            btn_Registro.Location = new Point(136, 339);
            btn_Registro.Name = "btn_Registro";
            btn_Registro.Size = new Size(94, 29);
            btn_Registro.TabIndex = 0;
            btn_Registro.Text = "button1";
            btn_Registro.UseVisualStyleBackColor = true;
            btn_Registro.Click += btn_Registro_Click;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(316, 347);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(94, 29);
            btn_Actualizar.TabIndex = 1;
            btn_Actualizar.Text = "btn_Actualizar";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_Consulta
            // 
            btn_Consulta.Location = new Point(557, 358);
            btn_Consulta.Name = "btn_Consulta";
            btn_Consulta.Size = new Size(94, 29);
            btn_Consulta.TabIndex = 2;
            btn_Consulta.Text = "button1";
            btn_Consulta.UseVisualStyleBackColor = true;
            btn_Consulta.Click += btn_Consulta_Click;
            // 
            // MateriaRA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Consulta);
            Controls.Add(btn_Actualizar);
            Controls.Add(btn_Registro);
            Name = "MateriaRA";
            Text = "Materia";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Registro;
        private Button btn_Actualizar;
        private Button btn_Consulta;
    }
}