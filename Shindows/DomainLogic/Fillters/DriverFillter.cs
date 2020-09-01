using Shindows.DomainLogic.Specifications;
using Shindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Fillters
{
    public class DriverFillter : IFillter<DriverModel>
    {
        public IEnumerable<DriverModel> Execute(
            IEnumerable<DriverModel> source, 
            Specification<DriverModel> spec)
        {
            return source.Where(spec.IsSatisfied);
        }
    }
}
