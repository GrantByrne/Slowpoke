using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slowpoke.Lib
{
    public class ConstructorInjectionTester<T>
    {
        private readonly T _testObject;

        /// <summary>
        ///     ctor
        /// </summary>
        /// <param name="dependency"></param>
        public ConstructorInjectionTester(T dependency)
        {
            _testObject = dependency;
        }
    }
}
