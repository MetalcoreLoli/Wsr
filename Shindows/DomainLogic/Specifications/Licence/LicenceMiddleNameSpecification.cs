using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications.Licence
{
    class LicenceMiddleNameSpecification : Specification<LicenceModel>
    {
        private string name;

        public LicenceMiddleNameSpecification(string name)
        {
            this.name = name;
        }

        public override bool IsSatisfied(LicenceModel item)
        {
            return new DriverMiddleNameSpecification(name).IsSatisfied(item.Driver);
        }
    }
}
