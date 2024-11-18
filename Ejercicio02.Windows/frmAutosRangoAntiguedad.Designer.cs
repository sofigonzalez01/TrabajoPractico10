namespace Ejercicio02.Windows
{
    partial class frmAutosRangoAntiguedad
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtDesdeAntiguedad = new TextBox();
            txtHastaAntiguedad = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 30);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Hasta";
            // 
            // txtDesdeAntiguedad
            // 
            txtDesdeAntiguedad.Location = new Point(14, 57);
            txtDesdeAntiguedad.Name = "txtDesdeAntiguedad";
            txtDesdeAntiguedad.Size = new Size(100, 23);
            txtDesdeAntiguedad.TabIndex = 2;
            txtDesdeAntiguedad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHastaAntiguedad
            // 
            txtHastaAntiguedad.Location = new Point(120, 57);
            txtHastaAntiguedad.Name = "txtHastaAntiguedad";
            txtHastaAntiguedad.Size = new Size(100, 23);
            txtHastaAntiguedad.TabIndex = 3;
            txtHastaAntiguedad.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(14, 110);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 80);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(120, 110);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 80);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // frmAutosRangoAntiguedad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 202);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtHastaAntiguedad);
            Controls.Add(txtDesdeAntiguedad);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAutosRangoAntiguedad";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Establecer Rango de Antiguedad";
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDesdeAntiguedad;
        private TextBox txtHastaAntiguedad;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errProvider;
    }
}