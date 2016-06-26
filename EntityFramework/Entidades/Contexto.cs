using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contexto : DbContext
    {
        private void Log(string log)
        {
            System.Diagnostics.Debug.WriteLine(log);
        }

        public Contexto(): base("name=Capacitacion")
        {
            Database.Log = Log;
        }

        public Contexto(TipoInicializador tipoInicializador) : base("name=Capacitacion")
        {
            Database.Log = Log;

            switch (tipoInicializador)
            {
                case TipoInicializador.CreateDatabaseIfNotExists:
                    Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());
                    break;
                case TipoInicializador.DropCreateDatabaseAlways:
                    Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());
                    break;
                case TipoInicializador.DropCreateDatabaseIfModelChanges:
                    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
                    break;
                case TipoInicializador.NullDatabaseInitializer:
                    Database.SetInitializer(new NullDatabaseInitializer<Contexto>());
                    break;
                default:
                    break;
            }
        }

        public virtual DbSet<Persona> Personas { get; set; }
    }
}
