using System;
using System.Collections.Generic;
using System.Text;

namespace VIN_LIB
{
    class Country : IMyRange
    {
        private readonly IMyRange _range;

        public string Name { get; set; }
        public char GeoLocationSymbol { get;  }
        public Country(string name, char geoLocationSymbol, IMyRange range)
        {
            Name = name;
            _range = range;
            GeoLocationSymbol = geoLocationSymbol;
        }
        
        public bool IsIn(int val)
        {
            return _range.IsIn(val);
        }
    }
}
