using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications
{
    class DriverMiddleNameSpecification : Specification<DriverModel>
    {
        private readonly string _name;

        public DriverMiddleNameSpecification(string name)
        {
            _name = name;
        }

        public override bool IsSatisfied(DriverModel item)
        {
            return item.MiddleName == _name;
        }
    }
}
