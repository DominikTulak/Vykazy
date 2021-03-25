using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vykazy.Model
{
    class Convertors
    {
        public static string MesicSlovne(int mesic)
        {
            switch (mesic)
            {
                case 1:
                    return "Leden";
                case 2:
                    return "Únor";
                case 3:
                    return "Březen";
                case 4:
                    return "Duben";
                case 5:
                    return "Květen";
                case 6:
                    return "Červen";
                case 7:
                    return "Červenec";
                case 8:
                    return "Srpen";
                case 9:
                    return "Září";
                case 10:
                    return "Říjen";
                case 11:
                    return "Listopad";
                case 12:
                    return "Prosinec";
                default:
                    return "";
            }
        }
        public static bool Svatek(int Den, int Mesic)
        {
            if(Mesic == 1 && Den == 1) { return true; }
            else if (Mesic == 1 && Den == 1) { return true; }
            else if (Mesic == 5 && Den == 1) { return true; }
            else if (Mesic == 5 && Den == 8) { return true; }
            else if (Mesic == 7 && Den == 5) { return true; }
            else if (Mesic == 7 && Den == 6) { return true; }
            else if (Mesic == 9 && Den == 28) { return true; }
            else if (Mesic == 10 && Den == 28) { return true; }
            else if (Mesic == 11 && Den == 17) { return true; }
            else if (Mesic == 12 && Den == 24) { return true; }
            else if (Mesic == 12 && Den == 25) { return true; }
            else if (Mesic == 12 && Den == 26) { return true; }
            return false;

        }
        public static bool Vikend(int Den, int Mesic, int Rok)
        {
            return (DateTime.Parse(String.Format("{0}-{1:D2}-{2:D2} 00:00", Rok, Mesic, Den)).DayOfWeek.ToString() == "Saturday" || DateTime.Parse(String.Format("{0}-{1:D2}-{2:D2} 00:00", Rok, Mesic, Den)).DayOfWeek.ToString() == "Sunday");
        }
    }
}
