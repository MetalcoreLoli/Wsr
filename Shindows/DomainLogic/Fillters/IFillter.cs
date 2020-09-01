using Shindows.DomainLogic.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Fillters
{
    interface IFillter <T>
    {
        IEnumerable<T> Execute(
            IEnumerable<T> source, 
            Specification<T> spec);
    }
}
