using Autofac;
using NUnit.Framework;
using Slowpoke.Service;
using Slowpoke.Test.Lib;

namespace Slowpoke.Test.Autofac
{
    [TestFixture]
    public class AutofacTest
    {
        [Test]
        public void Autofac_Resolve_Success()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Math>().As<IMath>();
            var container = builder.Build();

            var slowpoke = new AutofacResolver();
            slowpoke.Resolve(typeof(IMath), container);
        }
    }
}
