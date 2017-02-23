using System;

namespace Explicit.Domain
{
    //TODO : 08 - Cuando usar Implementaicon Explicita
    public class Catalog : ISaveable, IVoidSaveable
    {
        string ISaveable.Save()
        {
            throw new NotImplementedException();
        }

        void IVoidSaveable.Save()
        {
            throw new NotImplementedException();
        }
    }
}