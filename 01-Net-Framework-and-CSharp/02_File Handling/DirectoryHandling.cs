using System;
using System.IO;

namespace File_Handling
{
    class DirectoryHandling
    {
        public static void DirectoryDemo()
        {
            #region Creating Directories and SubDirectories
            Console.WriteLine("\n Creating the Directory at {0}", Environment.CurrentDirectory + @"\newdirectory");
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\newdirectory");
            Console.ReadKey();
            #endregion

            #region Checking the Existence of Directory
            Console.WriteLine("\n Checking if directory {0} exists: ", @"E:\demo\");
            if (Directory.Exists(@"E:\demo"))
            {
                Console.WriteLine("Directory Exists");
            }
            else
            {
                Console.WriteLine("Directory Does Not Exist");
            }
            Console.ReadKey();
            #endregion

            #region Get the Working Directory
            Console.WriteLine("\n Current Working Directory:");
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.ReadKey();
            #endregion

            #region Removing the Directory
            Console.WriteLine("\nRemoving the newdirectory");
            Directory.Delete(Directory.GetCurrentDirectory() + @"\newdirectory", true);
            Console.WriteLine("Directory Removed");
            Console.ReadKey();
            #endregion

            #region Moving the Directory
            Console.WriteLine("\n Moving the Directory test to E:\\demo");
            String srcDir = @"E:\demo";
            String destDir = @"E:\New folder\don\demo";
            Directory.Move(srcDir, destDir);
            Console.WriteLine("Directory Moved");
            Console.ReadKey();
            #endregion

            #region Obtaining Information
            Console.WriteLine("\nObtaining the info about directories");
            Console.WriteLine("Created test directory at: {0}", Directory.GetCreationTime(Directory.GetCurrentDirectory() + @"\test").ToLongDateString());
            Console.WriteLine("Last Access to test Directory {0}", Directory.GetLastAccessTime(Directory.GetCurrentDirectory() + @"\test").ToLongDateString());
            Console.ReadKey();
            #endregion

            #region Obtaining the Sub-Directory Information
            Console.WriteLine("\nObtaining the Sub Directories of E:\\");
            string[] subDirs = Directory.GetDirectories(@"E:\");

            foreach (string dir in subDirs)
                Console.WriteLine("Name: {0}", dir);
            Console.ReadKey();
            #endregion

            #region Obtaining the filename in current Directory
            Console.WriteLine("Obtaining filename in current directory");
            string[] fileName = Directory.GetFiles(@"E:\", "*.txt");
            foreach (string fname in fileName)
                Console.WriteLine(fname);
            #endregion
        }
    }
}
