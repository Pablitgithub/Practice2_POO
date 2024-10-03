namespace Practice1

{
	class City : IMessageWritter
    {
		private List<Taxi> taxis;
		private PoliceStation policeStation;

		public City()
		{
			taxis = new List<Taxi>();
			policeStation = new PoliceStation();
		}

		public void RegisterTaxi(Taxi taxi)
		{
			taxis.Add(taxi);
            Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} registered."));
        }

        public void RemoveTaxi(Taxi taxi)
		{
			if (taxis.Remove(taxi))
			{
                Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} license revoked."));
            }
            else
			{
                Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} not found."));
            }
        }

		public PoliceStation GetPoliceStation()
		{
			return policeStation;
		}

        public string WriteMessage(string message)
        {
            return $"IMATLAND: {message}";
        }
    }
}
