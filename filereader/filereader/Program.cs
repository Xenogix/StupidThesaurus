using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;
using Xceed.Words.NET;

namespace filereader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! What do you want to read ? 1 = txt, 2 = office, 3 = pdf, 4 = images : ");
            byte choice = Convert.ToByte(Console.ReadLine());
            string text = "";
            string file = "C:\\";


            switch (choice)
            {
                case 1:
                    text = File.ReadAllText(file);
                    break;
                case 2:
                    text = DocX.Load(file).Text;
                    break;
                case 3:
                    PdfReader reader = new PdfReader(file);
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        text += PdfTextExtractor.GetTextFromPage(reader, page);
                    }
                    reader.Close();
                    break;
                case 4:
                    for (int i = file.Length; i > 0; i--)
                    {
                        if(file[i] == '\\')
                        {
                            i = 0;
                        }
                        else
                        {
                            text += file[i];
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
