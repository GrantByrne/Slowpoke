using NUnit.Framework;
using Ninject;
using Slowpoke.Service;
using Slowpoke.Test.Lib;

namespace Slowpoke.Test.Ninject
{
    [TestFixture]
    public class NinjectTest
    {
        [Test]
        public void Ninject_Resolve_Success()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IMath>().To<Math>();
            ISlowpoke<IKernel> slowpoke = new NinjectResolver();

            slowpoke.Resolve(typeof(IMath), kernel);
        }
    }
}
