using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications
{
    public class LicenceStatusSpecification : Specification<LicenceModel>
    {
        private readonly string status;

        public LicenceStatusSpecification(string status)
        {
            this.status = status;
        }

        public override bool IsSatisfied(LicenceModel item)
        {
            return item.Status == status;
        }
    }
}
