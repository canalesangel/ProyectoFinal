
namespace ProyectoFinal
{
    partial class Login
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
            label1 = new Label();
            txt_Password = new TextBox();
            txt_Usuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_Ingreso = new Button();
            SuspendLayout();
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
            // txt_Password
            // 
            txt_Password.Location = new Point(313, 238);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(125, 27);
            txt_Password.TabIndex = 5;
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(313, 196);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(125, 27);
            txt_Usuario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 199);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 7;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 241);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Contraseña";
            // 
            // btn_Ingreso
            // 
            btn_Ingreso.Location = new Point(344, 316);
            btn_Ingreso.Name = "btn_Ingreso";
            btn_Ingreso.Size = new Size(94, 29);
            btn_Ingreso.TabIndex = 9;
            btn_Ingreso.Text = "Ingresa";
            btn_Ingreso.UseVisualStyleBackColor = true;
            btn_Ingreso.Click += btn_Ingreso_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Ingreso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_Usuario);
            Controls.Add(txt_Password);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private TextBox txt_Password;
        private TextBox txt_Usuario;
        private Label label3;
        private Label label4;
        private Button btn_Ingreso;
    }
}
