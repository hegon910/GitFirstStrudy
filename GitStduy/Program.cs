using System.Security.Cryptography;

namespace GitStduy
{
    public struct StruExam
    {
        public string Name;
        public int ID;
        
        public StruExam(string name, int howmany)
        {
            Name = name;
            ID = howmany;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bValue;
            int iValue = 10;
            bValue = true || (++iValue > 5);
            Console.WriteLine(bValue);

            int[] num= new int[3];
            num[0] = 1;
            num[1] = 2;
            num[2] = 3;

            Console.WriteLine("{0}{1}", num[1], num[2]);
            string[] height = new string[5];
            height[0] = "150";
            height[1] = "151";
            height[2] = "152";
            height[3] = "153";
            height[4] = "154";

            Console.WriteLine("{0}\n{1}", height[1], height[2]);


        }
    }
}
