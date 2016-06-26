namespace Entidades
{
    public enum TipoInicializador
    {
        CreateDatabaseIfNotExists,

        DropCreateDatabaseAlways,

        DropCreateDatabaseIfModelChanges,

        NullDatabaseInitializer
    }
}