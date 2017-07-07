using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Files
{

    class File
    {
        public string FileName { get; set; }
        public string Extention { get; set; }
        public long FileSize { get; set; }
    }

    class Program
    {
        static void Main()
        {

            int fileCount = int.Parse(Console.ReadLine());

          Dictionary<string, List<File>> rootInfo = new Dictionary<string,  List<File>>();

            for (int i = 0; i < fileCount; i++)
            {

                string[] fileInfo = Console.ReadLine().Split(';').ToArray();
                string[] filePath = fileInfo[0].Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string rootName = filePath[0].Trim();
                string fileName = filePath[filePath.Length - 1].Trim();
                string extention = Regex.Match(fileName, @"\.([a-z]+)(?!.*[a-z]+)").Groups[1].Value;
                long fileSize = long.Parse(fileInfo[1]);

                if (!rootInfo.ContainsKey(rootName))
                {
                    rootInfo[rootName] = new List<File>();
                }
                var item = rootInfo[rootName].FirstOrDefault(f => f.FileName == fileName);
                if (item != null)
                {
                    item.FileSize = fileSize;
                }
                else
                {
                    AddFileToRoot(rootInfo, rootName, fileName, extention, fileSize);
                }
                
            }

            string[] querry = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            bool isPrinted = false;
            if (rootInfo.ContainsKey(querry[2]))
            {
                var searchResult = rootInfo[querry[2]].Where(s => s.Extention.Equals(querry[0])).OrderByDescending(l => l.FileSize).ThenBy(s => s.FileName);
                foreach (var item in searchResult)
                {
                    Console.WriteLine($"{item.FileName} - {item.FileSize} KB");
                    isPrinted = true;
                }
            }
            if(!isPrinted)
            {
                Console.WriteLine("No");
            }
        }

        public static void AddFileToRoot(Dictionary<string, List<File>> rootInfo, string rootName, string fileName, string extention, long fileSize)
        {
            File currentFile = new File();
            currentFile.FileName = fileName;
            currentFile.Extention = extention;
            currentFile.FileSize = fileSize;
            rootInfo[rootName].Add(currentFile);
        }
    }
}
