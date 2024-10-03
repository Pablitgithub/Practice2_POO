namespace Practice1
{
    internal class Program
    {
        static void Main()
        {
            // Crear la ciudad y la comisaría
            City city = new City();
            Console.WriteLine(city.WriteMessage("City created"));

            // Crear y registrar taxis
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);

            // Crear y registrar coches de policía (uno con radar y otro sin radar)
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", new SpeedRadar());
            PoliceCar policeCar2 = new PoliceCar("0002 CNP"); // Este coche de policía no tiene radar
            city.GetPoliceStation().RegisterPoliceCar(policeCar1);
            city.GetPoliceStation().RegisterPoliceCar(policeCar2);

            // mensajes iniciales
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            Console.WriteLine(policeCar2.WriteMessage("Created"));

            // Iniciar patrullaje del coche de policía 1
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            taxi2.StartRide();

            policeCar2.UseRadar(taxi2);

           
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);

            
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide(); 
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            // Taxi 1 termina su trayecto dos veces
            taxi1.StopRide();
            taxi1.StopRide();

            // El coche de policía 1 deja de patrullar y reporta el historial de velocidades
            policeCar1.EndPatrolling();
            policeCar1.PrintRadarHistory();

            // El coche de policía 2 reporta el historial de velocidades
            policeCar2.PrintRadarHistory();

            string speedingVehiclePlate = taxi1.GetPlate();  
            city.GetPoliceStation().AlertSpeedingVehicle(speedingVehiclePlate)
            // Retirar la licencia de taxi 
            city.RemoveTaxi(taxi1);
        }
    }
}

    

