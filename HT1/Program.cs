using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;



namespace HT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            if (ConfigurationManager.AppSettings["config"].Equals("console"))
            {
                string str = Console.ReadLine();
               
                str = prog.ChangeAllCapitalLettersToSmallLetters(str);

                str = prog.LineBreak1(str);
                str = prog.LineBreak2(str);
                str = prog.LineBreak3(str);
                Console.WriteLine(DateTime.Now.ToString() + " " + str);
            }
            if (ConfigurationManager.AppSettings["config"].Equals("txt"))
            {
                string path = Console.ReadLine();
                if (!System.IO.File.Exists(path))
                {
                    Console.WriteLine("There are no such file or the path is uncorrect!");
                }
                else
                {
                    string str = System.IO.File.ReadAllText(path);
                }                
            }
        }
        public string ChangeAllCapitalLettersToSmallLetters(string str)
        {
            if(str != null)
            {
                return str.ToLower();
            }
            else
            {
                return str = "String is empty!";
            }               
        }

        public string LineBreak1(string str)
        {
            return str.Replace(".", ".\n" + DateTime.Now.ToString());
        }

        public string LineBreak2(string str)
        {
            return str.Replace("!", "!\n" + DateTime.Now.ToString());
        }

        public string LineBreak3(string str)
        {
            return str.Replace("?", "?\n" + DateTime.Now.ToString());
        }
    }
}
