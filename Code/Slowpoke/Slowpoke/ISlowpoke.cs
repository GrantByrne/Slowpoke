using System;
using System.Collections.Generic;

namespace Slowpoke
{
    /// <summary>
    /// Specificies the methods to test an IOC container's dependencies
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISlowpoke<in T>
    {
        /// <summary>
        /// Resolves the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="container">The container.</param>
        void Resolve(Type type, T container);

        /// <summary>
        /// Resolves the specified types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <param name="container">The container.</param>
        void Resolve(List<Type> types, T container);
    }
}
