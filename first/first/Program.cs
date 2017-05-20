using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace first
{
    class Program
    {
        static void recursion()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Admin\Documents\Task1");
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (FileInfo file in files)
            {
                FileStream fs = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                
                Console.WriteLine(file.Name + ":");
            }
           
        }
        static void isPower()
        {
        }
        static void Main(string[] args)
        {
            recursion();
            Console.ReadKey();
        }
    }
}
