namespace ValidadorDeRut
{
    partial class Form1
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
            this.rut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validaRut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rut
            // 
            this.rut.Location = new System.Drawing.Point(82, 36);
            this.rut.MaxLength = 11;
            this.rut.Name = "rut";
            this.rut.ShortcutsEnabled = false;
            this.rut.Size = new System.Drawing.Size(228, 20);
            this.rut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RUT  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese RUT con sin puntos y con guion ";
            // 
            // validaRut
            // 
            this.validaRut.Location = new System.Drawing.Point(82, 237);
            this.validaRut.Name = "validaRut";
            this.validaRut.Size = new System.Drawing.Size(215, 23);
            this.validaRut.TabIndex = 3;
            this.validaRut.Text = "Validar";
            this.validaRut.UseVisualStyleBackColor = true;
            this.validaRut.UseWaitCursor = true;
            this.validaRut.Click += new System.EventHandler(this.validaRut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 344);
            this.Controls.Add(this.validaRut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rut);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Valida Rut ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validaRut;
    }
}

