namespace CalenderProject.Pages.CalenderComponents.Helper
{
    public class RandomColorGen
    {
        private static Random random = new Random();
        private static string[] colorClasses = new string[] { "magenta", "yellow", "yellow-green", "pink-red", "red-orange" };

        public static string GetRandomColorClasses()
        {
            return colorClasses[random.Next(0,colorClasses.Length)];
        }
    }
}
