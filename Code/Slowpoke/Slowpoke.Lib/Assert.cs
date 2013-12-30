using System;
using System.CodeDom;
using System.Reflection;

namespace Slowpoke.Lib
{
    public class Assert
    {
        public void IsResolved(Object theInterface)
        {
            // Check if the dependency is an interface
            if (!typeof (Object).IsInterface)
            {
                throw new ArgumentException("Please pass in an interface");
            }

            var targetUnit = new CodeCompileUnit();
            CodeNamespace samples = new CodeNamespace("CodeDOMSample");
            samples.Imports.Add(new CodeNamespaceImport("System"));
            var targetClass = new CodeTypeDeclaration("CodeDOMCreatedClass")
                {
                    IsClass = true,
                    TypeAttributes = TypeAttributes.Public
                };
            samples.Types.Add(targetClass);
            targetUnit.Namespaces.Add(samples);
        }
    }
}
