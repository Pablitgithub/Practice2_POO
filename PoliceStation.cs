namespace Practice1
{
    class PoliceStation : IMessageWritter
    {
        private List<PoliceCar> policeCars;

        public PoliceStation()
        {
            policeCars = new List<PoliceCar>();
        }

        public void RegisterPoliceCar(PoliceCar policeCar)
        {
            policeCars.Add(policeCar);
            Console.WriteLine(WriteMessage($"Police car with plate {policeCar.GetPlate()} registered."));
        }

        public void AlertSpeedingVehicle(string vehiclePlate)
        {
            bool alertSent = false;
            foreach (var car in policeCars)
            {
                if (car.IsPatrolling())
                {
                    Console.WriteLine(WriteMessage($"{car.GetPlate()} is notified about speeding vehicle with plate {vehiclePlate}."));
                    alertSent = true;
                }
            }

            if (!alertSent)
            {
                Console.WriteLine(WriteMessage($"No police cars are patrolling to respond to speeding vehicle {vehiclePlate}."));
            }
        }

        // Implementación del método requerido por IMessageWritter
        public string WriteMessage(string message)
        {
            return $"{message}";
        }
    }
}
