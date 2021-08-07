using System;
using System.IO;
using System.Linq;

namespace FileSystemLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Windows\\System32";
            DirectoryInfo directory = new DirectoryInfo(path);

            var folders = directory.GetDirectories();
            var files = directory.GetFiles();

            var large10Folders = folders.Take(10)
                                        .OrderByDescending(f => DirectorySize(new DirectoryInfo(path + "\\" + f.Name)));
            
            Console.WriteLine("10 large folders");
            foreach (var folder in large10Folders)
            {
               Console.WriteLine(folder.Name);
            }

            

            var large10Files = files.OrderByDescending(f => f.Length)
                                    .Take(10);

            Console.WriteLine("10 large files");

            foreach (var file in large10Files)
            {
                Console.WriteLine(file.Name);
            }

            var fileInAscendingOrder = files.OrderBy(f => f.Name)
                                            .Take(10);

            Console.WriteLine("files in ascending order");

            foreach (var file in fileInAscendingOrder)
            {
                Console.WriteLine(file.Name);

            }

            var folderInAscendingOrder = folders.OrderBy(f => f.Name)
                                                .Take(10);

            Console.WriteLine("folders in ascending order");

            foreach (var file in folderInAscendingOrder)
            {
                Console.WriteLine(file.Name);

            }                      
        }
        
        private static long DirectorySize(DirectoryInfo directory)
        {
           
            long totalSize = directory.GetFiles().Sum(f => f.Length);
            totalSize += directory.GetDirectories().Sum(dir =>
            {
                try
                {
                    return DirectorySize(dir);
                }
                catch
                {
                    return 0;
                }
                
                });
            return totalSize;
        }
    }
}
