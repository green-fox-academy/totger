namespace DiceSimulation
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Simulation simulation = new Simulation();
            simulation.StartSimulation(6, 100000);
        }
    }
}