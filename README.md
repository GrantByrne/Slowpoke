Slowpoke
========

Testing Library to Help You Verify Whether You're IOC Container Has Properly Resolved the Dependencies

![The adorable Slowpoke](https://github.com/holymoo/Slowpoke/blob/master/Documentation/Slowpoke.png?raw=true)

What is this?
-------------

Slowpoke is a framework that is used to test whether you're dependencies are resolved with your IOC container. Often times when using an IOC container it's impossible to see whether you've properly set up everything correctly until you actually run the system. 

What Slowpoke is looking to do is provide a toolset for aiding in the testing of the dependency resolution so that developers do get suprised when they add a new dependency to the system.

What Frameworks are Currently Supported?
----------------------------------------

Currently, the IOC containers I'm looking to support are:
  - [Autofac](https://code.google.com/p/autofac/)
  - [Ninject](http://www.ninject.org/)
  - [Simple Injector](http://simpleinjector.codeplex.com/)

Getting Started
---------------

**Autofac**
            
    // Set up the dependencies in Autofac
    var builder = new ContainerBuilder();
    builder.RegisterType<Math>().As<IMath>();
    var container = builder.Build();

    // Test the depedency resolution with Slowpoke
    var slowpoke = new AutofacResolver();
    slowpoke.Resolve(typeof(IMath), container);

**Ninject**

    // Set up the dependencies in Ninject
    IKernel kernel = new StandardKernel();
    kernel.Bind<IMath>().To<Math>();
    
    // Test the depedency resolution with Slowpoke
    ISlowpoke<IKernel> slowpoke = new NinjectResolver();
    slowpoke.Resolve(typeof(IMath), kernel);

**Simple Injector**

    // Set up the dependencies in SimpleInjector
    var container = new Container();
    container.Register<IMath, Math>();
    
    // Test the depedency resolution with Slowpoke
    ISlowpoke<Container> resolver = new SimpleInjectorResolver();
    resolver.Resolve(typeof(IMath), container);
