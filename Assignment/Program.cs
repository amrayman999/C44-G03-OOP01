using Assignment.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            foreach (var day in Enum.GetNames(typeof(DayOfWeek)))
            {
                Console.WriteLine(day);
            }
            #endregion
        }
    }
}
