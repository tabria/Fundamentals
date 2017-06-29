using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFoleder");

            double totalSize = 0;
            foreach(var file in files)
            {
                var info = new FileInfo(file);
                totalSize += info.Length;
            }
            Console.WriteLine("{0}", (totalSize / 1024)/ 1024);
        }
    }
}
