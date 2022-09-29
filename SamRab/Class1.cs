using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SamRab
{
    class Class1
    {
        string path = @"C:\Users\murvi\Desktop\ReadWrite.txt";
        public void Read ()
        {
            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string read = reader.ReadToEnd();
                Console.WriteLine("Содержимое документа");
                Console.WriteLine(read);
            }
        }
        public void Write()
        {
            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    Console.WriteLine("Введите текст для добовления в документ");
                    string write = Console.ReadLine();
                    stream.WriteLine(write);
                }
            }
        }
    }
}
