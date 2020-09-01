using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.DomainLogic.Specifications
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T item);

        public static Specification<T> operator &(Specification<T> a, Specification<T> b)
             => new AndSpecification<T>(a, b);

        public static Specification<T> operator |(Specification<T> a, Specification<T> b)
             => new OrSpecification<T>(a, b);
    }
}
