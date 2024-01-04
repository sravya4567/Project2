using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader studentdetails = new StreamReader("c:\\Mphasis\\Mphasis Project2\\Student details.txt");
                string str = studentdetails.ReadToEnd();
                Console.WriteLine("student details are:Name-sravya");
                Console.WriteLine();
                Console.WriteLine(str);
                studentdetails.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("error" + e.Message);
            }
        }        
    }
}
