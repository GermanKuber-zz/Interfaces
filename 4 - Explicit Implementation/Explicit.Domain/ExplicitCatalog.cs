namespace Explicit.Domain
{
    //TODO : 06 - Defino una implementacion de manera explicita
    public class ExplicitCatalog : ISaveable, IPersistable
    {
        //public string Save()
        //{
        //    return "Catalog Save";
        //}

        string ISaveable.Save()
        {
            return "ISaveable Save";
        }

        string IPersistable.Save()
        {
            return "IPersistable Save";
        }
    }
}