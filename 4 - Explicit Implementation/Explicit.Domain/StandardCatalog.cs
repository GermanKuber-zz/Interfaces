namespace Explicit.Domain
{
    //TODO : 03 - Defino mi catalogo Standart
    public class StandardCatalog : ISaveable, IPersistable
    //public  class StandardCatalog
    {
        public void Load()
        {
        }

        public string Save()
        {
            return "Catalog Save";
        }
    }
}
