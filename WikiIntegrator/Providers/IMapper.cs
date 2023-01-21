using System;
using System.Collections.Generic;
using System.Text;

namespace WikiIntegrator.Providers
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
    }
}
