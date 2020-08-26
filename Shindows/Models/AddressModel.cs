using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Models
{
    public class AddressModel
    {
        public AddressModel(int id, StreetModel street, string houseNumber, string postCode)
        {
            Id = id;
            Street = street;
            HouseNumber = houseNumber;
            PostCode = postCode;
        }

        public int Id { get; set; }
        public StreetModel Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostCode { get; set; }

    }
}
