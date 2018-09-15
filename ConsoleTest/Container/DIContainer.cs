using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Interfaces
{
    public class DIContainer
    {
        private static Dictionary<Type, object> RegisteredModules = new Dictionary<Type, object>();

        public static void SetModule<TInterface,TModule>() {
            SetModule(typeof(TInterface), typeof(TModule));
        }

        public static void SetModule(Type tInterface, Type tModule) {

            if (!tInterface.IsAssignableFrom(tModule)) {
                throw new Exception("Wrong module type.");
            }

            // find constructor
            var firstConstructor = tModule.GetConstructors()[0];
            object module = null;
            if (!firstConstructor.GetParameters().Any())
            {
                module = firstConstructor.Invoke(null);
            }
            else {

                var constructorParams = firstConstructor.GetParameters();
                var moduleDependencies = new List<object>();

                foreach(var param in constructorParams) {
                    var dependency = GetModule(param.ParameterType);
                    moduleDependencies.Add(dependency);
                }
                module = firstConstructor.Invoke(moduleDependencies.ToArray());
            }
            RegisteredModules.Add(tInterface, module);

        }

        public static T GetModule<T>() {
            return (T)GetModule(typeof(T));
        }

        public static object GetModule(Type interfaceType) {
            if (RegisteredModules.ContainsKey(interfaceType)) {
                return RegisteredModules[interfaceType];
            }
            throw new Exception("Module not register");
        }

    }
}
