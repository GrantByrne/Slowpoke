using System;
using System.Collections.Generic;
using SimpleInjector;
using Slowpoke.Service;

namespace Slowpoke
{
    public class SimpleInjectorResolver : ISlowpoke<Container>
    {
        /// <summary>
        /// The resolver helper
        /// </summary>
        private readonly ResolverHelper resolverHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleInjectorResolver"/> class.
        /// </summary>
        public SimpleInjectorResolver()
        {
            this.resolverHelper = new ResolverHelper();
        }

        /// <summary>
        /// Resolves the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="container">The container.</param>
        public void Resolve(Type type, Container container)
        {
            this.resolverHelper.InterfaceValidator(type);

            container.GetInstance(type);
        }

        /// <summary>
        /// Resolves the specified types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <param name="container">The container.</param>
        public void Resolve(List<Type> types, Container container)
        {
            foreach (var type in types)
            {
                this.Resolve(type, container);
            }
        }
    }
}
