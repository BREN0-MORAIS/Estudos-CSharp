using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Secao_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //camino inicial
            string sourcePath = @"C:\Users\wcogeo\Desktop\TXTS\Coplan\geo_bairro.csv";
            string targetPath = @"C:\Users\wcogeo\Desktop\TXTS\Coplan\geo_bairro2.csv";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                FileInfo fileInfoTarget = new FileInfo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);


                //faz uma copia do arquivo
                //fileInfo.CopyTo(targetPath);
                if (fileInfoTarget.Exists)
                {
                    fileInfoTarget.Delete();
                    fileInfo.CopyTo(targetPath);
                }
                else
                {
                    fileInfo.CopyTo(targetPath);
                }

                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);

            }


        }



    }
}
