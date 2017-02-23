using System;
using Explicit.Domain;

class Program
{
    static void Main(string[] args)
    {
        //TODO : 04 - Imprimo el mensaje de Save
        StandardCatalog standardCatalog = new StandardCatalog();
        //TODO : 05 - Imprimo el mensaje de Save de mis 2 implementaciones
        //ISaveable saveable = new StandardCatalog();
        //IPersistable persistable = new StandardCatalog();

        Console.WriteLine("Standard Implementation\n");
        Console.WriteLine("Concrete Class:  {0}", standardCatalog.Save());
        //Console.WriteLine("ISaveable:       {0}", saveable.Save());
        //Console.WriteLine("IPersistable:    {0}", persistable.Save());
        Console.WriteLine();

        //Console.WriteLine("Concrete Class:        {0}", standardCatalog.Save());
        //Console.WriteLine("(ISaveable)Catalog:    {0}", ((ISaveable)standardCatalog).Save());
        //Console.WriteLine("(IPersistable)Catalog: {0}", ((IPersistable)standardCatalog).Save());
        //Console.WriteLine();

        //Console.WriteLine("================================================");
        //TODO : 07 - Imprimo la implementacion explicita
        //ExplicitCatalog explicitCatalog = new ExplicitCatalog();
        //saveable = new ExplicitCatalog();
        //persistable = new ExplicitCatalog();

        //Console.WriteLine("Explicit Implementation\n");
        ////Console.WriteLine("Concrete Class:  {0}", explicitCatalog.Save());
        //Console.WriteLine("ISaveable:       {0}", saveable.Save());
        //Console.WriteLine("IPersistable:    {0}", persistable.Save());
        //Console.WriteLine();

        ////Console.WriteLine("Concrete Class:        {0}", explicitCatalog.Save());
        //Console.WriteLine("(ISaveable)Catalog:    {0}", ((ISaveable)explicitCatalog).Save());
        //Console.WriteLine("(IPersistable)Catalog: {0}", ((IPersistable)explicitCatalog).Save());
        //Console.WriteLine();

        Console.ReadLine();
    }
}