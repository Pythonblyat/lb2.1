using System;

namespace DeliveryPolymorphism
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string name) : base(name, 8) { }

        public override double CalculateDeliveryCost(double distanceKm, double weightKg)
        {
            double cost = 10 + 4 * distanceKm;
            if (distanceKm > 10)
            {
                cost *= 1.5; // надбавка за далеку відстань для велокур'єра
            }
            return cost;
        }

        public override string GetDescription()
        {
            return $"Велокур'єр «{Name}»: екологічна доставка невеликих посилок до {MaxLoadKg} кг";
        }
        // GetRestrictions() НЕ перевизначено -> використовується версія Vehicle
    }

    public class Car : Vehicle
    {
        public Car(string name) : base(name, 300) { }

        public override double CalculateDeliveryCost(double distanceKm, double weightKg)
        {
            return 25 + 7 * distanceKm + 2 * weightKg;
        }

        public override string GetDescription()
        {
            return $"Легковий автомобіль «{Name}»: доставка містом, вантаж до {MaxLoadKg} кг";
        }
        // GetRestrictions() НЕ перевизначено -> використовується версія Vehicle
    }

    public class Drone : Vehicle
    {
        public Drone(string name) : base(name, 2) { }

        public override double CalculateDeliveryCost(double distanceKm, double weightKg)
        {
            return 40 + 12 * distanceKm; // вартість не залежить від ваги
        }

        public override string GetDescription()
        {
            return $"Дрон «{Name}»: швидка доставка легких відправлень до {MaxLoadKg} кг";
        }

        public override string GetRestrictions()
        {
            return "Лише легкі відправлення, залежить від погоди, заборонено у зонах обмеження польотів";
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string name) : base(name, 3000) { }

        public override double CalculateDeliveryCost(double distanceKm, double weightKg)
        {
            return 100 + 15 * distanceKm + 1.5 * weightKg;
        }

        public override string GetDescription()
        {
            return $"Вантажний автомобіль «{Name}»: великогабаритні вантажі до {MaxLoadKg} кг";
        }

        public override string GetRestrictions()
        {
            return "Потрібен під'їзд для вантажного транспорту, обмеження руху центром міста вдень";
        }
    }
}
