using Solution;

namespace Tests
{
   public class PotholesTests
   {
      [Theory]
      [InlineData(new[] { 2, 4, 2, 6, 7, 1 }, new[] { 0, 5, 3, 2, 1, 5 }, 2, 3)]
      [InlineData(new[] { 4, 8, 2, 2, 1, 4 }, new[] { 1, 2, 3, 1, 2, 3 }, 3, 2)]
      [InlineData(new[] { 0, 3, 6, 5 }, new[] { 0, 3, 2, 4 }, 1, 3)]
      [InlineData(new[] { 2, 0, 3, 4, 1, 4, 0, 2, 3, 1, 0 }, new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, 1, 3)]
      [InlineData(new[] { 2, 0, 3, 4, 1, 4, 0, 2, 3, 1, 0 }, new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, 2, 2)]
      [InlineData(new[] { 2, 4, 5, 3, 7, 6, 0, 9, 1, 8 }, new[] { 2, 1, 0, 0, 2, 0, 2, 2, 1, 1 }, 3, 3)]
      [InlineData(new[] { 2, 4, 5, 3, 7, 6, 0, 9, 1, 8 }, new[] { 2, 1, 0, 0, 2, 0, 2, 2, 1, 1 }, 2, 4)]
      public void CalculateMinNumberOfRoadRollerDrives_WhenReceivingAProperInput_ShouldReturnExpectedNumberOfTimes(int[] x, int[] y, int w, int expectedNumberOfTimes)
      {
         var actualNumberOfTimes = Solutions.CalculateMinNumberOfRoadRollerDrives(x, y, w);

         Assert.Equal(expectedNumberOfTimes, actualNumberOfTimes);
      }
   }
}