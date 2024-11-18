namespace Ejercicio02.Windows
{
    partial class frmAutosAE
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
            txtMarcaAuto = new TextBox();
            txtModeloAuto = new TextBox();
            txtAnoFabricacionAuto = new TextBox();
            listTipoCombustibleAuto = new ComboBox();
            txtPatenteAuto = new TextBox();
            txtColorAuto = new TextBox();
            errProvider = new ErrorProvider(components);
            btnAgregar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // txtMarcaAuto
            // 
            txtMarcaAuto.Location = new Point(62, 37);
            txtMarcaAuto.Name = "txtMarcaAuto";
            txtMarcaAuto.PlaceholderText = "Marca";
            txtMarcaAuto.Size = new Size(110, 23);
            txtMarcaAuto.TabIndex = 0;
            // 
            // txtModeloAuto
            // 
            txtModeloAuto.Location = new Point(62, 66);
            txtModeloAuto.Name = "txtModeloAuto";
            txtModeloAuto.PlaceholderText = "Modelo";
            txtModeloAuto.Size = new Size(110, 23);
            txtModeloAuto.TabIndex = 1;
            // 
            // txtAnoFabricacionAuto
            // 
            txtAnoFabricacionAuto.Location = new Point(62, 95);
            txtAnoFabricacionAuto.MaxLength = 4;
            txtAnoFabricacionAuto.Name = "txtAnoFabricacionAuto";
            txtAnoFabricacionAuto.PlaceholderText = "Año de fabricacion";
            txtAnoFabricacionAuto.Size = new Size(110, 23);
            txtAnoFabricacionAuto.TabIndex = 2;
            // 
            // listTipoCombustibleAuto
            // 
            listTipoCombustibleAuto.DropDownStyle = ComboBoxStyle.DropDownList;
            listTipoCombustibleAuto.FormattingEnabled = true;
            listTipoCombustibleAuto.Items.AddRange(new object[] { "Gasolina", "Diesel", "Gas Natural", "Electricidad", "Hidrogeno" });
            listTipoCombustibleAuto.Location = new Point(62, 153);
            listTipoCombustibleAuto.Name = "listTipoCombustibleAuto";
            listTipoCombustibleAuto.Size = new Size(110, 23);
            listTipoCombustibleAuto.TabIndex = 3;
            // 
            // txtPatenteAuto
            // 
            txtPatenteAuto.Location = new Point(62, 124);
            txtPatenteAuto.MaxLength = 8;
            txtPatenteAuto.Name = "txtPatenteAuto";
            txtPatenteAuto.PlaceholderText = "Patente";
            txtPatenteAuto.Size = new Size(110, 23);
            txtPatenteAuto.TabIndex = 4;
            // 
            // txtColorAuto
            // 
            txtColorAuto.Location = new Point(62, 182);
            txtColorAuto.Name = "txtColorAuto";
            txtColorAuto.PlaceholderText = "Color";
            txtColorAuto.Size = new Size(110, 23);
            txtColorAuto.TabIndex = 5;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 229);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 55);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Aceptar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(121, 229);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAutosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 296);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtColorAuto);
            Controls.Add(txtPatenteAuto);
            Controls.Add(listTipoCombustibleAuto);
            Controls.Add(txtAnoFabricacionAuto);
            Controls.Add(txtModeloAuto);
            Controls.Add(txtMarcaAuto);
            Name = "frmAutosAE";
            Text = "Agregar un Auto";
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarcaAuto;
        private TextBox txtModeloAuto;
        private TextBox txtAnoFabricacionAuto;
        private ComboBox listTipoCombustibleAuto;
        private TextBox txtPatenteAuto;
        private TextBox txtColorAuto;
        private ErrorProvider errProvider;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}