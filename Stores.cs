
namespace PPmedMartin
{
    internal class Stores
    {
        public string Name { get; private set; }
        public string Speciality { get; private set; }
        public int PriceRange { get; private set; }

        public List<Stores> StoresInCenter {  get; private set; }

        public Stores(string name, string speciality, int priceRange)
        {
            Name = name;
            Speciality = speciality;
            PriceRange = priceRange;
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
        }

        public void ShowStores()
        {
            foreach (Stores shops in StoresInCenter)
            {
                Console.WriteLine($"Navn: {shops.Name}");
                Console.WriteLine($"Spesialitet: {shops.Speciality}");
                Console.WriteLine($"Prisnivå: {shops.PriceRange}");
                Console.WriteLine();
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
            var inputPriceRange = Console.ReadLine();


        }
    }
}
