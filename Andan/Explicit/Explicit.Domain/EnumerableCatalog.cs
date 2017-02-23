using System.Collections;
using System.Collections.Generic;

namespace Explicit.Domain
{
    //TODO : 09 - Implementacion explicita de tipo default
    public class EnumerableCatalog : IEnumerable<string>
    {

        public IEnumerator<string> GetEnumerator()
        {
            // all of our code
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}