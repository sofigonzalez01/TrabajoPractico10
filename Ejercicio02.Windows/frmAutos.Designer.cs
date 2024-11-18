namespace Ejercicio02.Windows
{
    partial class frmAutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutos));
            toolStrip1 = new ToolStrip();
            btnAgregar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsBtnFiltrar = new ToolStripDropDownButton();
            tipoDeCombustibleToolStripMenuItem = new ToolStripMenuItem();
            tspiGasolina = new ToolStripMenuItem();
            tspiDiesel = new ToolStripMenuItem();
            tspiGasNatural = new ToolStripMenuItem();
            tspiElectricidad = new ToolStripMenuItem();
            tspiHidrogeno = new ToolStripMenuItem();
            rangoDeAntiguedadToolStripMenuItem = new ToolStripMenuItem();
            btnOrdernar = new ToolStripDropDownButton();
            tspiOrdernarAnoFabricacion = new ToolStripMenuItem();
            tspiOrdernarAnoFabricacionAscendente = new ToolStripMenuItem();
            tspiOrdernarAnoFabricacionDescendente = new ToolStripMenuItem();
            tspiOrdernarMarca = new ToolStripMenuItem();
            tspiOrdernarMarcaAscendente = new ToolStripMenuItem();
            tspiOrdernarMarcaDescendente = new ToolStripMenuItem();
            tspiOrdernarColor = new ToolStripMenuItem();
            tspiOrdernarColorAscendente = new ToolStripMenuItem();
            tspiOrdernarColorDescendente = new ToolStripMenuItem();
            btnActualizar = new ToolStripButton();
            dgvAutos = new DataGridView();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Patente = new DataGridViewTextBoxColumn();
            TipoCombustible = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            AnoFabricacion = new DataGridViewTextBoxColumn();
            AntiguedadAnos = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txtCantidadAutos = new Label();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCerrar = new ToolStripButton();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.AutoSize = false;
            toolStrip1.CanOverflow = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAgregar, btnEliminar, btnEditar, toolStripSeparator1, tsBtnFiltrar, btnOrdernar, btnActualizar, toolStripSeparator2, btnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(587, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            btnAgregar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(53, 22);
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(54, 22);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(41, 22);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsBtnFiltrar
            // 
            tsBtnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsBtnFiltrar.DropDownItems.AddRange(new ToolStripItem[] { tipoDeCombustibleToolStripMenuItem, rangoDeAntiguedadToolStripMenuItem });
            tsBtnFiltrar.Name = "tsBtnFiltrar";
            tsBtnFiltrar.Size = new Size(50, 22);
            tsBtnFiltrar.Text = "Filtrar";
            // 
            // tipoDeCombustibleToolStripMenuItem
            // 
            tipoDeCombustibleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tspiGasolina, tspiDiesel, tspiGasNatural, tspiElectricidad, tspiHidrogeno });
            tipoDeCombustibleToolStripMenuItem.Name = "tipoDeCombustibleToolStripMenuItem";
            tipoDeCombustibleToolStripMenuItem.Size = new Size(189, 22);
            tipoDeCombustibleToolStripMenuItem.Text = "Tipo de Combustible";
            // 
            // tspiGasolina
            // 
            tspiGasolina.Name = "tspiGasolina";
            tspiGasolina.Size = new Size(135, 22);
            tspiGasolina.Text = "Gasolina";
            tspiGasolina.Click += tspiGasolina_Click;
            // 
            // tspiDiesel
            // 
            tspiDiesel.Name = "tspiDiesel";
            tspiDiesel.Size = new Size(135, 22);
            tspiDiesel.Text = "Diesel";
            tspiDiesel.Click += tspiDiesel_Click;
            // 
            // tspiGasNatural
            // 
            tspiGasNatural.Name = "tspiGasNatural";
            tspiGasNatural.Size = new Size(135, 22);
            tspiGasNatural.Text = "Gas Natural";
            tspiGasNatural.Click += tspiGasNatural_Click;
            // 
            // tspiElectricidad
            // 
            tspiElectricidad.Name = "tspiElectricidad";
            tspiElectricidad.Size = new Size(135, 22);
            tspiElectricidad.Text = "Electricidad";
            tspiElectricidad.Click += tspiElectricidad_Click;
            // 
            // tspiHidrogeno
            // 
            tspiHidrogeno.Name = "tspiHidrogeno";
            tspiHidrogeno.Size = new Size(135, 22);
            tspiHidrogeno.Text = "Hidrogeno";
            tspiHidrogeno.Click += tspiHidrogeno_Click;
            // 
            // rangoDeAntiguedadToolStripMenuItem
            // 
            rangoDeAntiguedadToolStripMenuItem.Name = "rangoDeAntiguedadToolStripMenuItem";
            rangoDeAntiguedadToolStripMenuItem.Size = new Size(189, 22);
            rangoDeAntiguedadToolStripMenuItem.Text = "Rango de Antiguedad";
            rangoDeAntiguedadToolStripMenuItem.Click += rangoDeAntiguedadToolStripMenuItem_Click;
            // 
            // btnOrdernar
            // 
            btnOrdernar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnOrdernar.DropDownItems.AddRange(new ToolStripItem[] { tspiOrdernarAnoFabricacion, tspiOrdernarMarca, tspiOrdernarColor });
            btnOrdernar.Image = (Image)resources.GetObject("btnOrdernar.Image");
            btnOrdernar.Name = "btnOrdernar";
            btnOrdernar.Size = new Size(67, 22);
            btnOrdernar.Text = "Ordernar";
            // 
            // tspiOrdernarAnoFabricacion
            // 
            tspiOrdernarAnoFabricacion.DropDownItems.AddRange(new ToolStripItem[] { tspiOrdernarAnoFabricacionAscendente, tspiOrdernarAnoFabricacionDescendente });
            tspiOrdernarAnoFabricacion.Name = "tspiOrdernarAnoFabricacion";
            tspiOrdernarAnoFabricacion.Size = new Size(176, 22);
            tspiOrdernarAnoFabricacion.Text = "Año de Fabricacion";
            // 
            // tspiOrdernarAnoFabricacionAscendente
            // 
            tspiOrdernarAnoFabricacionAscendente.Name = "tspiOrdernarAnoFabricacionAscendente";
            tspiOrdernarAnoFabricacionAscendente.Size = new Size(142, 22);
            tspiOrdernarAnoFabricacionAscendente.Text = "Ascendente";
            tspiOrdernarAnoFabricacionAscendente.Click += tspiOrdernarAnoFabricacionAscendente_Click;
            // 
            // tspiOrdernarAnoFabricacionDescendente
            // 
            tspiOrdernarAnoFabricacionDescendente.Name = "tspiOrdernarAnoFabricacionDescendente";
            tspiOrdernarAnoFabricacionDescendente.Size = new Size(142, 22);
            tspiOrdernarAnoFabricacionDescendente.Text = "Descendente";
            tspiOrdernarAnoFabricacionDescendente.Click += tspiOrdernarAnoFabricacionDescendente_Click;
            // 
            // tspiOrdernarMarca
            // 
            tspiOrdernarMarca.DropDownItems.AddRange(new ToolStripItem[] { tspiOrdernarMarcaAscendente, tspiOrdernarMarcaDescendente });
            tspiOrdernarMarca.Name = "tspiOrdernarMarca";
            tspiOrdernarMarca.Size = new Size(176, 22);
            tspiOrdernarMarca.Text = "Marca";
            // 
            // tspiOrdernarMarcaAscendente
            // 
            tspiOrdernarMarcaAscendente.Name = "tspiOrdernarMarcaAscendente";
            tspiOrdernarMarcaAscendente.Size = new Size(142, 22);
            tspiOrdernarMarcaAscendente.Text = "Ascendente";
            // 
            // tspiOrdernarMarcaDescendente
            // 
            tspiOrdernarMarcaDescendente.Name = "tspiOrdernarMarcaDescendente";
            tspiOrdernarMarcaDescendente.Size = new Size(142, 22);
            tspiOrdernarMarcaDescendente.Text = "Descendente";
            // 
            // tspiOrdernarColor
            // 
            tspiOrdernarColor.DropDownItems.AddRange(new ToolStripItem[] { tspiOrdernarColorAscendente, tspiOrdernarColorDescendente });
            tspiOrdernarColor.Name = "tspiOrdernarColor";
            tspiOrdernarColor.Size = new Size(176, 22);
            tspiOrdernarColor.Text = "Color";
            // 
            // tspiOrdernarColorAscendente
            // 
            tspiOrdernarColorAscendente.Name = "tspiOrdernarColorAscendente";
            tspiOrdernarColorAscendente.Size = new Size(142, 22);
            tspiOrdernarColorAscendente.Text = "Ascendente";
            // 
            // tspiOrdernarColorDescendente
            // 
            tspiOrdernarColorDescendente.Name = "tspiOrdernarColorDescendente";
            tspiOrdernarColorDescendente.Size = new Size(142, 22);
            tspiOrdernarColorDescendente.Text = "Descendente";
            // 
            // btnActualizar
            // 
            btnActualizar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(63, 22);
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvAutos
            // 
            dgvAutos.AllowUserToAddRows = false;
            dgvAutos.AllowUserToDeleteRows = false;
            dgvAutos.BorderStyle = BorderStyle.None;
            dgvAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutos.Columns.AddRange(new DataGridViewColumn[] { Marca, Modelo, Patente, TipoCombustible, Color, AnoFabricacion, AntiguedadAnos });
            dgvAutos.Dock = DockStyle.Fill;
            dgvAutos.Location = new Point(0, 25);
            dgvAutos.Name = "dgvAutos";
            dgvAutos.Size = new Size(587, 286);
            dgvAutos.TabIndex = 1;
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Marca.Frozen = true;
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.SortMode = DataGridViewColumnSortMode.NotSortable;
            Marca.Width = 46;
            // 
            // Modelo
            // 
            Modelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Modelo.Frozen = true;
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            Modelo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Modelo.Width = 54;
            // 
            // Patente
            // 
            Patente.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Patente.Frozen = true;
            Patente.HeaderText = "Patente";
            Patente.Name = "Patente";
            Patente.ReadOnly = true;
            Patente.SortMode = DataGridViewColumnSortMode.NotSortable;
            Patente.Width = 53;
            // 
            // TipoCombustible
            // 
            TipoCombustible.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            TipoCombustible.Frozen = true;
            TipoCombustible.HeaderText = "Combustible";
            TipoCombustible.Name = "TipoCombustible";
            TipoCombustible.ReadOnly = true;
            TipoCombustible.SortMode = DataGridViewColumnSortMode.NotSortable;
            TipoCombustible.Width = 81;
            // 
            // Color
            // 
            Color.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Color.Frozen = true;
            Color.HeaderText = "Color";
            Color.Name = "Color";
            Color.ReadOnly = true;
            Color.SortMode = DataGridViewColumnSortMode.NotSortable;
            Color.Width = 42;
            // 
            // AnoFabricacion
            // 
            AnoFabricacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            AnoFabricacion.Frozen = true;
            AnoFabricacion.HeaderText = "Año de Fabricacion";
            AnoFabricacion.Name = "AnoFabricacion";
            AnoFabricacion.ReadOnly = true;
            AnoFabricacion.SortMode = DataGridViewColumnSortMode.NotSortable;
            AnoFabricacion.Width = 104;
            // 
            // AntiguedadAnos
            // 
            AntiguedadAnos.Frozen = true;
            AntiguedadAnos.HeaderText = "Años de Antiguedad";
            AntiguedadAnos.Name = "AntiguedadAnos";
            AntiguedadAnos.ReadOnly = true;
            AntiguedadAnos.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidadAutos);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 280);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 31);
            panel1.TabIndex = 2;
            // 
            // txtCantidadAutos
            // 
            txtCantidadAutos.AutoSize = true;
            txtCantidadAutos.Location = new Point(12, 7);
            txtCantidadAutos.Name = "txtCantidadAutos";
            txtCantidadAutos.Size = new Size(117, 15);
            txtCantidadAutos.TabIndex = 0;
            txtCantidadAutos.Text = "Cantidad de Autos: 0";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnCerrar
            // 
            btnCerrar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(43, 22);
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 311);
            Controls.Add(panel1);
            Controls.Add(dgvAutos);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAutos";
            ShowIcon = false;
            Text = "Lista de Autos";
            Load += frmAutos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAgregar;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnEditar;
        private DataGridView dgvAutos;
        private ToolStripDropDownButton tsBtnFiltrar;
        private ToolStripMenuItem tipoDeCombustibleToolStripMenuItem;
        private ToolStripMenuItem rangoDeAntiguedadToolStripMenuItem;
        private ToolStripMenuItem tspiGasolina;
        private ToolStripMenuItem dieselToolStripMenuItem;
        private ToolStripMenuItem gasNaturalToolStripMenuItem;
        private ToolStripMenuItem electricidadToolStripMenuItem;
        private ToolStripMenuItem hidrigenoToolStripMenuItem;
        private ToolStripButton btnActualizar;
        private ToolStripMenuItem tspiDiesel;
        private ToolStripMenuItem tspiGasNatural;
        private ToolStripMenuItem tspiElectricidad;
        private ToolStripMenuItem tspiHidrogeno;
        private Panel panel1;
        private Label txtCantidadAutos;
        private ToolStripSeparator toolStripSeparator1;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Patente;
        private DataGridViewTextBoxColumn TipoCombustible;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn AnoFabricacion;
        private DataGridViewTextBoxColumn AntiguedadAnos;
        private ToolStripDropDownButton btnOrdernar;
        private ToolStripMenuItem tspiOrdernarAnoFabricacion;
        private ToolStripMenuItem tspiOrdernarMarca;
        private ToolStripMenuItem tspiOrdernarColor;
        private ToolStripMenuItem tspiOrdernarAnoFabricacionAscendente;
        private ToolStripMenuItem tspiOrdernarAnoFabricacionDescendente;
        private ToolStripMenuItem tspiOrdernarMarcaAscendente;
        private ToolStripMenuItem tspiOrdernarMarcaDescendente;
        private ToolStripMenuItem tspiOrdernarColorAscendente;
        private ToolStripMenuItem tspiOrdernarColorDescendente;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnCerrar;
    }
}