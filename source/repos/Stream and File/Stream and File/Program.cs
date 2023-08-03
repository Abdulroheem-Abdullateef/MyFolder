using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Stream_and_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = " The Man Is Black";
            //byte[] byt = Encoding.UTF8.GetBytes(word);
            //MemoryStream stream = new MemoryStream(byt);
            //StreamReader StreamReader = new StreamReader(stream);
            // Console.WriteLine(StreamReader.ReadToEnd());

            //var word2 = Console.ReadLine();
            //var byt2 = Encoding.UTF8.GetBytes(word2);
            //MemoryStream stream1 = new MemoryStream(byt2);
            //StreamReader streamReader2 = new StreamReader(stream1);
            //Console.WriteLine(streamReader2.ReadToEnd());

            bool flag = true;

            do
            {
                Console.WriteLine(" What do you want to keep in the file ");
                string contents = Console.ReadLine();
               WriteToFile(".\\file.txt", contents);
                flag = CheckIfEnd();

            } while (flag);

            Console.WriteLine(" Here are the content of your file");
            
            foreach (string content in ReadFromFile(".\\file.txt"))
            {
                Console.WriteLine(content);
            }

            Console.WriteLine(" Thanks you for using our Application");

        }
         


        static void WriteToFile(string path, string content)
        {

            try
            {
                StreamWriter streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(content);
                streamWriter.Flush();
                streamWriter.Close();

            }
            catch (FileNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            } 

          
        }



        static IEnumerable<string> ReadFromFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            while (!streamReader.EndOfStream)
            {
                yield return streamReader.ReadLine();
            }
            streamReader.Close();
        }


        static bool CheckIfEnd()
        {
            Console.WriteLine(" Do you want to end the application ? (Yes (Y) / No (N) )  ");
            string choice = Console.ReadLine();

            if (choice.ToUpper() == "Y")
            {  
                return false;
            }

            else if (choice.ToUpper() == "N")
            {
                return true;
            }

            else
            {
                Console.WriteLine(" Application Ending, Bad Input");
                return false;
            }
        }
    }
}
