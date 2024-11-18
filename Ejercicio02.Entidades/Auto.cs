namespace Ejercicio02.Entidades
{
    public class Auto
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacion { get; set; }
        public string Patente { get; set; }
        public TiposCombustibles TipoCombustible { get; set; }
        public string Color { get; set; }

        public Auto(string marca, string modelo, int anoFabricacion, string patente, TiposCombustibles tipoCombustible, string color)
        {

            Marca = marca;
            Modelo = modelo;
            AnoFabricacion = anoFabricacion;
            Patente = patente;
            TipoCombustible = tipoCombustible;
            Color = color;

        }

        public Auto() { }

        public int ObtenerAntiguedad()
        {

            var anoActual = DateTime.Now.Year;

            return anoActual - AnoFabricacion;

        }

        public override string ToString()
        {
            return $"{Marca} {Modelo} ({AnoFabricacion})";
        }

    }
}
