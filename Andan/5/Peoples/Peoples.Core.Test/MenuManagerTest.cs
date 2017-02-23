using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Peoples.Core.Test
{
    //TODO : 10 - Genero un test para el MenuManager
    public class MenuManagerTest
    {
        [Fact]
        public void Start_Test()
        {
            MenuManager.Start();
        }
    }
}
