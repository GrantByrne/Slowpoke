using System;
using System.Collections.Generic;
using Ninject;
using Slowpoke.Service;

namespace Slowpoke
{
    public class NinjectResolver : ISlowpoke<IKernel>
    {
        private readonly ResolverHelper resolverHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="NinjectResolver"/> class.
        /// </summary>
        public NinjectResolver()
        {
            this.resolverHelper = new ResolverHelper();
        }

        /// <summary>
        /// Resolves the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="container">The container.</param>
        public void Resolve(Type type, IKernel container)
        {
            resolverHelper.InterfaceValidator(type);
            container.Get(type);
        }

        /// <summary>
        /// Resolves the specified types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <param name="container">The container.</param>
        public void Resolve(List<Type> types, IKernel container)
        {
            foreach (var type in types)
            {
                this.Resolve(type, container);
            }
        }
    }
}
