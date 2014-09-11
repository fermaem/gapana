namespace Compass.Core
{
    public static class Helper
    {
        public static string Combine(string one, string another)
        {
            string combined = one.Trim() + another.Trim();
            return combined;
        }
    }
}
