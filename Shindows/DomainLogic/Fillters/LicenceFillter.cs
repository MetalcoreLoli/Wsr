using Shindows.DomainLogic.Specifications;
using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Fillters
{
    class LicenceFillter : IFillter<LicenceModel>
    {
        public IEnumerable<LicenceModel> Execute(IEnumerable<LicenceModel> source, Specification<LicenceModel> spec)
        {
            return from item in source where spec.IsSatisfied(item) select item;
        }
    }
}
