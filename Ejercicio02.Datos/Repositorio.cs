using Ejercicio02.Entidades;

namespace Ejercicio02.Datos
{
    public class Repositorio
    {

        private char separadorArchivo = '|';
        private string nombreArchivo = "Autos.txt";
        private string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;

        private List<Auto> lista;
        
        public Repositorio()
        {

            lista = new List<Auto>();
            Cargar();

        }

        public void Agregar(Auto auto)
        {

            lista.Add(auto);

        }

        public void Eliminar(Auto auto)
        {

            lista.Remove(auto);

        }

        public void Editar(Auto autoViejo, Auto autoNuevo)
        {

            if (!Existe(autoViejo)) return;

            var index = lista.FindIndex(a => a == autoViejo);
            lista[index] = autoNuevo; 

        }

        public bool Existe(Auto auto)
        {

            return lista.Any(a => a == auto);

        }

        public int ObtenerCantidad()
        {

            return lista.Count;

        }

        public List<Auto> ObtenerLista()
        {

            return lista;

        }

        public void Guardar()
        {

            var rutaArchivo = Path.Combine(rutaProyecto, nombreArchivo);

            using(var escritor = new StreamWriter(rutaArchivo))
            {

                foreach(var auto in lista)
                {

                    escritor.WriteLine(ConvertirDatos(auto));

                }

            }

        }

        public void Cargar()
        {

            var rutaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            if (!File.Exists(rutaArchivo)) return;

            using (var lector = new StreamReader(rutaArchivo))
            { 

                while(!lector.EndOfStream)
                {

                    Auto autoConvertido = CrearDatos(lector.ReadLine()!);
                    Agregar(autoConvertido);

                }

            }


        }

        private string ConvertirDatos(Auto auto)
        {

           return $"{auto.Marca}|{auto.Modelo}|{auto.AnoFabricacion.ToString()}|{auto.Patente}|{auto.TipoCombustible.GetHashCode()}|{auto.Color}";

        }

        private Auto CrearDatos(string lineaDatos)
        {

            var lineas = lineaDatos.Split(separadorArchivo);
            var auto = new Auto();

            auto.Marca = lineas[0];
            auto.Modelo = lineas[1];
            auto.AnoFabricacion = int.Parse(lineas[2]);
            auto.Patente = lineas[3];
            auto.TipoCombustible = (TiposCombustibles)int.Parse(lineas[4]);
            auto.Color = lineas[5];

            return auto;

        }

        public List<Auto> OrdenarPorAnoFabricacion(bool descendiente)
        {

            if (descendiente)
            {

                return lista.OrderByDescending(a => a.AnoFabricacion).ToList();

            } else
            {

                return lista.OrderBy(a => a.AnoFabricacion).ToList();

            }
        
        }

        public List<Auto> OrdenarPorAntiguedad(bool descendiente)
        {

            if(descendiente)
            {

                return lista.OrderByDescending(a => DateTime.Now.Year - a.AnoFabricacion).ToList();

            } else
            {

                return lista.OrderBy(a => DateTime.Now.Year - a.AnoFabricacion).ToList();


            }

        }

        public List<Auto> OrdenarPorTipoCombustible()
        {

            return lista.OrderBy(a => a.TipoCombustible).ToList();
        
        }

        public List<Auto> FiltrarPorRangoAnoFabricacion(int anoMinimo, int anoMaximo)
        {

            return lista.Where(a => a.AnoFabricacion >= anoMinimo && a.AnoFabricacion <= anoMaximo).ToList();
        
        }

        public List<Auto> FiltarPorTipoCombustible(TiposCombustibles tipo)
        { 

            return lista.FindAll(a => a.TipoCombustible == tipo).ToList();
        
        }

    }
}