using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Entidades.Contexto contexto = new Entidades.Contexto(Entidades.TipoInicializador.CreateDatabaseIfNotExists);
                var datos = contexto.Personas.FirstOrDefault();

                if (datos != null)
                {
                    Console.WriteLine("Nombre {0} {1} - {2}", datos.Nombre,datos.Apellido,datos.FechaNacimiento);
                }
                else
                    Console.WriteLine("No hay datos");

                Console.WriteLine("Proceso ejecutado correctamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
