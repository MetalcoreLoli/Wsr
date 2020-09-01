using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications
{
    class DriverNameSpecification : Specification<DriverModel>
    {
        private readonly string _name;

        public DriverNameSpecification(string name)
        {
            _name = name;
        }

        public override bool IsSatisfied(DriverModel item)
        {
            return item.Name == _name;
        }
    }
}
