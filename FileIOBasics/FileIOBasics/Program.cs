using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOBasics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int[] values = { 5, 12, 7, 9, 1, 3, 0, 107, 42, 8 };

            //Queryable syntax of LINQ
            var sorted = from item in values
                         orderby item
                         select item;

            // sorted = values.OrderBy(x => x); // method syntax of LINQ;

            //ReadFile("");
        }
        static string winDir = System.Environment.GetEnvironmentVariable("windir");
        static void ReadFile(string filePath)
        { 
            List<string> textInMemory = new List<string>();
            string path = filePath;
            if (string.IsNullOrEmpty(path))
                path = winDir + "\\system.ini";
 
        StreamReader reader = new StreamReader(path);
        try
         {
           do
           {
            textInMemory.Add(IFileReaderService.ReadLine();
            }
        while (reader.Peek() != -1);
        }
        catch
        {
        textInMemory.Add("File is empty");
        }
    finally
    {
    reader.Close();
    }
Display(textInMemory);
}
private static void Display(List<string> linesOfText)
{
foreach (string line in linesOfText)
    Console.WriteLine(line);
    //Console.WriteLine(line);
}


    }
}
