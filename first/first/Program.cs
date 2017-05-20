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
                StreamReader sr = new StreamReader(@"C:\Users\Admin\Documents\Task1\file1.txt");
                string[] s = sr.ReadLine().Split();
                foreach (string ss in s)
                {
                    int a = int.Parse(ss);
                    if (a % 2 == 0)
                    {
                        Console.WriteLine(file.Name + ":" + a.ToString());
                    }
                }
                sr.Close();

            }
        }
        static void Main(string[] args)
        {
            recursion();
            Console.ReadKey();
        }
    }
}
