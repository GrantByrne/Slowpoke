using NUnit.Framework;
using SimpleInjector;
using Slowpoke.Service;
using Slowpoke.Test.Lib;

namespace Slowpoke.Test.SimpleInjector
{
    [TestFixture]
    public class SimpleInjectorTest
    {
        [Test]
        public void SimpleInjector_Resolve_Success()
        {
            var container = new Container();
            container.Register<IMath, Math>();
            ISlowpoke<Container> resolver = new SimpleInjectorResolver();

            resolver.Resolve(typeof(IMath), container);
        }
    }
}
