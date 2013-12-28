Slowpoke
========

Testing Library to Help You Verify Whether You're IOC Container Has Properly Resolved the Dependencies

**This Project is still under development, check back later for the cool stuff.**

![The adorable Slowpoke](https://github.com/holymoo/Slowpoke/blob/master/Documentation/Slowpoke.png?raw=true)

What is this?
-------------

Slowpoke is a framework that is used to test whether you're dependencies are resolved with your IOC container. Often times when using an IOC container it's impossible to see whether you've properly set up everything correctly until you actually run the system. 

What Slowpoke is looking to do is provide a toolset for aiding in the testing of the dependency resolution so that developers do get suprised when they add a new dependency to the system.

What frameworks are supported?
------------------------------

Currently, the IOC containers I'm looking to support are:
  - Autofac
  - Ninject
  - Simple Injector
