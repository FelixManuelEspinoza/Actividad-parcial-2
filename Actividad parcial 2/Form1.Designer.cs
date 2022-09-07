namespace Actividad_parcial_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_DNI = new System.Windows.Forms.TextBox();
            this.TB_FechNac = new System.Windows.Forms.TextBox();
            this.Lbl_edad = new System.Windows.Forms.Label();
            this.btn_Persona = new System.Windows.Forms.Button();
            this.Btn_Edad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "D.N.I : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(75, 33);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(167, 23);
            this.TB_Nombre.TabIndex = 4;
            this.TB_Nombre.TextChanged += new System.EventHandler(this.TB_Nombre_TextChanged);
            // 
            // TB_DNI
            // 
            this.TB_DNI.Location = new System.Drawing.Point(60, 75);
            this.TB_DNI.Name = "TB_DNI";
            this.TB_DNI.Size = new System.Drawing.Size(182, 23);
            this.TB_DNI.TabIndex = 5;
            this.TB_DNI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TB_FechNac
            // 
            this.TB_FechNac.Location = new System.Drawing.Point(144, 114);
            this.TB_FechNac.Name = "TB_FechNac";
            this.TB_FechNac.Size = new System.Drawing.Size(187, 23);
            this.TB_FechNac.TabIndex = 6;
            // 
            // Lbl_edad
            // 
            this.Lbl_edad.AutoSize = true;
            this.Lbl_edad.Location = new System.Drawing.Point(60, 161);
            this.Lbl_edad.Name = "Lbl_edad";
            this.Lbl_edad.Size = new System.Drawing.Size(38, 15);
            this.Lbl_edad.TabIndex = 7;
            this.Lbl_edad.Text = "label5";
            // 
            // btn_Persona
            // 
            this.btn_Persona.Location = new System.Drawing.Point(288, 29);
            this.btn_Persona.Name = "btn_Persona";
            this.btn_Persona.Size = new System.Drawing.Size(91, 64);
            this.btn_Persona.TabIndex = 8;
            this.btn_Persona.Text = "Persona";
            this.btn_Persona.UseVisualStyleBackColor = true;
            this.btn_Persona.Click += new System.EventHandler(this.btn_Persona_Click);
            // 
            // Btn_Edad
            // 
            this.Btn_Edad.Location = new System.Drawing.Point(337, 114);
            this.Btn_Edad.Name = "Btn_Edad";
            this.Btn_Edad.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edad.TabIndex = 9;
            this.Btn_Edad.Text = "Edad";
            this.Btn_Edad.UseVisualStyleBackColor = true;
            this.Btn_Edad.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 191);
            this.Controls.Add(this.Btn_Edad);
            this.Controls.Add(this.btn_Persona);
            this.Controls.Add(this.Lbl_edad);
            this.Controls.Add(this.TB_FechNac);
            this.Controls.Add(this.TB_DNI);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TB_Nombre;
        private TextBox TB_DNI;
        private TextBox TB_FechNac;
        private Label Lbl_edad;
        private Button btn_Persona;
        private Button Btn_Edad;
    }
}