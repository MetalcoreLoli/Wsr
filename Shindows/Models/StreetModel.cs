using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Models
{
    public class StreetModel
    {
        public StreetModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Int32 Id { get; set; }
        public String Name { get; set; }
    }
}
