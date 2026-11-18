
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DeliveryPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Колекція типу базового класу з об'єктами різних фактичних типів
            List<Vehicle> fleet = new List<Vehicle>
            {
                new Vehicle("Резервний транспорт", 50),
                new Bicycle("Вело-1"),
                new Car("Skoda Octavia"),
                new Drone("DJI-X"),
                new Truck("Isuzu NPR")
            };

            double distanceKm = 12;
            double weightKg = 4;

            Console.WriteLine($"Замовлення: відстань {distanceKm} км, вага {weightKg} кг");
            Console.WriteLine(new string('-', 70));

            for (int i = 0; i < fleet.Count; i++)
            {
                Vehicle v = fleet[i]; // посилання базового типу

                Console.WriteLine($"[{i + 1}] Фактичний тип: {v.GetType().Name}");
                Console.WriteLine($"    Опис: {v.GetDescription()}");

                double cost = v.CalculateDeliveryCost(distanceKm, weightKg);
                Console.WriteLine($"    Вартість: {cost.ToString("F2", CultureInfo.InvariantCulture)} грн");

                Console.WriteLine($"    Обмеження: {v.GetRestrictions()}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
