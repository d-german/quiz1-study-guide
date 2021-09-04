namespace Quiz1
{
    /// <summary>
    /// 3 overloads this is static polymorphism
    /// </summary>
    public static class Adder
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static string Add(string x, string y)
        {
            return x + y;
        }
    }
}
