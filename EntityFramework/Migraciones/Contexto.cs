using System.Data.Entity;

namespace Migraciones
{
    public class Contexto : DbContext
    {
        private void Log(string log)
        {
            System.Diagnostics.Debug.WriteLine(log);
        }

        public Contexto() : base("name=Migraciones")
        {
            Database.Log = Log;
        }

        public virtual DbSet<Persona> Personas { get; set; }
    }
}
