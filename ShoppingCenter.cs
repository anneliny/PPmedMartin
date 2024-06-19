/*﻿

DONT LOOK THIS IS UGLY DUCKLING

namespace PPmedMartin
{
    internal class ShoppingCenter
    {
        public List<Stores> StoresInCenter { get; private set; }
        public ShoppingCenter()
        {

            Main();
        }

        public void Main()
        {
            while (true)
            {
                Console.WriteLine("Nå skal det shoppes! Hva vil du gjøre?");
                Console.WriteLine("1. Se alle butikker"); //Velge å sortere etter pris
                Console.WriteLine("2. Legg til butikk");
                Console.WriteLine("3. Avslutt");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var store = new Stores();
                        store.ShowStores();
                        break;
                    case "2":
                        var addStores = new Stores();
                        addStores.AddStore();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
*/




