//================================================================================================================================================================
//========================================================================== THIS IS Start =======================================================================
//================================================================================================================================================================

//Problem_1 >> Write a program to print your name on screen 
namespace _1to_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Name = "Abdelwahab Shandy";
            Console.WriteLine($"Your Name Is : {Name}");
        }
    }
}

//================================================================================================================================================================
//================================================================================================================================================================
//================================================================================================================================================================

//Problem_2 >> Write a program to ask the user to enter his / hir name and print it on screen
using System.Threading.Channels;

namespace _1to_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine($"Your Name is : {Name}");
        }
    }
}

//================================================================================================================================================================
//================================================================================================================================================================
//================================================================================================================================================================
