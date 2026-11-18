using System;

namespace DeliveryPolymorphism
{
    // Неабстрактний базовий клас: засіб доставки
    public class Vehicle
    {
        public string Name { get; }
        public double MaxLoadKg { get; }

        public Vehicle(string name, double maxLoadKg)
        {
            Name = name;
            MaxLoadKg = maxLoadKg;
        }

        // Віртуальний метод 1: розрахунок вартості доставки
        public virtual double CalculateDeliveryCost(double distanceKm, double weightKg)
        {
            return 30 + 8 * distanceKm;
        }

        // Віртуальний метод 2: текстове подання для виводу
        public virtual string GetDescription()
        {
            return $"Універсальний засіб доставки «{Name}», вантажопідйомність до {MaxLoadKg} кг";
        }

        // Віртуальний метод 3: реалізація за замовчуванням,
        // яку перевизначають НЕ всі похідні класи
        public virtual string GetRestrictions()
        {
            return "Особливих обмежень немає (реалізація базового класу)";
        }
    }
}
