using Ejercicio02.Datos;
using Ejercicio02.Entidades;

namespace Ejercicio02.Windows
{
    public partial class frmAutos : Form
    {

        private Repositorio repositorio;
        private List<Auto>? tempLista;

        public frmAutos()
        {
            InitializeComponent();
            repositorio = new Repositorio();
            //DatosPrueba();
        }

        private void frmAutos_Load(object sender, EventArgs e)
        {

            tempLista = repositorio.ObtenerLista();
            MostrarLista();

        }

        private void DatosPrueba()
        {

            repositorio.Agregar(new Auto("Toyota", "Corolla", 2020, "ABC123", TiposCombustibles.Gasolina, "Rojo"));
            repositorio.Agregar(new Auto("Ford", "Fiesta", 2015, "XYZ789", TiposCombustibles.Diesel, "Azul"));
            repositorio.Agregar(new Auto("Tesla", "Model S", 2022, "TES999", TiposCombustibles.Electricidad, "Negro"));
            repositorio.Agregar(new Auto("Chevrolet", "Cruze", 2018, "CHE456", TiposCombustibles.GasNatural, "Blanco"));
            repositorio.Agregar(new Auto("Volkswagen", "Golf", 2019, "VW678", TiposCombustibles.Diesel, "Gris"));

        }

        private void MostrarLista()
        {

            if (tempLista is null || repositorio.ObtenerCantidad() == 0)
            {

                MessageBox.Show("No hay autos ingresados.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            dgvAutos.Rows.Clear();

            foreach (var auto in tempLista)
            {
                var row = CrearFila(dgvAutos);
                EstablecerLinea(row, auto);
                AgregarLinea(row);
            }

            txtCantidadAutos.Text = $"Cantidad de Autos: {tempLista.Count.ToString()}";

        }

        private DataGridViewRow CrearFila(DataGridView dvg)
        {

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dvg);

            return fila;

        }

        private void EstablecerLinea(DataGridViewRow row, Auto auto)
        {

            row.Cells[Marca.Index].Value = auto.Marca;
            row.Cells[Modelo.Index].Value = auto.Modelo;
            row.Cells[Patente.Index].Value = auto.Patente;
            row.Cells[AnoFabricacion.Index].Value = auto.AnoFabricacion;

            if (auto.TipoCombustible == TiposCombustibles.GasNatural)
            {
                row.Cells[TipoCombustible.Index].Value = "Gas Natural";
            }
            else
            {
                row.Cells[TipoCombustible.Index].Value = auto.TipoCombustible;
            }

            row.Cells[Color.Index].Value = auto.Color;

            string cantidadAnos;
            int antiguedadAuto = auto.ObtenerAntiguedad();

            if (antiguedadAuto == 1)
            {
                cantidadAnos = "1 año";
            }
            else
            {
                cantidadAnos = antiguedadAuto + " años";
            }

            if (antiguedadAuto < 1)
            {
                cantidadAnos = "menos de 1 año";
            }

            row.Cells[AntiguedadAnos.Index].Value = cantidadAnos;

            row.Tag = auto;

        }

        private void AgregarLinea(DataGridViewRow row)
        {

            dgvAutos.Rows.Add(row);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmAutosAE frm = new frmAutosAE();
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) return;

            Auto? autoAgregado = frm.ObtenerAuto();

            if (!repositorio.Existe(autoAgregado))
            {

                repositorio.Agregar(autoAgregado);
                MostrarLista();

                MessageBox.Show("Auto agregado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvAutos.SelectedCells.Count == 0) return;

            var rBorrar = dgvAutos.Rows[dgvAutos.SelectedCells[0].RowIndex];
            var aBorrar = rBorrar.Tag as Auto;

            var msg = $"¿Estas seguro de eliminar el '{aBorrar.ToString()}'?\nEsta accion es irreversible.";

            DialogResult dr = MessageBox.Show(msg, "Eliminar Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            repositorio.Eliminar(aBorrar);
            MostrarLista();

            MessageBox.Show("Auto eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvAutos.SelectedCells.Count == 0) return;

            var rEditar = dgvAutos.Rows[dgvAutos.SelectedCells[0].RowIndex];
            var aEditar = rEditar.Tag as Auto;

            frmAutosAE frm = new frmAutosAE() { Text = "Editar un Auto" };
            frm.EstablecerAuto(aEditar);
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) return;

            var nAEditar = frm.ObtenerAuto();

            repositorio.Editar(aEditar, nAEditar);
            MostrarLista();

            MessageBox.Show("Auto editado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.ObtenerLista();
            MostrarLista();

        }

        private void tspiGasolina_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.FiltarPorTipoCombustible(TiposCombustibles.Gasolina);
            MostrarLista();

        }

        private void tspiDiesel_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.FiltarPorTipoCombustible(TiposCombustibles.Diesel);
            MostrarLista();

        }

        private void tspiGasNatural_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.FiltarPorTipoCombustible(TiposCombustibles.GasNatural);
            MostrarLista();

        }

        private void tspiElectricidad_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.FiltarPorTipoCombustible(TiposCombustibles.Electricidad);
            MostrarLista();

        }

        private void tspiHidrogeno_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.FiltarPorTipoCombustible(TiposCombustibles.Hidrogeno);
            MostrarLista();

        }

        private void rangoDeAntiguedadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAutosRangoAntiguedad frm = new frmAutosRangoAntiguedad();
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) return;

            string[] valoresRango = frm.ObtenerRangoAntiguedad().Split('-');

            tempLista = repositorio.FiltrarPorRangoAnoFabricacion(int.Parse(valoresRango[0]), int.Parse(valoresRango[1]));
            MostrarLista();


        }

        private void tspiOrdernarAnoFabricacionAscendente_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.OrdenarPorAnoFabricacion(true);
            MostrarLista();

        }

        private void tspiOrdernarAnoFabricacionDescendente_Click(object sender, EventArgs e)
        {

            tempLista = repositorio.OrdenarPorAnoFabricacion(false);
            MostrarLista();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            repositorio.Guardar();
            Application.Exit();

        }
    }
}
