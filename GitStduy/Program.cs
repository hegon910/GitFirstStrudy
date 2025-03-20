namespace GitStduy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bValue;
            int iValue = 10;
            bValue = true || (++iValue > 5);
            Console.WriteLine(iValue);
        }
    }
}
