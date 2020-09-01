using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications.Licence
{
    class LicenceNameSpecification : Specification<LicenceModel>
    {
        private string name;

        public LicenceNameSpecification(string name)
        {
            this.name = name;
        }

        public override bool IsSatisfied(LicenceModel item)
        {
            return new DriverNameSpecification(name).IsSatisfied(item.Driver);
        }
    }
}
