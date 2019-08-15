using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stream_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\HackerU\Desktop\MyTest.txt";
            Stream writingStream = new FileStream(path, FileMode.Create);
            try
            {
                Console.WriteLine("Please enter 3 strings: ");
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string str3 = Console.ReadLine();

                byte[] bytes1 = Encoding.ASCII.GetBytes(str1);
                byte[] bytes2 = Encoding.ASCII.GetBytes(str2);
                byte[] bytes3 = Encoding.ASCII.GetBytes(str3);

                if (writingStream.CanWrite == true)
                {
                    writingStream.Write(bytes1, 0, bytes1.Length);
                    writingStream.Write(bytes2, 0, bytes2.Length);
                    writingStream.Write(bytes3, 0, bytes3.Length);

                    Stream readingStream = new FileStream(path, FileMode.Open);

                    Console.WriteLine("Enter a number: ");
                    int num = int.Parse(Console.ReadLine());

                    string s = Encoding.UTF8.GetString(readingStream, num, readingStream.Length - num);
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                writingStream.Close();
            }


        }
    }
}
