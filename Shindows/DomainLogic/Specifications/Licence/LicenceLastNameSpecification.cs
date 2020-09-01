using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications.Licence
{
    class LicenceLastNameSpecification : Specification<LicenceModel>
    {
        private string name;

        public LicenceLastNameSpecification(string name)
        {
            this.name = name;
        }

        public override bool IsSatisfied(LicenceModel item)
        {
            return new DriverLastNameSpecification(name).IsSatisfied(item.Driver);
        }
    }
}
