
namespace PPmedMartin
{
    internal class Stores
    {
        public string Name { get; private set; }
        public string Speciality { get; private set; }
        public int PriceRange { get; private set; }

        public static int storeCount = 0;

        public List<Stores> StoresInCenter { get; private set; }

        public Stores(string name, string speciality, int priceRange)
        {
            Name = name;
            Speciality = speciality;
            PriceRange = priceRange;
            storeCount++;
        }
        public Stores()
        {
            StoresInCenter = new List<Stores>()
            {
                new Stores("Hm", "Klær", 2),
                new Stores("Panduro", "Hobby", 2),
                new Stores("Bruktbutikk", "Diverse", 1),
                new Stores("Chanel", "Sminke", 3),
                new Stores("Normal", "Diverse", 1),
                new Stores("Bolia", "Interiør", 3),

            };

            Main();

            Console.WriteLine(Stores.storeCount);

        }

        public void Main()
        {
            while (true)
            {
                Console.WriteLine("Nå skal det shoppes! Hva vil du gjøre?");
                Console.WriteLine("1. Legg til butikk"); //Velge å sortere etter pris
                Console.WriteLine("2. Se butikkene");
                Console.WriteLine("3. Tell butikkene");
                Console.WriteLine("4. Avslutt");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //var addStores = new Stores();
                        AddStore();
                        //addStores.ShowStores1();
                        break;
                    case "2":
                        //var store = new Stores();
                        ShowStores();
                        break;
                    case "3":
                        Console.WriteLine(Stores.storeCount);
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }


        public void ShowStores()
        {
            foreach (Stores shops in StoresInCenter)
            {
                Console.WriteLine($"Navn: {shops.Name}");
                Console.WriteLine($"Spesialitet: {shops.Speciality}");
                Console.WriteLine($"Prisnivå: {shops.PriceRange} \n");
            }
        }

        public void AddStore()
        {
            Console.WriteLine("Legg til dine favoritt butikker!");

            Console.Write("Skriv navn: ");
            var inputName = Console.ReadLine();

            Console.Write("Skriv spesialitet: ");
            var inputSpeciality = Console.ReadLine();

            Console.Write("Skriv prisnivå: ");
            var inputPriceRange = Convert.ToInt32(Console.ReadLine());

            Stores store1 = new Stores(inputName, inputSpeciality, inputPriceRange);

            StoresInCenter.Add(store1);

        }


        /*public void ShowStores1()
        {
            foreach (Stores shops in StoresInCenter)
            {
                Console.WriteLine($"Navn: {shops.Name}");
                Console.WriteLine($"Spesialitet: {shops.Speciality}");
                Console.WriteLine($"Prisnivå: {shops.PriceRange} \n");
            }
        }*/
    }
}
