using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace Vykazy.Model
{
    class Settings
    {
        public static string Jmeno;
        public static string Text1;
        public static string Text2;
        public static void Nacist()
        {
            try
            {
                if (!Directory.Exists(Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%") + "\\Vykazy")) { throw new Exception(); }
                StreamReader sr = new StreamReader(Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%") + "\\Vykazy\\Vykazy.conf");
                List<string> config = new List<string>();
                while (!sr.EndOfStream)
                {
                    config.Add(sr.ReadLine());
                }
                sr.Close();
                int i = 0;
                foreach (String line in config)
                {
                    i++;
                    switch (i)
                    {
                        case 1:
                            Jmeno = line;
                            break;
                        case 2:
                            Text1 = line;
                            break;
                        case 3:
                            Text2 = line;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Konfigurační soubor nenalezen, vytvářím nový...");
                if (!Directory.Exists(Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%") + "\\Vykazy"))
                {
                    Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%") + "\\Vykazy");
                }
                StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%") + "\\Vykazy\\Vykazy.conf");
                sw.WriteLine("");
                sw.WriteLine("Dětský domov, Jablonec nad Nisou, Pasecká 20, příspěvková organizace");
                sw.WriteLine("Výkaz práce - služby:");

                sw.Close();
                Nacist();
            }
        }
        public static void Ulozit(string Jmeno, string Text1, string Text2)
        {
            StreamWriter sw = new StreamWriter(Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%") + "\\Vykazy\\Vykazy.conf");
            sw.WriteLine(Jmeno);
            sw.WriteLine(Text1);
            sw.WriteLine(Text2);
            sw.Close();
            Nacist();
        }
    }
}
