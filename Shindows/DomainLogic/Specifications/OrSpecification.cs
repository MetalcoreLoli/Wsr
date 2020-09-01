using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications
{
    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _a, _b;

        public OrSpecification(Specification<T> a, Specification<T> b)
        {
            _a = a;
            _b = b;
        }

        public override bool IsSatisfied(T item)
        {
            return _a.IsSatisfied(item) || _b.IsSatisfied(item);
        }
    }
}
