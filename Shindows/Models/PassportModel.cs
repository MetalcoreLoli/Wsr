using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Models
{
    public class PassportModel
    {
        public PassportModel()
        {
        }

        public PassportModel(int id, int serial, int number)
        {
            Id = id;
            Serial = serial;
            Number = number;
        }

        public int Id { get; set; }
        public int Serial { get; set; }
        public int Number { get; set; }
    }
}
