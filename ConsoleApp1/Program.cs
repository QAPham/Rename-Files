using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"U:\\transit\\Kiana\\Image4");
            FileInfo[] f = d.GetFiles().ToArray();
            foreach (FileInfo file  in f)
            {
                string[] s = file.FullName.Split(' ');
                int temp = s.Length;
                if(temp != 1)
                {
                    string newName = "";
                    for (int i = 0; i < temp ; i++)
                    {
                        if(i != temp - 1)
                        {
                            newName += s[i] + "_";
                        }
                        else
                        {
                            newName += s[i];
                        }
                        
                    }
                    File.Move(file.FullName, newName);
                }
            }
        }
    }
}
