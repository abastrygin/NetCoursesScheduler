using System;

namespace DAL
{
    public class TextReader
    {
        private string FileName;
        public string TextReader()
        {
            FileName = @"C:\Projects\test.txt";
            string rez = "";
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(FileName))
                {
                    rez = sr.ReadToEnd();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
