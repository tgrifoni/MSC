using Solution;

internal class Program
{
   private static void Main(string[] args)
   {
      Console.WriteLine("Starting Task One");
      Console.WriteLine(Solutions.CountBananaIncidences("NAABXXAN"));
      Console.WriteLine(Solutions.CountBananaIncidences("NAANAAXNABABYNNBZ"));
      Console.WriteLine(Solutions.CountBananaIncidences("QABAAAWOBL"));

      Console.WriteLine("Starting Task Two");
      var taskTwoExampleOne = Solutions.CalculateMinNumberOfRoadRollerDrives(
         x: new[] { 2, 4, 2, 6, 7, 1 },
         y: new[] { 0, 5, 3, 2, 1, 5 },
         w: 2);
      Console.WriteLine(taskTwoExampleOne);

      var taskTwoExampleTwo = Solutions.CalculateMinNumberOfRoadRollerDrives(
         x: new[] { 4, 8, 2, 2, 1, 4 },
         y: new[] { 1, 2, 3, 1, 2, 3 },
         w: 3);
      Console.WriteLine(taskTwoExampleTwo);

      var taskTwoExampleThree = Solutions.CalculateMinNumberOfRoadRollerDrives(
         x: new[] { 0, 3, 6, 5 },
         y: new[] { 0, 3, 2, 4 },
         w: 1);
      Console.WriteLine(taskTwoExampleThree);
   }
}