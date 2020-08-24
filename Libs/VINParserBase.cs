using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace VIN_LIB
{
    public class VINParserBase : IVINParser
    {
        private static Dictionary<char, int> _lettersUndNumberPair = new Dictionary<char, int>
        {
            ['A'] = 1,
            ['B'] = 2,
            ['C'] = 3,
            ['D'] = 4,
            ['E'] = 5,
            ['F'] = 6,
            ['G'] = 7,
            ['H'] = 8,
            ['J'] = 1,
            ['K'] = 2,
            ['L'] = 3,
            ['M'] = 4,
            ['N'] = 5,
            ['P'] = 7,
            ['R'] = 9,
            ['S'] = 2,
            ['T'] = 3,
            ['U'] = 4,
            ['V'] = 5,
            ['W'] = 6,
            ['X'] = 7,
            ['Y'] = 8,
            ['Z'] = 9,
        };

        private static Dictionary<int, int> _weight = new Dictionary<int, int> 
        {
            [1] = 8,
            [2] = 7,
            [3] = 6,
            [4] = 5,
            [5] = 4,
            [6] = 3,
            [7] = 2,
            [8] = 10,
            [10] = 9,
            [11] = 8,
            [12] = 7,
            [13] = 6,
            [14] = 5,
            [15] = 4,
            [16] = 3,
            [17] = 2,
        };

        private static Dictionary<int, int> _years = new Dictionary<int, int>
        {
            ['Y'] = 2000,
            [1] = 2001,
            [2] = 2002,
            [3] = 2003,
            [4] = 2004,
            [5] = 2005,
            [6] = 2006,
            [7] = 2007,
            [8] = 2008,
            ['A'] = 2010,
            ['B'] = 2011,
            ['C'] = 2012,
            ['D'] = 2013,
            ['E'] = 2014,
            ['F'] = 2015,
            ['G'] = 2016,
            ['H'] = 2017,
            ['J'] = 2018,
            ['L'] = 2020,
            ['M'] = 1991,
            ['N'] = 1992,
            ['P'] = 1993,
            ['R'] = 1994,
            ['S'] = 1995,
            ['T'] = 1996,
            ['V'] = 1997,
            ['W'] = 1998,
           
        };

        private static List<GeoLocation> _geoLocations = new List<GeoLocation>
        {
            new GeoLocation(
                "Африка", 
                new MyRange('A', 'H'), 
                new List<Country> 
                {
                    new Country("Египет", 'D', new MyRange('A', 'E')),
                    new Country("Марокко", 'D', new MyRange('F', 'K')),
                }
           ),
           new GeoLocation(
                "Азия",
                new MyRange('J', 'R'),
                new List<Country>
                {
                    new Country("Япония", 'J', new MyRange('A', 'T'))
                }
           ),
        };

        public bool CheckVIN(string vin)
        {
            if (vin == null)
                throw new System.ArgumentNullException(nameof(vin));

            int CHK = 0;
            string vinCHK = vin[8].ToString();
            if (vinCHK[0] != 'X' && !Int32.TryParse(vinCHK, out CHK))
                throw new System.ArgumentException("Wrong CHK!!!");

            if (vinCHK[0] == 'X')
                CHK = 10;

            _weight.Add(9, CHK);
            string _vin = string.Empty;
            
            foreach (var sym in vin)
            {
                if (_lettersUndNumberPair.ContainsKey(sym))
                    _vin += _lettersUndNumberPair[sym];
                else 
                    _vin += sym;
            }
            int sum = 0;
            for (int i = 0; i < vin.Length; i++)
            {
                if (i == 8) continue;
                int number = Int32.Parse(_vin[i].ToString());
                sum += (number * _weight[i + 1]);
            }

            return CHK == (sum - ((sum / 11) * 11));
        }

        public int GetTransportYear(string vin)
        {
            if (CheckVIN(vin))
                throw new System.ArgumentNullException(nameof (vin));
            
            int key = vin[9];

            if (!Int32.TryParse(vin[9].ToString(), out key))
                throw new System.ArgumentException("Wrong key!!!");    
           if (_years.ContainsKey(key))
               return _years[key];
           else
               throw new System.ArgumentException("Wrong key!!!");

        }

        public string GetVINCountry(string vin)
        {
            //if (CheckVIN(vin))
            //    throw new System.ArgumentNullException(nameof(vin));

            char location   = vin[0];
            char country    = vin[1];

            var countries =  _geoLocations
                                    .FirstOrDefault(geo => geo.IsIn(location))
                                    .Countries;

            string name = string.Empty;
            foreach (var ctr in countries)
            {
                if (ctr.GeoLocationSymbol.Equals(location)
                    && ctr.IsIn(country))
                    name =  ctr.Name;
            }

            return name;
        }
    }
}
