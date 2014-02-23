using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WordTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = "hello";
            string inputLanguage = "en";
            string outputLanguage = "sr";

            //Parse arguments
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; )
                {
                    if (args[i] == "--word")
                    {
                        inputWord = args[i + 1];
                        i += 2;
                        continue;
                    }
                    if (args[i] == "--inputLanguage")
                    {
                        inputLanguage = args[i + 1];
                        i += 2;
                        continue;
                    }
                    if (args[i] == "--outputLanguage")
                    {
                        outputLanguage = args[i + 1];
                        i += 2;
                        continue;
                    }
                    
                    if (args[i] == "--help")
                    {
                        string message = "Program that translates input word from input language to output language.\n\n" +
                                            "Usage: WordTranslator.exe --word --inputLanugage --outputLanguage\n" +
                                            "\n--word <input_word>           Word that will be translated." +
                                            "\n--inputLanguage <language>    Specify the input word language in standard RFC3066 format. Default 'en'" +
                                            "\n--outputLanguage <language>   Specify desired output language in standard RFC3066 format. Default 'sr'" +
                                            "\n--help                        This text\n";
                        System.Console.WriteLine(message);
                        return;
                    }
                }
            }

            string translation = Translate(inputWord, inputLanguage, outputLanguage);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(translation);
        }

        private static string Translate(string Word, string InputLanguage, string OutputLanguage)
        {
            WebRequest request = WebRequest.Create(string.Format("http://api.mymemory.translated.net/get?q={0}&langpair={1}|{2}&de=your_email@someprovider.com", Word, InputLanguage, OutputLanguage));
            request.Method = "GET";
            WebResponse response = request.GetResponse();
                      
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                        
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
                        
            //Console.WriteLine(responseFromServer);
                        
            reader.Close();
            dataStream.Close();
            response.Close();

            Translation translation = JsonConvert.DeserializeObject<Translation>(responseFromServer);

            if (translation.responseData != null)
            {
                return translation.responseData.translatedText;
            }

            return null;
        }
    }
}
