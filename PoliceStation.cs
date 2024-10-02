namespace Practice1
{
    class PoliceStation
    {
        private List<PoliceCar> policeCars;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            policeCars.Add(policeCar);
            Console.WriteLine($"Police car with plate {policeCar.GetPlate()} registered.");
        }

        public void AlertSpeedingVehicle(string vehiclePlate)
        {
            foreach (var car in policeCars)
            {
                if (car.IsPatrolling())
                {
                    Console.WriteLine($"{car.GetPlate()} is notified about speeding vehicle with plate {vehiclePlate}.");
                }
            }
        }
    }
}
