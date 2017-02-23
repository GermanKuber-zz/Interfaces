using System;

namespace Peoples
{
    public class Program
    {
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
            //MenuManager.Start();
        }

        

      
    }
}
