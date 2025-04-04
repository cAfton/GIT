using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data.Common;
using VehicleProga.Factories;
using VehicleProga.Interface;
using VehicleProga.Model;

namespace VehicleProga
{
    public class Shop
    {
        public List<IVehicle> Cataloge { get; set; } = new List<IVehicle>();

        public IVehicle Sell()
        {
            Cataloge.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Enter name: ");
            var item = Console.ReadLine();
            var found = Cataloge.FirstOrDefault(elem => elem.Name == item);

            Cataloge.Remove(found);

            Bicycle toSellBicycle = found as Bicycle;
            if (toSellBicycle != null)
            {
                Console.WriteLine("Your energy: ");
                toSellBicycle.Energy = double.Parse(Console.ReadLine());
                return toSellBicycle;
            }

            Car toSellCar = found as Car;
            object name = (object)toSellCar;
            BroomBroomMotosicle broomBroom = (BroomBroomMotosicle)name;
            Console.WriteLine($"/////////////////\n{broomBroom}\n///////////////////");
            if (toSellCar != null)
            {
                toSellCar.Fuel = 30;
                return toSellCar;
            }

            BroomBroomMotosicle toSellBroomBroomMotosicle = found as BroomBroomMotosicle;
            if (toSellBroomBroomMotosicle != null)
            {
                toSellBroomBroomMotosicle.Fuel = 50;
                return toSellBroomBroomMotosicle;
            }

            

            return null;
        }

        public void Buy(IVehicle newVehicle)
        {
            Cataloge.Add(newVehicle);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            string jsonFromFile = File.ReadAllText("vehicles.json");
            Shop shop = JsonConvert.DeserializeObject<Shop>(jsonFromFile, settings);

            Console.WriteLine("\nDeserialized from JSON:");
            foreach (var vehicle in shop.Cataloge)
            {
                Console.WriteLine($"Vehicle: {vehicle.Name}, Type: {vehicle.GetType().Name}");
                vehicle.Drive();
            }

            shop.Sell();
            string json = JsonConvert.SerializeObject(shop, Formatting.Indented, settings);
            File.WriteAllText("vehicles.json", json);
        }
    }
}
