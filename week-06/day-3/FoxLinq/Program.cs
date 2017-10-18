using System;
using System.Collections.Generic;
using System.Linq;

namespace FoxLinq
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Fox> Foxlist = new List<Fox>
            {
                new Fox("bela", "pallida", "green"),
                new Fox("helga", "arctic", "white"),
                new Fox("lolka", "spacefox", "purple"),
                new Fox("abel", "oceanfox", "green"),
                new Fox("majk", "forestfox", "red")
            };

            var output = FindGreenFox(Foxlist);

            var output2 = FindGreenPallida(Foxlist);
        }

        public static List<Fox> FindGreenPallida(List<Fox> list)
        {
            return list.Where(x => x.Color == "green" && x.Type == "pallida").Select(x => x).ToList();
        }

        public static List<Fox> FindGreenFox(List<Fox> list)
        {
            return list.Where( x => x.Color == "green").Select(x => x).ToList();
        }
    }
}
