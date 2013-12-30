using System;

namespace Slowpoke.Service
{
    class ResolverHelper
    {
        public void InterfaceValidator(Type type)
        {
            if (!type.IsInterface)
            {
                string errorMessage = string.Format("Provided type {0} must be an Interface", type.Name);
                throw new NotImplementedException(errorMessage);
            }
        }
    }
}
