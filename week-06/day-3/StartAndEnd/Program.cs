using System;
using System.Linq;
using System.Collections.Generic;
            

namespace StartAndEnd
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var output = GetCitiesLambda(cities);
            var outputQuery = GetCitiesQuery(cities);
        }

        private static object GetCitiesQuery(string[] cities)
        {
            return
                from city in cities
                where city.StartsWith("A") && city.EndsWith("I")
                select city;
        }

        private static object GetCitiesLambda(string[] cities)
        {
            return cities.Where(x => x.StartsWith("A") && x.EndsWith("I"));
        }
    }
}
