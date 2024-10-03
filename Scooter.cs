namespace Practice1
{
    class Scooter : Vehicle, IMessageWritter
    {
        
        private static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle, null)  // No matrícula
        {
            SetSpeed(20.0f); // Velocidad que añadimos por defecto al patinete
        }

        public override string GetPlate()
        {
            return "No plate (Scooter)";
        }

        // Implementación de la escritura de mensajes
        public override string WriteMessage(string message)
        {
            return $"{GetTypeOfVehicle()}: {message}";
        }
    }
}
