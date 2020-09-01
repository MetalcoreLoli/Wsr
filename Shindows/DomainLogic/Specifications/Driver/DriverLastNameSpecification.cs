using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications
{
    class DriverLastNameSpecification : Specification<DriverModel>
    {
        private readonly string _name;

        public DriverLastNameSpecification(string name)
        {
            _name = name;
        }

        public override bool IsSatisfied(DriverModel item)
        {
            return item.LastName == _name;
        }
    }
}
