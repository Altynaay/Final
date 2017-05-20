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
        static void Show()

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
                    for (int i = 0; i < 10; i++)
                    {
                        if (a == Math.Pow(2, i))
                        {
                            Console.WriteLine(file.Name + ":" + a.ToString()); //выводит имена файлов и числа только из первого файла
                        }
                    }
                  
                }
                sr.Close();

            }
        }
        static void Main(string[] args)
        {
            Show();
            Console.ReadKey();
        }
    }
}
