using System;

namespace Peoples
{
    public class Program
    {
        //TODO : 06 - Refactorizo programa principal, para consumir cualquiera de los repositorios
         static void Main(string[] args)
         {
            ConsoleKeyInfo key;
            while (key.KeyChar != '4')
            {
                MenuManager.WriteMenu();
                key = Console.ReadKey();
                MenuManager.OptionMenu(key);
            }
            Console.Read();
            //TODO : 10 - Utilizo el servicio Manager UI
            //MenuManager.Start();
        }

        

      
    }
}
