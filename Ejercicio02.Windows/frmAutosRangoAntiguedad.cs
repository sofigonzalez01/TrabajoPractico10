namespace Ejercicio02.Windows
{
    public partial class frmAutosRangoAntiguedad : Form
    {

        private string valorDesdeAntiguedad;
        private string valorHastaAntiguedad;

        public frmAutosRangoAntiguedad()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (DatosValidos())
            {

                valorDesdeAntiguedad = txtDesdeAntiguedad.Text;
                valorHastaAntiguedad = txtHastaAntiguedad.Text;

                DialogResult = DialogResult.OK;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;

        }

        public string ObtenerRangoAntiguedad()
        {
            return $"{valorDesdeAntiguedad}-{valorHastaAntiguedad}";
        }

        public bool DatosValidos()
        {

            bool valido = true;
            errProvider.Clear();

            if(string.IsNullOrEmpty(txtDesdeAntiguedad.Text))
            {

                errProvider.SetError(txtDesdeAntiguedad, "Ingrese un valor.");
                valido = false;

            } else
            {

                if(!int.TryParse(txtDesdeAntiguedad.Text, out _) || int.Parse(txtDesdeAntiguedad.Text) <= 0) {

                    errProvider.SetError(txtDesdeAntiguedad, "El valor debe ser numerico, o mayor a cero.");
                    valido = false;

                }

            }

            if (string.IsNullOrEmpty(txtHastaAntiguedad.Text))
            {

                errProvider.SetError(txtHastaAntiguedad, "Ingrese un valor.");
                valido = false;

            }
            else
            {

                if (!int.TryParse(txtHastaAntiguedad.Text, out _) || int.Parse(txtHastaAntiguedad.Text) <= 0)
                {

                    errProvider.SetError(txtHastaAntiguedad, "El valor debe ser numerico, o mayor a cero.");
                    valido = false;

                }

            }

            return valido;

        }
    }
}
