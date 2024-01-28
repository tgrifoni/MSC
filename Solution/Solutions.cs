namespace Solution
{
   public static class Solutions
   {
      /// <summary>
      /// Count the maximum number of times the word "BANANA" can be deleted from a string "s".
      /// 
      /// The idea here is to count the number the B, A and N letters contained in the given string,
      /// and then use a "formula" to check how many "BANANA"s can be formed/deleted.
      /// </summary>
      /// <param name="s">String input, made up by uppercase English letters</param>
      /// <returns></returns>
      public static int CountBananaIncidences(string s)
      {
         if (string.IsNullOrWhiteSpace(s))
            return 0;

         var bCount = s.Count(c => c == 'B');
         var aCount = s.Count(c => c == 'A');
         var nCount = s.Count(c => c == 'N');

         const int NumberOfBs = 1;
         const int NumberOfAs = 3;
         const int NumberOfNs = 2;

         static bool CanDeleteBananas(int bCount, int aCount, int nCount) =>
            bCount >= NumberOfBs &&
            aCount >= NumberOfAs &&
            nCount >= NumberOfNs;

         var bananaCount = 0;
         while (CanDeleteBananas(bCount, aCount, nCount))
         {
            bCount -= NumberOfBs;
            aCount -= NumberOfAs;
            nCount -= NumberOfNs;

            bananaCount++;
         }
         return bananaCount;
      }

      /// <summary>
      /// Calculate the minimum number of road roller drives required to close all potholes.
      /// 
      /// Since the road rollers drive parallel to the y-axis up to the end,
      /// all potholes will be closed regardless of their y position, so it
      /// can be "ignored". When the array X is ordered, it is possible to
      /// understand the distance between potholes (in the x-axis).
      /// Then, by using the width of the road roller, the range can be calculated,
      /// thus removing all potholes in such range. This can be done until there are
      /// no more potholes left to be removed, and then it will be possible to
      /// figure out the minimum number of drives.
      /// </summary>
      /// <param name="x">X-axis positions for the potholes</param>
      /// <param name="y">Y-axis positions for the potholes</param>
      /// <param name="w">Road roller width</param>
      /// <returns></returns>
      public static int CalculateMinNumberOfRoadRollerDrives(int[] x, int[] y, int w)
      {
         Array.Sort(x);
         var minNumberOfRoadRollerDrivesRequired = 0;

         while (x.Length > 0)
         {
            var firstPotholePosition = x[0];
            var potholesToBeRemovedRange = Enumerable.Range(firstPotholePosition, w + 1);
            x = x.Except(potholesToBeRemovedRange).ToArray();
            minNumberOfRoadRollerDrivesRequired++;
         }

         return minNumberOfRoadRollerDrivesRequired;
      }
   }
}
