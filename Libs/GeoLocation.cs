using System;
using System.Collections.Generic;
using System.Text;

namespace VIN_LIB
{
    public readonly struct MyRange : IMyRange
    {
        public Int32 Start { get; }
        public Int32 End   { get; }

        public MyRange(Int32 start, Int32 end)
        {
            Start   = Math.Min(start, end);
            End     = Math.Max(start, end);
        }

        public bool IsIn(int symbol) => Start <= symbol && symbol <= End;
    }
    class GeoLocation : IMyRange
    {
        public string Name { get; set; }

        public IEnumerable<Country> Countries { get;  }
        private readonly IMyRange _range;

        public GeoLocation(string name, IMyRange range, IEnumerable<Country> countries)
        {
            Name = name;
            _range = range;
            Countries = countries;
        }

        public bool IsIn(int val) => _range.IsIn(val);
    }
}
