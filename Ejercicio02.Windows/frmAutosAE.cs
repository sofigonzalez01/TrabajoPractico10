using Ejercicio02.Entidades;

namespace Ejercicio02.Windows
{
    public partial class frmAutosAE : Form
    {

        private Auto? autoForm;
        public frmAutosAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            listTipoCombustibleAuto.SelectedIndex = 0;

            if (autoForm != null)
            {

                txtMarcaAuto.Text = autoForm.Marca;
                txtModeloAuto.Text = autoForm.Modelo;
                txtAnoFabricacionAuto.Text = autoForm.AnoFabricacion.ToString();
                txtPatenteAuto.Text = autoForm.Patente;
                listTipoCombustibleAuto.SelectedIndex = (int)autoForm.TipoCombustible;
                txtColorAuto.Text = autoForm.Color;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (DatosValidos())
            {

                if (autoForm == null)
                {
                    autoForm = new Auto();
                }

                autoForm.Marca = txtMarcaAuto.Text;
                autoForm.Modelo = txtModeloAuto.Text;
                autoForm.AnoFabricacion = int.Parse(txtAnoFabricacionAuto.Text);
                autoForm.Patente = txtPatenteAuto.Text;
                autoForm.TipoCombustible = (TiposCombustibles)listTipoCombustibleAuto.SelectedIndex;
                autoForm.Color = txtColorAuto.Text;

                DialogResult = DialogResult.OK;

            }

        }

        public Auto? ObtenerAuto()
        {

            return autoForm;

        }

        public void EstablecerAuto(Auto auto)
        {

            autoForm = auto;

        }

        private bool DatosValidos()
        {

            bool valido = true;
            errProvider.Clear();

            if (string.IsNullOrEmpty(txtMarcaAuto.Text))
            {

                errProvider.SetError(txtMarcaAuto, "Ingrese una marca valida.");
                valido = false;

            }

            if (string.IsNullOrEmpty(txtModeloAuto.Text))
            {

                errProvider.SetError(txtModeloAuto, "Ingrese un modelo valido.");
                valido = false;

            }

            if (string.IsNullOrEmpty(txtPatenteAuto.Text))
            {

                errProvider.SetError(txtPatenteAuto, "Ingrese una patente valida.");
                valido = false;

            }

            if (string.IsNullOrEmpty(txtAnoFabricacionAuto.Text) || !int.TryParse(txtAnoFabricacionAuto.Text, out _))
            {

                errProvider.SetError(txtAnoFabricacionAuto, "Ingrese un año de fabricacion valido.");
                valido = false;

            }

            if (string.IsNullOrEmpty(txtColorAuto.Text))
            {

                errProvider.SetError(txtColorAuto, "Ingrese un color valido.");
                valido = false;

            }

            return valido;

        }

    }
}