using System;
using System.Collections.Generic;
using Autofac;

namespace Slowpoke
{
    public class AutofacResolver : ISlowpoke<IContainer>
    {
        public void Resolve(Type type, IContainer container)
        {
            if (!type.IsInterface)
            {
                string errorMessage = string.Format("Provided type {0} must be an Interface", type.Name);
                throw new NotImplementedException(errorMessage);
            }

            container.Resolve(type);
        }

        public void Resolve(List<Type> types, IContainer container)
        {
            foreach (var type in types)
            {
                this.Resolve(type, container);
            }
        }
    }
}
